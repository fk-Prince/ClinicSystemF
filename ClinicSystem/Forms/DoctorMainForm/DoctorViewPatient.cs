using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using ClinicSystem.DoctorClinic;
using ClinicSystem.Forms.PatientForm;
using ClinicSystem.Helpers;
using ClinicSystem.PatientForm;
using ClinicSystem.Repository;
using ClinicSystem.Rooms;
using ClinicSystem.UserLoginForm;
using DoctorClinic;
using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;

namespace ClinicSystem
{
    public partial class DoctorViewPatient : Form
    {

        private DoctorRepository doctorRepository = new DoctorRepository();

        private List<Appointment> patientAppointments;
        private DataTable dt, dt1;
        private Doctor dr;
        private Appointment selectedPatient = null;
        private int limitCharacter = 200;
        private List<Appointment> filtered = new List<Appointment>();
        private Appointment selectedAppointment;

        private HashSet<int> disabledTabs = new HashSet<int>() { 1 };
        private bool isSecondTab = false;
        public DoctorViewPatient(Doctor dr)
        {
            this.dr = dr;
            InitializeComponent();
            dt = new DataTable();
            dt.Columns.Add("Patient ID", typeof(string));
            dt.Columns.Add("FirstName", typeof(string));
            dt.Columns.Add("MiddleName", typeof(string));
            dt.Columns.Add("LastName", typeof(string));
            dt.Columns.Add("Gender", typeof(string));
            dt.Columns.Add("Age", typeof(int));
            dt.Columns.Add("Contact Number", typeof(string));
            patientAppointments = doctorRepository.getPatientByDoctor(dr.DoctorID);
            addRows(patientAppointments);
            dataGrid.DataSource = dt;


            dt1 = new DataTable();
            dt1.Columns.Add("Appointment No", typeof(string));
            dt1.Columns.Add("Operation", typeof(string));
            dt1.Columns.Add("Room No", typeof(string));
            dt1.Columns.Add("Start Schedule", typeof(string));
            dt1.Columns.Add("End Schedule", typeof(string));
            dt1.Columns.Add("Status", typeof(string));
            d1.AutoGenerateColumns = true;
            d1.DataSource = dt1;


       
        }

        

        private void addRows(List<Appointment> patientAppointments)
        {
            dt.Clear();
            HashSet<string> seen = new HashSet<string>();
            foreach (Appointment pa in patientAppointments)
            {
                if (seen.Add(pa.Patient.Patientid.ToString()))
                {
                    dt.Rows.Add(
                        pa.Patient.Patientid,
                        pa.Patient.Firstname,
                        pa.Patient.Middlename,
                        pa.Patient.Lastname,
                        pa.Patient.Gender,
                        pa.Patient.Age,
                        pa.Patient.ContactNumber
                    );
                }
            }
        }


