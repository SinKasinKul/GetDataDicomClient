using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace GetDataDicom
{
    public class DicomData
    {
        public string OrthancID { get; set; }
        public string ParentPatient { get; set; }
        public string PatientID { get; set; }
        public string PatientName { get; set; }
        public string PatientSex { get; set; }
        public string PatientBirthDate { get; set; }
        public string OtherPatientIDs { get; set; }
        public string AccessionNumber { get; set; }
        public string InstitutionName { get; set; }
        public string RequestedProcedureDescription { get; set; }
        public string StudyDate { get; set; }
        public string StudyDescription { get; set; }
        public string LastUpdate { get; set; }
    }
    class Webservice
    {

        public bool PingHost(string hostUri, int portNumber)
        {
            try
            {
                using (var client = new TcpClient(hostUri, portNumber))
                    return true;
            }
            catch //(SocketException ex)
            {
                //MessageBox.Show("Error pinging host:'" + hostUri + ":" + portNumber.ToString() + "'");
                return false;
            }
        }
        private bool AcceptAllCertifications(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certification, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }
        public string Accept { get; set; }
        public List<string> GetOrthancPatients(string host,string port,string vUser,string vPassword)
        {
            string url = "http://" + host + ":" + port + "/patients/";

            Uri uri = new Uri(url);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            // authentication
            CredentialCache cache = new CredentialCache();
            cache.Add(uri, "Basic", new NetworkCredential(vUser, vPassword));
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

            request.Method = "Get";
            request.Timeout = 10000;
            request.ContentType = "application/json; charset=utf-8";
            //request.ContentLength = data.Length;
            request.Credentials = cache;

            // response.
            WebResponse Credentialresponse = request.GetResponse();

            using (Stream dataStream = Credentialresponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                List<string> list = JsonConvert.DeserializeObject<List<string>>(reader.ReadToEnd().ToString());

                return list;
            }
        }
        public string GetOrthancSytem(string host, string port, string vUser, string vPassword)
        {
            string url = "http://" + host + ":" + port + "/system/";

            Uri uri = new Uri(url);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            // authentication
            CredentialCache cache = new CredentialCache();
            cache.Add(uri, "Basic", new NetworkCredential(vUser, vPassword));
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

            request.Method = "Get";
            request.Timeout = 10000;
            request.ContentType = "application/json; charset=utf-8";
            //request.ContentLength = data.Length;
            request.Credentials = cache;

            // response.
            WebResponse Credentialresponse = request.GetResponse();

            using (Stream dataStream = Credentialresponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string list = reader.ReadToEnd().ToString();

                return list;
            }
        }
        public string GetOrthancStudies(string host, string port, string vUser, string vPassword,string PatientsID)
        {
            string url = "http://" + host + ":" + port + "/patients/" + PatientsID + "/studies";

            Uri uri = new Uri(url);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            // authentication
            CredentialCache cache = new CredentialCache();
            cache.Add(uri, "Basic", new NetworkCredential(vUser, vPassword));
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

            request.Method = "Get";
            request.Timeout = 10000;
            request.ContentType = "application/json; charset=utf-8";
            //request.ContentLength = data.Length;
            request.Credentials = cache;

            // response.
            WebResponse Credentialresponse = request.GetResponse();

            using (Stream dataStream = Credentialresponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string list = reader.ReadToEnd().ToString();

                return list;
            }
        }        
        public string GetOrthancSeries(string host, string port, string vUser, string vPassword,string Series)
        {
            string url = "http://" + host + ":" + port + "/series/" + Series;

            Uri uri = new Uri(url);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            // authentication
            CredentialCache cache = new CredentialCache();
            cache.Add(uri, "Basic", new NetworkCredential(vUser, vPassword));
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

            request.Method = "Get";
            request.Timeout = 10000;
            request.ContentType = "application/json; charset=utf-8";
            //request.ContentLength = data.Length;
            request.Credentials = cache;

            // response.
            WebResponse Credentialresponse = request.GetResponse();

            using (Stream dataStream = Credentialresponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string list = reader.ReadToEnd().ToString();

                return list;
            }
        }
        public string GetOrthancChkSeries(string host, string port, string vUser, string vPassword, string ParentPatient)
        {
            string url = "http://" + host + ":" + port + "/patients/" + ParentPatient + "/series";

            Uri uri = new Uri(url);
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            // authentication
            CredentialCache cache = new CredentialCache();
            cache.Add(uri, "Basic", new NetworkCredential(vUser, vPassword));
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);

            request.Method = "Get";
            request.Timeout = 10000;
            request.ContentType = "application/json; charset=utf-8";
            //request.ContentLength = data.Length;
            request.Credentials = cache;

            // response.
            WebResponse Credentialresponse = request.GetResponse();

            using (Stream dataStream = Credentialresponse.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                string list = reader.ReadToEnd().ToString();

                return list;
            }
        }
        public string PostOrthancPeer(string host, string port, string vUser, string vPassword, string PatientsID)
        {
            try
            {
                string url = "http://" + host + ":" + port + "/peers/DataServer/store";
                string data = PatientsID;
                byte[] byteArray = Encoding.UTF8.GetBytes(data);

                Uri uri = new Uri(url);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                CredentialCache cache = new CredentialCache();
                cache.Add(uri, "Basic", new NetworkCredential(vUser, vPassword));
                ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);
                request.Credentials = cache;
                request.Timeout = 1000 * 600;
                request.Method = "Post";
                request.Accept = "text/plain,*/*; q=0.01";
                request.ContentType = "application/json";
                request.ContentLength = byteArray.Length;
                WebHeaderCollection OrthancHeaderCollection = request.Headers;
                //OrthancHeaderCollection.Add("Accept-Encoding:gzip, deflate");
                OrthancHeaderCollection.Add("Accept-Language:en-US,en;q=0.5");
                Stream dataStream = request.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                using (dataStream = response.GetResponseStream())
                {
                    Encoding encode = Encoding.GetEncoding("utf-8");
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();
                    //byte[] responsedecode = responseFromServer
                    return responseFromServer.ToString();
                }
            }
            catch (Exception ex)
            {
                string xx = ex.Message;
                PostOrthancPeer(host, port, vUser, vPassword, PatientsID);
                return xx;
            }
        }
        public string DeleteOrthancPatient(string host, string port, string vUser, string vPassword, string PatientsID)
        {
            try
            {
                string url = "http://" + host + ":" + port + "/patients/" + PatientsID;
                //JObject data = new JObject();
                string data = PatientsID;
                

                Uri uri = new Uri(url);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
                request.Method = "DELETE";
                request.Accept = "application/json, text/javascript, */*; q=0.01";
                CredentialCache cache = new CredentialCache();
                cache.Add(uri, "Basic", new NetworkCredential(vUser, vPassword));
                ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(AcceptAllCertifications);
                request.Credentials = cache;
                request.Timeout = 10000;

                HttpWebResponse response;
                try
                {
                    response = (HttpWebResponse)request.GetResponse();
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }

                using (Stream dataStream = response.GetResponseStream())
                {
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();
                    return responseFromServer.ToString();
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /*---------------Update Json File Orthanc------------------*/
        private string UpdateFileOrthanc()
        {
            try
            {
                string orthancFile = "C:\\Program Files\\Orthanc Server\\Configuration\\orthanc.json";
                using (StreamReader r = new StreamReader("file.json"))
                {
                    string json = r.ReadToEnd();
                    List<Itemorthanc> items = JsonConvert.DeserializeObject<List<Itemorthanc>>("Data:[" + json + "]");
                }
                return "";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public class Itemorthanc
        {
            public string stamp { get; set; }
        }
        /*--------------Insert Data Dicom--------------------*/
        public string SDIM_INS_DICOMDATA (string host,string[] DataDicon)
        {
            try
            {
                string url = "http://" + host + "/sapi/api.class.php?action=SDIC_INS_CASE";

                var data = "&OrthancID=" + Uri.EscapeDataString(DataDicon[0]);
                data += "&ParentPatient=" + Uri.EscapeDataString(DataDicon[1]);
                data += "&PatientID=" + Uri.EscapeDataString(DataDicon[2]);
                data += "&PatientName=" + Uri.EscapeDataString(DataDicon[3]);
                data += "&PatientSex=" + Uri.EscapeDataString(DataDicon[4]);
                data += "&PatientBirthDate=" + Uri.EscapeDataString(DataDicon[5]);
                data += "&OtherPatientIDs=" + Uri.EscapeDataString(DataDicon[6]);
                data += "&AccessionNumber=" + Uri.EscapeDataString(DataDicon[7]);
                data += "&InstitutionName=" + Uri.EscapeDataString(DataDicon[8]);
                data += "&RequestedProcedureDescription=" + Uri.EscapeDataString(DataDicon[9]).ToUpper();
                data += "&StudyDate=" + Uri.EscapeDataString(DataDicon[10]);
                data += "&StudyTime=" + Uri.EscapeDataString(DataDicon[11]);
                data += "&StudyDescription=" + Uri.EscapeDataString(DataDicon[12]).ToUpper();
                data += "&LastUpdate=" + Uri.EscapeDataString(DataDicon[13]);
                data += "&BodyPartExamined=" + Uri.EscapeDataString(DataDicon[14]);
                data += "&Manufacturer=" + Uri.EscapeDataString(DataDicon[15]);
                data += "&Modality=" + Uri.EscapeDataString(DataDicon[16]);
                data += "&ProtocolName=" + Uri.EscapeDataString(DataDicon[17]);
                data += "&SeriesDescription=" + Uri.EscapeDataString(DataDicon[18]);
                data += "&PerformedProcedureStepDescription=" + Uri.EscapeDataString(DataDicon[19]);
                data += "&StationName=" + Uri.EscapeDataString(DataDicon[20]);

                var dataPost = Encoding.ASCII.GetBytes(data);
                Uri uri = new Uri(url);
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri + data);
                request.Method = "GET";
                request.ContentType = "application/json";
                //request.ContentLength = data.Length;

                //using (var stream = request.GetRequestStream())
                //{
                //    stream.Write(dataPost, 0, dataPost.Length);
                //}

                HttpWebResponse response = (HttpWebResponse)request.GetResponse();

                using (var dataStream = response.GetResponseStream())
                {
                    Encoding encode = Encoding.GetEncoding("utf-8");
                    StreamReader reader = new StreamReader(dataStream);
                    string responseFromServer = reader.ReadToEnd();
                    //byte[] responsedecode = responseFromServer
                    return responseFromServer.ToString();
                }
            }
            catch (Exception ex)
            {
                string xx = ex.Message;
                return xx;
            }
            

        }
    }
}
