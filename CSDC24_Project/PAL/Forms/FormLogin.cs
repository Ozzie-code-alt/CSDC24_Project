using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CSDC24_Project.PAL.Forms
{
    public partial class FormLogin : Form
    {

        private string sql = @"Data Source = .\SQLEXPRESS; Initial Catalog = Attendance_Management_System; Integrated Security = True;";
        public FormLogin()
        {
            InitializeComponent();
        }

        private void pictureBoxClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pictureBoxShow_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxShow, "Show Password");
        }

        private void pictureBoxHide_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxHide, "Hide Password");
        }

        private void pictureBoxShow_Click(object sender, EventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = false;
            pictureBoxShow.Hide();
            pictureBoxHide.Show();
        }

        private void pictureBoxHide_Click(object sender, EventArgs e)
        {
            textBoxPass.UseSystemPasswordChar = true;
            pictureBoxShow.Show();
            pictureBoxHide.Hide();

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            pictureBoxHide.Hide();
            pictureBoxError.Hide();
            labelInvalid.Hide();
        }

        private void pictureBoxClose_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBoxClose, "Close Window");

        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            toolTip.SetToolTip(pictureBox1, "Minimize Window");
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string Check = Attendance.Attendance.IsValidNamePass(textBoxName.Text, textBoxPass.Text, sql);

            if (textBoxName.Text.Trim() != string.Empty && textBoxPass.Text.Trim() != string.Empty)
            {
                if (Check != "")
                {
                    FormMain formain = new FormMain();
                    formain.Username = textBoxName.Text;
                    formain.Role = Check;
                    textBoxName.Clear();
                    textBoxPass.Clear();
                    pictureBoxHide_Click(sender, e);
                    textBoxName.Focus();
                    pictureBoxError.Hide();
                    labelInvalid.Hide();
                           
                    formain.ShowDialog();
                    this.Hide();
                }
                else
                {
                    pictureBoxError.Show();
                    labelInvalid.Show();

                }

            }

        }

        private void textBoxName_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress= true;

            }

        }

        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SelectNextControl(ActiveControl, true, true, true, true);
                e.Handled = true;
            }


        }

        private void textBoxPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;

            }
        }

        private void textBoxPass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
               buttonLogin.PerformClick();
                e.Handled = true;
            }

        }

        private void labelFP_Click(object sender, EventArgs e)
        {
            FormForgotPass formForgotPass = new FormForgotPass();
            formForgotPass.Show();

        }
    }
}
