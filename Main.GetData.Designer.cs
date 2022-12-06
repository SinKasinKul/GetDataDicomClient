namespace GetDataDicom
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.Title title4 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.lbImgCount = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lbNotiSpace = new System.Windows.Forms.Label();
            this.lbOrthancRecvice = new System.Windows.Forms.Label();
            this.lbOrthancData = new System.Windows.Forms.Label();
            this.lbTotalCase = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbTimeShow = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbLastUpdate = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chartDrive = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dGVMonitor = new System.Windows.Forms.DataGridView();
            this.PatientID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudyDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ParentPatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrthancID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastUpdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tBPort = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tBIP = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbNotiSpace = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.cbBDrive = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkStartUp = new System.Windows.Forms.CheckBox();
            this.cBPeerWithDelete = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tBPWOrthancData = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tBUserOrthancData = new System.Windows.Forms.TextBox();
            this.tBOrthancData = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tBPortOrthancData = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tBPWOrthancReceice = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tBUserOrthancReceice = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBPoetOrthancReceice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tBOrthancReceice = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.lbSocketStatus = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.cBShowLogSocket = new System.Windows.Forms.CheckBox();
            this.btClsLogRes = new System.Windows.Forms.Button();
            this.cBShowResponse = new System.Windows.Forms.CheckBox();
            this.label18 = new System.Windows.Forms.Label();
            this.rTBSocketReceive = new System.Windows.Forms.RichTextBox();
            this.rTBSocketStatus = new System.Windows.Forms.RichTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rTBResultRecceive = new System.Windows.Forms.RichTextBox();
            this.bgWPingReceive = new System.ComponentModel.BackgroundWorker();
            this.bgWPingData = new System.ComponentModel.BackgroundWorker();
            this.timerGetData = new System.Windows.Forms.Timer(this.components);
            this.dgWGetData = new System.ComponentModel.BackgroundWorker();
            this.bgWPeer = new System.ComponentModel.BackgroundWorker();
            this.dgWPatientDelete = new System.ComponentModel.BackgroundWorker();
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.bgWSocket = new System.ComponentModel.BackgroundWorker();
            this.label23 = new System.Windows.Forms.Label();
            this.bdWCountIns = new System.ComponentModel.BackgroundWorker();
            this.timerCheckImg = new System.Windows.Forms.Timer(this.components);
            this.cBConnectName = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMonitor)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(765, 481);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.chartDrive);
            this.tabPage1.Controls.Add(this.dGVMonitor);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(757, 455);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Monitoring";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox5.Controls.Add(this.lbImgCount);
            this.groupBox5.Controls.Add(this.label24);
            this.groupBox5.Controls.Add(this.lbNotiSpace);
            this.groupBox5.Controls.Add(this.lbOrthancRecvice);
            this.groupBox5.Controls.Add(this.lbOrthancData);
            this.groupBox5.Controls.Add(this.lbTotalCase);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.lbTimeShow);
            this.groupBox5.Controls.Add(this.lbStatus);
            this.groupBox5.Controls.Add(this.lbLastUpdate);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(549, 218);
            this.groupBox5.TabIndex = 35;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Status";
            // 
            // lbImgCount
            // 
            this.lbImgCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbImgCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbImgCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbImgCount.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbImgCount.Location = new System.Drawing.Point(403, 83);
            this.lbImgCount.Name = "lbImgCount";
            this.lbImgCount.Size = new System.Drawing.Size(135, 25);
            this.lbImgCount.TabIndex = 43;
            this.lbImgCount.Text = "-";
            this.lbImgCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(236, 83);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(161, 25);
            this.label24.TabIndex = 42;
            this.label24.Text = "Image Count :: ";
            this.label24.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lbNotiSpace
            // 
            this.lbNotiSpace.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lbNotiSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNotiSpace.ForeColor = System.Drawing.Color.Tomato;
            this.lbNotiSpace.Location = new System.Drawing.Point(365, 173);
            this.lbNotiSpace.Name = "lbNotiSpace";
            this.lbNotiSpace.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbNotiSpace.Size = new System.Drawing.Size(178, 25);
            this.lbNotiSpace.TabIndex = 40;
            this.lbNotiSpace.Text = "-";
            this.lbNotiSpace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbOrthancRecvice
            // 
            this.lbOrthancRecvice.BackColor = System.Drawing.Color.Red;
            this.lbOrthancRecvice.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbOrthancRecvice.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrthancRecvice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbOrthancRecvice.Location = new System.Drawing.Point(178, 54);
            this.lbOrthancRecvice.Name = "lbOrthancRecvice";
            this.lbOrthancRecvice.Size = new System.Drawing.Size(365, 25);
            this.lbOrthancRecvice.TabIndex = 39;
            this.lbOrthancRecvice.Text = "Offline";
            this.lbOrthancRecvice.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbOrthancData
            // 
            this.lbOrthancData.BackColor = System.Drawing.Color.Red;
            this.lbOrthancData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbOrthancData.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrthancData.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbOrthancData.Location = new System.Drawing.Point(178, 19);
            this.lbOrthancData.Name = "lbOrthancData";
            this.lbOrthancData.Size = new System.Drawing.Size(365, 25);
            this.lbOrthancData.TabIndex = 38;
            this.lbOrthancData.Text = "Offline";
            this.lbOrthancData.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTotalCase
            // 
            this.lbTotalCase.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbTotalCase.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTotalCase.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTotalCase.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbTotalCase.Location = new System.Drawing.Point(160, 83);
            this.lbTotalCase.Name = "lbTotalCase";
            this.lbTotalCase.Size = new System.Drawing.Size(70, 25);
            this.lbTotalCase.TabIndex = 35;
            this.lbTotalCase.Text = "-";
            this.lbTotalCase.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(16, 83);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(144, 25);
            this.label20.TabIndex = 34;
            this.label20.Text = "Total Case :: ";
            this.label20.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(77, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 25);
            this.label8.TabIndex = 20;
            this.label8.Text = "Date ::";
            // 
            // lbTimeShow
            // 
            this.lbTimeShow.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbTimeShow.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbTimeShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeShow.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbTimeShow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTimeShow.Location = new System.Drawing.Point(160, 113);
            this.lbTimeShow.Name = "lbTimeShow";
            this.lbTimeShow.Size = new System.Drawing.Size(237, 25);
            this.lbTimeShow.TabIndex = 19;
            this.lbTimeShow.Text = "-";
            this.lbTimeShow.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbStatus.Location = new System.Drawing.Point(160, 174);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(199, 26);
            this.lbStatus.TabIndex = 23;
            this.lbStatus.Text = "-";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbLastUpdate
            // 
            this.lbLastUpdate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbLastUpdate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbLastUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastUpdate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lbLastUpdate.Location = new System.Drawing.Point(160, 143);
            this.lbLastUpdate.Name = "lbLastUpdate";
            this.lbLastUpdate.Size = new System.Drawing.Size(237, 25);
            this.lbLastUpdate.TabIndex = 33;
            this.lbLastUpdate.Text = "-";
            this.lbLastUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(60, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(100, 25);
            this.label11.TabIndex = 31;
            this.label11.Text = "Status :: ";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 143);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(154, 25);
            this.label19.TabIndex = 32;
            this.label19.Text = "Last Update :: ";
            this.label19.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 25);
            this.label7.TabIndex = 1;
            this.label7.Text = "Server Data :: ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Client Receive :: ";
            // 
            // chartDrive
            // 
            this.chartDrive.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chartDrive.BorderlineColor = System.Drawing.Color.DarkRed;
            this.chartDrive.BorderlineWidth = 2;
            chartArea2.Name = "ChartArea1";
            this.chartDrive.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartDrive.Legends.Add(legend2);
            this.chartDrive.Location = new System.Drawing.Point(561, 3);
            this.chartDrive.Name = "chartDrive";
            series2.BackImageAlignment = System.Windows.Forms.DataVisualization.Charting.ChartImageAlignmentStyle.Center;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Color = System.Drawing.Color.NavajoWhite;
            series2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            series2.IsVisibleInLegend = false;
            series2.Legend = "Legend1";
            series2.Name = "SeriesDrive";
            this.chartDrive.Series.Add(series2);
            this.chartDrive.Size = new System.Drawing.Size(190, 221);
            this.chartDrive.TabIndex = 28;
            this.chartDrive.Text = "chart1";
            title3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title3.Name = "Title1";
            title4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold);
            title4.Name = "Title2";
            this.chartDrive.Titles.Add(title3);
            this.chartDrive.Titles.Add(title4);
            // 
            // dGVMonitor
            // 
            this.dGVMonitor.AllowUserToAddRows = false;
            this.dGVMonitor.AllowUserToDeleteRows = false;
            this.dGVMonitor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dGVMonitor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGVMonitor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PatientID,
            this.PatientName,
            this.PatientSex,
            this.PatientBirthDate,
            this.StudyDescription,
            this.ParentPatient,
            this.OrthancID,
            this.LastUpdate});
            this.dGVMonitor.Location = new System.Drawing.Point(6, 230);
            this.dGVMonitor.Name = "dGVMonitor";
            this.dGVMonitor.ReadOnly = true;
            this.dGVMonitor.RowHeadersVisible = false;
            this.dGVMonitor.Size = new System.Drawing.Size(745, 219);
            this.dGVMonitor.TabIndex = 4;
            // 
            // PatientID
            // 
            this.PatientID.DataPropertyName = "PatientID";
            this.PatientID.HeaderText = "PatientID";
            this.PatientID.Name = "PatientID";
            this.PatientID.ReadOnly = true;
            this.PatientID.Width = 85;
            // 
            // PatientName
            // 
            this.PatientName.DataPropertyName = "PatientName";
            this.PatientName.HeaderText = "PatientName";
            this.PatientName.Name = "PatientName";
            this.PatientName.ReadOnly = true;
            this.PatientName.Width = 104;
            // 
            // PatientSex
            // 
            this.PatientSex.DataPropertyName = "PatientSex";
            this.PatientSex.HeaderText = "PatientSex";
            this.PatientSex.Name = "PatientSex";
            this.PatientSex.ReadOnly = true;
            this.PatientSex.Width = 93;
            // 
            // PatientBirthDate
            // 
            this.PatientBirthDate.DataPropertyName = "PatientBirthDate";
            this.PatientBirthDate.HeaderText = "PatientBirthDate";
            this.PatientBirthDate.Name = "PatientBirthDate";
            this.PatientBirthDate.ReadOnly = true;
            this.PatientBirthDate.Width = 125;
            // 
            // StudyDescription
            // 
            this.StudyDescription.DataPropertyName = "StudyDescription";
            this.StudyDescription.HeaderText = "StudyDescription";
            this.StudyDescription.Name = "StudyDescription";
            this.StudyDescription.ReadOnly = true;
            this.StudyDescription.Width = 128;
            // 
            // ParentPatient
            // 
            this.ParentPatient.DataPropertyName = "ParentPatient";
            this.ParentPatient.HeaderText = "ParentPatient";
            this.ParentPatient.Name = "ParentPatient";
            this.ParentPatient.ReadOnly = true;
            this.ParentPatient.Width = 109;
            // 
            // OrthancID
            // 
            this.OrthancID.HeaderText = "OrthancID";
            this.OrthancID.Name = "OrthancID";
            this.OrthancID.ReadOnly = true;
            this.OrthancID.Width = 90;
            // 
            // LastUpdate
            // 
            this.LastUpdate.HeaderText = "LastUpdate";
            this.LastUpdate.Name = "LastUpdate";
            this.LastUpdate.ReadOnly = true;
            this.LastUpdate.Width = 97;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.btSave);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(757, 455);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Setting";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.tBPort);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.tBIP);
            this.groupBox4.Location = new System.Drawing.Point(318, 92);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(307, 75);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Socket Server";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(179, 23);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 3;
            this.label16.Text = "Port ::";
            // 
            // tBPort
            // 
            this.tBPort.Location = new System.Drawing.Point(220, 20);
            this.tBPort.Name = "tBPort";
            this.tBPort.Size = new System.Drawing.Size(48, 20);
            this.tBPort.TabIndex = 2;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 23);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(26, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "IP ::";
            // 
            // tBIP
            // 
            this.tBIP.Location = new System.Drawing.Point(38, 20);
            this.tBIP.Name = "tBIP";
            this.tBIP.Size = new System.Drawing.Size(135, 20);
            this.tBIP.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cBConnectName);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Controls.Add(this.tbNotiSpace);
            this.groupBox3.Controls.Add(this.label21);
            this.groupBox3.Controls.Add(this.cbBDrive);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.chkStartUp);
            this.groupBox3.Controls.Add(this.cBPeerWithDelete);
            this.groupBox3.Location = new System.Drawing.Point(6, 92);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(306, 111);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Orthanc Setting";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(145, 85);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 13);
            this.label22.TabIndex = 19;
            this.label22.Text = "%";
            // 
            // tbNotiSpace
            // 
            this.tbNotiSpace.Location = new System.Drawing.Point(91, 82);
            this.tbNotiSpace.Name = "tbNotiSpace";
            this.tbNotiSpace.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.tbNotiSpace.Size = new System.Drawing.Size(48, 20);
            this.tbNotiSpace.TabIndex = 16;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(14, 85);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(71, 13);
            this.label21.TabIndex = 18;
            this.label21.Text = "Limit Space ::";
            // 
            // cbBDrive
            // 
            this.cbBDrive.FormattingEnabled = true;
            this.cbBDrive.Location = new System.Drawing.Point(91, 59);
            this.cbBDrive.Name = "cbBDrive";
            this.cbBDrive.Size = new System.Drawing.Size(48, 21);
            this.cbBDrive.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Drive Monitor ::";
            // 
            // chkStartUp
            // 
            this.chkStartUp.AutoSize = true;
            this.chkStartUp.Location = new System.Drawing.Point(6, 19);
            this.chkStartUp.Name = "chkStartUp";
            this.chkStartUp.Size = new System.Drawing.Size(98, 17);
            this.chkStartUp.TabIndex = 16;
            this.chkStartUp.Text = "Setting StartUp";
            this.chkStartUp.UseVisualStyleBackColor = true;
            // 
            // cBPeerWithDelete
            // 
            this.cBPeerWithDelete.AutoSize = true;
            this.cBPeerWithDelete.Location = new System.Drawing.Point(6, 42);
            this.cBPeerWithDelete.Name = "cBPeerWithDelete";
            this.cBPeerWithDelete.Size = new System.Drawing.Size(133, 17);
            this.cBPeerWithDelete.TabIndex = 15;
            this.cBPeerWithDelete.Text = "Delete Data After Peer";
            this.cBPeerWithDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tBPWOrthancData);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.tBUserOrthancData);
            this.groupBox2.Controls.Add(this.tBOrthancData);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.tBPortOrthancData);
            this.groupBox2.Location = new System.Drawing.Point(318, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(307, 80);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Setting Orthanc Data";
            // 
            // tBPWOrthancData
            // 
            this.tBPWOrthancData.Location = new System.Drawing.Point(174, 48);
            this.tBPWOrthancData.Name = "tBPWOrthancData";
            this.tBPWOrthancData.PasswordChar = '*';
            this.tBPWOrthancData.Size = new System.Drawing.Size(69, 20);
            this.tBPWOrthancData.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "URL ::";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(134, 51);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(34, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "PW ::";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Port ::";
            // 
            // tBUserOrthancData
            // 
            this.tBUserOrthancData.Location = new System.Drawing.Point(50, 48);
            this.tBUserOrthancData.Name = "tBUserOrthancData";
            this.tBUserOrthancData.PasswordChar = '*';
            this.tBUserOrthancData.Size = new System.Drawing.Size(78, 20);
            this.tBUserOrthancData.TabIndex = 17;
            // 
            // tBOrthancData
            // 
            this.tBOrthancData.Location = new System.Drawing.Point(50, 21);
            this.tBOrthancData.Name = "tBOrthancData";
            this.tBOrthancData.Size = new System.Drawing.Size(152, 20);
            this.tBOrthancData.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 16;
            this.label15.Text = "User ::";
            // 
            // tBPortOrthancData
            // 
            this.tBPortOrthancData.Location = new System.Drawing.Point(249, 21);
            this.tBPortOrthancData.Name = "tBPortOrthancData";
            this.tBPortOrthancData.Size = new System.Drawing.Size(48, 20);
            this.tBPortOrthancData.TabIndex = 10;
            // 
            // btSave
            // 
            this.btSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSave.Location = new System.Drawing.Point(676, 426);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(75, 23);
            this.btSave.TabIndex = 12;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.BtSave_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tBPWOrthancReceice);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.tBUserOrthancReceice);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tBPoetOrthancReceice);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tBOrthancReceice);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(306, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting Orthanc Receive";
            // 
            // tBPWOrthancReceice
            // 
            this.tBPWOrthancReceice.Location = new System.Drawing.Point(176, 50);
            this.tBPWOrthancReceice.Name = "tBPWOrthancReceice";
            this.tBPWOrthancReceice.PasswordChar = '*';
            this.tBPWOrthancReceice.Size = new System.Drawing.Size(61, 20);
            this.tBPWOrthancReceice.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(136, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 13);
            this.label13.TabIndex = 14;
            this.label13.Text = "PW ::";
            // 
            // tBUserOrthancReceice
            // 
            this.tBUserOrthancReceice.Location = new System.Drawing.Point(52, 51);
            this.tBUserOrthancReceice.Name = "tBUserOrthancReceice";
            this.tBUserOrthancReceice.PasswordChar = '*';
            this.tBUserOrthancReceice.Size = new System.Drawing.Size(78, 20);
            this.tBUserOrthancReceice.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(8, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(38, 13);
            this.label12.TabIndex = 12;
            this.label12.Text = "User ::";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(202, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Port ::";
            // 
            // tBPoetOrthancReceice
            // 
            this.tBPoetOrthancReceice.Location = new System.Drawing.Point(243, 24);
            this.tBPoetOrthancReceice.Name = "tBPoetOrthancReceice";
            this.tBPoetOrthancReceice.Size = new System.Drawing.Size(48, 20);
            this.tBPoetOrthancReceice.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "URL ::";
            // 
            // tBOrthancReceice
            // 
            this.tBOrthancReceice.Location = new System.Drawing.Point(52, 24);
            this.tBOrthancReceice.Name = "tBOrthancReceice";
            this.tBOrthancReceice.Size = new System.Drawing.Size(147, 20);
            this.tBOrthancReceice.TabIndex = 4;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.tabPage3.Controls.Add(this.lbSocketStatus);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.cBShowLogSocket);
            this.tabPage3.Controls.Add(this.btClsLogRes);
            this.tabPage3.Controls.Add(this.cBShowResponse);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.rTBSocketReceive);
            this.tabPage3.Controls.Add(this.rTBSocketStatus);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.rTBResultRecceive);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(757, 455);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Log Data";
            // 
            // lbSocketStatus
            // 
            this.lbSocketStatus.AutoSize = true;
            this.lbSocketStatus.BackColor = System.Drawing.Color.Red;
            this.lbSocketStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSocketStatus.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbSocketStatus.Location = new System.Drawing.Point(160, 225);
            this.lbSocketStatus.Name = "lbSocketStatus";
            this.lbSocketStatus.Size = new System.Drawing.Size(69, 22);
            this.lbSocketStatus.TabIndex = 11;
            this.lbSocketStatus.Text = "Offline";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(676, 225);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Clear Log";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // cBShowLogSocket
            // 
            this.cBShowLogSocket.AutoSize = true;
            this.cBShowLogSocket.Checked = true;
            this.cBShowLogSocket.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBShowLogSocket.Location = new System.Drawing.Point(617, 228);
            this.cBShowLogSocket.Name = "cBShowLogSocket";
            this.cBShowLogSocket.Size = new System.Drawing.Size(53, 17);
            this.cBShowLogSocket.TabIndex = 9;
            this.cBShowLogSocket.Text = "Show";
            this.cBShowLogSocket.UseVisualStyleBackColor = true;
            // 
            // btClsLogRes
            // 
            this.btClsLogRes.Location = new System.Drawing.Point(676, 5);
            this.btClsLogRes.Name = "btClsLogRes";
            this.btClsLogRes.Size = new System.Drawing.Size(75, 23);
            this.btClsLogRes.TabIndex = 8;
            this.btClsLogRes.Text = "Clear Log";
            this.btClsLogRes.UseVisualStyleBackColor = true;
            this.btClsLogRes.Click += new System.EventHandler(this.btClsLogRes_Click);
            // 
            // cBShowResponse
            // 
            this.cBShowResponse.AutoSize = true;
            this.cBShowResponse.Checked = true;
            this.cBShowResponse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBShowResponse.Location = new System.Drawing.Point(617, 9);
            this.cBShowResponse.Name = "cBShowResponse";
            this.cBShowResponse.Size = new System.Drawing.Size(53, 17);
            this.cBShowResponse.TabIndex = 7;
            this.cBShowResponse.Text = "Show";
            this.cBShowResponse.UseVisualStyleBackColor = true;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label18.Location = new System.Drawing.Point(382, 225);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(149, 22);
            this.label18.TabIndex = 6;
            this.label18.Text = "Socket Receive";
            // 
            // rTBSocketReceive
            // 
            this.rTBSocketReceive.Location = new System.Drawing.Point(386, 247);
            this.rTBSocketReceive.Name = "rTBSocketReceive";
            this.rTBSocketReceive.ReadOnly = true;
            this.rTBSocketReceive.Size = new System.Drawing.Size(365, 192);
            this.rTBSocketReceive.TabIndex = 5;
            this.rTBSocketReceive.Text = "";
            // 
            // rTBSocketStatus
            // 
            this.rTBSocketStatus.Location = new System.Drawing.Point(6, 247);
            this.rTBSocketStatus.Name = "rTBSocketStatus";
            this.rTBSocketStatus.ReadOnly = true;
            this.rTBSocketStatus.Size = new System.Drawing.Size(365, 192);
            this.rTBSocketStatus.TabIndex = 4;
            this.rTBSocketStatus.Text = "";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(7, 225);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(134, 22);
            this.label9.TabIndex = 3;
            this.label9.Text = "Socket Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(6, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(159, 25);
            this.label5.TabIndex = 1;
            this.label5.Text = "Response Data";
            // 
            // rTBResultRecceive
            // 
            this.rTBResultRecceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTBResultRecceive.Location = new System.Drawing.Point(6, 36);
            this.rTBResultRecceive.Name = "rTBResultRecceive";
            this.rTBResultRecceive.ReadOnly = true;
            this.rTBResultRecceive.Size = new System.Drawing.Size(745, 186);
            this.rTBResultRecceive.TabIndex = 0;
            this.rTBResultRecceive.Text = "";
            // 
            // bgWPingReceive
            // 
            this.bgWPingReceive.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWPingReceive_DoWork);
            this.bgWPingReceive.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgWPingReceive_RunWorkerCompleted);
            // 
            // bgWPingData
            // 
            this.bgWPingData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWPingData_DoWork);
            this.bgWPingData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgWPingData_RunWorkerCompleted);
            // 
            // timerGetData
            // 
            this.timerGetData.Tick += new System.EventHandler(this.TimerGetData_Tick);
            // 
            // dgWGetData
            // 
            this.dgWGetData.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DgWGetData_DoWork);
            this.dgWGetData.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.DgWGetData_RunWorkerCompleted);
            // 
            // bgWPeer
            // 
            this.bgWPeer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BgWPeer_DoWork);
            this.bgWPeer.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgWPeer_ProgressChanged);
            this.bgWPeer.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BgWPeer_RunWorkerCompleted);
            // 
            // dgWPatientDelete
            // 
            this.dgWPatientDelete.DoWork += new System.ComponentModel.DoWorkEventHandler(this.DgWPatientDelete_DoWork);
            this.dgWPatientDelete.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.DgWPatientDelete_RunWorkerCompleted);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip";
            this.contextMenuStrip.Size = new System.Drawing.Size(104, 48);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.ShowToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // trayIcon
            // 
            this.trayIcon.ContextMenuStrip = this.contextMenuStrip;
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "TransOrthancClient";
            this.trayIcon.Visible = true;
            // 
            // bgWSocket
            // 
            this.bgWSocket.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWSocket_DoWork);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label23.Location = new System.Drawing.Point(542, 496);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(235, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "Copyright© 2020 Kinmedical Version 4.1";
            // 
            // bdWCountIns
            // 
            this.bdWCountIns.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bdWCountIns_DoWork);
            this.bdWCountIns.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bdWCountIns_RunWorkerCompleted);
            // 
            // timerCheckImg
            // 
            this.timerCheckImg.Tick += new System.EventHandler(this.timerCheckImg_Tick);
            // 
            // cBConnectName
            // 
            this.cBConnectName.AutoSize = true;
            this.cBConnectName.Location = new System.Drawing.Point(119, 19);
            this.cBConnectName.Name = "cBConnectName";
            this.cBConnectName.Size = new System.Drawing.Size(119, 17);
            this.cBConnectName.TabIndex = 20;
            this.cBConnectName.Text = "Use Connect Name";
            this.cBConnectName.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(789, 515);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.ShowInTaskbar = false;
            this.Text = "Get Data From Orthanc Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartDrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dGVMonitor)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.contextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBPoetOrthancReceice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBOrthancReceice;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBPortOrthancData;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBOrthancData;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox rTBResultRecceive;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.ComponentModel.BackgroundWorker bgWPingReceive;
        private System.ComponentModel.BackgroundWorker bgWPingData;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tBPWOrthancData;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tBUserOrthancData;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tBPWOrthancReceice;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tBUserOrthancReceice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dGVMonitor;
        private System.Windows.Forms.Timer timerGetData;
        private System.ComponentModel.BackgroundWorker dgWGetData;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbTimeShow;
        private System.ComponentModel.BackgroundWorker bgWPeer;
        private System.Windows.Forms.Label lbStatus;
        private System.ComponentModel.BackgroundWorker dgWPatientDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cBPeerWithDelete;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon trayIcon;
        private System.Windows.Forms.CheckBox chkStartUp;
        private System.Windows.Forms.ComboBox cbBDrive;
        private System.Windows.Forms.Label label10;
        protected System.Windows.Forms.DataVisualization.Charting.Chart chartDrive;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tBPort;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tBIP;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox cBShowLogSocket;
        private System.Windows.Forms.Button btClsLogRes;
        private System.Windows.Forms.CheckBox cBShowResponse;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.RichTextBox rTBSocketReceive;
        private System.Windows.Forms.RichTextBox rTBSocketStatus;
        private System.Windows.Forms.Label lbSocketStatus;
        private System.ComponentModel.BackgroundWorker bgWSocket;
        private System.Windows.Forms.Label lbLastUpdate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lbTotalCase;
        private System.Windows.Forms.Label lbOrthancData;
        private System.Windows.Forms.Label lbOrthancRecvice;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbNotiSpace;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lbNotiSpace;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudyDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ParentPatient;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrthancID;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastUpdate;
        private System.Windows.Forms.Label lbImgCount;
        private System.Windows.Forms.Label label24;
        private System.ComponentModel.BackgroundWorker bdWCountIns;
        private System.Windows.Forms.Timer timerCheckImg;
        private System.Windows.Forms.CheckBox cBConnectName;
    }
}

