using System;
using ClinicSystem.UserLoginForm;
using System.Windows.Forms;
using System.Data;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Collections.Generic;
using ClinicSystem.PatientForm;
using ClinicSystem.Appointments;
using System.Linq;
using ClinicSystem.DoctorClinic;
using System.Web.UI.WebControls;
using ClinicSystem.Forms.PatientForm;

namespace ClinicSystem
{
    public partial class ViewPatientForm : Form
    {
        private DataTable dt, dt1;
        private List<Appointment> appointmentList;

        private AppointmentRepository db = new AppointmentRepository();

        private HashSet<int> disabledTabs = new HashSet<int>() { 1 };
        private bool isSecondTab = false;


        public ViewPatientForm(Staff staff)
        {
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("Patient ID", typeof(string));
            dt.Columns.Add("First Name", typeof(string));
            dt.Columns.Add("Middle Name", typeof(string));
            dt.Columns.Add("Last Name", typeof(string));
            dt.Columns.Add("Age", typeof(int));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("Contact Number", typeof(string));
            dataGrid.AutoGenerateColumns = true;
            dataGrid.DataSource = dt;


            dt1 = new DataTable();
            dt1.Columns.Add("Appointment No", typeof(string));
            dt1.Columns.Add("Operation", typeof(string));
            dt1.Columns.Add("Doctor", typeof(string));
            dt1.Columns.Add("Room No", typeof(string));
            dt1.Columns.Add("Start Schedule", typeof(string));
            dt1.Columns.Add("End Schedule", typeof(string));
            dt1.Columns.Add("Status", typeof(string));
            d1.AutoGenerateColumns = true;
            d1.DataSource = dt1;

            appointmentList = db.getAppointment();
            displayTable(appointmentList);



        }



        public void displayTable(List<Appointment> appList)
        {
            dt.Clear();
            HashSet<string> seen = new HashSet<string>();

            foreach (Appointment pa in appList)
            {
                if (seen.Add(pa.Patient.Patientid.ToString()))
                {
                    dt.Rows.Add(
                        pa.Patient.Patientid,
                        pa.Patient.Firstname,
                        pa.Patient.Middlename,
                        pa.Patient.Lastname,
                        pa.Patient.Age,
                        pa.Patient.Gender,
                        pa.Patient.ContactNumber
                    );
                }
            }


        }


        private void ViewPatientForm_Load(object sender, EventArgs e)
        {
            d1.EnableHeadersVisualStyles = false;
            d1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#5CA8A3");
            d1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            d1.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#5CA8A3");
            d1.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            SearchBar1.Focus();
            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#5CA8A3");
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#5CA8A3");
            dataGrid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

            dataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
            dataGrid.RowsDefaultCellStyle.BackColor = Color.White;
            dataGrid.RowsDefaultCellStyle.SelectionBackColor = dataGrid.RowsDefaultCellStyle.BackColor;
            dataGrid.AlternatingRowsDefaultCellStyle.SelectionBackColor = dataGrid.AlternatingRowsDefaultCellStyle.BackColor;
        }

        private void SearchBar1_TextChanged(object sender, EventArgs e)
        {
            string keyword = SearchBar1.Text.Trim().ToLower().Replace("'", "''");

            if (dt == null || dt.Rows.Count == 0)
                return;

            DataView dv = dt.DefaultView;
            dv.RowFilter = string.Format(
                "[Patient ID] LIKE '%{0}%' OR " +
                "[First Name] LIKE '{0}%' OR " +
                "[Middle Name] LIKE '{0}%' OR " +
                "[Last Name] LIKE '{0}%' ",
                keyword
            );
        }
        private void dataGrid_CellContentClick(object sender, MouseEventArgs e)
        {


            var hit = dataGrid.HitTest(e.X, e.Y);

            if (hit.Type == DataGridViewHitTestType.Cell && hit.RowIndex >= 0)
            {
                DataGridViewRow row = dataGrid.Rows[hit.RowIndex];


                if (row.Cells["Patient ID"]?.Value != null)
                {
                    string patientIdStr = row.Cells["Patient ID"].Value.ToString();

                    Appointment selected = appointmentList
                    .FirstOrDefault(a =>
                        a.Patient.Patientid.ToString().Equals(patientIdStr)
                    );


                    if (dt1.Rows.Count > 0)
                    {
                        dt1.Rows.Clear();
                    }


                    foreach (Appointment pas in appointmentList)
                    {
                        if (selected.Patient.Patientid == pas.Patient.Patientid)
                        {
                           
                            //if (dt1.Rows.Count > 0)
                            //{
                            //    var value = dt1.Rows[0]["Appointment No"];
                            //    if (value != DBNull.Value && !string.IsNullOrWhiteSpace(value.ToString()))
                            //    {
                            //        continue;
                            //    }
                            //}
                            dt1.Rows.Add
                            (
                                pas.AppointmentDetailNo,
                                pas.Operation.OperationName,
                                pas.Doctor.DoctorFirstName + " " + pas.Doctor.DoctorMiddleName + " " + pas.Doctor.DoctorLastName,
                                pas.RoomNo,
                                pas.StartTime.ToString("yyyy-MM-dd") + Environment.NewLine + pas.StartTime.ToString("hh:mm:ss tt"),
                                pas.EndTime.ToString("yyyy-MM-dd") + Environment.NewLine + pas.EndTime.ToString("hh:mm:ss tt"),
                                pas.Status
                            );
                        }
                    }



                    //tabPagePatientDetails.SelectedTab = tabPatientDetails;


                    changeTab(1);
                }

            }
        }








        bool isPatientList = true;
        private void tabPagePatientDetails_TabIndexChanged(object sender, EventArgs e)
        {
            if (!isPatientList)
            {

                isPatientList = !isPatientList;
            }
            else
            {
                isPatientList = !isPatientList;
            }
        }



        private void tabPagePatientDetails_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!isSecondTab && disabledTabs.Contains(e.TabPageIndex))
            {
                e.Cancel = true;
            }
        }

        private void d1_MouseClick(object sender, MouseEventArgs e)
        {
            var hit = d1.HitTest(e.X, e.Y);

            if (hit.Type == DataGridViewHitTestType.Cell && hit.RowIndex >= 0)
            {
                DataGridViewRow row = d1.Rows[hit.RowIndex];
                if (row.Cells["Appointment No"]?.Value != null)
                {
                    string appNo = row.Cells["Appointment No"].Value.ToString();

                    Appointment selected = appointmentList
                    .FirstOrDefault(a =>
                        a.AppointmentDetailNo.ToString().Equals(appNo)
                    );

                    PatientDiagnosis p = new PatientDiagnosis(selected, "VIEW ONLY",null); ;
                    p.Show();
                }

            }
        }

        public void changeTab(int index)
        {
            if (index >= 0 && index < s.TabCount)
            {
                isSecondTab = true;
                s.SelectedIndex = index;
                isSecondTab = false;
            }
        }


    }
}
