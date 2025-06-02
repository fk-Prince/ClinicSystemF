using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSystem.Entity
{
    public class Prescription
    {
        private int appointmentno,prescriptionNo;
        private string prescription;
        private DateTime date;

        public Prescription(int appointmentno, string prescription, DateTime date)
        {
            this.appointmentno = appointmentno;
            this.prescription = prescription;
            this.date = date;
        }

        public Prescription(int prescriptionNo, int appointmentno, string prescription, DateTime date)
        {
            this.prescriptionNo = prescriptionNo;
            this.appointmentno = appointmentno;
            this.prescription = prescription;
            this.date = date;
        }

        public int Appointmentno { get => appointmentno; set => appointmentno = value; }
        public string pp { get => prescription; set => prescription = value; }
        public DateTime Date { get => date; set => date = value; }
        public int PrescriptionNo { get => prescriptionNo; set => prescriptionNo = value; }
    }
}
