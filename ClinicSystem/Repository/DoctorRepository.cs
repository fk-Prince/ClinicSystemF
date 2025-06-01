using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using ClinicSystem;
using ClinicSystem.Entity;
using ClinicSystem.Helpers;
using ClinicSystem.PatientForm;
using ClinicSystem.Repository;
using ClinicSystem.UserLoginForm;
using MySql.Data.MySqlClient;

namespace DoctorClinic
{
    public class DoctorRepository
    {

        public List<Doctor> getAvailableDoctors(Operation operaiton)
        {
            List<Doctor> availableDoctors = new List<Doctor>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
                {
                    conn.Open();
                    string query = @"
                                SELECT * FROM patientappointment_tbl
                                LEFT JOIN doctor_tbl ON doctor_tbl.doctorid = patientappointment_tbl.doctorid
                                LEFT JOIN operation_tbl ON operation_tbl.operationcode = patientappointment_tbl.OperationCode
                                LEFT JOIN patient_tbl ON patient_tbl.patientid = patientappointment_tbl.patientid
                                LEFT JOIN appointmentdetails_tbl ON appointmentdetails_tbl.AppointmentDetailNo = patientappointment_tbl.AppointmentDetailNo
                                WHERE patientappointment_tbl.StartSchedule BETWEEN @Start AND @End AND Status = 'Upcoming' AND EndSchedule > Now()
                                AND patientappointment_tbl.doctorid = @doctorid";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
           
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                availableDoctors.Add(EntityMapping.GetDoctor(reader));
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error on getTodayAppointmentByDoctor() db" + ex.Message);
            }
            return availableDoctors;
        }

        public List<Appointment> getTodayAppointmentByDoctor(string doctorid)
        {
            List<Appointment> todayAppointment = new List<Appointment>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
                {
                    conn.Open();
                    string query = @"
                              SELECT * FROM appointmentRecord_tbl
                                 LEFT JOIN patientappointment_tbl ON appointmentRecord_tbl.AppointmentRecordNo = patientappointment_tbl.AppointmentRecordNo
                                 INNER JOIN discount_tbl ON discount_tbl.DiscountType = appointmentRecord_tbl.DiscountType
                                 LEFT JOIN patient_tbl ON patient_tbl.patientid = appointmentRecord_tbl.patientid
                                 LEFT JOIN doctor_tbl ON doctor_tbl.doctorId = patientappointment_tbl.doctorId
                                 LEFT JOIN operation_tbl ON operation_tbl.operationCode = patientappointment_tbl.OperationCode
                                 LEFT JOIN appointmentdetails_tbl ON appointmentdetails_tbl.AppointmentDetailNo = patientappointment_tbl.AppointmentDetailNo
                                 LEFT JOIN (
                                  SELECT *
                                  FROM prescription_tbl
                                  LIMIT 1
                                ) as p ON p.AppointmentDetailNo = patientappointment_tbl.AppointmentDetailNo
                                LEFT JOIN (
                                  SELECT *
                                  FROM diagnosis_tbl
                                  LIMIT 1
                                ) d ON d.AppointmentDetailNo = patientappointment_tbl.AppointmentDetailNo
                                WHERE patientappointment_tbl.StartSchedule BETWEEN @Start AND @End AND Status = 'Upcoming' AND EndSchedule > Now()
                                AND patientappointment_tbl.doctorid = @doctorid";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Start", DateTime.Now.ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@End", DateTime.Now.AddDays(1).ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@doctorid", doctorid);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                todayAppointment.Add(EntityMapping.GetAppointment(reader));
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error on getTodayAppointmentByDoctor() db" + ex.Message);
            }
            return todayAppointment;
        }

