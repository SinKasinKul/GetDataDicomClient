using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using GetDataDicomClient;
using Microsoft.Win32;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
//using OrthancAPI;

namespace GetDataDicom
{
    public partial class Main : Form
    {
        Webservice orthancAPI = new Webservice();
        SocketClient socketClient = new SocketClient();
        string applicationName;
        string OrthancReceive, PortOrthancReceive, UserOrthancReceive, PWOrthancReceive;
        bool StatusOrthancReceive;
        string OrthancData, PortOrthancData, UserOrthancData, PWOrthancData;
        string vChkStartUp, vPeerWithDelete, vConnectName;
        string vDeviesShow,vNotiSpace;
        bool StatusOrthancData;
        bool AllowClose = false;
        string IPServer;
        string PortServer;
        bool StatusClientOnline = false;
        bool StatusServerOnline = false;
        decimal vUsagePercent;
        DateTime vLastUpdate;
        List<string> vDrives = new List<string>();
        string pubIp = new WebClient().DownloadString("https://api.ipify.org");

        private static Socket _ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private const int BUFFER_SIZE = 2048;
        private static readonly byte[] buffer = new byte[BUFFER_SIZE];

        public delegate void callrichtextStatus(String ss);
        public callrichtextStatus clientStatus;
        public delegate void callrichtext1Receive(String ss);
        public callrichtext1Receive clientReceive;
        public delegate void callrichtextResultRecceive(String ss);
        public callrichtextResultRecceive clientResultRecceive;

        int vSleepAuto = 1000;

        public Main()
        {
            InitializeComponent();
            AppSetting();
            KeepAliveServer();

            applicationName = System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
            trayIcon.Visible = false; // Hide form window.
            this.ShowInTaskbar = true; // Remove from taskbar.

            //trayIcon.Visible = true;
        }
        private void AppSetting()
        {
            var appSettings = ConfigurationManager.AppSettings;
            OrthancReceive = appSettings.Get("OrthancReceive");
            PortOrthancReceive = appSettings.Get("PortOrthancReceive");
            UserOrthancReceive = appSettings.Get("UserOrthancReceive");
            PWOrthancReceive = appSettings.Get("PWOrthancReceive");

            OrthancData = appSettings.Get("OrthancData");
            PortOrthancData = appSettings.Get("PortOrthancData");
            UserOrthancData = appSettings.Get("UserOrthancData");
            PWOrthancData = appSettings.Get("PWOrthancData");
            PWOrthancData = appSettings.Get("PWOrthancData");

            vChkStartUp = appSettings.Get("StartUpApp");
            vPeerWithDelete = appSettings.Get("AutoDelete");
            vConnectName = appSettings.Get("ConnectName");

            vDeviesShow = appSettings.Get("DrevieMonitor");
            vNotiSpace = appSettings.Get("NotiSpace");

            IPServer = appSettings.Get("IPSocketServer");
            //IPServer = pubIp;
            PortServer = appSettings.Get("PortSocketServer");

            string _LastUpdate = appSettings.Get("LastUpdate");

            tBOrthancReceice.Text = OrthancReceive;
            tBPoetOrthancReceice.Text = PortOrthancReceive;
            tBUserOrthancReceice.Text = UserOrthancReceive;
            tBPWOrthancReceice.Text = PWOrthancReceive;

            tBOrthancData.Text = OrthancData;
            tBPortOrthancData.Text = PortOrthancData;
            tBUserOrthancData.Text = UserOrthancData;
            tBPWOrthancData.Text = PWOrthancData;

            tBIP.Text = IPServer;
            tBPort.Text = PortServer;

            tbNotiSpace.Text = vNotiSpace;

            if (_LastUpdate != "")
            {
                vLastUpdate = DateTime.ParseExact(_LastUpdate, "yyyyMMddTHHmmss", null);
                lbLastUpdate.Text = vLastUpdate.ToString("dd-MM-yyyy HH:mm:ss");
            }
            else
            {
                //string DT = DateTime.Now.ToString("yyyyMMddTHHmmss");
                vLastUpdate = DateTime.Now;
                lbLastUpdate.Text = vLastUpdate.ToString("dd-MM-yyyy HH:mm:ss");
            }

            if (vChkStartUp == "1")
                chkStartUp.Checked = true;

            if (vPeerWithDelete == "1")
                cBPeerWithDelete.Checked = true;

            if (vConnectName == "1")
                cBConnectName.Checked = true;

            SetStartup();
        }
        private void SetStartup()
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);

