using CSDC24_Project.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSDC24_Project.PAL.User_Control
{
    public partial class UserControlReport : UserControl
    {
        private string sql = @"Data Source = .\SQLEXPRESS; Initial Catalog = Attendance_Management_System; Integrated Security = True;";
        public UserControlReport()
        {
            InitializeComponent();
        }

        public void FirstTab()
        {
            tabControlReport.SelectedTab = tabPageClassReport;
        }

        private void comboBoxClass_Click(object sender, EventArgs e)
        {
            comboBoxClass.Items.Clear();
            Attendance.Attendance.FillComboBox("SELECT DISTINCT(Class_Name) FROM Class_Table;", comboBoxClass, sql);
        }

        private void comboBoxClass1_Click(object sender, EventArgs e)
        {
            comboBoxClass1.Items.Clear();
            Attendance.Attendance.FillComboBox("SELECT DISTINCT(Class_Name) FROM Class_Table;", comboBoxClass1, sql);
        }

        private void comboBoxRegNo_Click(object sender, EventArgs e)
        {
            if (comboBoxClass1.SelectedIndex != 1)
            {
                comboBoxRegNo.Items.Clear();
                Attendance.Attendance.FillComboBox("SELECT DISTINCT(Student_Reg) FROM Student_Table INNER JOIN Class_Table ON Student_Table.Class_ID = Class_Table.Class_ID WHERE Class_Name = '"+comboBoxClass1.SelectedItem.ToString()+"';", comboBoxRegNo, sql);
            }

        }

        private void comboBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClass.SelectedIndex != -1)
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_Name, Student_Reg, Class_Name, Attendance_Date, Attendance_Status FROM Student_Table INNER JOIN Attendance_Table ON Student_Table.Student_ID = Attendance_Table.Student_ID INNER JOIN Class_Table ON Class_Table.Class_ID = Student_Table.Class_ID WHERE Attendance_Date LIKE '" + dateTimePickerDate.Text + "%' AND Class_Name = '" + comboBoxClass.SelectedItem.ToString() + "'; ", dataGridViewClassReport,sql);
            }

        }

        private void comboBoxRegNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClass1.SelectedIndex != -1 && comboBoxRegNo.SelectedIndex != -1)
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_Name, Student_Reg, Class_Name, Attendance_Date, Attendance_Status FROM Student_Table INNER JOIN Attendance_Table ON Student_Table.Student_ID = Attendance_Table.Student_ID INNER JOIN Class_Table ON Class_Table.Class_ID = Student_Table.Class_ID WHERE Attendance_Date LIKE '" + dateTimePickerDate1.Text + "%' AND Student_Reg = '" + comboBoxRegNo.SelectedItem.ToString() + "'; ", dataGridViewStudentReport,sql);
            }
        }

        private void comboBoxClass1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxClass1.SelectedIndex != -1 && comboBoxRegNo.SelectedIndex != -1)
            {
                Attendance.Attendance.DisplayAndSearchAllData("SELECT Student_Name, Student_Reg, Class_Name, Attendance_Date, Attendance_Status FROM Student_Table INNER JOIN Attendance_Table ON Student_Table.Student_ID = Attendance_Table.Student_ID INNER JOIN Class_Table ON Class_Table.Class_ID = Student_Table.Class_ID WHERE Attendance_Date LIKE '" + dateTimePickerDate1.Text + "%' AND Student_Reg = '" + comboBoxRegNo.SelectedItem.ToString() + "'; ", dataGridViewStudentReport, sql);
            }
        }

        private void pictureBoxPrint_Click(object sender, EventArgs e)
        {
            if (comboBoxClass.SelectedIndex != 1)
            {
                var present = dataGridViewClassReport.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Column5"].Value.ToString() == "Present");
                var absent = dataGridViewClassReport.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Column5"].Value.ToString() == "Absent");

                easyhtmlReports.Clear();
                easyhtmlReports.AddImage(Resources.undraw_Drink_coffee_jdqb, "width=100, style='float:right'");
                easyhtmlReports.AddString("<h1>Central Philippine University</h1>");
                easyhtmlReports.AddString("<h2><i>" + comboBoxClass.SelectedItem.ToString() + "</i></h2>");
                easyhtmlReports.AddLineBreak();
                easyhtmlReports.AddLineBreak();
                easyhtmlReports.AddLineBreak();

                easyhtmlReports.AddDatagridView(dataGridViewClassReport);
                easyhtmlReports.AddLineBreak();
                easyhtmlReports.AddString("Total Student: " + dataGridViewClassReport.Rows.Count.ToString());
                easyhtmlReports.AddLineBreak();
                easyhtmlReports.AddString("Present Student: " + present.ToString());
                easyhtmlReports.AddLineBreak();
                easyhtmlReports.AddString("Absent Student: " + absent.ToString());
                easyhtmlReports.ShowPrintPreviewDialog();

            }

        }

        private void pictureBoxPrint1_Click(object sender, EventArgs e)
        {
            if (comboBoxClass1.SelectedIndex != -1 && comboBoxRegNo.SelectedIndex != -1)
            {
                var present = dataGridViewStudentReport.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Column10"].Value.ToString() == "Present");
                var absent = dataGridViewStudentReport.Rows.Cast<DataGridViewRow>().Count(row => row.Cells["Column10"].Value.ToString() == "Absent");

                easyhtmlReports.Clear();
                easyhtmlReports.AddImage(Resources.undraw_Drink_coffee_jdqb, "width=100, style='float:right'");
                easyhtmlReports.AddString("<h1>Central Philippine University</h1>");
                easyhtmlReports.AddString("<h2><i>" + comboBoxClass1.SelectedItem.ToString() + "</i></h2>");
                easyhtmlReports.AddLineBreak();
                easyhtmlReports.AddLineBreak();
                easyhtmlReports.AddLineBreak();

                easyhtmlReports.AddDatagridView(dataGridViewStudentReport);
                easyhtmlReports.AddLineBreak();
                easyhtmlReports.AddString("Total Student: " + dataGridViewStudentReport.Rows.Count.ToString());
                easyhtmlReports.AddLineBreak();
                easyhtmlReports.AddString("Present: " + present.ToString());
                easyhtmlReports.AddString("Absent: " + absent.ToString());
                easyhtmlReports.ShowPrintPreviewDialog();

            }
        }
    }
}