        private void searchPatient_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchPatient.Text))
            {
                addRows(patientAppointments);
            }
            else
            {
                string text = searchPatient.Text;
                List<Appointment> filtered = new List<Appointment>();

                filtered = patientAppointments.Where(pa =>
                pa.Patient.Firstname.StartsWith(text, StringComparison.OrdinalIgnoreCase) ||
                pa.Patient.Middlename.StartsWith(text, StringComparison.OrdinalIgnoreCase) ||
                pa.Patient.Lastname.StartsWith(text, StringComparison.OrdinalIgnoreCase) ||
                pa.Patient.Patientid.StartsWith(text, StringComparison.OrdinalIgnoreCase) ||
                pa.Patient.Patientid.EndsWith(text, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                addRows(filtered);
            }
        }
        private bool isPatientList = true;
        private void TabChanged(object sender, EventArgs e)
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



        private void DoctorViewPatient_Load(object sender, EventArgs e)
        {

            d1.EnableHeadersVisualStyles = false;
            d1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#5CA8A3");
            d1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            d1.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#5CA8A3");
            d1.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;


            dataGrid.EnableHeadersVisualStyles = false;
            dataGrid.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#5CA8A3");
            dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#5CA8A3");
            dataGrid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;

        }

        private void dataGrid_MouseClick(object sender, MouseEventArgs e)
        {
            var hit = dataGrid.HitTest(e.X, e.Y);

            if (hit.Type == DataGridViewHitTestType.Cell && hit.RowIndex >= 0)
            {
                DataGridViewRow row = dataGrid.Rows[hit.RowIndex];


                if (row.Cells["Patient ID"]?.Value != null)
                {
                    string patientIdStr = row.Cells["Patient ID"].Value.ToString();

                    Appointment selected = patientAppointments
                    .FirstOrDefault(a =>
                        a.Patient.Patientid.ToString().Equals(patientIdStr)
                    );


                    if (dt1.Rows.Count > 0)
                    {
                        dt1.Rows.Clear();
                    }
                    HashSet<int> seen = new HashSet<int>();
                    foreach (Appointment pas in patientAppointments)
                    {
                        if (selected.Patient.Patientid == pas.Patient.Patientid)
                        {
                            if (seen.Add(pas.AppointmentDetailNo)) { 

                                dt1.Rows.Add
                                     (
                                        pas.AppointmentDetailNo,
                                        pas.Operation.OperationName,
                                        pas.RoomNo,
                                        pas.StartTime.ToString("yyyy-MM-dd") + Environment.NewLine + pas.StartTime.ToString("hh:mm:ss tt"),
                                        pas.EndTime.ToString("yyyy-MM-dd") + Environment.NewLine + pas.EndTime.ToString("hh:mm:ss tt"),
                                        pas.Status
                                    );
                                }
                             
                        }
                    }
                    changeTab(1);
                }

            }
        }


        private void tabControl_Selecting(object sender, TabControlCancelEventArgs e)
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

                    Appointment selected = patientAppointments
                    .FirstOrDefault(a =>
                        a.AppointmentDetailNo.ToString().Equals(appNo)
                    );

                    PatientDiagnosis p = new PatientDiagnosis(selected, "UPDATE", dr);
                    p.Show();
                }

            }
        }

        private void dd_Click(object sender, EventArgs e)
        {
          
            //if (string.IsNullOrWhiteSpace(a.Text)) return;
            //try
            //{

            //    using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
            //    {
            //        conn.Open();
            //        string query = @"SELECT * FROM patientappointment_tbl WHERE appointmentdetailno = @appointmentdetailno AND doctorid = @doctorid";
            //        using (MySqlCommand command = new MySqlCommand(query, conn))
            //        {
            //            command.Parameters.AddWithValue("@appointmentdetailno", a.Text.Trim());
            //            command.Parameters.AddWithValue("@doctorid", dr.DoctorID);
            //            using (MySqlDataReader reader = command.ExecuteReader())
            //            {
            //                if (reader.HasRows)
            //                {
            //                    MessagePromp.ShowCenter(this, "Cant send a request to your own appointmnet", MessageBoxIcon.Error);
            //                    return;
            //                }
            //            }
            //        }
            //    }

            //    using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
            //    {
            //        conn.Open();
            //        string query = @"SELECT * FROM appointmentdetails_tbl WHERE appointmentdetailno = @appointmentdetailno";
            //        using (MySqlCommand command = new MySqlCommand(query, conn))
            //        {
            //            command.Parameters.AddWithValue("@appointmentdetailno", a.Text.Trim());
            //            using (MySqlDataReader reader = command.ExecuteReader())
            //            {
            //                if (!reader.Read())
            //                {

            //                    MessagePromp.ShowCenter(this, "Appointment No doens't exist.", MessageBoxIcon.Error);
            //                    return;
            //                } 
            //            }
            //        }
            //    }

            //    using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
            //    {
            //        conn.Open();
            //        string query = @"SELECT * FROM sharedappointment_tbl WHERE SharedAppointmentNo = @SharedAppointmentNo AND SharedDoctorID = @SharedDoctorID AND Status = 'Allowed'";
            //        using (MySqlCommand command = new MySqlCommand(query, conn))
            //        {
            //            command.Parameters.AddWithValue("@SharedAppointmentNo", a.Text.Trim());
            //            command.Parameters.AddWithValue("@SharedDoctorID", dr.DoctorID);
            //            using (MySqlDataReader reader = command.ExecuteReader())
            //            {
            //                if (reader.Read())
            //                {
            //                    MessagePromp.ShowCenter(this, "You have already access to this data.", MessageBoxIcon.Error);
            //                    return;
            //                }
            //            }
            //        }
            //    }

            //    using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
            //    {
            //        conn.Open();
            //        string query = @"SELECT COUNT(*) FROM sharedappointment_tbl WHERE SharedAppointmentNo = @SharedAppointmentNo AND SharedDoctorID = @SharedDoctorID AND Status = 'Pending'";
            //        using (MySqlCommand command = new MySqlCommand(query, conn))
            //        {
            //            command.Parameters.AddWithValue("@SharedAppointmentNo", a.Text.Trim());
            //            command.Parameters.AddWithValue("@SharedDoctorID", dr.DoctorID);
            //            using (MySqlDataReader reader = command.ExecuteReader())
            //            {
            //                if (reader.Read())
            //                {
            //                    MessagePromp.ShowCenter(this, "You have request to access this data.", MessageBoxIcon.Error);
            //                    return;
            //                }
            //            }
            //        }
            //    }

            //    using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
            //        {
            //            conn.Open();
            //            string query = @"INSERT INTO sharedappointment_tbl (SharedAppointmentNo, SharedDoctorID) VALUES (@SharedAppointmentNo, @SharedDoctorID)";
            //            using (MySqlCommand command = new MySqlCommand(query, conn))
            //            {
            //                command.Parameters.AddWithValue("SharedAppointmentNo", a.Text.Trim());
            //                command.Parameters.AddWithValue("@SharedDoctorID", dr.DoctorID);
            //                command.ExecuteNonQuery();
            //                MessagePromp.ShowCenter(this, "Request successfully sent.", MessageBoxIcon.Information);
            //            }
            //        }

            //}
            //catch (MySqlException ex)
            //{
            //    MessageBox.Show("error db" + ex.Message);
            //}
        }

        public void changeTab(int index)
        {
            if (index >= 0 && index < tabControl.TabCount)
            {
                isSecondTab = true;
                tabControl.SelectedIndex = index;
                isSecondTab = false;
            }
        }
    }
}
