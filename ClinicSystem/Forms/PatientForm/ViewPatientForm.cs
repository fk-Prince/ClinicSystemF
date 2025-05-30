﻿using System;
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

namespace ClinicSystem
{
    public partial class ViewPatientForm : Form
    {
        private DataTable dt, dt1;
        private List<Appointment> appointmentList;

        private AppointmentRepository db = new AppointmentRepository();
        private List<Appointment> filter = new List<Appointment>();

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

                a.Visible = false;
                if (row.Cells["Patient ID"]?.Value != null)
                {
                    string patientIdStr = row.Cells["Patient ID"].Value.ToString();

                    Appointment selected = appointmentList
                    .FirstOrDefault(a =>
                        a.Patient.Patientid.ToString().Equals(patientIdStr)
                    );


                    tbPatId.Text = selected.Patient.Patientid.ToString();
                    tbfullName.Text = $"{selected.Patient.Firstname} {selected.Patient.Middlename} {selected.Patient.Lastname}";
                    tbAge.Text = selected.Patient.Age.ToString();
                    tbGender.Text = selected.Patient.Gender;
                    tbAddress.Text = selected.Patient.Address;
                    datepickBirthDay.Value = selected.Patient.Birthdate;
                    tbContactNumber.Text = selected.Patient.ContactNumber;
                    prescription.Text = selected.Prescription;
                    filter.Clear();
                    foreach (Appointment pas in appointmentList)
                    {
                        if (selected.Patient.Patientid == pas.Patient.Patientid)
                        {
                            filter.Add(pas);
                        }
                    }

                    if (dt1.Rows.Count > 0)
                    {
                        dt1.Rows.Clear();
                    }


                    if (filter != null && filter.Count > 0)
                    {

                        foreach (Appointment appointment in filter)
                        {
                            comboAppNo.Items.Add(appointment.AppointmentDetailNo);
                            string dr = $"{appointment.Doctor.DoctorLastName}, {appointment.Doctor.DoctorFirstName}  {appointment.Doctor.DoctorMiddleName}";
                            dt1.Rows.Add(
                                appointment.AppointmentDetailNo.ToString(),
                                appointment.Operation.OperationName,
                                dr
                                );
                        }
                        tbBill.Text = "₱ " + filter.Sum(x => x.Total).ToString("N2");
                       
                    }
                    //tabPagePatientDetails.SelectedTab = tabPatientDetails;


                    changeTab(1);
                }

            }
        }

     
        


        private void clear()
        {
            tbPatId.Text = "";
            tbfullName.Text = "";
            tbAddress.Text = "";
            tbAge.Text = "";
            tbGender.Text = "";
            tbAddress.Text = "";
            tbContactNumber.Text = "";
            datepickBirthDay.Value = DateTime.Now;
            tbBill.Text = "";
            tbDoctor.Text = "";
            tbOperation.Text = "";
            cost.Text = "";
            Status.Text = "";
            start.Text = "";
            end.Text = "";
            prescription.Text = "";
            tbDoctorDiagnosis.Text = "";
            comboAppNo.Items.Clear();
            filter.Clear();
        }

        private void comboAppNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboAppNo.SelectedIndex == -1) return;

            int appointmentDetailNo = int.Parse(comboAppNo.SelectedItem.ToString());
            foreach (Appointment appointment in filter)
            {
                if (appointment.AppointmentDetailNo == appointmentDetailNo)
                {
                    string dr = $"{appointment.Doctor.DoctorID}  | {appointment.Doctor.DoctorLastName}, {appointment.Doctor.DoctorFirstName}  {appointment.Doctor.DoctorMiddleName}";
                    tbDoctor.Text = dr;
                    tbOperation.Text = appointment.Operation.OperationCode + "  |  "+ appointment.Operation.OperationName;
                    tbDoctorDiagnosis.Text = appointment.Diagnosis;
                    prescription.Text = appointment.Prescription;
                    cost.Text = "₱ " + appointment.Total.ToString("N2");
                    start.Text = appointment.StartTime.ToString("yyyy-MM-dd hh:mm:ss tt");
                    end.Text = appointment.EndTime.ToString("yyyy-MM-dd hh:mm:ss tt");
                    Status.Text = appointment.Status;
                    a.Visible = false;
                    break;
                }
            }
        }

        bool isPatientList = true;
        private void tabPagePatientDetails_TabIndexChanged(object sender, EventArgs e)
        {
            if (!isPatientList)
            {
                clear();
                isPatientList = !isPatientList;
            } else
            {
                isPatientList = !isPatientList;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void panel8_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPagePatientDetails_Selecting(object sender, TabControlCancelEventArgs e)
        {
            if (!isSecondTab && disabledTabs.Contains(e.TabPageIndex))
            {
                e.Cancel = true;
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

        private void reset2()
        { 
            tbDoctor.Text = "";
            tbOperation.Text = "";
            cost.Text = "";
            Status.Text = "";
            start.Text = "";
            end.Text = "";
            prescription.Text = "";
            tbDoctorDiagnosis.Text = "";
            comboAppNo.SelectedIndex = -1;
        }

        private void guna2PictureBox2_Click_1(object sender, EventArgs e)
        {
            a.Visible = !a.Visible;
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

                    foreach(Appointment appointment in filter)
                    {
                        if (appNo == appointment.AppointmentDetailNo.ToString())
                        {
                            comboAppNo.SelectedItem = appointment.AppointmentDetailNo;
                            string dr = $"{appointment.Doctor.DoctorID}  | {appointment.Doctor.DoctorLastName}, {appointment.Doctor.DoctorFirstName}  {appointment.Doctor.DoctorMiddleName}";
                            tbDoctor.Text = dr;
                            tbOperation.Text = appointment.Operation.OperationCode + "  |  " + appointment.Operation.OperationName;
                            tbDoctorDiagnosis.Text = appointment.Diagnosis;
                            prescription.Text = appointment.Prescription;
                            cost.Text = "₱ " + appointment.Total.ToString("N2");
                            start.Text = appointment.StartTime.ToString("yyyy-MM-dd hh:mm:ss tt");
                            end.Text = appointment.EndTime.ToString("yyyy-MM-dd hh:mm:ss tt");
                            Status.Text = appointment.Status;
                            a.Visible = !a.Visible;
                            break;
                        }
                    }
                }
            }
        }
    }
}
