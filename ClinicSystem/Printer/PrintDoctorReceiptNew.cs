using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicSystem.Entity;
using ClinicSystem.PatientForm;
using Google.Protobuf.WellKnownTypes;

namespace ClinicSystem.Printer
{
    public partial class PrintDoctorReceiptNew : Form
    {
        private Image image = Properties.Resources.Logo;


        private string patientFullName;
        private string doctorFullName;
        private Patient selectedPatient;
        private Appointment app;
        private Doctor selectedDoctor;
        private Diagnosis d;

        private int y = 450;
        private int x = 50;

        private int newLine = 100;
        private string type;
        private string fullname;
        private string text;
        public PrintDoctorReceiptNew(Appointment selected, Doctor selectedDoctor, string text, string type)
        {
            InitializeComponent();
            this.type = type;
            this.selectedDoctor = selectedDoctor;
            this.app = selected;
            this.text = text;
            selectedPatient = selected.Patient;
            this.selectedDoctor = selectedDoctor;
            patientFullName = Capitalized(selected.Patient.Firstname) + "  " + Capitalized(selected.Patient.Middlename) + "  " + Capitalized(selected.Patient.Lastname);
            fullname = Capitalized(selectedDoctor.DoctorFirstName) + "  " + Capitalized(selectedDoctor.DoctorMiddleName) + "  " + Capitalized(selectedDoctor.DoctorLastName);
            doctorFullName = fullname;




        }

        public void print()
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
        }

        private string Capitalized(string name)
        {
            return name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
        }
   


        private StringBuilder checkLength(string diagnosis)
        {
            StringBuilder sb = new StringBuilder();
            int textIndex = 0;
            for (int i = 0; i < diagnosis.Length; i++)
            {

                sb.Append(diagnosis[i]);
                textIndex++;

                if (textIndex == newLine)
                {
                    sb.Append(Environment.NewLine);
                    textIndex = 0;
                }
            }
            return sb;
        }

