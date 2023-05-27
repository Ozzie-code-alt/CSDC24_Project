namespace CSDC24_Project.PAL.Forms
{
    partial class FormForgotPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormForgotPass));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxError = new System.Windows.Forms.PictureBox();
            this.buttonVerify = new System.Windows.Forms.Button();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBoxError);
            this.panel1.Controls.Add(this.buttonVerify);
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBoxClose);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(569, 482);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Location = new System.Drawing.Point(138, 355);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 2);
            this.panel2.TabIndex = 12;
            // 
            // pictureBoxError
            // 
            this.pictureBoxError.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxError.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxError.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxError.Image")));
            this.pictureBoxError.Location = new System.Drawing.Point(409, 332);
            this.pictureBoxError.Name = "pictureBoxError";
            this.pictureBoxError.Size = new System.Drawing.Size(19, 17);
            this.pictureBoxError.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxError.TabIndex = 11;
            this.pictureBoxError.TabStop = false;
            this.pictureBoxError.Visible = false;
            this.pictureBoxError.MouseHover += new System.EventHandler(this.pictureBoxError_MouseHover);
            // 
            // buttonVerify
            // 
            this.buttonVerify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(142)))), ((int)(((byte)(252)))));
            this.buttonVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonVerify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVerify.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonVerify.Location = new System.Drawing.Point(138, 400);
            this.buttonVerify.Name = "buttonVerify";
            this.buttonVerify.Size = new System.Drawing.Size(265, 38);
            this.buttonVerify.TabIndex = 2;
            this.buttonVerify.Text = "Verify";
            this.buttonVerify.UseVisualStyleBackColor = false;
            this.buttonVerify.Click += new System.EventHandler(this.buttonVerify_Click);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(138, 326);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(265, 23);
            this.textBoxEmail.TabIndex = 1;
            this.textBoxEmail.Text = "Enter Email Here";
            this.textBoxEmail.Enter += new System.EventHandler(this.textBoxEmail_Enter);
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(142)))), ((int)(((byte)(252)))));
            this.label1.Location = new System.Drawing.Point(93, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "Email:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::CSDC24_Project.Properties.Resources.undraw_Forgot_password_re_hxwm;
            this.pictureBox1.Location = new System.Drawing.Point(18, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 250);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxClose.Image = global::CSDC24_Project.Properties.Resources.cross;
            this.pictureBoxClose.Location = new System.Drawing.Point(526, 12);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(31, 31);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxClose.TabIndex = 2;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.pictureBoxClose_Click);
            this.pictureBoxClose.MouseHover += new System.EventHandler(this.pictureBoxClose_MouseHover);
            // 
            // FormForgotPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 506);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormForgotPass";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormForgotPass_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxError)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Panel panel2;
        private PictureBox pictureBoxError;
        private Button buttonVerify;
        private TextBox textBoxEmail;
        private Label label1;
        private PictureBox pictureBoxClose;
        private ToolTip toolTip1;
    }
}