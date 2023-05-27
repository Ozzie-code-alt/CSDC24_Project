namespace CSDC24_Project.PAL.User_Control
{
    partial class UserControlAttendance
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMarkAttendance = new System.Windows.Forms.TabPage();
            this.dataGridViewMrkAttendance = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comboBoxClass = new System.Windows.Forms.ComboBox();
            this.dateTimePickerDate = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPageMarkAttendance.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMrkAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl1.Controls.Add(this.tabPageMarkAttendance);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(942, 501);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageMarkAttendance
            // 
            this.tabPageMarkAttendance.Controls.Add(this.dataGridViewMrkAttendance);
            this.tabPageMarkAttendance.Controls.Add(this.comboBoxClass);
            this.tabPageMarkAttendance.Controls.Add(this.dateTimePickerDate);
            this.tabPageMarkAttendance.Controls.Add(this.panel2);
            this.tabPageMarkAttendance.Controls.Add(this.panel1);
            this.tabPageMarkAttendance.Controls.Add(this.label3);
            this.tabPageMarkAttendance.Controls.Add(this.label2);
            this.tabPageMarkAttendance.Controls.Add(this.label1);
            this.tabPageMarkAttendance.Location = new System.Drawing.Point(4, 4);
            this.tabPageMarkAttendance.Name = "tabPageMarkAttendance";
            this.tabPageMarkAttendance.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMarkAttendance.Size = new System.Drawing.Size(934, 473);
            this.tabPageMarkAttendance.TabIndex = 0;
            this.tabPageMarkAttendance.Text = "Mark Attendance";
            this.tabPageMarkAttendance.UseVisualStyleBackColor = true;
            this.tabPageMarkAttendance.Leave += new System.EventHandler(this.tabPageMarkAttendance_Leave);
            // 
            // dataGridViewMrkAttendance
            // 
            this.dataGridViewMrkAttendance.AllowUserToAddRows = false;
            this.dataGridViewMrkAttendance.AllowUserToDeleteRows = false;
            this.dataGridViewMrkAttendance.AllowUserToResizeColumns = false;
            this.dataGridViewMrkAttendance.AllowUserToResizeRows = false;
            this.dataGridViewMrkAttendance.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMrkAttendance.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewMrkAttendance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMrkAttendance.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewMrkAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMrkAttendance.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewMrkAttendance.Location = new System.Drawing.Point(3, 125);
            this.dataGridViewMrkAttendance.Name = "dataGridViewMrkAttendance";
            this.dataGridViewMrkAttendance.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMrkAttendance.RowTemplate.Height = 25;
            this.dataGridViewMrkAttendance.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewMrkAttendance.ShowCellErrors = false;
            this.dataGridViewMrkAttendance.ShowEditingIcon = false;
            this.dataGridViewMrkAttendance.ShowRowErrors = false;
            this.dataGridViewMrkAttendance.Size = new System.Drawing.Size(925, 342);
            this.dataGridViewMrkAttendance.TabIndex = 7;
            this.dataGridViewMrkAttendance.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridViewMrkAttendance_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Student_ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Student_Name";
            this.Column2.HeaderText = "Student Name";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Student_Reg";
            this.Column3.HeaderText = "Reg No";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Attendance_Status";
            this.Column4.HeaderText = "Status";
            this.Column4.Name = "Column4";
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            this.label3.Location = new System.Drawing.Point(552, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(31)))), ((int)(((byte)(125)))));
            this.label2.Location = new System.Drawing.Point(88, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(31)))), ((int)(((byte)(125)))));
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Attendance";
            // 
            // UserControlAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "UserControlAttendance";
            this.Size = new System.Drawing.Size(942, 501);
            this.tabControl1.ResumeLayout(false);
            this.tabPageMarkAttendance.ResumeLayout(false);
            this.tabPageMarkAttendance.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMrkAttendance)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPageMarkAttendance;
        private Label label2;
        private Label label1;
        private ComboBox comboBoxClass;
        private DateTimePicker dateTimePickerDate;
        private Panel panel2;
        private Panel panel1;
        private Label label3;
        private DataGridView dataGridViewMrkAttendance;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewCheckBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}