        private void drawHeader(PrintPageEventArgs e)
        {

            e.Graphics.DrawImage(image, 20, 20, 140, 140);
            e.Graphics.DrawString("Quantum Care", new Font("Impact", 36, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline), Brushes.Black, 140, 25);
            e.Graphics.DrawString("506 J.P. Laurel Ave,", new Font("Sans-serif", 12, FontStyle.Regular), Brushes.Black, 145, 85);
            e.Graphics.DrawString("Poblacion District, Davao City", new Font("Sans-serif", 12, FontStyle.Regular), Brushes.Black, 145, 105);

            if (type.Equals("DISCHARGED"))
            {
                e.Graphics.DrawString("Discharged", new Font("Impact", 20, FontStyle.Bold), Brushes.Black, 685, 60);
                e.Graphics.DrawString("Slip", new Font("Impact", 20, FontStyle.Bold), Brushes.Black, 730, 95);
            }else
            {
                e.Graphics.DrawString($"{type}", new Font("Impact", 20, FontStyle.Bold), Brushes.Black, 685, 60);
                e.Graphics.DrawString("Details", new Font("Impact", 20, FontStyle.Bold), Brushes.Black, 720, 95);
            }
            

            e.Graphics.DrawString($"Patient Name  : {patientFullName}", new Font("Sans-serif", 12, FontStyle.Bold), Brushes.Black, 30, 210);
            e.Graphics.DrawString($"Age  : {selectedPatient.Age}", new Font("Sans-serif", 12), Brushes.Black, 30, 230);
            e.Graphics.DrawString($"Gender  : {selectedPatient.Gender}", new Font("Sans-serif", 12), Brushes.Black, 30, 250);
            e.Graphics.DrawString($"Contact No.  : {selectedPatient.ContactNumber}", new Font("Sans-serif", 12), Brushes.Black, 30, 270);

            e.Graphics.DrawString($"Attending Doctor  : {doctorFullName}", new Font("Sans-serif", 12, FontStyle.Bold), Brushes.Black, 30, 320);
            e.Graphics.DrawString($"Dr. Contact No.  : {selectedDoctor.DoctorContactNumber}", new Font("Sans-serif", 12), Brushes.Black, 30, 340);
            e.Graphics.DrawString($"Date Issued.  : {DateTime.Now}", new Font("Sans-serif", 12), Brushes.Black, 30, 360);

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            drawHeader(e);
            Brush brush = Brushes.Black;
            Graphics graphics = Graphics.FromHwnd(IntPtr.Zero);
            Font mainFont = new Font("Sans-serif", 11);
            SizeF size1;
            StringBuilder sb;

           
           
            e.Graphics.DrawString($"Appointment No.  {app.AppointmentDetailNo}", mainFont, Brushes.Black, x, y);
            e.Graphics.DrawRectangle(Pens.Black, 30, y - 10, this.Width - 30, 40);
            //e.Graphics.DrawRectangle(Pens.Black, 30, y - 10, this.Width - 30, 350);
            e.Graphics.DrawString($"Operation Name:  {app.Operation.OperationName}", mainFont, Brushes.Black, x, y + 50);
            e.Graphics.DrawString($"Doctor Name:  {fullname}", mainFont, Brushes.Black, x, y + 80);


            sb = checkLength(text);

            if (type.Equals("DISCHARGED",StringComparison.OrdinalIgnoreCase))
            {

                e.Graphics.DrawLine(Pens.Black, 60, y + 120, this.Width - 60, y + 120);
                e.Graphics.DrawString($"Successfully {type}.", mainFont, Brushes.Black, x, y + 140);
                e.Graphics.DrawRectangle(Pens.Black, 30, y - 10, this.Width - 30, 200);
                e.Graphics.DrawString("Status: Discharged", mainFont, Brushes.Black, 620, y);


                size1 = graphics.MeasureString($"Dr: {doctorFullName}", mainFont);
                e.Graphics.DrawLine(Pens.Black, 500, 800, 700, 800);
                e.Graphics.DrawString($"Dr: {doctorFullName}", mainFont, Brushes.Black, 670-size1.Width, 820);

                size1 = graphics.MeasureString($"Signature", mainFont);
                e.Graphics.DrawString($"Signature", mainFont, Brushes.Black, 600 - size1.Width + 40, 850);
            }
            else
            {
                e.Graphics.DrawRectangle(Pens.Black, 30, y - 10, this.Width - 30, 350);
                e.Graphics.DrawLine(Pens.Black, 60, y + 120, this.Width - 60, y + 120);
                e.Graphics.DrawString($"Doctor's {type}:", mainFont, Brushes.Black, x, y + 130);
                e.Graphics.DrawString(sb.ToString(), new Font("Arial", 11), brush, x + 10, y + 155);
                e.Graphics.DrawString("Status: " + app.Status, mainFont, Brushes.Black, 620, y);
            }


            size1 = graphics.MeasureString("Start Appointment:", mainFont);
            e.Graphics.DrawString($"Start Appointment", mainFont, Brushes.Black, 600 - size1.Width, y + 40);

            size1 = graphics.MeasureString($"{app.StartTime.ToString("yyyy-MM-dd")}", mainFont);
            e.Graphics.DrawString($"{app.StartTime.ToString("yyyy-MM-dd")}", mainFont, Brushes.Black, 580 - size1.Width, y + 60);

            size1 = graphics.MeasureString($"{app.StartTime.ToString("hh:mm:ss tt")}", mainFont);
            e.Graphics.DrawString($"{app.StartTime.ToString("hh:mm:ss tt")}", mainFont, Brushes.Black, 585 - size1.Width, y + 80);

            size1 = graphics.MeasureString("End Appointment", mainFont);
            e.Graphics.DrawString($"End Appointment", mainFont, Brushes.Black, 800 - size1.Width, y + 40);

            size1 = graphics.MeasureString($"{app.StartTime.ToString("yyyy-MM-dd")}", mainFont);
            e.Graphics.DrawString($"{app.EndTime.ToString("yyyy-MM-dd")}", mainFont, Brushes.Black, 780 - size1.Width, y + 60);

            size1 = graphics.MeasureString($"{app.StartTime.ToString("hh:mm:ss tt")}", mainFont);
            e.Graphics.DrawString($"{app.EndTime.ToString("hh:mm:ss tt")}", mainFont, Brushes.Black, 785 - size1.Width, y + 80);

            e.Graphics.DrawString("o", new Font("Sans-serif", 9), Brushes.Black, 600, y + 60);
            e.Graphics.DrawString("o", new Font("Sans-serif", 9), Brushes.Black, 610, y + 60);
            e.Graphics.DrawString("o", new Font("Sans-serif", 9), Brushes.Black, 620, y + 60);
            e.Graphics.DrawString("o", new Font("Sans-serif", 9), Brushes.Black, 630, y + 60);
            e.Graphics.DrawString("o", new Font("Sans-serif", 9), Brushes.Black, 640, y + 60);
            e.Graphics.DrawString("o", new Font("Sans-serif", 9), Brushes.Black, 650, y + 60);
        }
    }
}
