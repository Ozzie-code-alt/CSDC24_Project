using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDC24_Project.PAL.User_Control
{
    public partial class UserControlAddStudent : UserControl
    {
        private string sql = @"Data Source = .\SQLEXPRESS; Initial Catalog = Attendance_Management_System; Integrated Security = True;";
        private string SID = "", gender ="";


        public UserControlAddStudent()
        {
            InitializeComponent();
        }

        public void ClearTextBox()
        {
            textBoxName.Clear();
            textBoxRegNo.Clear();
            comboBoxClass.SelectedIndex= -1;
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            tabControllAddStudent.SelectedTab = tabPageAddStudent;
        }
        private void ClearTextBox1()
        {
            textBoxName1.Clear();
            textBoxRegNo1.Clear();
            comboBoxClass1.SelectedIndex = -1;
            radioButtonMale1.Checked = false;
            radioButtonFemale1.Checked = false;
            SID = "";
        }

        private void tabPageSearchStudent_Enter(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            comboBoxSearchBy.SelectedIndex = -1;
            Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID, Student_Name, Student_Reg, Student_Gender, Class_Name FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID;",dataGridViewStudent,sql);
         
            dataGridViewStudent.Columns[0].Visible = false;
            labelCountStudent.Text = dataGridViewStudent.Rows.Count.ToString();

        }

        private void tabPageAddStudent_Enter(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void tabPageAddStudent_Leave(object sender, EventArgs e)
        {
            ClearTextBox();
        }

        private void tabPageUPStudent_Leave(object sender, EventArgs e)
        {
            ClearTextBox1();
        }

        private void comboBoxClass_Click(object sender, EventArgs e)
        {
            comboBoxClass.Items.Clear();
            Attendance.Attendance.FillComboBox("SELECT DISTINCT(Class_Name) FROM Class_Table;", comboBoxClass, sql);
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            string gender = "";
            if (radioButtonMale.Checked)
            {
                gender = "Male";
            }
            else if (radioButtonFemale.Checked)
            {
                gender = "Female";
            }

            if (textBoxName.Text.Trim() == string.Empty || textBoxRegNo.Text.Trim() == string.Empty || comboBoxClass.SelectedIndex == -1)
            {
                MessageBox.Show("Field are Empty", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (radioButtonMale.Checked == false && radioButtonFemale.Checked == false)
            {
                MessageBox.Show("Field are Empty", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;


            }
            else
            {
                bool check = Attendance.Attendance.AddStudent(textBoxName.Text.Trim(), textBoxRegNo.Text.Trim(), comboBoxClass.SelectedItem.ToString(), gender, sql);
                if (check)
                {
                    ClearTextBox();
                }

            }

        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (comboBoxSearchBy.SelectedIndex == 0)
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID, Student_Name, Student_Reg, Student_Gender, Class_Name FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID WHERE Student_Name LIKE '%" + textBoxSearch.Text.Trim() + "%'; ", dataGridViewStudent, sql);

            }

            if (comboBoxSearchBy.SelectedIndex == 1)
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID, Student_Name, Student_Reg, Student_Gender, Class_Name FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID WHERE Student_Reg LIKE '%" + textBoxSearch.Text.Trim() + "%'; ", dataGridViewStudent, sql);

            }

            if (comboBoxSearchBy.SelectedIndex == 2)
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_ID, Student_Name, Student_Reg, Student_Gender, Class_Name FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID WHERE Class_Name LIKE '%" + textBoxSearch.Text.Trim() + "%'; ", dataGridViewStudent, sql);

            }
        }

        private void dataGridViewStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridViewStudent.Rows[e.RowIndex];
                SID = row.Cells["Column1"].Value.ToString();
                textBoxName1.Text = row.Cells["Column2"].Value.ToString();
                textBoxRegNo1.Text = row.Cells["Column3"].Value.ToString();
                comboBoxClass1.Items.Clear();

                Attendance.Attendance.FillComboBox("SELECT DISTINCT(Class_Name) FROM Class_Table;", comboBoxClass1, sql);
                comboBoxClass1.SelectedItem = row.Cells["Column4"].Value.ToString();


                if (row.Cells["Column5"].Value.ToString() == "Male")
                {
                    radioButtonMale1.Checked = true;
                }
                if (row.Cells["Column5"].Value.ToString() == "Female")
                {
                    radioButtonFemale1.Checked = true;
                }
            }


        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (SID != "")
            {
               
                if (radioButtonMale1.Checked)
                {
                    gender = "Male";
                }
                else if (radioButtonFemale1.Checked)
                {
                    gender = "Female";
                }

                if (textBoxName1.Text.Trim() == string.Empty || textBoxRegNo1.Text.Trim() == string.Empty || comboBoxClass1.SelectedIndex == -1)
                {
                    MessageBox.Show("Field are Empty", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (radioButtonMale1.Checked == false && radioButtonFemale1.Checked == false)
                {
                    MessageBox.Show("Field are Empty", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;


                }
                else
                {
                    bool check = Attendance.Attendance.UpdateStudent(SID, textBoxName1.Text.Trim(), textBoxRegNo1.Text.Trim(), comboBoxClass1.SelectedItem.ToString(), gender, sql);
                    if (check)
                    {
                        ClearTextBox1();
                    }

                }
            }
            else
            {
                MessageBox.Show("Select row from Table", "Select Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        //#####################################################################
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (SID != "")
            {
                
                if (radioButtonMale1.Checked)
                {
                    gender = "Male";
                }
                else if (radioButtonFemale1.Checked)
                {
                    gender = "Female";
                }

                if (textBoxName1.Text.Trim() == string.Empty || textBoxRegNo1.Text.Trim() == string.Empty || comboBoxClass1.SelectedIndex == -1)
                {
                    MessageBox.Show("Field are Empty", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else if (radioButtonMale1.Checked == false && radioButtonFemale1.Checked == false)
                {
                    MessageBox.Show("Field are Empty", "Required Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;


                }
                else
                {
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this Student ?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (dialogResult == DialogResult.Yes)
                    {
                        bool check = Attendance.Attendance.DeleteStudent(SID, sql);
                        if (check)
                        {
                            ClearTextBox1();
                        }
                    }

                }
            }
            else
            {
                MessageBox.Show("Select row from Table", "Select Row", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
