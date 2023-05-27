using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDC24_Project.PAL.User_Control
{
    public partial class UserControlRegister : UserControl
    {

        private string sql = @"Data Source = .\SQLEXPRESS; Initial Catalog = Attendance_Management_System; Integrated Security = True;";

        public string UID;
        private string Gender = "", Role, ID = "";



        public UserControlRegister()
        {
            InitializeComponent();
        }

        public void HideErrorPic()
        {
            pictureBoxErrorPho.Visible = false;
            pictureBoxErrorCNIC.Visible = false;
            pictureBoxErrorDOB.Visible = false;
            pictureBoxErrorEmail.Visible = false;
        }

        private void HideErrorPic1()
        {
            pictureBoxErrorPho1.Visible = false;
            pictureBoxErrorCNIC1.Visible = false;
            pictureBoxErrorDOB1.Visible = false;
            pictureBoxErrorEmail1.Visible = false;
        }



        public void ClearTextBox()
        {
            textBoxName.Clear();
            textBoxPass.Clear();
            maskedTextBoxPho.Text = "+00 000 0000000";
            maskedTextBoxPho.ForeColor = Color.DarkGray;
            maskedTextBoxCNIC.Text = "00000-0000000-0";
            maskedTextBoxCNIC.ForeColor = Color.DarkGray;
            maskedTextBoxDOB.Text = "00/00/0000";
            maskedTextBoxDOB.ForeColor = Color.DarkGray;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            textBoxEmail.Text = "justin.santos-18@cpu.edu.ph";
            textBoxEmail.ForeColor = Color.DarkGray;
            checkBoxRole.Checked = false;
            textBoxAdd.Clear();
            tabControlRegister.SelectedTab = tabPageAddUser;
            
        }

        private void ClearTextBox1()
        {
            textBoxName1.Clear();
            textBoxPass1.Clear();
            maskedTextBoxPho1.Text = "+00 000 0000000";
            maskedTextBoxPho1.ForeColor = Color.DarkGray;
            maskedTextBoxCNIC1.Text = "00000-0000000-0";
            maskedTextBoxCNIC1.ForeColor = Color.DarkGray;
            maskedTextBoxDOB1.Text = "00/00/0000";
            maskedTextBoxDOB1.ForeColor = Color.DarkGray;
            radioButtonMale1.Checked = false;
            radioButtonFemale1.Checked = false;
            textBoxEmail1.Text = "justin.santos-18@cpu.edu.ph";
            textBoxEmail1.ForeColor = Color.DarkGray;
            checkBoxRole1.Checked = false;
            textBoxAdd1.Clear();
            ID = "";

        }

        private void Mask(MaskedTextBox txtBox)
        {
            BeginInvoke((MethodInvoker)delegate () { txtBox.Select(0, 0); });

        }

        private void textBoxEmail_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "justin.santos-18@cpu.edu.ph")
            {
                textBoxEmail.Text = "";
                textBoxEmail.ForeColor = Color.Black;
            }

        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail.Text == "")
            {
                textBoxEmail.Text = "justin.santos-18@cpu.edu.ph";
                textBoxEmail.ForeColor = Color.DarkGray;
            }
            if (!isValidEmail(textBoxEmail.Text) || textBoxEmail.Text == "justin.santos-18@cpu.edu.ph")
            {
                pictureBoxErrorEmail.Visible = true;
                
            }else
            {
                pictureBoxErrorEmail.Visible = false;
            }


        }

        private void maskedTextBoxPho_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxPho.Text == "+00 000 0000000")
            {
                maskedTextBoxPho.Text = "";
            }
            if (!maskedTextBoxPho.MaskCompleted)
            {
                maskedTextBoxPho.ForeColor = Color.Black;
                Mask(maskedTextBoxPho);
            }


        }

        private void maskedTextBoxPho_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxPho.Text == "+")
            {
                maskedTextBoxPho.Text = "00 000 0000000";
                maskedTextBoxPho.ForeColor = Color.DarkGray;
            }

            if (!maskedTextBoxPho.MaskCompleted)
            {
                maskedTextBoxPho.ForeColor = Color.DarkGray;
            }
            if (!maskedTextBoxPho.MaskCompleted || maskedTextBoxPho.Text == "+00 000 000000")
            {
                pictureBoxErrorPho.Visible = true;
            }
            else
            {
                pictureBoxErrorPho.Visible= false;
            }




        }

        private void maskedTextBoxCNIC_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxCNIC.Text == "00000-0000000-0")
            {
                maskedTextBoxCNIC.Text = "";
            }
            if (!maskedTextBoxCNIC.MaskCompleted)
            {
                maskedTextBoxCNIC.ForeColor = Color.Black;
                Mask(maskedTextBoxCNIC);
            }

        }

        private void maskedTextBoxCNIC_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxCNIC.Text.Trim() == "-      -")
            {
                maskedTextBoxCNIC.Text = "00000-000000-0";
                maskedTextBoxCNIC.ForeColor = Color.DarkGray;
            }

            if (!maskedTextBoxCNIC.MaskCompleted)
            {
                maskedTextBoxCNIC.ForeColor = Color.DarkGray;
            }
            if (maskedTextBoxCNIC.Text == "00000-0000000-0" || !maskedTextBoxCNIC.MaskCompleted)
            {
                pictureBoxErrorCNIC.Visible = true;
            }
            else
            {
                pictureBoxErrorCNIC.Visible= false;
            }


        }

        private void maskedTextBoxDOB_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxDOB.Text == "00/00/0000")
            {
                maskedTextBoxDOB.Text = "";
            }
            if (!maskedTextBoxDOB.MaskCompleted)
            {
                maskedTextBoxDOB.ForeColor = Color.Black;
                Mask(maskedTextBoxDOB);

            }


        }

        private void maskedTextBoxDOB_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxDOB.Text.Trim() == "/  /")
            {
                maskedTextBoxDOB.Text = "00/00/0000";
                maskedTextBoxDOB.ForeColor = Color.DarkGray;
            }
            if (!maskedTextBoxDOB.MaskCompleted)
            {
                maskedTextBoxDOB.ForeColor = Color.DarkGray;
            }
            if (!isValidDate(maskedTextBoxDOB.Text) || maskedTextBoxDOB.Text == "00/00/0000" || DateTime.Parse(maskedTextBoxDOB.Text) > DateTime.Now)
            {

                pictureBoxErrorDOB.Visible = true;
            }
            else
            {
                pictureBoxErrorDOB.Visible= false;
            }





        }

        private void maskedTextBoxDOB_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(maskedTextBoxDOB, "MM/DD/YYYY");
        }

        private void pictureBoxErrorEmail_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxErrorEmail, "Invalid Email");
        }

        private void pictureBoxErrorPho_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxErrorPho, "Invalid Phone Number");
        }

        private void pictureBoxErrorCNIC_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxErrorCNIC, "Invalid CNIC");
        }


        //####################################################
        private void maskedTextBoxPho1_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxPho1.Text == "+00 000 0000000")
            {
                maskedTextBoxPho1.Text = "";
            }
            if (!maskedTextBoxPho1.MaskCompleted)
            {
                maskedTextBoxPho1.ForeColor = Color.Black;
                Mask(maskedTextBoxPho1);
            }
        }

        private void maskedTextBoxPho1_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxPho1.Text == "+")
            {
                maskedTextBoxPho1.Text = "00 000 0000000";
                maskedTextBoxPho1.ForeColor = Color.DarkGray;
            }

            if (!maskedTextBoxPho1.MaskCompleted)
            {
                maskedTextBoxPho1.ForeColor = Color.DarkGray;
            }
            if (!maskedTextBoxPho1.MaskCompleted || maskedTextBoxPho1.Text == "+00 000 0000000")
            {
                pictureBoxErrorPho1.Visible = true;
            }
            else
            {
                pictureBoxErrorPho1.Visible = false;
            }

        }

        private void pictureBoxErrorPho1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxErrorPho1, "Invalid Phone Number");
        }

        private void maskedTextBoxCNIC1_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxCNIC1.Text == "00000-0000000-0")
            {
                maskedTextBoxCNIC1.Text = "";
            }
            if (!maskedTextBoxCNIC1.MaskCompleted)
            {
                maskedTextBoxCNIC1.ForeColor = Color.Black;
                Mask(maskedTextBoxCNIC1);
            }
        }

        private void maskedTextBoxCNIC1_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxCNIC1.Text.Trim() == "-      -")
            {
                maskedTextBoxCNIC1.Text = "00000-000000-0";
                maskedTextBoxCNIC1.ForeColor = Color.DarkGray;
            }

            if (!maskedTextBoxCNIC1.MaskCompleted)
            {
                maskedTextBoxCNIC1.ForeColor = Color.DarkGray;
            }
            if (maskedTextBoxCNIC1.Text == "00000-0000000-0" || !maskedTextBoxCNIC1.MaskCompleted)
            {
                pictureBoxErrorCNIC1.Visible = true;
            }
            else
            {
                pictureBoxErrorCNIC1.Visible = false;
            }

        }

        private void pictureBoxErrorCNIC1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxErrorCNIC1, "Invalid CNIC");
        }

        private void maskedTextBoxDOB1_Enter(object sender, EventArgs e)
        {
            if (maskedTextBoxDOB1.Text == "00/00/0000")
            {
                maskedTextBoxDOB1.Text = "";
            }
            if (!maskedTextBoxDOB1.MaskCompleted)
            {
                maskedTextBoxDOB1.ForeColor = Color.Black;
                Mask(maskedTextBoxDOB1);

            }
        }

        private void maskedTextBoxDOB1_Leave(object sender, EventArgs e)
        {
            if (maskedTextBoxDOB1.Text.Trim() == "/  /")
            {
                maskedTextBoxDOB1.Text = "00/00/0000";
                maskedTextBoxDOB1.ForeColor = Color.DarkGray;
            }
            if (!maskedTextBoxDOB1.MaskCompleted)
            {
                maskedTextBoxDOB1.ForeColor = Color.DarkGray;
            }
            if (!isValidDate(maskedTextBoxDOB1.Text) || maskedTextBoxDOB1.Text == "00/00/0000" || DateTime.Parse(maskedTextBoxDOB1.Text) > DateTime.Now)
            {

                pictureBoxErrorDOB1.Visible = true;
            }
            else
            {
                pictureBoxErrorDOB1.Visible = false;
            }

        }

        private void pictureBoxErrorDOB1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxErrorDOB1, "Invalid Date of Birth Fomat");

        }

        private void textBoxEmail1_Enter(object sender, EventArgs e)
        {
            if (textBoxEmail1.Text == "justin.santos-18@cpu.edu.ph")
            {
                textBoxEmail1.Text = "";
                textBoxEmail1.ForeColor = Color.Black;
            }
        }

        private void textBoxEmail1_Leave(object sender, EventArgs e)
        {
            if (textBoxEmail1.Text == "")
            {
                textBoxEmail1.Text = "justin.santos-18@cpu.edu.ph";
                textBoxEmail1.ForeColor = Color.DarkGray;
            }
            if (!isValidEmail(textBoxEmail1.Text) || textBoxEmail1.Text == "justin.santos-18@cpu.edu.ph")
            {
                pictureBoxErrorEmail1.Visible = true;

            }
            else
            {
                pictureBoxErrorEmail1.Visible = false;
            }

        }

        private void pictureBoxErrorEmail1_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxErrorEmail1, "Invalid Email");
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxSearchBy.SelectedIndex == 0)
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM User_Table WHERE User_Name LIKE '%" + textBoxSearch.Text + "%'", dataGridViewUser1, sql);
            }
            if (comboBoxSearchBy.SelectedIndex == 1)
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM User_Table WHERE User_Pho LIKE '%" + textBoxSearch.Text + "%'", dataGridViewUser1, sql);
            }
            if (comboBoxSearchBy.SelectedIndex == 2)
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM User_Table WHERE User_CNIC LIKE '%" + textBoxSearch.Text + "%'", dataGridViewUser1, sql);
            }



        }

        private void tabPageSearchUser_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            comboBoxSearchBy.SelectedIndex = -1;
            Attendance.Attendance.DisplayAndSearchAllData("SELECT * FROM User_Table;", dataGridViewUser1, sql);
      
            dataGridViewUser1.Columns[0].Visible = false;
            labelCountUser.Text = dataGridViewUser1.Rows.Count.ToString();
            
        }

        private void tabPageAddUser_Leave(object sender, EventArgs e)
        {
            HideErrorPic();
            HideErrorPic1();
            ClearTextBox();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (radioButtonMale.Checked)
            {
                Gender = "Male";
            }
            else
            {
                Gender = "Female";
            }

            if (checkBoxRole.Checked)
            {
                Role = "Admin";
            }
            else
            {
                Role = "User";
            }
            if (textBoxName.Text.Trim() == string.Empty
                || textBoxPass.Text.Trim() == string.Empty
                || !maskedTextBoxPho.MaskCompleted
                || maskedTextBoxPho.Text == "+00 000 0000000"
                || !maskedTextBoxCNIC.MaskCompleted
                || maskedTextBoxCNIC.Text == "00000-0000000-0"
                || !isValidDate(maskedTextBoxDOB.Text)
                || maskedTextBoxDOB.Text == "00/00/0000" || DateTime.Parse(maskedTextBoxDOB.Text) > DateTime.Now
                || Gender == string.Empty
                || !isValidEmail(textBoxEmail.Text)
                || textBoxEmail.Text == "justin.santos-18@cpu.edu.ph"
                )
            {

                MessageBox.Show("Empty / Invalid Fields", "required all Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
}
            else
            {
                bool check = Attendance.Attendance.AddRole(textBoxName.Text.Trim(), textBoxPass.Text.Trim(), maskedTextBoxPho.Text, maskedTextBoxCNIC.Text, maskedTextBoxDOB.Text, Gender, textBoxEmail.Text.Trim(),
                    Role, textBoxAdd.Text.Trim(), sql
                    );
                if (check)
                {
                    ClearTextBox();
                }


            }






;


        }

        private void tabPageAddUser_Enter(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void tabPageUPUser_Leave(object sender, EventArgs e)
        {
            HideErrorPic1();
            ClearTextBox1();
          
        }

        private void dataGridViewUser_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewUser1.Rows[e.RowIndex];
                ID = row.Cells[0].Value.ToString();
                textBoxName1.Text = row.Cells[1].Value.ToString();
                textBoxPass1.Text = row.Cells[2].Value.ToString();
                maskedTextBoxPho1.Text = row.Cells[3].Value.ToString();
                maskedTextBoxPho1.ForeColor = Color.Black;
                maskedTextBoxCNIC1.Text = row.Cells[4].Value.ToString();
                maskedTextBoxCNIC1.ForeColor = Color.Black;
                maskedTextBoxDOB1.Text = row.Cells[5].ToString();
                maskedTextBoxDOB1.ForeColor = Color.Black;
                Gender = row.Cells[6].Value.ToString();
                if (Gender == "Male")
                {
                    radioButtonMale1.Checked = true;
                }
                else
                {
                    radioButtonFemale1.Checked = true;
                }
                textBoxEmail1.Text = row.Cells[7].Value.ToString(); 
                textBoxEmail1.ForeColor = Color.Black;
                Role = row.Cells[8].Value.ToString();
                if (Role == "Admin")
                {
                    checkBoxRole1.Checked = true;
                }
                textBoxAdd1.Text = row.Cells[9].Value.ToString();


            }

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (ID != "")
            {
                if (radioButtonMale1.Checked)
                {
                    Gender = "Male";
                }
                else
                {
                    Gender = "Female";
                }

                if (checkBoxRole1.Checked)
                {
                    Role = "Admin";
                }
                else
                {
                    Role = "User";
                }
                if (textBoxName1.Text.Trim() == string.Empty
                    || textBoxPass1.Text.Trim() == string.Empty
                    || !maskedTextBoxPho1.MaskCompleted
                    || maskedTextBoxPho1.Text == "+00 000 0000000"
                    || !maskedTextBoxCNIC1.MaskCompleted
                    || maskedTextBoxCNIC1.Text == "00000-0000000-0"
                    || !isValidDate(maskedTextBoxDOB1.Text)
                    || maskedTextBoxDOB1.Text == "00/00/0000" || DateTime.Parse(maskedTextBoxDOB1.Text) > DateTime.Now
                    || Gender == string.Empty
                    || !isValidEmail(textBoxEmail1.Text)
                    || textBoxEmail1.Text == "justin.santos-18@cpu.edu.ph"
                    )
                {

                    MessageBox.Show("Empty / Invalid Fields", "required all Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    bool check = Attendance.Attendance.UpdateUser(ID, textBoxName.Text.Trim(), textBoxPass.Text.Trim(), maskedTextBoxPho.Text, maskedTextBoxCNIC.Text, maskedTextBoxDOB.Text, Gender, textBoxEmail.Text.Trim(),
                 Role, textBoxAdd.Text.Trim(), sql);
                    if (check)
                    {
                        ClearTextBox1();
                    }
                }

            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (ID != "")
            {
                if (radioButtonMale1.Checked)
                {
                    Gender = "Male";
                }
                else
                {
                    Gender = "Female";
                }

                if (checkBoxRole1.Checked)
                {
                    Role = "Admin";
                }
                else
                {
                    Role = "User";
                }
                if (textBoxName1.Text.Trim() == string.Empty
                    || textBoxPass1.Text.Trim() == string.Empty
                    || !maskedTextBoxPho1.MaskCompleted
                    || maskedTextBoxPho1.Text == "+00 000 0000000"
                    || !maskedTextBoxCNIC1.MaskCompleted
                    || maskedTextBoxCNIC1.Text == "00000-0000000-0"
                    || !isValidDate(maskedTextBoxDOB1.Text)
                    || maskedTextBoxDOB1.Text == "00/00/0000" || DateTime.Parse(maskedTextBoxDOB1.Text) > DateTime.Now
                    || Gender == string.Empty
                    || !isValidEmail(textBoxEmail1.Text)
                    || textBoxEmail1.Text == "justin.santos-18@cpu.edu.ph"
                    )
                {

                    MessageBox.Show("Empty / Invalid Fields", "required all Fields", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("u SUre you want to delete this ? ", "Delete user", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        bool check = Attendance.Attendance.DeleteUser(ID, sql);
                        if (check)
                        {
                            if (UID == ID)
                                Application.Exit();
                            ClearTextBox1();
                          

                        }


                    }



                }


            }


        }

        private bool isValidEmail(string email)
        {

            try
            {
                var addr = new MailAddress(email);
                return addr.Address == email;
            }
            catch (Exception)
            {

                return false;
            }

        }


        private bool isValidDate(string date)
        {
            DateTime d;
            bool chValidity;

            try
            {
                return chValidity = DateTime.TryParseExact(date, "MM/dd/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out d);
            }
            catch (Exception)
            {

                return false;
            }

        }





    }
}
