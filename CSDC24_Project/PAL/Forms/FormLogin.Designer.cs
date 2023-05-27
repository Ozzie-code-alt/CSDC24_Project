namespace CSDC24_Project.PAL.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFP = new System.Windows.Forms.Label();
            this.pictureBoxError = new System.Windows.Forms.PictureBox();
            this.labelInvalid = new System.Windows.Forms.Label();
            this.pictureBoxShow = new System.Windows.Forms.PictureBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.pictureBoxHide = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = global::CSDC24_Project.Properties.Resources.cross;
            this.pictureBoxClose.Location = new System.Drawing.Point(1157, 12);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(31, 31);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 1;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            this.pictureBoxClose.MouseHover += new System.EventHandler(this.pictureBoxClose_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::CSDC24_Project.Properties.Resources.minimize;
            this.pictureBox1.Location = new System.Drawing.Point(1120, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.labelFP);
            this.groupBox1.Controls.Add(this.pictureBoxError);
            this.groupBox1.Controls.Add(this.labelInvalid);
            this.groupBox1.Controls.Add(this.pictureBoxShow);
            this.groupBox1.Controls.Add(this.textBoxPass);
            this.groupBox1.Controls.Add(this.pictureBoxHide);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonLogin);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(107, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 348);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please Login First";
            // 
            // labelFP
            // 
            this.labelFP.AutoSize = true;
            this.labelFP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(142)))), ((int)(((byte)(252)))));
            this.labelFP.Location = new System.Drawing.Point(147, 252);
            this.labelFP.Name = "labelFP";
            this.labelFP.Size = new System.Drawing.Size(137, 21);
            this.labelFP.TabIndex = 7;
            this.labelFP.Text = "Forgot Password ?";
            this.labelFP.Click += new System.EventHandler(this.labelFP_Click);
            // 
            // pictureBoxError
            // 
            this.pictureBoxError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxError.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxError.Image")));
            this.pictureBoxError.Location = new System.Drawing.Point(92, 212);
            this.pictureBoxError.Name = "pictureBoxError";
            this.pictureBoxError.Size = new System.Drawing.Size(31, 31);
            this.pictureBoxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxError.TabIndex = 6;
            this.pictureBoxError.TabStop = false;
            this.pictureBoxError.Visible = false;
            // 
            // labelInvalid
            // 
            this.labelInvalid.AutoSize = true;
            this.labelInvalid.BackColor = System.Drawing.Color.Transparent;
            this.labelInvalid.ForeColor = System.Drawing.Color.Red;
            this.labelInvalid.Location = new System.Drawing.Point(129, 222);
            this.labelInvalid.Name = "labelInvalid";
            this.labelInvalid.Size = new System.Drawing.Size(223, 21);
            this.labelInvalid.TabIndex = 5;
            this.labelInvalid.Text = "Invalid Username or Password.";
            this.labelInvalid.Visible = false;
            // 
            // pictureBoxShow
            // 
            this.pictureBoxShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxShow.Image = global::CSDC24_Project.Properties.Resources.show;
            this.pictureBoxShow.Location = new System.Drawing.Point(366, 170);
            this.pictureBoxShow.Name = "pictureBoxShow";
            this.pictureBoxShow.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxShow.TabIndex = 4;
            this.pictureBoxShow.TabStop = false;
            this.pictureBoxShow.Click += new System.EventHandler(this.pictureBoxShow_Click);
            this.pictureBoxShow.MouseHover += new System.EventHandler(this.pictureBoxShow_MouseHover);
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(95, 166);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.Size = new System.Drawing.Size(265, 29);
            this.textBoxPass.TabIndex = 2;
            this.textBoxPass.UseSystemPasswordChar = true;
            this.textBoxPass.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxPass_KeyPress);
            this.textBoxPass.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxPass_KeyUp);
            // 
            // pictureBoxHide
            // 
            this.pictureBoxHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxHide.Image = global::CSDC24_Project.Properties.Resources.hide;
            this.pictureBoxHide.Location = new System.Drawing.Point(366, 170);
            this.pictureBoxHide.Name = "pictureBoxHide";
            this.pictureBoxHide.Size = new System.Drawing.Size(25, 25);
            this.pictureBoxHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHide.TabIndex = 3;
            this.pictureBoxHide.TabStop = false;
            this.pictureBoxHide.Click += new System.EventHandler(this.pictureBoxHide_Click);
            this.pictureBoxHide.MouseHover += new System.EventHandler(this.pictureBoxHide_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(142)))), ((int)(((byte)(252)))));
            this.label2.Location = new System.Drawing.Point(92, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(142)))), ((int)(((byte)(252)))));
            this.buttonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonLogin.Location = new System.Drawing.Point(92, 289);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(265, 38);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(95, 92);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(265, 29);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            this.textBoxName.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBoxName_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(142)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(92, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "UserName:";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Location = new System.Drawing.Point(696, 163);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 408);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::CSDC24_Project.Properties.Resources.undraw_Drink_coffee_jdqb;
            this.pictureBox2.Location = new System.Drawing.Point(710, 138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(478, 309);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(142)))), ((int)(((byte)(252)))));
            this.label3.Location = new System.Drawing.Point(787, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "CSDC 24 Project";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(142)))), ((int)(((byte)(252)))));
            this.label4.Location = new System.Drawing.Point(787, 541);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "Student Attendance System";
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBoxClose);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxClose;
        private PictureBox pictureBox1;
        private GroupBox groupBox1;
        private Label labelFP;
        private PictureBox pictureBoxError;
        private Label labelInvalid;
        private PictureBox pictureBoxShow;
        private TextBox textBoxPass;
        private PictureBox pictureBoxHide;
        private Label label2;
        private Button buttonLogin;
        private TextBox textBoxName;
        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
        private ToolTip toolTip;
    }
}