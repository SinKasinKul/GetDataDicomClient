using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace GetDataDicomClient
{
    class SocketClient
    {
        public Socket _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public Socket _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public List<Socket> _clientSockets = new List<Socket>();
        private const int BUFFER_SIZE = 20480;
        private readonly byte[] buffer = new byte[BUFFER_SIZE];

        string IPServer { get; set; }
        string PortServer { get; set; }
        public string ResultStatus { get; set; }
        public string ResultReceive { get; set; }

        public string SetupServer()
        {
            var appSettings = ConfigurationManager.AppSettings;
            IPServer = appSettings.Get("IPSocketServer");
            PortServer = appSettings.Get("PortSocketServer");

            try
            {
                IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IPServer), int.Parse(PortServer));
                _serverSocket.Bind(iep);
                _serverSocket.Listen(-1); //Set connect Client
                _serverSocket.BeginAccept(new AsyncCallback(AcceptConn), null);
                ResultStatus = "Server Online...";
                return ResultStatus;
            }
            catch (Exception ex)
            {
                ResultStatus = ex.Message;
                return ResultStatus;
            }
            
        }
        public void AcceptConn(IAsyncResult IAR)
        {
            Socket socket;

            try
            {
                socket = _serverSocket.EndAccept(IAR);
            }
            catch (ObjectDisposedException) // I cannot seem to avoid this (on exit when properly closing sockets)
            {
                return;
            }

            _clientSockets.Add(socket);
            _serverSocket.BeginAccept(AcceptConn, null);
            ResultStatus = "Connected to: " + socket.RemoteEndPoint.ToString();

            string stringData = "Connected Server";
            byte[] vWelcomMsg = Encoding.ASCII.GetBytes(stringData);
            socket.BeginSend(vWelcomMsg, 0, vWelcomMsg.Length, SocketFlags.None, new AsyncCallback(SendData), socket);
        }
        private void SendData(IAsyncResult IAR)
        {
            Socket client = (Socket)IAR.AsyncState;
            int sent;// = client.EndSend(iar);

            try
            {
                sent = client.EndReceive(IAR);
            }
            catch (SocketException)
            {
                client.Close();
                _clientSockets.Remove(client);
                return;
            }

            if (sent == 0) return;
            try
            {
                client.BeginReceive(buffer, 0, BUFFER_SIZE, SocketFlags.None, new AsyncCallback(ReceiveData), client);
            }
            catch (Exception ex)
            {
                ResultStatus = ex.Message;
            }
        }
        private void ReceiveData(IAsyncResult IAR)
        {
            Socket client = (Socket)IAR.AsyncState;
            int received;// = client.EndReceive(iar);

            try
            {
                received = client.EndReceive(IAR);
            }
            catch (SocketException)
            {
                client.Close();
                _clientSockets.Remove(client);
                return;
            }

            if (received == 0) return;
            byte[] recBuf = new byte[received];
            Array.Copy(buffer, recBuf, received);

            string receivedData = Encoding.ASCII.GetString(recBuf);
            ResultReceive = receivedData;

            byte[] vServerSend;
            vServerSend = Encoding.ASCII.GetBytes(receivedData);

            string[] ArrReceivedData = receivedData.Split(',');
            if (ArrReceivedData[2] == "KeepAlive") // Client requested time
            {
                vServerSend = Encoding.ASCII.GetBytes(ArrReceivedData[2]);
                client.BeginSend(vServerSend, 0, vServerSend.Length, SocketFlags.None, new AsyncCallback(SendData), client);
            }
            else
            {
                client.BeginSend(vServerSend, 0, vServerSend.Length, SocketFlags.None, new AsyncCallback(SendData), client);
            }
        }
    }
}
