namespace CSDC24_Project.PAL.User_Control
{
    partial class UserControlReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControlReport = new System.Windows.Forms.TabControl();
            this.tabPageClassReport = new System.Windows.Forms.TabPage();
            this.pictureBoxPrint = new System.Windows.Forms.PictureBox();
            this.dataGridViewClassReport = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageStudentReport = new System.Windows.Forms.TabPage();
            this.pictureBoxPrint1 = new System.Windows.Forms.PictureBox();
            this.dataGridViewStudentReport = new System.Windows.Forms.DataGridView();
            this.comboBoxRegNo = new System.Windows.Forms.ComboBox();
            this.comboBoxClass1 = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDate1 = new System.Windows.Forms.DateTimePicker();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.easyhtmlReports = new KimToo.EasyHTMLReports(this.components);
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControlReport.SuspendLayout();
            this.tabPageClassReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassReport)).BeginInit();
            this.tabPageStudentReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrint1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentReport)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlReport
            // 
            this.tabControlReport.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControlReport.Controls.Add(this.tabPageClassReport);
            this.tabControlReport.Controls.Add(this.tabPageStudentReport);
            this.tabControlReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlReport.Location = new System.Drawing.Point(0, 0);
            this.tabControlReport.Name = "tabControlReport";
            this.tabControlReport.SelectedIndex = 0;
            this.tabControlReport.Size = new System.Drawing.Size(942, 501);
            this.tabControlReport.TabIndex = 1;
            // 
            // tabPageClassReport
            // 
            this.tabPageClassReport.Controls.Add(this.pictureBoxPrint);
            this.tabPageClassReport.Controls.Add(this.dataGridViewClassReport);
            this.tabPageClassReport.Controls.Add(this.comboBoxClass);
            this.tabPageClassReport.Controls.Add(this.dateTimePickerDate);
            this.tabPageClassReport.Controls.Add(this.panel2);
            this.tabPageClassReport.Controls.Add(this.panel1);
            this.tabPageClassReport.Controls.Add(this.label3);
            this.tabPageClassReport.Controls.Add(this.label2);
            this.tabPageClassReport.Controls.Add(this.label1);
            this.tabPageClassReport.Location = new System.Drawing.Point(4, 4);
            this.tabPageClassReport.Name = "tabPageClassReport";
            this.tabPageClassReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClassReport.Size = new System.Drawing.Size(934, 473);
            this.tabPageClassReport.TabIndex = 0;
            this.tabPageClassReport.Text = "Class Report";
            this.tabPageClassReport.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPrint
            // 
            this.pictureBoxPrint.Image = global::CSDC24_Project.Properties.Resources.printer;
            this.pictureBoxPrint.Location = new System.Drawing.Point(856, 15);
            this.pictureBoxPrint.Name = "pictureBoxPrint";
            this.pictureBoxPrint.Size = new System.Drawing.Size(58, 50);
            this.pictureBoxPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPrint.TabIndex = 8;
            this.pictureBoxPrint.TabStop = false;
            this.pictureBoxPrint.Click += new System.EventHandler(this.pictureBoxPrint_Click);
            // 
            // dataGridViewClassReport
            // 
            this.dataGridViewClassReport.AllowUserToAddRows = false;
            this.dataGridViewClassReport.AllowUserToDeleteRows = false;
            this.dataGridViewClassReport.AllowUserToResizeColumns = false;
            this.dataGridViewClassReport.AllowUserToResizeRows = false;
            this.dataGridViewClassReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClassReport.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewClassReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewClassReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewClassReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClassReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewClassReport.Location = new System.Drawing.Point(3, 125);
            this.dataGridViewClassReport.Name = "dataGridViewClassReport";
            this.dataGridViewClassReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewClassReport.RowTemplate.Height = 25;
            this.dataGridViewClassReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewClassReport.ShowCellErrors = false;
            this.dataGridViewClassReport.ShowEditingIcon = false;
            this.dataGridViewClassReport.ShowRowErrors = false;
            this.dataGridViewClassReport.Size = new System.Drawing.Size(925, 342);
            this.dataGridViewClassReport.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Student_Name";
            this.Column1.HeaderText = "Student Name";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Student_Reg";
            this.Column2.HeaderText = "Reg No.";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Class_Name";
            this.Column3.HeaderText = "Class";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Attendance_Date";
            this.Column4.HeaderText = "Date";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Attendance_Status";
            this.Column5.HeaderText = "Status";
            this.Column5.Name = "Column5";
            // 
            // comboBoxClass
            // 
            this.comboBoxClass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClass.FormattingEnabled = true;
            this.comboBoxClass.Location = new System.Drawing.Point(592, 54);
            this.comboBoxClass.Name = "comboBoxClass";
            this.comboBoxClass.Size = new System.Drawing.Size(230, 23);
            this.comboBoxClass.TabIndex = 6;
            this.comboBoxClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass_SelectedIndexChanged);
            this.comboBoxClass.Click += new System.EventHandler(this.comboBoxClass_Click);
            // 
            // dateTimePickerDate
            // 
            this.dateTimePickerDate.CustomFormat = "yyyy/MM/dd";
            this.dateTimePickerDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate.Location = new System.Drawing.Point(125, 54);
            this.dateTimePickerDate.Name = "dateTimePickerDate";
            this.dateTimePickerDate.Size = new System.Drawing.Size(233, 23);
            this.dateTimePickerDate.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(552, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(270, 2);
            this.panel2.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Location = new System.Drawing.Point(88, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(270, 2);
            this.panel1.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(31)))), ((int)(((byte)(125)))));
            this.label3.Location = new System.Drawing.Point(555, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(31)))), ((int)(((byte)(125)))));
            this.label2.Location = new System.Drawing.Point(91, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(31)))), ((int)(((byte)(125)))));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Class Report";
            // 
            // tabPageStudentReport
            // 
            this.tabPageStudentReport.Controls.Add(this.pictureBoxPrint1);
            this.tabPageStudentReport.Controls.Add(this.dataGridViewStudentReport);
            this.tabPageStudentReport.Controls.Add(this.comboBoxRegNo);
            this.tabPageStudentReport.Controls.Add(this.comboBoxClass1);
            this.tabPageStudentReport.Controls.Add(this.dateTimePickerDate1);
            this.tabPageStudentReport.Controls.Add(this.panel5);
            this.tabPageStudentReport.Controls.Add(this.panel3);
            this.tabPageStudentReport.Controls.Add(this.label7);
            this.tabPageStudentReport.Controls.Add(this.panel4);
            this.tabPageStudentReport.Controls.Add(this.label4);
            this.tabPageStudentReport.Controls.Add(this.label5);
            this.tabPageStudentReport.Controls.Add(this.label6);
            this.tabPageStudentReport.Location = new System.Drawing.Point(4, 4);
            this.tabPageStudentReport.Name = "tabPageStudentReport";
            this.tabPageStudentReport.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageStudentReport.Size = new System.Drawing.Size(934, 473);
            this.tabPageStudentReport.TabIndex = 1;
            this.tabPageStudentReport.Text = "Student Report";
            this.tabPageStudentReport.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPrint1
            // 
            this.pictureBoxPrint1.Image = global::CSDC24_Project.Properties.Resources.printer;
            this.pictureBoxPrint1.Location = new System.Drawing.Point(11, 54);
            this.pictureBoxPrint1.Name = "pictureBoxPrint1";
            this.pictureBoxPrint1.Size = new System.Drawing.Size(58, 50);
            this.pictureBoxPrint1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPrint1.TabIndex = 16;
            this.pictureBoxPrint1.TabStop = false;
            this.pictureBoxPrint1.Click += new System.EventHandler(this.pictureBoxPrint1_Click);
            // 
            // dataGridViewStudentReport
            // 
            this.dataGridViewStudentReport.AllowUserToAddRows = false;
            this.dataGridViewStudentReport.AllowUserToDeleteRows = false;
            this.dataGridViewStudentReport.AllowUserToResizeColumns = false;
            this.dataGridViewStudentReport.AllowUserToResizeRows = false;
            this.dataGridViewStudentReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewStudentReport.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStudentReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewStudentReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewStudentReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudentReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10});
            this.dataGridViewStudentReport.Location = new System.Drawing.Point(5, 125);
            this.dataGridViewStudentReport.Name = "dataGridViewStudentReport";
            this.dataGridViewStudentReport.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewStudentReport.RowTemplate.Height = 25;
            this.dataGridViewStudentReport.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewStudentReport.ShowCellErrors = false;
            this.dataGridViewStudentReport.ShowEditingIcon = false;
            this.dataGridViewStudentReport.ShowRowErrors = false;
            this.dataGridViewStudentReport.Size = new System.Drawing.Size(925, 342);
            this.dataGridViewStudentReport.TabIndex = 15;
            // 
            // comboBoxRegNo
            // 
            this.comboBoxRegNo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxRegNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxRegNo.FormattingEnabled = true;
            this.comboBoxRegNo.Location = new System.Drawing.Point(682, 54);
            this.comboBoxRegNo.Name = "comboBoxRegNo";
            this.comboBoxRegNo.Size = new System.Drawing.Size(230, 23);
            this.comboBoxRegNo.TabIndex = 14;
            this.comboBoxRegNo.SelectedIndexChanged += new System.EventHandler(this.comboBoxRegNo_SelectedIndexChanged);
            this.comboBoxRegNo.Click += new System.EventHandler(this.comboBoxRegNo_Click);
            // 
            // comboBoxClass1
            // 
            this.comboBoxClass1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClass1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxClass1.FormattingEnabled = true;
            this.comboBoxClass1.Location = new System.Drawing.Point(406, 54);
            this.comboBoxClass1.Name = "comboBoxClass1";
            this.comboBoxClass1.Size = new System.Drawing.Size(230, 23);
            this.comboBoxClass1.TabIndex = 14;
            this.comboBoxClass1.SelectedIndexChanged += new System.EventHandler(this.comboBoxClass1_SelectedIndexChanged);
            this.comboBoxClass1.Click += new System.EventHandler(this.comboBoxClass1_Click);
            // 
            // dateTimePickerDate1
            // 
            this.dateTimePickerDate1.CustomFormat = "yyyy/MM";
            this.dateTimePickerDate1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDate1.Location = new System.Drawing.Point(127, 54);
            this.dateTimePickerDate1.Name = "dateTimePickerDate1";
            this.dateTimePickerDate1.Size = new System.Drawing.Size(233, 23);
            this.dateTimePickerDate1.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.LightGray;
            this.panel5.Location = new System.Drawing.Point(642, 83);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(270, 2);
            this.panel5.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Location = new System.Drawing.Point(366, 83);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(270, 2);
            this.panel3.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(31)))), ((int)(((byte)(125)))));
            this.label7.Location = new System.Drawing.Point(682, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Reg No.";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Location = new System.Drawing.Point(90, 83);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(270, 2);
            this.panel4.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(31)))), ((int)(((byte)(125)))));
            this.label4.Location = new System.Drawing.Point(406, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(31)))), ((int)(((byte)(125)))));
            this.label5.Location = new System.Drawing.Point(127, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(31)))), ((int)(((byte)(125)))));
            this.label6.Location = new System.Drawing.Point(11, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 15);
            this.label6.TabIndex = 8;
            this.label6.Text = "Student Report";
            // 
            // easyhtmlReports
            // 
            this.easyhtmlReports.AlternativeRowBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(229)))), ((int)(((byte)(229)))));
            this.easyhtmlReports.AlternativeRowGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            this.easyhtmlReports.HeaderBackgroundColor = System.Drawing.Color.DodgerBlue;
            this.easyhtmlReports.HeaderFontColor = System.Drawing.Color.White;
            this.easyhtmlReports.HeaderGridColor = System.Drawing.Color.DodgerBlue;
            this.easyhtmlReports.RowDefaultBackgroudColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.easyhtmlReports.RowDefaultFontColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(46)))));
            this.easyhtmlReports.RowDefaultGridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(61)))), ((int)(((byte)(65)))));
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Student_Name";
            this.Column6.HeaderText = "Student Name";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Student_Reg";
            this.Column7.HeaderText = "Reg No.";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Class_Name";
            this.Column8.HeaderText = "Class";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Attendance_Date";
            this.Column9.HeaderText = "Date";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Attendance_Status";
            this.Column10.HeaderText = "Status";
            this.Column10.Name = "Column10";
            // 
            // UserControlReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabControlReport);
            this.Name = "UserControlReport";
            this.Size = new System.Drawing.Size(942, 501);
            this.tabControlReport.ResumeLayout(false);
            this.tabPageClassReport.ResumeLayout(false);
            this.tabPageClassReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClassReport)).EndInit();
            this.tabPageStudentReport.ResumeLayout(false);
            this.tabPageStudentReport.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPrint1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudentReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlReport;
        private TabPage tabPageClassReport;
        private PictureBox pictureBoxPrint;
        private DataGridView dataGridViewClassReport;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private ComboBox comboBoxClass;
        private DateTimePicker dateTimePickerDate;
        private Panel panel2;
        private Panel panel1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPageStudentReport;
        private PictureBox pictureBoxPrint1;
        private DataGridView dataGridViewStudentReport;
        private ComboBox comboBoxRegNo;
        private ComboBox comboBoxClass1;
        private DateTimePicker dateTimePickerDate1;
        private Panel panel5;
        private Panel panel3;
        private Label label7;
        private Panel panel4;
        private Label label4;
        private Label label5;
        private Label label6;
        private KimToo.EasyHTMLReports easyhtmlReports;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewTextBoxColumn Column10;
    }
}