        public Dictionary<Doctor, Operation> getDoctorOperations()
        {
            Dictionary <Doctor, Operation> doctorOperation = new Dictionary<Doctor, Operation>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
                {
                    conn.Open();
                    string query = @"SELECT * FROM doctor_operation_mm_tbl
                        LEFT JOIN doctor_tbl ON doctor_operation_mm_tbl.DoctorID = doctor_tbl.DoctorID  
                        LEFT JOIN operation_tbl ON doctor_operation_mm_tbl.OperationCode = operation_tbl.OperationCode
                        ";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Doctor d = EntityMapping.GetDoctorWithImage(reader);
                                Operation o = EntityMapping.GetOperation(reader);
                                doctorOperation.Add(d, o);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error on getDoctorOperation() db" + ex.Message);   
            }
            return doctorOperation;
        }
        public List<Appointment> getPatientByDoctor(string doctorID)
        {
            List<Appointment> appointments = new List<Appointment>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
                {
                    conn.Open();
                    string query = @"
                         SELECT * FROM appointmentRecord_tbl
                         LEFT JOIN patientappointment_tbl ON appointmentRecord_tbl.AppointmentRecordNo = patientappointment_tbl.AppointmentRecordNo
                         INNER JOIN discount_tbl ON discount_tbl.DiscountType = appointmentRecord_tbl.DiscountType
                         LEFT JOIN patient_tbl ON patient_tbl.patientid = appointmentRecord_tbl.patientid
                         LEFT JOIN doctor_tbl ON doctor_tbl.doctorId = patientappointment_tbl.doctorId
                         LEFT JOIN operation_tbl ON operation_tbl.operationCode = patientappointment_tbl.OperationCode
                         LEFT JOIN appointmentdetails_tbl ON appointmentdetails_tbl.AppointmentDetailNo = patientappointment_tbl.AppointmentDetailNo
                         LEFT JOIN prescription_tbl ON prescription_tbl.appointmentdetailNo = appointmentdetails_tbl.AppointmentDetailNo
                         LEFT JOIN diagnosis_tbl ON appointmentdetails_tbl.appointmentdetailNo = diagnosis_tbl.AppointmentDetailNo
                         WHERE patientappointment_tbl.DoctorId = @DoctorID
                         ORDER BY patientappointment_tbl.appointmentdetailno ASC";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("DoctorID", doctorID);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                appointments.Add(EntityMapping.GetAppointmentByDoctor(reader));
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error from getPati ents() DB" + ex.Message);
            }
            return appointments;
        }
        public bool setDiagnosis(Appointment updatedSchedule)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
                {
                    conn.Open();
                    string query = @"UPDATE appointmentdetails_tbl 
                                 SET `Diagnosis` = @Diagnosis, `Prescription` = @Prescription
                                WHERE AppointmentDetailNo = @AppointmentDetailNo";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Diagnosis", updatedSchedule.Diagnosis);
                        command.Parameters.AddWithValue("@AppointmentDetailNo", updatedSchedule.AppointmentDetailNo);
                        //command.Parameters.AddWithValue("@Prescription", updatedSchedule.Prescription);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error from updateSchedule() DB" + ex.Message);
            }
            return false;
        }
        public List<Doctor> getDoctors()
        {
            List<Doctor> doctorList = new List<Doctor>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand("SELECT * FROM doctor_tbl", conn))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Doctor doctor = EntityMapping.GetDoctorWithImage(reader);
                                doctorList.Add(doctor);
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error on getDoctors() db" + ex.Message);
            }
            return doctorList;
        }
        public List<Doctor> getDoctorsByOperation(Operation operation)
        {
            List<Doctor> doctorList = new List<Doctor>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
                {
                    conn.Open();
                    string query = @"
                        SELECT *, doctor_tbl.* FROM doctor_operation_mm_tbl
                        LEFT JOIN doctor_tbl 
                        ON doctor_operation_mm_tbl.DoctorID = doctor_tbl.DoctorID
                        WHERE operationcode = @operationcode AND doctor_tbl.Active = 'Yes' 
                        ";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@operationcode", operation.OperationCode);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Doctor doctor = EntityMapping.GetDoctor(reader);
                                doctorList.Add(doctor);
                            }
                        }
                    }
                }
            }
            catch (MySqlException e)
            {
                MessageBox.Show("Error from getDoctors DB" + e.Message);
            }
            return doctorList;
        }
        public bool AddDoctor(Doctor doctor)
        {
            try
            {

                using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
                {
                    conn.Open();


                    string query = @"INSERT INTO doctor_tbl 
                    (DoctorID, doctorFirstName, doctorMiddleName, doctorLastName, doctorAge, Pin, doctorDateHired, 
                        doctorGender, doctorAddress, doctorcontactnumber, doctorImage, doctorRFID) 
                 VALUES 
                    (@DoctorID, @doctorFirstName, @doctorMiddleName, @doctorLastName, @doctorAge, @Pin, @doctorDateHired,
                        @doctorGender, @doctorAddress, @doctorcontactnumber, @doctorImage, @doctorRFID)";

                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@DoctorID", doctor.DoctorID);
                        command.Parameters.AddWithValue("@doctorFirstName", doctor.DoctorFirstName);
                        command.Parameters.AddWithValue("@doctorMiddleName", doctor.DoctorMiddleName);
                        command.Parameters.AddWithValue("@doctorLastName", doctor.DoctorLastName);
                        command.Parameters.AddWithValue("@doctorAge", doctor.DoctorAge);
                        command.Parameters.AddWithValue("@doctorDateHired", doctor.DateHired);
                        command.Parameters.AddWithValue("@doctorGender", doctor.Gender);
                        command.Parameters.AddWithValue("@doctorAddress", doctor.DoctorAddress);
                        command.Parameters.AddWithValue("@doctorcontactnumber", doctor.DoctorContactNumber);
                        if (doctor.DoctorRFID.Length == 0)
                        {
                            command.Parameters.AddWithValue("@doctorRFID", DBNull.Value);
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@doctorRFID", doctor.DoctorRFID);
                        }
                        command.Parameters.AddWithValue("@Pin", doctor.Pin);

                        if (doctor.Image != null)
                        {
                            MemoryStream ms = new MemoryStream();
                            doctor.Image.Save(ms, doctor.Image.RawFormat);
                            byte[] doctorImage = ms.ToArray();
                            command.Parameters.Add("@doctorImage", MySqlDbType.LongBlob).Value = doctorImage;
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@doctorImage", DBNull.Value);
                        }
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error on AddDoctor() db: " + ex.Message );
            }
            catch (IOException ex)
            {
                MessageBox.Show("Error on AddDoctor() IO: " + ex.Message);
            }
            
            return false;
        }   
        public string getDoctorLastID()
        {       
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
                {
                    conn.Open();
                    string query = "SELECT doctorid FROM doctor_tbl ORDER BY doctorid DESC LIMIT 1";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            

                            return reader.Read()
                                    ? "D" + DateTime.Now.ToString("yyyy") + "-" + checkID(reader.GetString("doctorID"))
                                    : "D" + DateTime.Now.ToString("yyyy") + "-000001";
                            
                        }
                    }

                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error on getDoctorLastID() db" + ex.Message);
            }
            return "ERROR ON DATABASE PLEASE TRY AGAIN";
        }
        public string checkID(string n)
        {
            int number = int.Parse(n.Substring(6)) + 1;
            if (number < 1000000) return number.ToString("D6");
            else return number.ToString();
        }
        public Doctor doctorLogin(string doctorid, string pin)
        {

            try
            {
                using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
                {
                    conn.Open();
                    string query = "SELECT * FROM doctor_tbl WHERE PIN = @PIN AND DOCTORID = @DOCTORID";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@DOCTORID", doctorid);
                        command.Parameters.AddWithValue("@PIN", pin);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                Image doctorImage;
                                if (!reader.IsDBNull(reader.GetOrdinal("doctorImage")))
                                {
                                    byte[] imageBytes = (byte[])reader["doctorImage"];
                                    MemoryStream ms = new MemoryStream(imageBytes);
                                    doctorImage = Image.FromStream(ms);
                                }
                                else
                                {
                                    doctorImage = null;
                                }
                                Doctor doctor = EntityMapping.GetDoctorWithImage(reader);
                                return doctor;
                            }
                        }
                    }
                }
            } catch (MySqlException ex)
            {
                MessageBox.Show("Error on doctorLogin() db" + ex.Message);
            }
            return null;
        }
        public Doctor doctorScanned(string rfid)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
                {
                    conn.Open();
                    string query = "SELECT * FROM doctor_tbl WHERE doctorRFID = @doctorRFID LIMIT 1";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@doctorRFID", rfid);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            { 
                                Doctor doctor = EntityMapping.GetDoctorWithImage(reader);
                                return doctor;
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error on doctorLogin() db" + ex.Message);
            }
            return null;
        }
        public bool setPatientDischarged(int appointmentDetailNo)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
                {
                    conn.Open();
                    string query = "UPDATE patientappointment_tbl SET Status = 'Discharged' WHERE AppointmentDetailNo = @AppointmentDetailNo";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@AppointmentDetailNo", appointmentDetailNo);
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error on setComplete() db" + ex.Message);
            }
            return false;
        }
        public void updateDoctorStatus(string doctorID, string active)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
                {
                    conn.Open();
                    string query =
                        "UPDATE doctor_tbl SET Active = @Active WHERE doctorid = @doctorid";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@Active", active);
                        command.Parameters.AddWithValue("@doctorId", doctorID);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR FROM insertSpecialized() DB " + ex.Message);
            }
        }

        internal List<DoctorAppointment> getDoctorAvailable(DateTime value)
        {

            List<DoctorAppointment> list = new List<DoctorAppointment>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
                {
                    conn.Open();
                    string query = availableQ();
                    //string query = @"
                    //    SELECT 
                    //        d.*,
                    //        CASE 
                    //            WHEN MIN(a.StartSchedule) IS NULL THEN 
                    //                CASE 
                    //                    WHEN DATE(@Date) = CURDATE() AND CURTIME() < '09:00:00' THEN '09:00:00'
                    //                    WHEN DATE(@Date) = CURDATE() AND CURTIME() >= '09:00:00' THEN CURTIME()  
                    //                    ELSE '09:00:00'
                    //                END
                    //            WHEN TIME(MIN(a.StartSchedule)) > 
                    //                CASE 
                    //                    WHEN DATE(@Date) = CURDATE() AND CURTIME() < '09:00:00' THEN '09:00:00'
                    //                    WHEN DATE(@Date) = CURDATE() AND CURTIME() >= '09:00:00' THEN CURTIME()
                    //                    ELSE '09:00:00'
                    //                END 
                    //            THEN 
                    //                CASE 
                    //                    WHEN DATE(@Date) = CURDATE() AND CURTIME() < '09:00:00' THEN '09:00:00'
                    //                    WHEN DATE(@Date) = CURDATE() AND CURTIME() >= '09:00:00' THEN CURTIME()
                    //                    ELSE '09:00:00'
                    //                END
                    //            ELSE 
                    //                CASE 
                    //                    WHEN DATE(@Date) = CURDATE() AND CURTIME() > TIME(MAX(a.EndSchedule)) THEN 
                    //                        CASE 
                    //                            WHEN CURTIME() < '09:00:00' THEN '09:00:00'
                    //                            ELSE CURTIME()
                    //                        END
                    //                    ELSE TIME(MAX(a.EndSchedule))
                    //                END
                    //        END as Available_From,
                    //        CASE 
                    //            WHEN MIN(a.StartSchedule) IS NULL THEN '21:00:00'
                    //            WHEN TIME(MIN(a.StartSchedule)) > 
                    //                CASE 
                    //                    WHEN DATE(@Date) = CURDATE() AND CURTIME() < '09:00:00' THEN '09:00:00'
                    //                    WHEN DATE(@Date) = CURDATE() AND CURTIME() >= '09:00:00' THEN CURTIME()
                    //                    ELSE '09:00:00'
                    //                END 
                    //            THEN TIME(MIN(a.StartSchedule))
                    //            ELSE '21:00:00'
                    //        END as Available_Until,
                    //        COUNT(a.AppointmentDetailNo) as todayCount
                    //    FROM doctor_tbl d
                    //    LEFT JOIN patientappointment_tbl a ON d.DoctorId = a.DoctorID
                    //        AND DATE(a.StartSchedule) = DATE(@Date)
                    //        AND (a.Status = 'Upcoming' OR a.Status = 'Reappointment')
                    //    WHERE d.Active = 'Yes'
                    //    GROUP BY d.DoctorId
                    //    ORDER BY d.DoctorId
                    //    ";

                    using (MySqlCommand command = new MySqlCommand(query,conn))
                    {
                        command.Parameters.AddWithValue("@Date", value.Date);
                        using(MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                list.Add(EntityMapping.GetAvailableDoctor(reader));
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("ERROR FROM insertSpecialized() DB " + ex.Message);
            }
            return list;
        }
        private string availableQ()
        {
            return @"
                 WITH doctor_base AS (
                        SELECT * 
                        FROM doctor_tbl 
                        WHERE Active = 'Yes'
                    ),
                    appointments AS (
                        SELECT 
                            DoctorID,
                            TIME(StartSchedule) AS StartTime,
                            TIME(EndSchedule) AS EndTime
                        FROM patientappointment_tbl
                        WHERE DATE(StartSchedule) = @Date
                          AND (Status = 'Upcoming' OR Status = 'Reappointment')
                    ),
                    first_appointment AS (
                        SELECT 
                            DoctorID,
                            MIN(StartTime) AS FirstStartTime
                        FROM appointments
                        GROUP BY DoctorID
                    ),
                    last_appointment AS (
                        SELECT 
                            DoctorID,
                            MAX(EndTime) AS LastEndTime     
                        FROM appointments
                        GROUP BY DoctorID
                    ),
                    base_start_time AS (
                        SELECT 
                            CASE 
                                WHEN @Date = CURDATE() AND CURTIME() > TIME('09:00:00') THEN CURTIME()
                                ELSE TIME('09:00:00')
                            END AS BaseStartTime
                    ),
                    before_gap AS (
                        SELECT 
                            db.*,
                            bst.BaseStartTime AS Available_From,
                            fa.FirstStartTime AS Available_Until
                        FROM doctor_base db
                        JOIN first_appointment fa ON db.DoctorID = fa.DoctorID
                        CROSS JOIN base_start_time bst
                        WHERE fa.FirstStartTime > bst.BaseStartTime
                    ),
                    inbetween_gaps AS (
                        SELECT 
                            db.*,
                            a1.EndTime AS Available_From,
                            a2.StartTime AS Available_Until
                        FROM appointments a1
                        JOIN appointments a2 
                            ON a1.DoctorID = a2.DoctorID AND a1.EndTime < a2.StartTime
                        JOIN doctor_base db ON db.DoctorID = a1.DoctorID
                        CROSS JOIN base_start_time bst
                        WHERE NOT EXISTS (
                            SELECT 1 FROM appointments ax
                            WHERE ax.DoctorID = a1.DoctorID
                              AND ax.StartTime > a1.EndTime
                              AND ax.StartTime < a2.StartTime
                        )
                        AND a1.EndTime >= bst.BaseStartTime
                    ),
                    after_gap AS (
                        SELECT 
                            db.*,
                            GREATEST(bst.BaseStartTime, la.LastEndTime) AS Available_From,
                            TIME('21:00:00') AS Available_Until
                        FROM doctor_base db
                        JOIN last_appointment la ON db.DoctorID = la.DoctorID
                        CROSS JOIN base_start_time bst
                        WHERE GREATEST(bst.BaseStartTime, la.LastEndTime) < TIME('21:00:00')
                    ),
                    no_appointments AS (
                        SELECT 
                            db.*,
                            bst.BaseStartTime AS Available_From,
                            TIME('21:00:00') AS Available_Until
                        FROM doctor_base db
                        CROSS JOIN base_start_time bst
                        WHERE NOT EXISTS (
                            SELECT 1 FROM appointments a WHERE a.DoctorID = db.DoctorID
                        )
                        AND bst.BaseStartTime < TIME('21:00:00')
                    ),
                    early_availability AS (
                        SELECT 
                            db.*,
                            TIME('09:00:00') AS Available_From,
                            bst.BaseStartTime AS Available_Until
                        FROM doctor_base db
                        CROSS JOIN base_start_time bst
                        WHERE @Date != CURDATE() 
                          AND bst.BaseStartTime > TIME('09:00:00')
                          AND EXISTS (SELECT 1 FROM appointments a WHERE a.DoctorID = db.DoctorID) 
                    )
                    SELECT * FROM before_gap
                    UNION ALL
                    SELECT * FROM inbetween_gaps
                    UNION ALL
                    SELECT * FROM after_gap
                    UNION ALL
                    SELECT * FROM no_appointments
                    UNION ALL
                    SELECT * FROM early_availability
                    ORDER BY DoctorID, Available_From;

                    ";
        }

        internal bool insertNewPrescription(string pr, int appointmentDetailNo)
        {
           try
            {
                string query = @"
                            INSERT INTO prescription_tbl (appointmentdetailno, prescription, prescriptiondate) 
                            VALUES  (@appointmentdetailno, @prescription, @prescriptiondate)";
                using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@appointmentdetailno", appointmentDetailNo);
                        command.Parameters.AddWithValue("@prescription", pr);
                        command.Parameters.AddWithValue("@prescriptiondate", DateTime.Now);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error on insertNewPrescription() db: " + ex.Message);
            }
            return false;
        }

        internal bool insertNewDiagnosis(string pr, int appointmentDetailNo)
        {
            try
            {
                string query = @"
                            INSERT INTO diagnosis_tbl (appointmentdetailno, diagnosis, diagnosisdate) 
                            VALUES  (@appointmentdetailno, @diagnosis, @diagnosisdate)";
                using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
                {
                    conn.Open();
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@appointmentdetailno", appointmentDetailNo);
                        command.Parameters.AddWithValue("@diagnosis", pr);
                        command.Parameters.AddWithValue("@diagnosisdate", DateTime.Now);
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error on insetNewDiagnosis() db: " + ex.Message);
            }
            return false;
        }

        internal List<Appointment> getSharedAppointmentByDoctor(string doctorID)
        {
            List<Appointment> appointments = new List<Appointment>();
            try
            {
                using (MySqlConnection conn = new MySqlConnection(DatabaseConnection.getConnection()))
                {
                    conn.Open();
                    string query = @"
                        SELECT * FROM appointmentRecord_tbl
                         LEFT JOIN patientappointment_tbl ON appointmentRecord_tbl.AppointmentRecordNo = patientappointment_tbl.AppointmentRecordNo
                         INNER JOIN discount_tbl ON discount_tbl.DiscountType = appointmentRecord_tbl.DiscountType
                         LEFT JOIN patient_tbl ON patient_tbl.patientid = appointmentRecord_tbl.patientid
                         LEFT JOIN doctor_tbl ON doctor_tbl.doctorId = patientappointment_tbl.doctorId
                         LEFT JOIN operation_tbl ON operation_tbl.operationCode = patientappointment_tbl.OperationCode
                         LEFT JOIN appointmentdetails_tbl ON appointmentdetails_tbl.AppointmentDetailNo = patientappointment_tbl.AppointmentDetailNo
                          LEFT JOIN (
                          SELECT *
                          FROM prescription_tbl
                          LIMIT 1
                        ) as p ON p.AppointmentDetailNo = patientappointment_tbl.AppointmentDetailNo
                        LEFT JOIN (
                          SELECT *
                          FROM diagnosis_tbl
                          LIMIT 1
                        ) d ON d.AppointmentDetailNo = patientappointment_tbl.AppointmentDetailNo
                         LEFT JOIN sharedappointment_tbl ON sharedappointment_tbl.sharedappointmentno = appointmentdetails_tbl.appointmentdetailNo
                         WHERE sharedappointment_tbl.sharedDoctorId = @doctorid AND sharedappointment_tbl.Status = 'Allowed'
                         ORDER BY patientappointment_tbl.appointmentdetailno ASC";
                    using (MySqlCommand command = new MySqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@DoctorID", doctorID);
                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                appointments.Add(EntityMapping.GetAppointmentByDoctor(reader));
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error from getPati ents() DB" + ex.Message);
            }
            return appointments;
        }
    }
}
