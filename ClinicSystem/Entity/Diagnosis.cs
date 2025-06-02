using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSystem.Entity
{
    public class Diagnosis
    {

        private int appointmentno,diagnosisno;
        private string diagnosis;
        private DateTime diagnosisdate;

        public Diagnosis(int appointmentno, string diagnosis, DateTime diagnosisdate)
        {
            this.appointmentno = appointmentno;
            this.diagnosis = diagnosis;
            this.diagnosisdate = diagnosisdate;
        }
        public Diagnosis(int diagnosisno, int appointmentno, string diagnosis, DateTime diagnosisdate)
        {
            this.diagnosisno = diagnosisno;
            this.appointmentno = appointmentno;
            this.diagnosis = diagnosis;
            this.diagnosisdate = diagnosisdate;
        }

        public int Appointmentno { get => appointmentno; set => appointmentno = value; }
        public string dd { get => diagnosis; set => diagnosis = value; }
        public DateTime Diagnosisdate { get => diagnosisdate; set => diagnosisdate = value; }
        public int Diagnosisno { get => diagnosisno; set => diagnosisno = value; }
    }
}
