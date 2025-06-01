using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using ClinicSystem.DoctorClinic;
using ClinicSystem.Entity;
using ClinicSystem.Printer;
using ClinicSystem.Repository;
using ClinicSystem.UserLoginForm;
using DoctorClinic;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ClinicSystem.Forms.PatientForm
{
    public partial class PatientDiagnosis : Form
    {
        private Appointment app;
        private Doctor dr;
        private DoctorRepository doctorRepository = new DoctorRepository();
        private DataTable t1 = new DataTable();
        private DataTable t2 = new DataTable();
        private Appointment selected;
        private Guna2Button lastClickedButton;

        public PatientDiagnosis(Appointment selected, string type, Doctor dr)
        {
            InitializeComponent();

            if (type.Equals("VIEW ONLY"))
            {
                b1.Visible = false;
                b2.Visible = false;
                pr.Visible = false;
                limitD.Visible = false;
                d1.Size = new Size(976, 454);
                d2.Size = new Size(976, 454);
                d1.Refresh();
                d2.Refresh();

                d1.Invalidate();
                d2.Invalidate();
            }
            else
            {
                this.dr = dr;
            }
            SetButtonColor(pb);
            SetButtonColor(pd);
            lastClickedButton = pb;
            lastClickedButton.ForeColor = ColorTranslator.FromHtml("#2E4E4E");
            lastClickedButton.FillColor = ColorTranslator.FromHtml("#6FA8A6");
            app = selected;

            table();
            getPrescription();
        }

        private void table()
        {
            t1.Columns.Add("Appointment No", typeof(string));
            t1.Columns.Add("Prescription", typeof(string));
            t1.Columns.Add("Prescription Date", typeof(string));
            d1.AutoGenerateColumns = true;
            d1.DataSource = t1;

            t2.Columns.Add("Appointment No", typeof(string));
            t2.Columns.Add("Diagnosis", typeof(string));
            t2.Columns.Add("Diagnosis Date", typeof(string));
            d2.AutoGenerateColumns = true;
            d2.DataSource = t2;
        }

        private void getPrescription()
        {
            try
            {
                string query = @"
                            SELECT * FROM prescription_tbl         
                            WHERE prescription_tbl.appointmentdetailNo = @appointmentdetailNo";
                using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@appointmentdetailno", app.AppointmentDetailNo);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string appointmentNo = reader["appointmentdetailNo"].ToString();
                                string prescription = reader["prescription"].ToString();
                                DateTime date = Convert.ToDateTime(reader["prescriptiondate"]);
                                t1.Rows.Add(appointmentNo, InsertNewLines(prescription, 50), date.ToString("yyyy-MM-dd") + Environment.NewLine + date.ToString("hh:mm:dd tt"));
                            }
                        }
                    }
                }

                string query1 = @"
                            SELECT * FROM diagnosis_tbl
                            WHERE diagnosis_tbl.appointmentdetailNo = @appointmentdetailNo";
                using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(query1, conn))
                    {
                        command.Parameters.AddWithValue("@appointmentdetailno", app.AppointmentDetailNo);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string appointmentNo = reader["appointmentdetailNo"].ToString();
                                string diagnosis = reader["diagnosis"].ToString();
                                DateTime date1 = Convert.ToDateTime(reader["diagnosisdate"]);
                                t2.Rows.Add(appointmentNo, InsertNewLines(diagnosis, 50), date1.ToString("yyyy-MM-dd") + Environment.NewLine + date1.ToString("hh:mm:dd tt"));
                            }
                        }
                    }
                }

                string query2 = @"
                            SELECT status FROM patientappointment_tbl         
                            WHERE patientappointment_tbl.appointmentdetailNo = @appointmentdetailNo";
                using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(query2, conn))
                    {
                        command.Parameters.AddWithValue("@appointmentdetailno", app.AppointmentDetailNo);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                if (reader.GetString("Status").Equals("DISCHARGED",StringComparison.OrdinalIgnoreCase))
                                {
                                    dd.Visible = false;
                                }
                                else
                                {
                                    dd.Visible = true;
                                }
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("error on getPrescription() " + ex.Message);
            }
        }
        string InsertNewLines(string text, int maxLineLength)
        {
            if (string.IsNullOrEmpty(text)) return text;

            var sb = new StringBuilder();
            int currentPosition = 0;

            while (currentPosition < text.Length)
            {
                int length = Math.Min(maxLineLength, text.Length - currentPosition);
                sb.Append(text.Substring(currentPosition, length));

                currentPosition += length;

                if (currentPosition < text.Length)
                    sb.Append(Environment.NewLine);
            }

            return sb.ToString();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pr.Text.Trim())) return;
            if (doctorRepository.insertNewPrescription(pr.Text.Trim(), app.AppointmentDetailNo))
            {
                PrintDoctorReceiptNew p = new PrintDoctorReceiptNew(app, dr, pr.Text.Trim(), "Prescription");
                p.print();

                t1.Rows.Add(app.AppointmentDetailNo, InsertNewLines(pr.Text.Trim(), 50), DateTime.Now.ToString("yyyy-MM-dd") + Environment.NewLine + DateTime.Now.ToString("hh:mm:dd tt"));
                MessagePromp.ShowCenter(this, "Successfully added prescription", MessageBoxIcon.Information);
            }
            else
            {
                MessagePromp.ShowCenter(this, "Failed to add prescription", MessageBoxIcon.Information);

            }

        }

        private void b2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(pr.Text.Trim())) return;
            if (doctorRepository.insertNewDiagnosis(pr.Text.Trim(), app.AppointmentDetailNo))
            {
                PrintDoctorReceiptNew p = new PrintDoctorReceiptNew(app, dr, pr.Text.Trim(), "Diagnosis");
                p.print();
                t2.Rows.Add(app.AppointmentDetailNo, InsertNewLines(pr.Text.Trim(), 50), DateTime.Now.ToString("yyyy-MM-dd") + Environment.NewLine + DateTime.Now.ToString("hh:mm:dd tt"));
                MessagePromp.ShowCenter(this, "Successfully added diagnosis", MessageBoxIcon.Information);
            }
            else
            {
                MessagePromp.ShowCenter(this, "Failed to add diagnosis", MessageBoxIcon.Information);
            }
        }

        private void PatientDiagnosis_Load(object sender, EventArgs e)
        {
            d1.EnableHeadersVisualStyles = false;
            d1.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#5CA8A3");
            d1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            d1.ColumnHeadersDefaultCellStyle.Font = new Font("Segui", 12);
            d1.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#5CA8A3");
            d1.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            d1.Columns[0].Width = 100;
            d1.Columns[2].Width = 150;

            d2.EnableHeadersVisualStyles = false;
            d2.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#5CA8A3");
            d2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            d2.ColumnHeadersDefaultCellStyle.Font = new Font("Segui", 12);
            d2.ColumnHeadersDefaultCellStyle.SelectionBackColor = ColorTranslator.FromHtml("#5CA8A3");
            d2.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            d2.Columns[0].Width = 100;
            d2.Columns[2].Width = 150;
        }

        private void SetButtonColor(Guna2Button btn)
        {
            btn.FillColor = ColorTranslator.FromHtml("#CFF1EF");
            btn.BackColor = Color.Transparent;
            btn.ForeColor = ColorTranslator.FromHtml("#000000");
        }

        private void PatientDiagnosis_Deactivate(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            d1.Visible = true;
            d2.Visible = false;
            b1.Enabled = true;
            b2.Enabled = false;
            b2.BorderThickness = 1;
            b1.BorderThickness = 0;
            l1.Text = "Prescription";
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            d1.Visible = false;
            d2.Visible = true;
            b1.Enabled = false;
            b2.Enabled = true;
            b2.BorderThickness = 0;
            b1.BorderThickness = 1;
            l1.Text = "Diagnosis";
        }

        private void pd_MouseClick(object sender, MouseEventArgs e)
        {
            Guna2Button btn = sender as Guna2Button;

            if (btn != lastClickedButton)
            {
                btn.FillColor = ColorTranslator.FromHtml("#6FA8A6");
                btn.ForeColor = ColorTranslator.FromHtml("#2E4E4E");
                lastClickedButton.FillColor = ColorTranslator.FromHtml("#CFF1EF");
                lastClickedButton.ForeColor = ColorTranslator.FromHtml("#000000");

                lastClickedButton = btn;
            }
        }

        private int limitChar = 200;
        private void pr_TextChanged(object sender, EventArgs e)
        {
            string a = pr.Text.Trim();

            limitCheck(a, limitD);
        }

        public void limitCheck(string text, System.Windows.Forms.Label limit)
        {
            if (!string.IsNullOrWhiteSpace(text))
            {
                int total = limitChar - text.Length;
                if (total == 0)
                {
                    limit.Text = $"You reached limit 200 characters.";
                }
                else
                {
                    limit.Text = $"Up to {total.ToString()} characters.";
                }
            }
            else
            {
                limit.Text = $"Up to 200 characters.";
            }

        }


  

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {
            if (doctorRepository.setPatientDischarged(app.AppointmentDetailNo))
            {
                MessagePromp.MainShowMessage(this, "Succefully Discharged .", MessageBoxIcon.Information);
                dd.Visible = false;
                PrintDoctorReceiptNew p = new PrintDoctorReceiptNew(app, dr, "Patient has been discharged.", "Discharged");
                p.print();
            }
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
