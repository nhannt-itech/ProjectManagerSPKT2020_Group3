namespace NNA.View
{
    partial class MainGUI
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
            System.Windows.Forms.Button btnChart;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGUI));
            System.Windows.Forms.Button btnProject;
            System.Windows.Forms.Button btnTeacher;
            System.Windows.Forms.Button btnStudent;
            System.Windows.Forms.Button btnDashBoard;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.dashboard = new System.Windows.Forms.TabPage();
            this.tabStudent = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearchStudent = new System.Windows.Forms.Button();
            this.txbSearchStudent = new System.Windows.Forms.TextBox();
            this.cbSearchStudent = new System.Windows.Forms.ComboBox();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnDetailStudent = new System.Windows.Forms.Button();
            this.dtgvStudent = new System.Windows.Forms.DataGridView();
            this.tabTeacher = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSearchTeacher = new System.Windows.Forms.Button();
            this.txbSearchTeacher = new System.Windows.Forms.TextBox();
            this.cbSearchTeacher = new System.Windows.Forms.ComboBox();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.btnUpdateTeacher = new System.Windows.Forms.Button();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnDetailTeacher = new System.Windows.Forms.Button();
            this.dtgvTeacher = new System.Windows.Forms.DataGridView();
            this.tabProject = new System.Windows.Forms.TabPage();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearchProject = new System.Windows.Forms.Button();
            this.txbSearchProject = new System.Windows.Forms.TextBox();
            this.cbSearchProject = new System.Windows.Forms.ComboBox();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.btnUpdateProject = new System.Windows.Forms.Button();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.btnDetailProject = new System.Windows.Forms.Button();
            this.dtgvProject = new System.Windows.Forms.DataGridView();
            this.tabChart = new System.Windows.Forms.TabPage();
            this.showChartStudent = new System.Windows.Forms.Button();
            this.showChartTeacher = new System.Windows.Forms.Button();
            this.showChartProject = new System.Windows.Forms.Button();
            this.chartALL = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            btnChart = new System.Windows.Forms.Button();
            btnProject = new System.Windows.Forms.Button();
            btnTeacher = new System.Windows.Forms.Button();
            btnStudent = new System.Windows.Forms.Button();
            btnDashBoard = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.dashboard.SuspendLayout();
            this.tabStudent.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStudent)).BeginInit();
            this.tabTeacher.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTeacher)).BeginInit();
            this.tabProject.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProject)).BeginInit();
            this.tabChart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartALL)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnChart
            // 
            btnChart.BackColor = System.Drawing.Color.Salmon;
            btnChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnChart.Image = ((System.Drawing.Image)(resources.GetObject("btnChart.Image")));
            btnChart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnChart.Location = new System.Drawing.Point(0, 330);
            btnChart.Name = "btnChart";
            btnChart.Size = new System.Drawing.Size(158, 58);
            btnChart.TabIndex = 5;
            btnChart.Text = "     Thống Kê";
            btnChart.UseVisualStyleBackColor = false;
            btnChart.Click += new System.EventHandler(this.BtnChart_Click);
            // 
            // btnProject
            // 
            btnProject.BackColor = System.Drawing.Color.Salmon;
            btnProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnProject.Image = ((System.Drawing.Image)(resources.GetObject("btnProject.Image")));
            btnProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnProject.Location = new System.Drawing.Point(0, 274);
            btnProject.Name = "btnProject";
            btnProject.Size = new System.Drawing.Size(158, 58);
            btnProject.TabIndex = 4;
            btnProject.Text = "  Đề Tài";
            btnProject.UseVisualStyleBackColor = false;
            btnProject.Click += new System.EventHandler(this.BtnProject_Click_1);
            // 
            // btnTeacher
            // 
            btnTeacher.BackColor = System.Drawing.Color.Salmon;
            btnTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnTeacher.Image = ((System.Drawing.Image)(resources.GetObject("btnTeacher.Image")));
            btnTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnTeacher.Location = new System.Drawing.Point(0, 218);
            btnTeacher.Name = "btnTeacher";
            btnTeacher.Size = new System.Drawing.Size(158, 58);
            btnTeacher.TabIndex = 2;
            btnTeacher.Text = "       Giáo Viên";
            btnTeacher.UseVisualStyleBackColor = false;
            btnTeacher.Click += new System.EventHandler(this.BtnTeacher_Click);
            // 
            // btnStudent
            // 
            btnStudent.BackColor = System.Drawing.Color.Salmon;
            btnStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnStudent.Image")));
            btnStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnStudent.Location = new System.Drawing.Point(0, 162);
            btnStudent.Name = "btnStudent";
            btnStudent.Size = new System.Drawing.Size(158, 58);
            btnStudent.TabIndex = 1;
            btnStudent.Text = "       Sinh Viên";
            btnStudent.UseVisualStyleBackColor = false;
            btnStudent.Click += new System.EventHandler(this.BtnStudent_Click);
            // 
            // btnDashBoard
            // 
            btnDashBoard.BackColor = System.Drawing.Color.Salmon;
            btnDashBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashBoard.Image")));
            btnDashBoard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnDashBoard.Location = new System.Drawing.Point(0, 106);
            btnDashBoard.Name = "btnDashBoard";
            btnDashBoard.Size = new System.Drawing.Size(158, 58);
            btnDashBoard.TabIndex = 0;
            btnDashBoard.Text = "        Trang Chủ";
            btnDashBoard.UseVisualStyleBackColor = false;
            btnDashBoard.Click += new System.EventHandler(this.BtnDashBoard_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Bisque;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(btnChart);
            this.panel1.Controls.Add(btnProject);
            this.panel1.Controls.Add(btnTeacher);
            this.panel1.Controls.Add(btnStudent);
            this.panel1.Controls.Add(btnDashBoard);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(158, 451);
            this.panel1.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.dashboard);
            this.tabMain.Controls.Add(this.tabStudent);
            this.tabMain.Controls.Add(this.tabTeacher);
            this.tabMain.Controls.Add(this.tabProject);
            this.tabMain.Controls.Add(this.tabChart);
            this.tabMain.Location = new System.Drawing.Point(156, 0);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(644, 451);
            this.tabMain.TabIndex = 0;
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.Bisque;
            this.dashboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dashboard.Controls.Add(this.pictureBox3);
            this.dashboard.Controls.Add(this.label11);
            this.dashboard.Controls.Add(this.label10);
            this.dashboard.Controls.Add(this.label9);
            this.dashboard.Controls.Add(this.label8);
            this.dashboard.Controls.Add(this.label7);
            this.dashboard.Controls.Add(this.label3);
            this.dashboard.Controls.Add(this.label2);
            this.dashboard.Controls.Add(this.label1);
            this.dashboard.Location = new System.Drawing.Point(4, 22);
            this.dashboard.Name = "dashboard";
            this.dashboard.Padding = new System.Windows.Forms.Padding(3);
            this.dashboard.Size = new System.Drawing.Size(636, 425);
            this.dashboard.TabIndex = 0;
            this.dashboard.Text = "Trang chủ";
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.panel3);
            this.tabStudent.Location = new System.Drawing.Point(4, 22);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.Padding = new System.Windows.Forms.Padding(3);
            this.tabStudent.Size = new System.Drawing.Size(636, 425);
            this.tabStudent.TabIndex = 1;
            this.tabStudent.Text = "Sinh Viên";
            this.tabStudent.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnSearchStudent);
            this.panel3.Controls.Add(this.txbSearchStudent);
            this.panel3.Controls.Add(this.cbSearchStudent);
            this.panel3.Controls.Add(this.btnDeleteStudent);
            this.panel3.Controls.Add(this.btnUpdateStudent);
            this.panel3.Controls.Add(this.btnAddStudent);
            this.panel3.Controls.Add(this.btnDetailStudent);
            this.panel3.Controls.Add(this.dtgvStudent);
            this.panel3.Location = new System.Drawing.Point(-1, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(636, 425);
            this.panel3.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(515, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 34);
            this.label4.TabIndex = 3;
            this.label4.Text = "Student";
            // 
            // btnSearchStudent
            // 
            this.btnSearchStudent.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudent.Location = new System.Drawing.Point(394, 23);
            this.btnSearchStudent.Name = "btnSearchStudent";
            this.btnSearchStudent.Size = new System.Drawing.Size(78, 20);
            this.btnSearchStudent.TabIndex = 11;
            this.btnSearchStudent.Text = "Tìm";
            this.btnSearchStudent.UseVisualStyleBackColor = true;
            this.btnSearchStudent.Click += new System.EventHandler(this.BtnSearchStudent_Click);
            // 
            // txbSearchStudent
            // 
            this.txbSearchStudent.Location = new System.Drawing.Point(183, 24);
            this.txbSearchStudent.Name = "txbSearchStudent";
            this.txbSearchStudent.Size = new System.Drawing.Size(205, 20);
            this.txbSearchStudent.TabIndex = 10;
            this.txbSearchStudent.Click += new System.EventHandler(this.TxbSearchStudent_Click);
            // 
            // cbSearchStudent
            // 
            this.cbSearchStudent.FormattingEnabled = true;
            this.cbSearchStudent.Items.AddRange(new object[] {
            "Mã Số Sinh Viên",
            "Họ Tên",
            "Số Điện Thoại",
            "Email",
            "Khoa",
            "Năm Nhập Học",
            "Mã Đề Tài",
            "Tất Cả"});
            this.cbSearchStudent.Location = new System.Drawing.Point(6, 24);
            this.cbSearchStudent.Name = "cbSearchStudent";
            this.cbSearchStudent.Size = new System.Drawing.Size(170, 21);
            this.cbSearchStudent.TabIndex = 9;
            this.cbSearchStudent.Text = "Tất Cả";
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteStudent.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudent.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteStudent.Image")));
            this.btnDeleteStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteStudent.Location = new System.Drawing.Point(497, 334);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(123, 53);
            this.btnDeleteStudent.TabIndex = 8;
            this.btnDeleteStudent.Text = "     Xóa";
            this.btnDeleteStudent.UseVisualStyleBackColor = false;
            this.btnDeleteStudent.Click += new System.EventHandler(this.BtnDeleteStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateStudent.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudent.ForeColor = System.Drawing.Color.Black;
            this.btnUpdateStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateStudent.Image")));
            this.btnUpdateStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateStudent.Location = new System.Drawing.Point(497, 259);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(123, 53);
            this.btnUpdateStudent.TabIndex = 7;
            this.btnUpdateStudent.Text = "     Sửa";
            this.btnUpdateStudent.UseVisualStyleBackColor = false;
            this.btnUpdateStudent.Click += new System.EventHandler(this.BtnUpdateStudent_Click);
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddStudent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnAddStudent.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudent.ForeColor = System.Drawing.Color.Black;
            this.btnAddStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnAddStudent.Image")));
            this.btnAddStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddStudent.Location = new System.Drawing.Point(497, 110);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(123, 53);
            this.btnAddStudent.TabIndex = 6;
            this.btnAddStudent.Text = "       Thêm";
            this.btnAddStudent.UseVisualStyleBackColor = false;
            this.btnAddStudent.Click += new System.EventHandler(this.BtnAddStudent_Click);
            // 
            // btnDetailStudent
            // 
            this.btnDetailStudent.BackColor = System.Drawing.Color.Turquoise;
            this.btnDetailStudent.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailStudent.ForeColor = System.Drawing.Color.Black;
            this.btnDetailStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnDetailStudent.Image")));
            this.btnDetailStudent.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetailStudent.Location = new System.Drawing.Point(497, 185);
            this.btnDetailStudent.Name = "btnDetailStudent";
            this.btnDetailStudent.Size = new System.Drawing.Size(123, 53);
            this.btnDetailStudent.TabIndex = 3;
            this.btnDetailStudent.Text = "          Chi Tiết";
            this.btnDetailStudent.UseVisualStyleBackColor = false;
            this.btnDetailStudent.Click += new System.EventHandler(this.BtnDetailStudent_Click);
            // 
            // dtgvStudent
            // 
            this.dtgvStudent.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvStudent.BackgroundColor = System.Drawing.Color.OldLace;
            this.dtgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvStudent.Location = new System.Drawing.Point(1, 69);
            this.dtgvStudent.Name = "dtgvStudent";
            this.dtgvStudent.RowHeadersWidth = 51;
            this.dtgvStudent.Size = new System.Drawing.Size(471, 356);
            this.dtgvStudent.TabIndex = 0;
            this.dtgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvStudent_CellClick);
            // 
            // tabTeacher
            // 
            this.tabTeacher.Controls.Add(this.panel4);
            this.tabTeacher.Location = new System.Drawing.Point(4, 22);
            this.tabTeacher.Name = "tabTeacher";
            this.tabTeacher.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeacher.Size = new System.Drawing.Size(636, 425);
            this.tabTeacher.TabIndex = 2;
            this.tabTeacher.Text = "Giáo Viên";
            this.tabTeacher.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.btnSearchTeacher);
            this.panel4.Controls.Add(this.txbSearchTeacher);
            this.panel4.Controls.Add(this.cbSearchTeacher);
            this.panel4.Controls.Add(this.btnDeleteTeacher);
            this.panel4.Controls.Add(this.btnUpdateTeacher);
            this.panel4.Controls.Add(this.btnAddTeacher);
            this.panel4.Controls.Add(this.btnDetailTeacher);
            this.panel4.Controls.Add(this.dtgvTeacher);
            this.panel4.Location = new System.Drawing.Point(-1, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(636, 425);
            this.panel4.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(514, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 34);
            this.label5.TabIndex = 12;
            this.label5.Text = "Teacher";
            // 
            // btnSearchTeacher
            // 
            this.btnSearchTeacher.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTeacher.Location = new System.Drawing.Point(394, 23);
            this.btnSearchTeacher.Name = "btnSearchTeacher";
            this.btnSearchTeacher.Size = new System.Drawing.Size(78, 20);
            this.btnSearchTeacher.TabIndex = 11;
            this.btnSearchTeacher.Text = "Tìm";
            this.btnSearchTeacher.UseVisualStyleBackColor = true;
            this.btnSearchTeacher.Click += new System.EventHandler(this.BtnSearchTeacher_Click);
            // 
            // txbSearchTeacher
            // 
            this.txbSearchTeacher.Location = new System.Drawing.Point(183, 24);
            this.txbSearchTeacher.Name = "txbSearchTeacher";
            this.txbSearchTeacher.Size = new System.Drawing.Size(205, 20);
            this.txbSearchTeacher.TabIndex = 10;
            this.txbSearchTeacher.Click += new System.EventHandler(this.TxbSearchTeacher_Click);
            // 
            // cbSearchTeacher
            // 
            this.cbSearchTeacher.FormattingEnabled = true;
            this.cbSearchTeacher.Items.AddRange(new object[] {
            "Mã Giáo Viên",
            "Họ Tên",
            "Số Điện Thoại",
            "Email",
            "Khoa",
            "Môn",
            "Mã Đề Tài GVQL",
            "Tất Cả"});
            this.cbSearchTeacher.Location = new System.Drawing.Point(6, 24);
            this.cbSearchTeacher.Name = "cbSearchTeacher";
            this.cbSearchTeacher.Size = new System.Drawing.Size(170, 21);
            this.cbSearchTeacher.TabIndex = 9;
            this.cbSearchTeacher.Text = "Tất Cả";
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteTeacher.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteTeacher.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteTeacher.Image")));
            this.btnDeleteTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteTeacher.Location = new System.Drawing.Point(497, 334);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(123, 53);
            this.btnDeleteTeacher.TabIndex = 8;
            this.btnDeleteTeacher.Text = "     Xóa";
            this.btnDeleteTeacher.UseVisualStyleBackColor = false;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.BtnDeleteTeacher_Click);
            // 
            // btnUpdateTeacher
            // 
            this.btnUpdateTeacher.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateTeacher.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateTeacher.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateTeacher.Image")));
            this.btnUpdateTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateTeacher.Location = new System.Drawing.Point(497, 259);
            this.btnUpdateTeacher.Name = "btnUpdateTeacher";
            this.btnUpdateTeacher.Size = new System.Drawing.Size(123, 53);
            this.btnUpdateTeacher.TabIndex = 7;
            this.btnUpdateTeacher.Text = "     Sửa";
            this.btnUpdateTeacher.UseVisualStyleBackColor = false;
            this.btnUpdateTeacher.Click += new System.EventHandler(this.BtnUpdateTeacher_Click);
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddTeacher.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTeacher.Image = ((System.Drawing.Image)(resources.GetObject("btnAddTeacher.Image")));
            this.btnAddTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddTeacher.Location = new System.Drawing.Point(497, 110);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(123, 53);
            this.btnAddTeacher.TabIndex = 6;
            this.btnAddTeacher.Text = "       Thêm";
            this.btnAddTeacher.UseVisualStyleBackColor = false;
            this.btnAddTeacher.Click += new System.EventHandler(this.BtnAddTeacher_Click);
            // 
            // btnDetailTeacher
            // 
            this.btnDetailTeacher.BackColor = System.Drawing.Color.Turquoise;
            this.btnDetailTeacher.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailTeacher.Image = ((System.Drawing.Image)(resources.GetObject("btnDetailTeacher.Image")));
            this.btnDetailTeacher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetailTeacher.Location = new System.Drawing.Point(497, 185);
            this.btnDetailTeacher.Name = "btnDetailTeacher";
            this.btnDetailTeacher.Size = new System.Drawing.Size(123, 53);
            this.btnDetailTeacher.TabIndex = 3;
            this.btnDetailTeacher.Text = "          Chi Tiết";
            this.btnDetailTeacher.UseVisualStyleBackColor = false;
            this.btnDetailTeacher.Click += new System.EventHandler(this.BtnDetailTeacher_Click);
            // 
            // dtgvTeacher
            // 
            this.dtgvTeacher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvTeacher.BackgroundColor = System.Drawing.Color.OldLace;
            this.dtgvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTeacher.Location = new System.Drawing.Point(1, 69);
            this.dtgvTeacher.Name = "dtgvTeacher";
            this.dtgvTeacher.RowHeadersWidth = 51;
            this.dtgvTeacher.Size = new System.Drawing.Size(471, 356);
            this.dtgvTeacher.TabIndex = 0;
            this.dtgvTeacher.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvTeacher_CellClick);
            // 
            // tabProject
            // 
            this.tabProject.Controls.Add(this.panel5);
            this.tabProject.Location = new System.Drawing.Point(4, 22);
            this.tabProject.Name = "tabProject";
            this.tabProject.Padding = new System.Windows.Forms.Padding(3);
            this.tabProject.Size = new System.Drawing.Size(636, 425);
            this.tabProject.TabIndex = 3;
            this.tabProject.Text = "Đề Tài";
            this.tabProject.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.btnSearchProject);
            this.panel5.Controls.Add(this.txbSearchProject);
            this.panel5.Controls.Add(this.cbSearchProject);
            this.panel5.Controls.Add(this.btnDeleteProject);
            this.panel5.Controls.Add(this.btnUpdateProject);
            this.panel5.Controls.Add(this.btnAddProject);
            this.panel5.Controls.Add(this.btnDetailProject);
            this.panel5.Controls.Add(this.dtgvProject);
            this.panel5.Location = new System.Drawing.Point(-1, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(636, 425);
            this.panel5.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Mistral", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(517, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 34);
            this.label6.TabIndex = 12;
            this.label6.Text = "Project";
            // 
            // btnSearchProject
            // 
            this.btnSearchProject.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchProject.Location = new System.Drawing.Point(394, 23);
            this.btnSearchProject.Name = "btnSearchProject";
            this.btnSearchProject.Size = new System.Drawing.Size(78, 20);
            this.btnSearchProject.TabIndex = 11;
            this.btnSearchProject.Text = "Tìm";
            this.btnSearchProject.UseVisualStyleBackColor = true;
            this.btnSearchProject.Click += new System.EventHandler(this.BtnSearchProject_Click);
            // 
            // txbSearchProject
            // 
            this.txbSearchProject.Location = new System.Drawing.Point(183, 24);
            this.txbSearchProject.Name = "txbSearchProject";
            this.txbSearchProject.Size = new System.Drawing.Size(205, 20);
            this.txbSearchProject.TabIndex = 10;
            this.txbSearchProject.Click += new System.EventHandler(this.TxbSearchProject_Click);
            // 
            // cbSearchProject
            // 
            this.cbSearchProject.FormattingEnabled = true;
            this.cbSearchProject.Items.AddRange(new object[] {
            "Mã Đề Tài",
            "Tên Đề Tài",
            "Loại Đề Tài",
            "Bộ Môn",
            "MGV Quản Lý",
            "MSV Tham Gia",
            "Kết Quả",
            "Tất Cả"});
            this.cbSearchProject.Location = new System.Drawing.Point(6, 24);
            this.cbSearchProject.Name = "cbSearchProject";
            this.cbSearchProject.Size = new System.Drawing.Size(170, 21);
            this.cbSearchProject.TabIndex = 9;
            this.cbSearchProject.Text = "Tất Cả";
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.BackColor = System.Drawing.Color.LightCoral;
            this.btnDeleteProject.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProject.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteProject.Image")));
            this.btnDeleteProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteProject.Location = new System.Drawing.Point(497, 334);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(123, 53);
            this.btnDeleteProject.TabIndex = 8;
            this.btnDeleteProject.Text = "     Xóa";
            this.btnDeleteProject.UseVisualStyleBackColor = false;
            this.btnDeleteProject.Click += new System.EventHandler(this.BtnDeleteProject_Click);
            // 
            // btnUpdateProject
            // 
            this.btnUpdateProject.BackColor = System.Drawing.Color.Silver;
            this.btnUpdateProject.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateProject.Image = ((System.Drawing.Image)(resources.GetObject("btnUpdateProject.Image")));
            this.btnUpdateProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdateProject.Location = new System.Drawing.Point(497, 259);
            this.btnUpdateProject.Name = "btnUpdateProject";
            this.btnUpdateProject.Size = new System.Drawing.Size(123, 53);
            this.btnUpdateProject.TabIndex = 7;
            this.btnUpdateProject.Text = "     Sửa";
            this.btnUpdateProject.UseVisualStyleBackColor = false;
            this.btnUpdateProject.Click += new System.EventHandler(this.BtnUpdateProject_Click);
            // 
            // btnAddProject
            // 
            this.btnAddProject.BackColor = System.Drawing.Color.YellowGreen;
            this.btnAddProject.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProject.Image = ((System.Drawing.Image)(resources.GetObject("btnAddProject.Image")));
            this.btnAddProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddProject.Location = new System.Drawing.Point(497, 110);
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.Size = new System.Drawing.Size(123, 53);
            this.btnAddProject.TabIndex = 6;
            this.btnAddProject.Text = "       Thêm";
            this.btnAddProject.UseVisualStyleBackColor = false;
            this.btnAddProject.Click += new System.EventHandler(this.BtnAddProject_Click);
            // 
            // btnDetailProject
            // 
            this.btnDetailProject.BackColor = System.Drawing.Color.Turquoise;
            this.btnDetailProject.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetailProject.Image = ((System.Drawing.Image)(resources.GetObject("btnDetailProject.Image")));
            this.btnDetailProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetailProject.Location = new System.Drawing.Point(497, 185);
            this.btnDetailProject.Name = "btnDetailProject";
            this.btnDetailProject.Size = new System.Drawing.Size(123, 53);
            this.btnDetailProject.TabIndex = 3;
            this.btnDetailProject.Text = "          Chi Tiết";
            this.btnDetailProject.UseVisualStyleBackColor = false;
            this.btnDetailProject.Click += new System.EventHandler(this.BtnDetailProject_Click);
            // 
            // dtgvProject
            // 
            this.dtgvProject.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvProject.BackgroundColor = System.Drawing.Color.OldLace;
            this.dtgvProject.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvProject.Location = new System.Drawing.Point(1, 69);
            this.dtgvProject.Name = "dtgvProject";
            this.dtgvProject.RowHeadersWidth = 51;
            this.dtgvProject.Size = new System.Drawing.Size(471, 356);
            this.dtgvProject.TabIndex = 0;
            this.dtgvProject.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgvProject_CellClick);
            // 
            // tabChart
            // 
            this.tabChart.Controls.Add(this.showChartStudent);
            this.tabChart.Controls.Add(this.showChartTeacher);
            this.tabChart.Controls.Add(this.showChartProject);
            this.tabChart.Controls.Add(this.chartALL);
            this.tabChart.Location = new System.Drawing.Point(4, 22);
            this.tabChart.Name = "tabChart";
            this.tabChart.Padding = new System.Windows.Forms.Padding(3);
            this.tabChart.Size = new System.Drawing.Size(636, 425);
            this.tabChart.TabIndex = 4;
            this.tabChart.Text = "Thống kê";
            this.tabChart.UseVisualStyleBackColor = true;
            // 
            // showChartStudent
            // 
            this.showChartStudent.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showChartStudent.Location = new System.Drawing.Point(441, 267);
            this.showChartStudent.Name = "showChartStudent";
            this.showChartStudent.Size = new System.Drawing.Size(162, 50);
            this.showChartStudent.TabIndex = 3;
            this.showChartStudent.Text = "Tỉ Lệ Sinh Viên";
            this.showChartStudent.UseVisualStyleBackColor = true;
            this.showChartStudent.Click += new System.EventHandler(this.ShowChartStudent_Click);
            // 
            // showChartTeacher
            // 
            this.showChartTeacher.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showChartTeacher.Location = new System.Drawing.Point(441, 175);
            this.showChartTeacher.Name = "showChartTeacher";
            this.showChartTeacher.Size = new System.Drawing.Size(162, 50);
            this.showChartTeacher.TabIndex = 2;
            this.showChartTeacher.Text = "Tỉ Lệ Giáo Viên";
            this.showChartTeacher.UseVisualStyleBackColor = true;
            this.showChartTeacher.Click += new System.EventHandler(this.ShowChartTeacher_Click);
            // 
            // showChartProject
            // 
            this.showChartProject.Font = new System.Drawing.Font("Verdana", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showChartProject.Location = new System.Drawing.Point(441, 82);
            this.showChartProject.Name = "showChartProject";
            this.showChartProject.Size = new System.Drawing.Size(162, 50);
            this.showChartProject.TabIndex = 1;
            this.showChartProject.Text = "Tỉ Lệ Đề Tài";
            this.showChartProject.UseVisualStyleBackColor = true;
            this.showChartProject.Click += new System.EventHandler(this.ShowChartProject_Click);
            // 
            // chartALL
            // 
            chartArea4.Name = "ChartArea1";
            this.chartALL.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chartALL.Legends.Add(legend4);
            this.chartALL.Location = new System.Drawing.Point(17, 26);
            this.chartALL.Name = "chartALL";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "chartALL";
            this.chartALL.Series.Add(series4);
            this.chartALL.Size = new System.Drawing.Size(420, 373);
            this.chartALL.TabIndex = 0;
            this.chartALL.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MistyRose;
            this.panel2.Controls.Add(this.tabMain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 450);
            this.panel2.TabIndex = 1;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(0, 22);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(158, 69);
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Bisque;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 263);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "GVHD: Huỳnh Xuân Phụng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Bisque;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 326);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhóm 3";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Bisque;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 326);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(207, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Trương Thị Thảo Nguyên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Bisque;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(273, 358);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Lương Thế Anh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Bisque;
            this.label8.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(272, 390);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 18);
            this.label8.TabIndex = 5;
            this.label8.Text = "Nguyễn Thanh Nhân";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Bisque;
            this.label9.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(504, 326);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 18);
            this.label9.TabIndex = 6;
            this.label9.Text = "18110327";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Bisque;
            this.label10.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(504, 358);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 18);
            this.label10.TabIndex = 7;
            this.label10.Text = "18110403";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Bisque;
            this.label11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(504, 390);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 18);
            this.label11.TabIndex = 8;
            this.label11.Text = "18110328";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Bisque;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(236, 17);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(196, 215);
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // MainGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "MainGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Đề Tài Sinh Viên";
            this.panel1.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.dashboard.ResumeLayout(false);
            this.dashboard.PerformLayout();
            this.tabStudent.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvStudent)).EndInit();
            this.tabTeacher.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTeacher)).EndInit();
            this.tabProject.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvProject)).EndInit();
            this.tabChart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartALL)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage dashboard;
        private System.Windows.Forms.TabPage tabStudent;
        private System.Windows.Forms.TabPage tabTeacher;
        private System.Windows.Forms.TabPage tabProject;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearchStudent;
        private System.Windows.Forms.TextBox txbSearchStudent;
        private System.Windows.Forms.ComboBox cbSearchStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnDetailStudent;
        private System.Windows.Forms.DataGridView dtgvStudent;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnSearchTeacher;
        private System.Windows.Forms.TextBox txbSearchTeacher;
        private System.Windows.Forms.ComboBox cbSearchTeacher;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.Button btnUpdateTeacher;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnDetailTeacher;
        private System.Windows.Forms.DataGridView dtgvTeacher;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnSearchProject;
        private System.Windows.Forms.TextBox txbSearchProject;
        private System.Windows.Forms.ComboBox cbSearchProject;
        private System.Windows.Forms.Button btnDeleteProject;
        private System.Windows.Forms.Button btnUpdateProject;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button btnDetailProject;
        private System.Windows.Forms.DataGridView dtgvProject;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TabPage tabChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartALL;
        private System.Windows.Forms.Button showChartStudent;
        private System.Windows.Forms.Button showChartTeacher;
        private System.Windows.Forms.Button showChartProject;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}

