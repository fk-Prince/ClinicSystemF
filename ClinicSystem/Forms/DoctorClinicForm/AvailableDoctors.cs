using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicSystem.Entity;
using DoctorClinic;

namespace ClinicSystem.Forms.DoctorClinicForm
{
    public partial class AvailableDoctors : Form
    {
        private DataTable table;
        private List<DoctorAppointment> ap;
        private DoctorRepository doctorRepository = new DoctorRepository();
        public AvailableDoctors()
        {
            InitializeComponent();
            table = new DataTable();
            table.Columns.Add("Doctor ID", typeof(string));
            table.Columns.Add("Doctor's Name", typeof(string));
            table.Columns.Add("Available From", typeof(string));
            table.Columns.Add("Available Until", typeof(string));
            dr.DataSource = table;


            d1.Value = DateTime.Now;
            getAvailable();
        }

        private void getAvailable()
        {
            table.Clear();
            ap = doctorRepository.getDoctorAvailable(d1.Value);

            string doctorSearcgh = search.Text.Trim();
            table.Clear();
            foreach (DoctorAppointment a in ap)
            {
                
                DateTime stime = DateTime.Today.Add(a.StartTime);
                DateTime etime = DateTime.Today.Add(a.EndTime);
                if (string.IsNullOrWhiteSpace(doctorSearcgh))
                {
                    table.Rows.Add(
                               a.Doctor.DoctorID,
                               $"Dr. {a.Doctor.DoctorFirstName} {a.Doctor.DoctorMiddleName} {a.Doctor.DoctorLastName}",
                               stime.ToString("hh:mm:ss tt"),
                               etime.ToString("hh:mm:ss tt")
                            );
                }
                else if (
                     a.Doctor.DoctorID.StartsWith(doctorSearcgh, StringComparison.OrdinalIgnoreCase) ||
                     a.Doctor.DoctorID.EndsWith(doctorSearcgh, StringComparison.OrdinalIgnoreCase) ||
                     a.Doctor.DoctorMiddleName.StartsWith(doctorSearcgh, StringComparison.OrdinalIgnoreCase) ||
                     a.Doctor.DoctorLastName.StartsWith(doctorSearcgh, StringComparison.OrdinalIgnoreCase)
                     )
                {
                    table.Rows.Add(
                            a.Doctor.DoctorID,
                            $"Dr. {a.Doctor.DoctorFirstName} {a.Doctor.DoctorMiddleName} {a.Doctor.DoctorLastName}",
                            stime.ToString("hh:mm:ss tt"),
                            etime.ToString("hh:mm:ss tt")
                         );

                }
            }
        }

        private void search_TextChanged(object sender, EventArgs e)
        {
            string doctorSearcgh = search.Text.Trim();
            table.Clear();
            foreach (DoctorAppointment a in ap)
            {
                DateTime stime = DateTime.Today.Add(a.StartTime);
                DateTime etime = DateTime.Today.Add(a.EndTime);
                if (string.IsNullOrWhiteSpace(doctorSearcgh))
                {
                    table.Rows.Add(
                               a.Doctor.DoctorID,
                               $"Dr. {a.Doctor.DoctorFirstName} {a.Doctor.DoctorMiddleName} {a.Doctor.DoctorLastName}",
                               stime.ToString("hh:mm:ss tt"),
                               etime.ToString("hh:mm:ss tt")
                            );
                }
                else if (
                    a.Doctor.DoctorID.StartsWith(doctorSearcgh, StringComparison.OrdinalIgnoreCase) ||
                    a.Doctor.DoctorID.EndsWith(doctorSearcgh, StringComparison.OrdinalIgnoreCase) ||
                     a.Doctor.DoctorMiddleName.StartsWith(doctorSearcgh, StringComparison.OrdinalIgnoreCase) ||
                     a.Doctor.DoctorLastName.StartsWith(doctorSearcgh, StringComparison.OrdinalIgnoreCase)
                    )
                {
                    table.Rows.Add(
                            a.Doctor.DoctorID,
                            $"Dr. {a.Doctor.DoctorFirstName} {a.Doctor.DoctorMiddleName} {a.Doctor.DoctorLastName}",
                            stime.ToString("hh:mm:ss tt"),
                            etime.ToString("hh:mm:ss tt")
                         );

                }
            }
        }

        private void d1_ValueChanged(object sender, EventArgs e)
        {
            getAvailable();
        }

        private void AvailableDoctors_Load(object sender, EventArgs e)
        {
            dr.EnableHeadersVisualStyles = false;
            dr.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#5CA8A3");
            dr.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dr.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#5CA8A3");
            dr.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
        }
    }
}
