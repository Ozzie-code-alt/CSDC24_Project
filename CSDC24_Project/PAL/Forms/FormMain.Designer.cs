namespace CSDC24_Project.PAL.Forms
{
    partial class FormMain
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonAddStudent = new System.Windows.Forms.Button();
            this.buttonAddClass = new System.Windows.Forms.Button();
            this.buttonAttendance = new System.Windows.Forms.Button();
            this.buttonDashboard = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelBack = new System.Windows.Forms.Panel();
            this.panelExpand = new System.Windows.Forms.Panel();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxExpand = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelTOP = new System.Windows.Forms.Panel();
            this.labelRole = new System.Windows.Forms.Label();
            this.labelUsername = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timerDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.userControlDashboard1 = new CSDC24_Project.PAL.User_Control.UserControlDashboard();
            this.userControlAddClass1 = new CSDC24_Project.PAL.User_Control.UserControlAddClass();
            this.userControlAddStudent1 = new CSDC24_Project.PAL.User_Control.UserControlAddStudent();
            this.userControlRegister1 = new CSDC24_Project.PAL.User_Control.UserControlRegister();
            this.userControlAttendance1 = new CSDC24_Project.PAL.User_Control.UserControlAttendance();
            this.userControlReport1 = new CSDC24_Project.PAL.User_Control.UserControlReport();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelBack.SuspendLayout();
            this.panelExpand.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTOP.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.buttonRegister);
            this.panel1.Controls.Add(this.buttonReport);
            this.panel1.Controls.Add(this.buttonAddStudent);
            this.panel1.Controls.Add(this.buttonAddClass);
            this.panel1.Controls.Add(this.buttonAttendance);
            this.panel1.Controls.Add(this.buttonDashboard);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 700);
            this.panel1.TabIndex = 0;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.ForeColor = System.Drawing.Color.Black;
            this.buttonRegister.Location = new System.Drawing.Point(8, 415);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(250, 47);
            this.buttonRegister.TabIndex = 0;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonReport.FlatAppearance.BorderSize = 0;
            this.buttonReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonReport.ForeColor = System.Drawing.Color.Black;
            this.buttonReport.Location = new System.Drawing.Point(8, 368);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(250, 47);
            this.buttonReport.TabIndex = 0;
            this.buttonReport.Text = "Report";
            this.buttonReport.UseVisualStyleBackColor = true;
            this.buttonReport.Click += new System.EventHandler(this.buttonReport_Click);
            // 
            // buttonAddStudent
            // 
            this.buttonAddStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddStudent.FlatAppearance.BorderSize = 0;
            this.buttonAddStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddStudent.ForeColor = System.Drawing.Color.Black;
            this.buttonAddStudent.Location = new System.Drawing.Point(8, 321);
            this.buttonAddStudent.Name = "buttonAddStudent";
            this.buttonAddStudent.Size = new System.Drawing.Size(250, 47);
            this.buttonAddStudent.TabIndex = 0;
            this.buttonAddStudent.Text = "Add Student";
            this.buttonAddStudent.UseVisualStyleBackColor = true;
            this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
            // 
            // buttonAddClass
            // 
            this.buttonAddClass.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAddClass.FlatAppearance.BorderSize = 0;
            this.buttonAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddClass.ForeColor = System.Drawing.Color.Black;
            this.buttonAddClass.Location = new System.Drawing.Point(8, 274);
            this.buttonAddClass.Name = "buttonAddClass";
            this.buttonAddClass.Size = new System.Drawing.Size(250, 47);
            this.buttonAddClass.TabIndex = 0;
            this.buttonAddClass.Text = "Add Class";
            this.buttonAddClass.UseVisualStyleBackColor = true;
            this.buttonAddClass.Click += new System.EventHandler(this.buttonAddClass_Click);
            // 
            // buttonAttendance
            // 
            this.buttonAttendance.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonAttendance.FlatAppearance.BorderSize = 0;
            this.buttonAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAttendance.ForeColor = System.Drawing.Color.Black;
            this.buttonAttendance.Location = new System.Drawing.Point(8, 227);
            this.buttonAttendance.Name = "buttonAttendance";
            this.buttonAttendance.Size = new System.Drawing.Size(250, 47);
            this.buttonAttendance.TabIndex = 0;
            this.buttonAttendance.Text = "Attendance";
            this.buttonAttendance.UseVisualStyleBackColor = true;
            this.buttonAttendance.Click += new System.EventHandler(this.buttonAttendance_Click);
            // 
            // buttonDashboard
            // 
            this.buttonDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDashboard.FlatAppearance.BorderSize = 0;
            this.buttonDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDashboard.ForeColor = System.Drawing.Color.Black;
            this.buttonDashboard.Location = new System.Drawing.Point(8, 180);
            this.buttonDashboard.Name = "buttonDashboard";
            this.buttonDashboard.Size = new System.Drawing.Size(250, 47);
            this.buttonDashboard.TabIndex = 0;
            this.buttonDashboard.Text = "DashBoard";
            this.buttonDashboard.UseVisualStyleBackColor = true;
            this.buttonDashboard.Click += new System.EventHandler(this.buttonDashboard_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panelSlide);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 180);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(8, 520);
            this.panel4.TabIndex = 0;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(0, 0);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(8, 47);
            this.panelSlide.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 180);
            this.panel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(36, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Attendace Management";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CSDC24_Project.Properties.Resources.reading;
            this.pictureBox1.Location = new System.Drawing.Point(81, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelBack
            // 
            this.panelBack.Controls.Add(this.panelExpand);
            this.panelBack.Controls.Add(this.pictureBoxExpand);
            this.panelBack.Controls.Add(this.pictureBox2);
            this.panelBack.Controls.Add(this.labelTime);
            this.panelBack.Controls.Add(this.panelTOP);
            this.panelBack.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBack.Location = new System.Drawing.Point(258, 0);
            this.panelBack.Name = "panelBack";
            this.panelBack.Size = new System.Drawing.Size(1023, 165);
            this.panelBack.TabIndex = 1;
            // 
            // panelExpand
            // 
            this.panelExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelExpand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(40)))), ((int)(((byte)(204)))));
            this.panelExpand.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelExpand.Controls.Add(this.buttonLogout);
            this.panelExpand.Controls.Add(this.buttonMinimize);
            this.panelExpand.Controls.Add(this.panel3);
            this.panelExpand.Location = new System.Drawing.Point(779, 53);
            this.panelExpand.Name = "panelExpand";
            this.panelExpand.Size = new System.Drawing.Size(200, 100);
            this.panelExpand.TabIndex = 3;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.White;
            this.buttonLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.buttonLogout.Location = new System.Drawing.Point(0, 54);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(198, 44);
            this.buttonLogout.TabIndex = 2;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.BackColor = System.Drawing.Color.White;
            this.buttonMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMinimize.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.buttonMinimize.Location = new System.Drawing.Point(0, 5);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(198, 43);
            this.buttonMinimize.TabIndex = 1;
            this.buttonMinimize.Text = "Minimize";
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(40)))), ((int)(((byte)(204)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(198, 5);
            this.panel3.TabIndex = 0;
            // 
            // pictureBoxExpand
            // 
            this.pictureBoxExpand.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxExpand.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxExpand.Image = global::CSDC24_Project.Properties.Resources.down_arrow;
            this.pictureBoxExpand.Location = new System.Drawing.Point(833, 34);
            this.pictureBoxExpand.Name = "pictureBoxExpand";
            this.pictureBoxExpand.Size = new System.Drawing.Size(27, 24);
            this.pictureBoxExpand.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxExpand.TabIndex = 3;
            this.pictureBoxExpand.TabStop = false;
            this.pictureBoxExpand.Click += new System.EventHandler(this.pictureBoxExpand_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::CSDC24_Project.Properties.Resources.write;
            this.pictureBox2.Location = new System.Drawing.Point(767, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(60, 58);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(3)))), ((int)(((byte)(125)))));
            this.labelTime.Location = new System.Drawing.Point(24, 23);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(20, 15);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "{?}";
            // 
            // panelTOP
            // 
            this.panelTOP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(191)))), ((int)(((byte)(255)))));
            this.panelTOP.Controls.Add(this.labelRole);
            this.panelTOP.Controls.Add(this.labelUsername);
            this.panelTOP.Controls.Add(this.label5);
            this.panelTOP.Controls.Add(this.label3);
            this.panelTOP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelTOP.Location = new System.Drawing.Point(0, 65);
            this.panelTOP.Name = "panelTOP";
            this.panelTOP.Size = new System.Drawing.Size(1023, 100);
            this.panelTOP.TabIndex = 0;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.ForeColor = System.Drawing.Color.White;
            this.labelRole.Location = new System.Drawing.Point(154, 55);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(20, 15);
            this.labelRole.TabIndex = 2;
            this.labelRole.Text = "{?}";
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.ForeColor = System.Drawing.Color.White;
            this.labelUsername.Location = new System.Drawing.Point(154, 22);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(20, 15);
            this.labelUsername.TabIndex = 2;
            this.labelUsername.Text = "{?}";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(50, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 15);
            this.label5.TabIndex = 2;
            this.label5.Text = "Role:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(50, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Welcome:";
            // 
            // timerDateAndTime
            // 
            this.timerDateAndTime.Tick += new System.EventHandler(this.timerDateAndTime_Tick);
            // 
            // userControlDashboard1
            // 
            this.userControlDashboard1.BackColor = System.Drawing.Color.White;
            this.userControlDashboard1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlDashboard1.Location = new System.Drawing.Point(258, 165);
            this.userControlDashboard1.Name = "userControlDashboard1";
            this.userControlDashboard1.Size = new System.Drawing.Size(1023, 535);
            this.userControlDashboard1.TabIndex = 0;
            // 
            // userControlAddClass1
            // 
            this.userControlAddClass1.BackColor = System.Drawing.Color.White;
            this.userControlAddClass1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAddClass1.Location = new System.Drawing.Point(258, 165);
            this.userControlAddClass1.Name = "userControlAddClass1";
            this.userControlAddClass1.Size = new System.Drawing.Size(1023, 535);
            this.userControlAddClass1.TabIndex = 0;
            this.userControlAddClass1.Visible = false;
            // 
            // userControlAddStudent1
            // 
            this.userControlAddStudent1.BackColor = System.Drawing.Color.White;
            this.userControlAddStudent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAddStudent1.Location = new System.Drawing.Point(258, 165);
            this.userControlAddStudent1.Name = "userControlAddStudent1";
            this.userControlAddStudent1.Size = new System.Drawing.Size(1023, 535);
            this.userControlAddStudent1.TabIndex = 0;
            this.userControlAddStudent1.Visible = false;
            // 
            // userControlRegister1
            // 
            this.userControlRegister1.BackColor = System.Drawing.Color.White;
            this.userControlRegister1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlRegister1.Location = new System.Drawing.Point(258, 165);
            this.userControlRegister1.Name = "userControlRegister1";
            this.userControlRegister1.Size = new System.Drawing.Size(1023, 535);
            this.userControlRegister1.TabIndex = 0;
            this.userControlRegister1.Visible = false;
            // 
            // userControlAttendance1
            // 
            this.userControlAttendance1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlAttendance1.Location = new System.Drawing.Point(258, 165);
            this.userControlAttendance1.Name = "userControlAttendance1";
            this.userControlAttendance1.Size = new System.Drawing.Size(1023, 535);
            this.userControlAttendance1.TabIndex = 2;
            this.userControlAttendance1.Visible = false;
            // 
            // userControlReport1
            // 
            this.userControlReport1.BackColor = System.Drawing.Color.White;
            this.userControlReport1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControlReport1.Location = new System.Drawing.Point(258, 165);
            this.userControlReport1.Name = "userControlReport1";
            this.userControlReport1.Size = new System.Drawing.Size(1023, 535);
            this.userControlReport1.TabIndex = 3;
            this.userControlReport1.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1281, 700);
            this.Controls.Add(this.userControlReport1);
            this.Controls.Add(this.userControlAttendance1);
            this.Controls.Add(this.userControlRegister1);
            this.Controls.Add(this.userControlAddStudent1);
            this.Controls.Add(this.userControlAddClass1);
            this.Controls.Add(this.userControlDashboard1);
            this.Controls.Add(this.panelBack);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CSDC24 Project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelBack.ResumeLayout(false);
            this.panelBack.PerformLayout();
            this.panelExpand.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxExpand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTOP.ResumeLayout(false);
            this.panelTOP.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panelBack;
        private Label labelTime;
        private Panel panelTOP;
        private Label labelRole;
        private Label labelUsername;
        private Label label5;
        private Label label3;
        private Panel panelExpand;
        private Button buttonMinimize;
        private Panel panel3;
        private PictureBox pictureBoxExpand;
        private PictureBox pictureBox2;
        private Button buttonLogout;
        private Button buttonRegister;
        private Button buttonReport;
        private Button buttonAddStudent;
        private Button buttonAddClass;
        private Button buttonAttendance;
        private Button buttonDashboard;
        private Panel panel4;
        private Panel panelSlide;
        private System.Windows.Forms.Timer timerDateAndTime;
        private User_Control.UserControlDashboard userControlDashboard1;
        private User_Control.UserControlAddClass userControlAddClass1;
        private User_Control.UserControlAddStudent userControlAddStudent1;
        private User_Control.UserControlRegister userControlRegister1;
        private User_Control.UserControlAttendance userControlAttendance1;
        private User_Control.UserControlReport userControlReport1;
    }
}