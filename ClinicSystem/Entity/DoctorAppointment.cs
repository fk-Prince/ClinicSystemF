using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicSystem.Entity
{
    public class DoctorAppointment
    {

      
        private int totalAppointments;
        private int totalPatient;
        private double totalRevenue;

        private Doctor doctor;
        private TimeSpan startTime;
        private TimeSpan endTime;
        private int totalAppointmentToday;

        public DoctorAppointment(Doctor doctor, int totalPatient, int totalAppointments, double totalRevenue)
        {
            this.doctor = doctor;
            this.totalPatient = totalPatient;
            this.totalAppointments = totalAppointments;
            this.totalRevenue = totalRevenue;
        }

        public DoctorAppointment(Doctor doctor, TimeSpan startTime, TimeSpan endTime)
        {
            this.doctor = doctor;
            this.startTime = startTime;
            this.endTime = endTime;

        }

        public Doctor Doctor { get => doctor;  }
        public int TotalAppointments { get => totalAppointments; }
        public int TotalPatient { get => totalPatient;  }
        public double TotalRevenue { get => totalRevenue; }
        public TimeSpan StartTime { get => startTime;  }
        public TimeSpan EndTime { get => endTime; }
  
    }
}