            if (chkStartUp.Checked)
                rk.SetValue(applicationName, Application.ExecutablePath.ToString());
            else
                rk.DeleteValue(applicationName, false);

        }
        private void BtSave_Click(object sender, EventArgs e)
        {
            Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);

            config.AppSettings.Settings.Remove("OrthancReceive");
            config.AppSettings.Settings.Add("OrthancReceive", tBOrthancReceice.Text);
            config.AppSettings.Settings.Remove("PortOrthancReceive");
            config.AppSettings.Settings.Add("PortOrthancReceive", tBPoetOrthancReceice.Text);
            config.AppSettings.Settings.Remove("UserOrthancReceive");
            config.AppSettings.Settings.Add("UserOrthancReceive", tBUserOrthancReceice.Text);
            config.AppSettings.Settings.Remove("PWOrthancReceive");
            config.AppSettings.Settings.Add("PWOrthancReceive", tBPWOrthancReceice.Text);

            config.AppSettings.Settings.Remove("OrthancData");
            config.AppSettings.Settings.Add("OrthancData", tBOrthancData.Text);
            config.AppSettings.Settings.Remove("PortOrthancData");
            config.AppSettings.Settings.Add("PortOrthancData", tBPortOrthancData.Text);
            config.AppSettings.Settings.Remove("UserOrthancData");
            config.AppSettings.Settings.Add("UserOrthancData", tBUserOrthancData.Text);
            config.AppSettings.Settings.Remove("PWOrthancData");
            config.AppSettings.Settings.Add("PWOrthancData", tBPWOrthancData.Text);

            config.AppSettings.Settings.Remove("IPSocketServer");
            config.AppSettings.Settings.Add("IPSocketServer", tBIP.Text);
            config.AppSettings.Settings.Remove("PortSocketServer");
            config.AppSettings.Settings.Add("PortSocketServer", tBPort.Text);

            if (chkStartUp.Checked)
                vChkStartUp = "1";
            else
                vChkStartUp = "0";

            if (cBPeerWithDelete.Checked)
                vPeerWithDelete = "1";
            else
                vPeerWithDelete = "0";

            if (cBConnectName.Checked)
                vConnectName = "1";
            else
                vConnectName = "0";

            config.AppSettings.Settings.Remove("StartUpApp");
            config.AppSettings.Settings.Add("StartUpApp", vChkStartUp);

            config.AppSettings.Settings.Remove("AutoDelete");
            config.AppSettings.Settings.Add("AutoDelete", vPeerWithDelete);

            config.AppSettings.Settings.Remove("ConnectName");
            config.AppSettings.Settings.Add("ConnectName", vConnectName);

            config.AppSettings.Settings.Remove("DrevieMonitor");
            config.AppSettings.Settings.Add("DrevieMonitor", cbBDrive.Text);
            config.AppSettings.Settings.Remove("NotiSpace");
            config.AppSettings.Settings.Add("NotiSpace", tbNotiSpace.Text);

            config.Save(ConfigurationSaveMode.Minimal);
            MessageBox.Show("Save completed", "Setting", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AllowClose = true;
            Application.Restart();
            Environment.Exit(0);
        }
        private void Main_Load(object sender, EventArgs e)
        {
            TextBox.CheckForIllegalCrossThreadCalls = false;
            int TimeInt = (1 * 1000);
            timerGetData.Interval = TimeInt;
            timerGetData.Enabled = true;
            timerCheckImg.Interval = TimeInt;
            //timerCheckImg.Enabled = true;
            //timerCheckImg.Stop();
            ResultReceive(applicationName + " Started...");
            //KeepAliveServer();
            GetDriveInfo();

            var bSDrive = new BindingSource();
            bSDrive.DataSource = vDrives;
            cbBDrive.DataSource = bSDrive.DataSource;

            clientStatus = new callrichtextStatus(ResultSocketStatus);
            clientReceive = new callrichtext1Receive(ResultSocketReceive);
            clientResultRecceive = new callrichtextResultRecceive(ResultReceive);
        }
        public void ResultReceive(string RText)
        {
            if (cBShowResponse.Checked)
            {
                rTBResultRecceive.Clear();
                string dateLog = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                rTBResultRecceive.AppendText(dateLog + "----> " + RText);
                rTBResultRecceive.AppendText("\n");
            }
        }
        public void ResultSocketStatus(string RText)
        {
            if (cBShowLogSocket.Checked)
            {
                string dateLog = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                rTBSocketStatus.AppendText(dateLog + "----> " + RText);
                rTBSocketStatus.AppendText("\n");
            }
        }
        public void ResultSocketReceive(string RText)
        {
            if (cBShowLogSocket.Checked)
            {
                string dateLog = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
                rTBSocketReceive.AppendText(dateLog + "----> " + RText);
                rTBSocketReceive.AppendText("\n");
            }
        }
        public string orthancSystem(string IP,string Port, string User,string PW)
        {
            try
            {
                JObject obJson = new JObject();
                string System = "{\n \"Data\" :[" + orthancAPI.GetOrthancSytem(IP, Port, User, PW) + "]\n}";
                obJson = JObject.Parse(System);
                string systemName = obJson.SelectToken("Data[0].Name").ToString();
                return systemName;
            }
            catch (Exception ex)
            {
                ResultReceive(ex.Message);
                return "Not Found Orthanc";
            }
        }
        public void orthancPatients()
        {
            try
            {
                List<string> Patients = orthancAPI.GetOrthancPatients(OrthancReceive, PortOrthancReceive, UserOrthancReceive, PWOrthancReceive);
                string[] PatientsArr = Patients.ToArray();
                int CountP = Patients.Count;
                int CountRow = dGVMonitor.Rows.Count;
                lbTotalCase.Text = CountP.ToString();
                if (CountP > 0)
                {
                    dGVMonitor.Rows.Clear();
                    //foreach (string item in Patients)
                    //{
                    //ResultReceive("Orthanc ID : " + PatientsArr[CountP - 1]);
                    string Studies = "{\n \"Data\" :" + orthancAPI.GetOrthancStudies(OrthancReceive, PortOrthancReceive, UserOrthancReceive, PWOrthancReceive, PatientsArr[CountP - 1].ToString()) + "\n}";
                    JObject json = new JObject();
                    json = JObject.Parse(Studies);

                    string OrthancID = CheckJson(json,"Data[0].ID").ToString();
                    string LastUpdate = CheckJson(json,"Data[0].LastUpdate");
                    string ParentPatient = CheckJson(json, "Data[0].ParentPatient");

                    string PatientID = CheckJson(json, "Data[0].PatientMainDicomTags.PatientID");
                    string PatientName = CheckJson(json, "Data[0].PatientMainDicomTags.PatientName");
                    string PatientSex = CheckJson(json, "Data[0].PatientMainDicomTags.PatientSex");
                    string PatientBirthDate = CheckJson(json, "Data[0].PatientMainDicomTags.PatientBirthDate");
                    string OtherPatientIDs = CheckJson(json, "Data[0].PatientMainDicomTags.OtherPatientIDs");

                    string AccessionNumber = CheckJson(json, "Data[0].MainDicomTags.AccessionNumber");
                    string InstitutionName = CheckJson(json, "Data[0].MainDicomTags.InstitutionName");
                    string RequestedProcedureDescription = CheckJson(json, "Data[0].MainDicomTags.RequestedProcedureDescription");
                    string StudyDate = CheckJson(json, "Data[0].MainDicomTags.StudyDate");
                    string StudyTime = CheckJson(json, "Data[0].MainDicomTags.StudyTime");
                    string StudyDescription = CheckJson(json, "Data[0].MainDicomTags.StudyDescription");
                    string Series = CheckJson(json, "Data[0].Series[0]");

                    string SreiesDetail = orthancAPI.GetOrthancSeries(OrthancReceive, PortOrthancReceive, UserOrthancReceive, PWOrthancReceive, Series);
                    string ttt = SreiesDetail;
                    JObject jsonSreies = new JObject();
                    jsonSreies = JObject.Parse(SreiesDetail);
                    string BodyPartExamined = CheckJson(jsonSreies, "MainDicomTags.BodyPartExamined");
                    string Manufacturer = CheckJson(jsonSreies, "MainDicomTags.Manufacturer");
                    string Modality = CheckJson(jsonSreies, "MainDicomTags.Modality");
                    string PerformedProcedureStepDescription = CheckJson(jsonSreies, "MainDicomTags.PerformedProcedureStepDescription");
                    string ProtocolName = CheckJson(jsonSreies, "MainDicomTags.ProtocolName");
                    string SeriesDescription = CheckJson(jsonSreies, "MainDicomTags.SeriesDescription");
                    string StationName = CheckJson(jsonSreies, "MainDicomTags.StationName");

                    double vDiffMin = (DateTime.ParseExact(LastUpdate, "yyyyMMddTHHmmss", null).AddHours(7) - vLastUpdate).TotalMinutes;
                    string[] DicomData;

                    if (vDiffMin > 0)
                    {
                        int rowId = dGVMonitor.Rows.Add();
                        DataGridViewRow row = dGVMonitor.Rows[rowId];
                        row.Cells["OrthancID"].Value = OrthancID;
                        row.Cells["ParentPatient"].Value = ParentPatient;

                        row.Cells["PatientID"].Value = PatientID;
                        row.Cells["PatientName"].Value = PatientName;
                        row.Cells["PatientSex"].Value = PatientSex;
                        row.Cells["PatientBirthDate"].Value = PatientBirthDate;
                        //row.Cells["OtherPatientIDs"].Value = OtherPatientIDs;

                        //row.Cells["AccessionNumber"].Value = AccessionNumber;
                        //row.Cells["InstitutionName"].Value = InstitutionName;
                        //row.Cells["RequestedProcedureDescription"].Value = RequestedProcedureDescription;
                        //row.Cells["StudyDate"].Value = StudyDate;
                        //row.Cells["StudyTime"].Value = StudyTime;
                        row.Cells["StudyDescription"].Value = StudyDescription;

                        vLastUpdate = DateTime.ParseExact(LastUpdate, "yyyyMMddTHHmmss", null).AddHours(7);
                        row.Cells["LastUpdate"].Value = vLastUpdate;

                        lbLastUpdate.Text = vLastUpdate.ToString("dd-MM-yyyy HH:mm:ss");

                        Configuration config = ConfigurationManager.OpenExeConfiguration(Application.ExecutablePath);
                        config.AppSettings.Settings.Remove("LastUpdate");
                        config.AppSettings.Settings.Add("LastUpdate", vLastUpdate.ToString("yyyyMMddTHHmmss"));

                        config.Save(ConfigurationSaveMode.Minimal);

                        if (cBConnectName.Checked == true)
                        {
                            InstitutionName = lbOrthancRecvice.Text;
                        }

                        DicomData = new string[] 
                        {     OrthancID
                            , ParentPatient
                            , PatientID
                            , PatientName
                            , PatientSex
                            , PatientBirthDate
                            , OtherPatientIDs 
                            , AccessionNumber
                            , InstitutionName 
                            , RequestedProcedureDescription
                            , StudyDate
                            , StudyTime
                            , StudyDescription
                            , vLastUpdate.ToString("yyyy-MM-dd HH:mm:ss")
                            , BodyPartExamined
                            , Manufacturer
                            , Modality
                            , ProtocolName
                            , SeriesDescription
                            , PerformedProcedureStepDescription
                            , StationName
                        };
                        string SQLReponse = orthancAPI.SDIM_INS_DICOMDATA(OrthancData, DicomData);
                        ResultReceive(SQLReponse);
                    }
                        //dGVMonitor.Rows.Add(row);
                    //}
                }
                else
                {
                    return;
                }
            }
            catch (Exception ex)
            {
                string xx = ex.Message;
                return;
            }
        }
        public void orthancPeer()
        {
            int DataRowCount = dGVMonitor.Rows.Count;
            try
            {
                if (DataRowCount > 0)
                {
                    ResultReceive("Wait...");
                    //System.Threading.Thread.Sleep(30000);
                    string PPID = dGVMonitor.Rows[0].Cells["ParentPatient"].Value.ToString();

                    //for (int i = 0; i < DataRowCount; i++)
                    //{
                    lbStatus.Text = "Sending...";
                    string PID = dGVMonitor.Rows[0].Cells["OrthancID"].Value.ToString();
                    ResultReceive("Sending " + PID);

                    //timerCheckImg.Start();
                    string respones = orthancAPI.PostOrthancPeer(OrthancReceive, PortOrthancReceive, UserOrthancReceive, PWOrthancReceive, PID);
                    ResultReceive("respones Peer: " + respones);
                    JObject json = new JObject();
                    json = JObject.Parse(respones);
                    string FiledCound = json.SelectToken("FailedInstancesCount").ToString();
                    string TotalFileSend = json.SelectToken("InstancesCount").ToString();
                    string ParentResources = json.SelectToken("ParentResources[0]").ToString();
                    ResultReceive("ParentResources : " + ParentResources);
                    ResultReceive("TotalFileSend : " + TotalFileSend);
                    ResultReceive("FailledCount : " + FiledCound);

                    lbImgCount.Text = "0";

                    SendText("UpdateCase," + lbTotalCase.Text);

                    if (FiledCound == "0" && dGVMonitor.Rows[0].Cells["OrthancID"].Value.ToString() == PID)
                    {
                        dGVMonitor.Rows.RemoveAt(dGVMonitor.Rows[0].Index);
                        if (cBPeerWithDelete.Checked)
                        {
                            string OID = PPID;// dGVMonitor.Rows[0].Cells["ParentPatient"].Value.ToString();
                            DeleteOrthancPatient(OID);
                        }
                    }

                }
                else
                {
                    lbStatus.Text = "Standby...";
                }
            }
            catch (Exception ex)
            {
                ResultReceive("Pree Failled : " + ex);
                ResultReceive("Start Pree agian.");
                orthancPeer();
            }
            
        }
        public void DeleteOrthancPatient(string PID)
        {
            int DataRowCount = dGVMonitor.Rows.Count;
            try
            {
                //if (DataRowCount > 0)
                //{
                    //for (int i = 0; i < DataRowCount; i++)
                    //{
                        //string PID = dGVMonitor.Rows[i].Cells["ParentPatient"].Value.ToString();
                        string respones = orthancAPI.DeleteOrthancPatient(OrthancReceive, PortOrthancReceive, UserOrthancReceive, PWOrthancReceive, PID);
                        JObject json = new JObject();
                        json = JObject.Parse(respones);
                        string RemainingAncestor = json.SelectToken("RemainingAncestor").ToString();
                        RemainingAncestor = (RemainingAncestor.ToString() != null) ? RemainingAncestor.ToString() : "0";
                        ResultReceive("Total Patient : " + RemainingAncestor);
                    //}
                //}
            }
            catch (Exception ex)
            {
                ResultReceive("Failled : " + ex);
            }

        }
        private string CheckJson(JObject json,string values)
        {
            try
            {
                JObject vJson = new JObject();
                vJson = json;
                string DataJson = vJson.SelectToken(values).ToString();
                return DataJson;
            }
            catch (Exception ex)
            {
                //ResultReceive(ex.Message);
                return "";
            }
        }
        private void TimerGetData_Tick(object sender, EventArgs e)
        {
            string datelog = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss");
            string vKeepAliveT = DateTime.Now.ToString("ss");
            int vKeepAlive = int.Parse(vKeepAliveT) % 60;

            lbTimeShow.Text = datelog;
            KeepAliveServer();
            GetDriveInfo();

            if (StatusClientOnline)
            {
                if (dgWGetData.IsBusy != true && bdWCountIns.IsBusy != true && bgWPeer.IsBusy != true)
                {
                    dgWGetData.RunWorkerAsync();
                }
            }
            if (bgWSocket.IsBusy != true)
            {
                bgWSocket.RunWorkerAsync();

                if (vKeepAlive == 0)
                    SendText("KeepAlive");
            }
        }
        private void KeepAliveServer()
        {
            if (bgWPingReceive.IsBusy != true)
            {
                bgWPingReceive.RunWorkerAsync();
            }

            if (bgWPingData.IsBusy != true)
            {
                bgWPingData.RunWorkerAsync();
            }
        }
        private void BgWPingReceive_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                StatusOrthancReceive = orthancAPI.PingHost(OrthancReceive, int.Parse(PortOrthancReceive));
                lbOrthancRecvice.Text = orthancSystem(OrthancReceive, PortOrthancReceive, UserOrthancReceive, PWOrthancReceive);
            }
            catch (Exception ex)
            {
                ResultReceive("Ping : " + ex.Message);
            }
        }
        private void BgWPingReceive_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (StatusOrthancReceive)
            {
                lbOrthancRecvice.BackColor = Color.LimeGreen;
                StatusClientOnline = true;
            }
            else
            {
                lbOrthancRecvice.Text = "Offline";
                lbOrthancRecvice.BackColor = Color.Red;
                StatusClientOnline = false;
            }
        }
        private void BgWPingData_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                StatusOrthancData = orthancAPI.PingHost(OrthancData, int.Parse(PortOrthancData));
                lbOrthancData.Text = orthancSystem(OrthancData, PortOrthancData, UserOrthancData, PWOrthancData);
            }
            catch (Exception ex)
            {
                ResultReceive(ex.Message);
            }
        }
        private void BgWPingData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            string vServer = lbOrthancData.Text;
            if (StatusOrthancData)
            {
                if (vServer != "Not Found Orthanc")
                {
                    lbOrthancData.BackColor = Color.LimeGreen;
                    StatusServerOnline = true;
                }
                else
                {
                    lbOrthancData.BackColor = Color.Red;
                    StatusServerOnline = true;
                }
            }
            else
            {
                lbOrthancData.Text = "OffLine";
                lbOrthancData.BackColor = Color.Red;
                StatusServerOnline = false;
            }
        }
        private void BgWPeer_DoWork(object sender, DoWorkEventArgs e)
        {
            ResultReceive("Start Peer");
            timerGetData.Enabled = false;
            orthancPeer();
        }
        private void bgWPeer_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            e.ToString();
        }
        private void BgWPeer_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timerGetData.Enabled = true;
            //orthancPatients();
            lbImgCount.Text = "0";
            //timerCheckImg.Stop();
            if (Math.Round(vUsagePercent, 2) > int.Parse(vNotiSpace))
            {
                DeleteOverData();
            }
        }
        private void DgWPatientDelete_DoWork(object sender, DoWorkEventArgs e)
        {
            lbStatus.Text = "Deleting...";
            DeleteOrthancPatient(e.Argument.ToString());
        }
        private void DgWPatientDelete_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lbStatus.Text = "Finish...";
        }
        private void BtGetlist_Click(object sender, EventArgs e)
        {
            orthancPatients();
        }
        private void DgWGetData_DoWork(object sender, DoWorkEventArgs e)
        {
            if (StatusClientOnline)
            {
                timerGetData.Enabled = false;
                orthancPatients();
                System.Threading.Thread.Sleep(1000);
            }
            //GetDriveInfo();
        }
        private void DgWGetData_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            timerGetData.Enabled = true;
            //if (bgWPeer.IsBusy != true)
            //{
            //    bgWPeer.RunWorkerAsync();
            //}

            int DataRowCount = dGVMonitor.Rows.Count;
            if (bdWCountIns.IsBusy != true && DataRowCount > 0)
            {
                bdWCountIns.RunWorkerAsync();
            }
            else
            {
                lbStatus.Text = "Standby...";
            }
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            //if (bgWPeer.IsBusy != true)
            //{
            //    bgWPeer.RunWorkerAsync();
            //}
            //UpdateFileOrthanc();
            SendText("Offline");
        }
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!AllowClose)
            {
                e.Cancel = (e.CloseReason == CloseReason.UserClosing);
                WindowState = FormWindowState.Minimized;
                Hide();


                if (WindowState == FormWindowState.Minimized)
                {
                    trayIcon.Visible = true;
                }
                else
                {
                    // kill the icon
                    trayIcon.Icon = null;
                }
            }
        }
        private void ShowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }
        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /*--------------Get Data Drive---------------------*/
        private void GetDriveInfo()
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();
            //string vDrive = cbBDrive.Text;

            foreach (var series in chartDrive.Series)
            {
                series.Points.Clear();
            }

            foreach (DriveInfo d in allDrives)
            {
                //ResultReceive("Drive " + d.Name);
                vDrives.Add(d.Name);
                if (d.IsReady == true && vDeviesShow == d.Name)
                {
                    vUsagePercent = (decimal)(((d.TotalSize - d.TotalFreeSpace) / (float)d.TotalSize) * 100);
                    decimal vFreePercent = (decimal)(((d.TotalFreeSpace) / (float)d.TotalSize) * 100);
                    //ResultReceive("Volume label: " + d.VolumeLabel);
                    //ResultReceive("File system: " + d.DriveFormat);
                    //ResultReceive("Available space to current user: "+ (d.AvailableFreeSpace / 1024 / 1024 / 1024) + " GB");
                    //ResultReceive("Total available space: " + (d.TotalFreeSpace / 1024 / 1024 / 1024) + " GB");
                    //ResultReceive("Total size of drive: " + (d.TotalSize / 1024 / 1024 / 1024) + " GB");
                    //ResultReceive("Free size of drive: " + Math.Round(vFreePercent,2) + " %");
                    //lbDrivePercent.Text = Math.Round(vFreePercent, 2) + " %";

                    chartDrive.Titles["Title1"].Text = "Drive : " + d.Name;
                    chartDrive.Titles["Title2"].Text = "Usage : " + Math.Round(vUsagePercent, 2) + " %";

                    if(Math.Round(vUsagePercent, 2) > int.Parse(vNotiSpace))
                    {
                        chartDrive.Titles["Title2"].ForeColor = Color.Red;
                        lbNotiSpace.Text = "Data over limit";
                        //DeleteOverData();
                    }
                    else
                    {
                        chartDrive.Titles["Title2"].ForeColor = Color.Black;
                        lbNotiSpace.Text = "";
                    }
                        
                    //chartDrive.Series["SeriesDrive"]["PieLabelStyle"] = "Disabled";
                    chartDrive.Series["SeriesDrive"].IsValueShownAsLabel = true;
                    chartDrive.Series["SeriesDrive"].Points.AddXY("Usage", Math.Round(vFreePercent, 2));
                    chartDrive.Series["SeriesDrive"].Points.AddXY("Free", Math.Round(vUsagePercent, 2));
                    
                }
            }
        }
        private void DeleteOverData()
        {
            try
            {
                if (lbStatus.Text == "Finish...")
                {
                    List<string> Patients = orthancAPI.GetOrthancPatients(OrthancReceive, PortOrthancReceive, UserOrthancReceive, PWOrthancReceive);
                    string[] PatientsArr = Patients.ToArray();

                    if (dgWPatientDelete.IsBusy != true)
                    {
                        dgWPatientDelete.RunWorkerAsync(PatientsArr[0]);
                    }
                }
            }
            catch
            {
                //return;
            }
            //DeleteOrthancPatient(PatientsArr[0]);
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            SendText("Offline");
        }

        private void btClsLogRes_Click(object sender, EventArgs e)
        {
            rTBResultRecceive.Clear();
        }
        private void UpdateFileOrthanc()
        {
            try
            {
                string orthancFile = "C:\\Program Files\\Orthanc Server\\Configuration\\orthanc.json";
                JObject o2 = new JObject();
                var newPeer = "{\"reveivePeer\" : [ \"Test\" , \"companyname\", \"companyname\"] }";  
                using (StreamReader r = File.OpenText(orthancFile))
                using (JsonTextReader reader = new JsonTextReader(r))
                {
                    o2 = (JObject)JToken.ReadFrom(reader);
                    var experienceArrary = o2.GetValue("OrthancPeers") as JArray;
                    var vNewPeer = (JObject)JToken.Parse(newPeer);
                    experienceArrary.Add("\"reveivePeer\" :[]");

                    o2["OrthancPeers"] = experienceArrary;

                    string newJsonResult = Newtonsoft.Json.JsonConvert.SerializeObject(o2, Formatting.Indented);
                    File.WriteAllText(orthancFile, newJsonResult);

                    string OrthancPeers = o2.SelectToken("OrthancPeers").ToString();
                    ResultReceive(OrthancPeers);
                }
                
            }
            catch (Exception ex)
            {
                ResultReceive(ex.Message);
            }
        }

        public class Itemorthanc
        {
            public string OrthancPeers { get; set; }
        }
        /*----------------Socket---------------------------*/
        private void ConnectToServer()
        {
            int amp = 0;
            while (!_ClientSocket.Connected)
            {
                try
                {
                    rTBSocketStatus.Clear();
                    amp++;
                    rTBSocketStatus.Invoke(this.clientStatus, new Object[] { "Connecting... (" + amp + ")" });
                    IPEndPoint iep = new IPEndPoint(IPAddress.Parse(IPServer), int.Parse(PortServer));
                    _ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    _ClientSocket.Connect(iep);
                    _ClientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _ClientSocket);
                    SendText("Online");

                    lbSocketStatus.Text = "Online";
                    lbSocketStatus.BackColor = Color.Green;
                    rTBSocketStatus.Invoke(this.clientStatus, new Object[] { "Connected to: " + _ClientSocket.RemoteEndPoint.ToString() });
                }
                catch (SocketException ex)
                {
                    lbSocketStatus.Text = "Offline";
                    lbSocketStatus.BackColor = Color.Red;
                    rTBSocketStatus.Invoke(this.clientStatus, new Object[] { "Connection : " + _ClientSocket.Connected.ToString() });
                }
            }
            
        }
        private void ReceiveData(IAsyncResult iar)
        {
            int received;

            try
            {
                received = _ClientSocket.EndReceive(iar);
            }
            catch (SocketException)
            {
                return;
            }

            if (received == 0) return;
            var data = new byte[received];
            Array.Copy(buffer, data, received);
            string receivedData = Encoding.ASCII.GetString(data);

            if (receivedData != "1")
            {
                if (receivedData == "KeepAlive")
                {
                    rTBSocketReceive.Clear();
                    rTBSocketReceive.Invoke(this.clientReceive, new Object[] { receivedData });
                }
                else if (receivedData == "Offline")
                {
                    exitApp();
                    return;
                }
                else
                {
                    rTBResultRecceive.Invoke(this.clientReceive, new Object[] { receivedData });
                }
            }
        }
        private void SendData(IAsyncResult iar)
        {
            int sent;
            try
            {
                sent = _ClientSocket.EndReceive(iar);
            }
            catch (SocketException)
            {
                _ClientSocket.Close();
                return;
            }

            if (sent == 0) return;
            try
            {
                _ClientSocket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveData), _ClientSocket);
            }
            catch (Exception ex)
            {
                ResultSocketStatus(ex.Message);
            }
        }
        private void SendText(string text)
        {
            try
            {
                //if (_ClientSocket.Connected)
                //{
                    string vClientName = lbOrthancRecvice.Text;
                    byte[] message = Encoding.ASCII.GetBytes(vClientName + "," + text);
                    _ClientSocket.BeginSend(message, 0, message.Length, SocketFlags.None, new AsyncCallback(SendData), _ClientSocket);
                //}
            }
            catch (Exception ex)
            {
                ResultSocketStatus("Offline");
            }
        }
        private void bgWSocket_DoWork(object sender, DoWorkEventArgs e)
        {
            ConnectToServer();
        }

        private void exitApp()
        {
            _ClientSocket.Shutdown(SocketShutdown.Both);
            _ClientSocket.Disconnect(true);
            _ClientSocket.Dispose();
            _ClientSocket.Close();
            Application.Exit();
        }
        public void LoopChk()
        {
            lbStatus.Text = "Count Image...";
            int vInstanceslen = 0;
            int vInstancesCount = -1;
            while (vInstanceslen != vInstancesCount)
            {
                try
                {
                    vInstancesCount = ChkInstances();
                    lbImgCount.Text = vInstancesCount.ToString();
                    AutoSleep(vInstancesCount);
                    System.Threading.Thread.Sleep(vSleepAuto);

                    vInstanceslen = ChkInstances();
                    lbImgCount.Text = vInstanceslen.ToString();
                    AutoSleep(vInstanceslen);
                    System.Threading.Thread.Sleep(vSleepAuto);

                    vInstancesCount = ChkInstances();
                    lbImgCount.Text = vInstancesCount.ToString();
                    AutoSleep(vInstancesCount);
                    System.Threading.Thread.Sleep(vSleepAuto);
                }
                catch (Exception e)
                {
                    ResultReceive(e.Message);
                    vInstancesCount = 0;
                }
            }
        }
        public void AutoSleep(int Count)
        {
            if (Count > 500)
            {
                vSleepAuto = 15000;
            }
            else if(Count > 700)
            {
                vSleepAuto = 20000;
            }
            else if (Count > 1000)
            {
                vSleepAuto = 25000;
            }
            else
            {
                vSleepAuto = 10000;
            }
        }
        public int ChkInstances()
        {
            string PPID = dGVMonitor.Rows[0].Cells["ParentPatient"].Value.ToString();
            int vInstanceslen = 0;
            string SreiesDetail = "{\n \"Data\" :" + orthancAPI.GetOrthancChkSeries(OrthancReceive, PortOrthancReceive, UserOrthancReceive, PWOrthancReceive, PPID) + "\n}";

            JObject jsonSreies = new JObject();
            jsonSreies = JObject.Parse(SreiesDetail);
            JArray vData = (JArray)jsonSreies["Data"];
            int vDatalen = vData.Count;

            for (int i = 0; i < vDatalen; i++)
            {
                var item = (JObject)vData[i];
                JArray vInstances = (JArray)item["Instances"];
                vInstanceslen += vInstances.Count;
                //do something with item
            }
            return vInstanceslen;
        }
        private void bdWCountIns_DoWork(object sender, DoWorkEventArgs e)
        {
            LoopChk();
        }
        private void bdWCountIns_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            lbStatus.Text = "Count Image done.";
            if (bgWPeer.IsBusy != true)
            {
                bgWPeer.RunWorkerAsync();
            }
        }
        private void timerCheckImg_Tick(object sender, EventArgs e)
        {
            string vTotalImg = lbImgCount.Text;
            int cTotalImg = int.Parse(vTotalImg);

            for (int i = 0; i < cTotalImg; i++)
            {
                lbNotiSpace.Text = i.ToString();
            }
        }
    }
}
