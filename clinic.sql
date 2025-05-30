-- MySQL dump 10.13  Distrib 8.0.41, for Win64 (x86_64)
--
-- Host: localhost    Database: clinic
-- ------------------------------------------------------
-- Server version	8.0.41

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `appointmentdetails_tbl`
--

DROP DATABASE IF EXISTS clinic;
CREATE DATABASE clinic;
USE clinic;
DROP TABLE IF EXISTS `appointmentdetails_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `appointmentdetails_tbl` (
  `AppointmentDetailNo` bigint NOT NULL,
  `diagnosis` varchar(200) DEFAULT NULL,
  `Prescription` varchar(200) DEFAULT NULL,
  `subtotal` decimal(10,2) NOT NULL,
  `TotalWithDiscount` decimal(10,2) NOT NULL,
  PRIMARY KEY (`AppointmentDetailNo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appointmentdetails_tbl`
--

LOCK TABLES `appointmentdetails_tbl` WRITE;
/*!40000 ALTER TABLE `appointmentdetails_tbl` DISABLE KEYS */;
INSERT INTO `appointmentdetails_tbl` VALUES (1,NULL,NULL,1000.00,700.00),(2,NULL,NULL,1800.00,1260.00),(3,NULL,NULL,1500.00,1200.00),(4,NULL,NULL,1500.00,1200.00),(5,NULL,NULL,1500.00,1200.00),(6,NULL,NULL,2200.00,2200.00),(7,NULL,NULL,3500.00,2800.00),(8,NULL,NULL,3000.00,2100.00),(9,NULL,NULL,2200.00,2200.00),(10,NULL,NULL,1500.00,1200.00),(11,NULL,NULL,2500.00,1750.00),(12,NULL,NULL,1200.00,1200.00),(13,NULL,NULL,2200.00,1760.00),(14,NULL,NULL,1000.00,1000.00),(15,NULL,NULL,2200.00,2200.00),(16,NULL,NULL,2000.00,2000.00);
/*!40000 ALTER TABLE `appointmentdetails_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `appointmentpenalty_tbl`
--

DROP TABLE IF EXISTS `appointmentpenalty_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `appointmentpenalty_tbl` (
  `AppointmentDetailNo` bigint NOT NULL,
  `PenaltyType` varchar(45) NOT NULL,
  `Amount` decimal(10,2) NOT NULL,
  `Reason` varchar(100) NOT NULL,
  `DateIssued` datetime NOT NULL,
  KEY `fk_idx` (`AppointmentDetailNo`),
  CONSTRAINT `fk` FOREIGN KEY (`AppointmentDetailNo`) REFERENCES `appointmentdetails_tbl` (`AppointmentDetailNo`) ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb3;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appointmentpenalty_tbl`
--

LOCK TABLES `appointmentpenalty_tbl` WRITE;
/*!40000 ALTER TABLE `appointmentpenalty_tbl` DISABLE KEYS */;
/*!40000 ALTER TABLE `appointmentpenalty_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `appointmentrecord_tbl`
--

DROP TABLE IF EXISTS `appointmentrecord_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `appointmentrecord_tbl` (
  `AppointmentRecordNo` bigint NOT NULL AUTO_INCREMENT,
  `patientid` varchar(100) NOT NULL,
  `staffid` bigint NOT NULL,
  `DiscountType` varchar(100) NOT NULL,
  `BookingDate` datetime NOT NULL,
  PRIMARY KEY (`AppointmentRecordNo`),
  KEY `a_idx` (`patientid`),
  KEY `b_idx` (`staffid`),
  KEY `asd_idx` (`DiscountType`),
  CONSTRAINT `b` FOREIGN KEY (`staffid`) REFERENCES `staff_tbl` (`StaffID`) ON UPDATE CASCADE,
  CONSTRAINT `dad` FOREIGN KEY (`DiscountType`) REFERENCES `discount_tbl` (`DiscountType`) ON UPDATE CASCADE,
  CONSTRAINT `PAITNETID` FOREIGN KEY (`patientid`) REFERENCES `patient_tbl` (`patientId`)
) ENGINE=InnoDB AUTO_INCREMENT=13 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `appointmentrecord_tbl`
--

LOCK TABLES `appointmentrecord_tbl` WRITE;
/*!40000 ALTER TABLE `appointmentrecord_tbl` DISABLE KEYS */;
INSERT INTO `appointmentrecord_tbl` VALUES (1,'P2025-000001',2,'PWD','2025-04-14 15:04:17'),(2,'P2025-000002',2,'PagIbig','2025-04-15 15:07:17'),(3,'P2025-000003',2,'No Discount','2025-05-25 15:08:48'),(4,'P2025-000004',2,'PagIbig','2025-05-25 15:10:07'),(5,'P2025-000005',2,'PWD','2025-05-25 15:11:10'),(6,'P2025-000006',2,'No Discount','2025-05-25 15:12:30'),(7,'P2025-000006',2,'PhilHealth ','2025-05-25 15:12:49'),(8,'P2025-000003',2,'PWD','2025-05-25 15:13:38'),(9,'P2025-000005',2,'No Discount','2025-05-25 15:20:00'),(10,'P2025-000006',2,'PagIbig','2025-05-30 17:55:17'),(11,'P2025-000007',2,'No Discount','2025-05-30 17:56:14'),(12,'P2025-000004',2,'No Discount','2025-05-30 18:20:30');
/*!40000 ALTER TABLE `appointmentrecord_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `discount_tbl`
--

DROP TABLE IF EXISTS `discount_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `discount_tbl` (
  `DiscountType` varchar(100) NOT NULL,
  `DiscountRate` decimal(4,3) NOT NULL,
  `DiscountDescription` varchar(200) NOT NULL,
  PRIMARY KEY (`DiscountType`),
  CONSTRAINT `discount_tbl_chk_1` CHECK ((`discountRate` < 1))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `discount_tbl`
--

LOCK TABLES `discount_tbl` WRITE;
/*!40000 ALTER TABLE `discount_tbl` DISABLE KEYS */;
INSERT INTO `discount_tbl` VALUES ('No Discount',0.000,'No Discount'),('PagIbig',0.200,'Pag-Ibig Membership'),('PhilHealth ',0.200,'Healthcare services provided to members of the Philippine Health Insurance Corporation (PhilHealth).'),('PWD',0.300,'Person With Disablities'),('Senior Citizen',0.400,'Senior Citizen 65 AGE ABOVE');
/*!40000 ALTER TABLE `discount_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `doctor_operation_mm_tbl`
--

DROP TABLE IF EXISTS `doctor_operation_mm_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `doctor_operation_mm_tbl` (
  `operationCode` varchar(10) NOT NULL,
  `doctorId` varchar(50) NOT NULL,
  KEY `fk_doctorid` (`doctorId`),
  KEY `fk_opera_idx` (`operationCode`),
  CONSTRAINT `fk_doctorid` FOREIGN KEY (`doctorId`) REFERENCES `doctor_tbl` (`DoctorId`) ON DELETE RESTRICT ON UPDATE CASCADE,
  CONSTRAINT `fk_opera` FOREIGN KEY (`operationCode`) REFERENCES `operation_tbl` (`operationCode`) ON DELETE RESTRICT ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doctor_operation_mm_tbl`
--

LOCK TABLES `doctor_operation_mm_tbl` WRITE;
/*!40000 ALTER TABLE `doctor_operation_mm_tbl` DISABLE KEYS */;
INSERT INTO `doctor_operation_mm_tbl` VALUES ('CK101','D2025-000001'),('EE101','D2025-000002'),('DC100','D2025-000003'),('MSB1001','D2025-000004'),('MWD102','D2025-000004'),('RCT101','D2025-000005'),('UA501','D2025-000006'),('XR301','D2025-000007'),('VCT102','D2025-000009'),('MSB1001','D2025-000001'),('MWD102','D2025-000001'),('VCT102','D2025-000002'),('XR301','D2025-000002'),('UA501','D2025-000003'),('BP102','D2025-000003'),('CK101','D2025-000004'),('BT101','D2025-000005'),('DC100','D2025-000006'),('CK101','D2025-000006'),('MSB1001','D2025-000007'),('RCT101','D2025-000007'),('MWD102','D2025-000009'),('BP102','D2025-000001');
/*!40000 ALTER TABLE `doctor_operation_mm_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `doctor_tbl`
--

DROP TABLE IF EXISTS `doctor_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `doctor_tbl` (
  `DoctorId` varchar(50) NOT NULL,
  `doctorFirstname` varchar(100) NOT NULL,
  `doctorMiddleName` varchar(100) NOT NULL,
  `doctorLastname` varchar(100) NOT NULL,
  `doctorAge` int NOT NULL,
  `PIN` varchar(45) NOT NULL,
  `doctordatehired` date NOT NULL,
  `doctorgender` varchar(100) NOT NULL,
  `doctoraddress` varchar(100) NOT NULL,
  `doctorcontactnumber` varchar(11) NOT NULL,
  `doctorImage` longblob,
  `doctorRFID` bigint DEFAULT NULL,
  `Active` varchar(3) NOT NULL DEFAULT 'Yes',
  PRIMARY KEY (`DoctorId`),
  UNIQUE KEY `doctorRFID_UNIQUE` (`doctorRFID`),
  CONSTRAINT `doctor_tbl_chk_1` CHECK (((length(`doctorcontactnumber`) = 11) and (`doctorcontactnumber` like _utf8mb4'09%'))),
  CONSTRAINT `doctor_tbl_chk_2` CHECK (((`doctorgender` = _utf8mb4'Male') or (`doctorgender` = _utf8mb4'Female'))),
  CONSTRAINT `doctoractive` CHECK (((`Active` = _utf8mb4'Yes') or (`Active` = _utf8mb4'No'))),
  CONSTRAINT `doctoragecheck` CHECK (((`doctorAge` > 18) and (`doctorAge` < 120)))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `doctor_tbl`
--

LOCK TABLES `doctor_tbl` WRITE;
/*!40000 ALTER TABLE `doctor_tbl` DISABLE KEYS */;
INSERT INTO `doctor_tbl` VALUES ('D2025-000001','Julie','Eiluj','Santos',39,'1234','2025-03-15','Female','Makati, Metro Manila','09171234567',NULL,NULL,'No'),('D2025-000002','Rachel','Isabel','Dela Cruz',40,'5678','2025-04-03','Female','Quezon Ave., Quezon City','09281234567',NULL,NULL,'Yes'),('D2025-000003','Aeyc','Luis','Winn',20,'2345','2025-05-10','Male','Matina, Davao City','09361234567',NULL,NULL,'Yes'),('D2025-000004','Rica','Acir','Winn',25,'4321','2025-04-11','Female','Pasig, Metro Manila','09451234567',NULL,NULL,'Yes'),('D2025-000005','Rafael','Leafar','Ababa',22,'2349','2025-04-18','Male','Sampaloc, Manila','09321234567',NULL,NULL,'Yes'),('D2025-000006','Clareynz','June','Masudog',21,'6789','2025-03-30','Male','Mandug, Davao City','09131234567',NULL,NULL,'Yes'),('D2025-000007','Nica','Acin','Espantalion',20,'5679','2025-05-05','Female','Buhangin, Davao City','09421234567',NULL,NULL,'Yes'),('D2025-000009','Joshua','Auhsoj','Bongo',30,'3458','2025-04-25','Male','Roxas Avenue Davao City','09221234567',NULL,NULL,'Yes');
/*!40000 ALTER TABLE `doctor_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `operation_tbl`
--

DROP TABLE IF EXISTS `operation_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `operation_tbl` (
  `operationCode` varchar(10) NOT NULL,
  `operationName` varchar(25) NOT NULL,
  `DateAdded` date NOT NULL,
  `Description` varchar(300) NOT NULL,
  `Price` decimal(12,2) NOT NULL,
  `Duration` time NOT NULL,
  `roomtype` varchar(45) NOT NULL,
  PRIMARY KEY (`operationCode`),
  UNIQUE KEY `operationName_UNIQUE` (`operationName`),
  KEY `roomtype_idx` (`roomtype`),
  CONSTRAINT `roomtyp` FOREIGN KEY (`roomtype`) REFERENCES `roomtype_tbl` (`Roomtype`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `operation_tbl`
--

LOCK TABLES `operation_tbl` WRITE;
/*!40000 ALTER TABLE `operation_tbl` DISABLE KEYS */;
INSERT INTO `operation_tbl` VALUES ('BP102','Blood Pressure','2025-03-16','Routine blood pressure check for hypertension monitoring.',1000.00,'00:30:00','Examination Room'),('BT101','Diagnostic Blood Test','2025-04-10','Blood test for routine health screening and early detection of conditions.',2500.00,'01:00:00','Laboratory Room'),('CK101','Check-Up','2025-04-05','General health assessment including blood pressure and heart rate checks.',1500.00,'01:30:00','Examination Room'),('DC100','Dental Cleaning','2025-04-30','Cleaning of teeth, removal of plaque, tartar, and stains.',2000.00,'01:45:00','Dental Room'),('EE101','Eye Examination','2025-04-22','Comprehensive eye exam to assess vision and eye health.',2200.00,'01:40:00','Imaging Room'),('MSB1001','Minor Skin Biopsy','2025-05-17','Removing a small sample of skin tissue for diagnostic testing.',3500.00,'00:45:00','Treatment Room'),('MWD102','Minor Wound Dressing','2025-04-14','Cleaning and dressing minor wounds or cuts.',1800.00,'00:45:00','Treatment Room'),('RCT101','Root Canal Treatment ','2025-03-30','Removal of infected pulp from inside the tooth, followed by cleaning, filling, and sealing the root canals.',3500.00,'01:00:00','Dental Room'),('UA501','Urine Analysis','2025-04-01','Testing urine sample for signs of infection, dehydration, or other conditions.',1600.00,'01:10:00','Laboratory Room'),('VCT102','Vaccination','2025-05-12','Administering vaccines for flu, tetanus, or other preventive care.',1200.00,'00:30:00','Examination Room'),('XR301','X-ray','2025-05-11','A chest X-ray to evaluate the lungs and heart for possible diseases.',3000.00,'00:30:00','Imaging Room');
/*!40000 ALTER TABLE `operation_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patient_tbl`
--

DROP TABLE IF EXISTS `patient_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patient_tbl` (
  `patientId` varchar(100) NOT NULL,
  `patientfirstname` varchar(100) NOT NULL,
  `patientmiddlename` varchar(100) NOT NULL,
  `patientlastname` varchar(100) NOT NULL,
  `address` varchar(200) NOT NULL,
  `gender` varchar(10) NOT NULL,
  `birthdate` date NOT NULL,
  `contactnumber` varchar(11) DEFAULT NULL,
  `Age` int NOT NULL,
  PRIMARY KEY (`patientId`),
  CONSTRAINT `patient_tbl_chk_1` CHECK (((length(`contactnumber`) = 11) and (`contactnumber` like _utf8mb4'09%'))),
  CONSTRAINT `patient_tbl_chk_2` CHECK (((`gender` = _utf8mb4'Male') or (`gender` = _utf8mb4'Female'))),
  CONSTRAINT `pchAge` CHECK (((`Age` >= 0) and (`Age` < 120)))
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patient_tbl`
--

LOCK TABLES `patient_tbl` WRITE;
/*!40000 ALTER TABLE `patient_tbl` DISABLE KEYS */;
INSERT INTO `patient_tbl` VALUES ('P2025-000001','Jake','Ekaj','Maunas','Mandug	','Male','2001-07-06','09977132465',23),('P2025-000002','Yuika','Akiuy','Santos','Tagum','Female','2015-07-16',NULL,9),('P2025-000003','Julie','Eilij','Joy','Roxas','Female','2001-06-21','09941177822',23),('P2025-000004','John','Rey','Busalo','Matina','Male','2004-06-01',NULL,20),('P2025-000005','Aeyc','Rey','Winn','Roxas	','Male','2024-10-08',NULL,0),('P2025-000006','Stephanie','Mae','Quisay','Buhangin','Female','2000-03-23','09881235874',25),('P2025-000007','Prince','Iba','Sestoso','Roxas	','Male','2002-11-21','09771171913',22);
/*!40000 ALTER TABLE `patient_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `patientappointment_tbl`
--

DROP TABLE IF EXISTS `patientappointment_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `patientappointment_tbl` (
  `AppointmentDetailNo` bigint NOT NULL AUTO_INCREMENT,
  `AppointmentRecordNo` bigint NOT NULL,
  `RoomNo` bigint NOT NULL,
  `OperationCode` varchar(10) NOT NULL,
  `DoctorID` varchar(50) NOT NULL,
  `StartSchedule` datetime NOT NULL,
  `EndSchedule` datetime NOT NULL,
  `Status` varchar(45) NOT NULL DEFAULT 'Upcoming',
  KEY `a_idx` (`RoomNo`),
  KEY `appontmentid_idx` (`AppointmentDetailNo`),
  KEY `doctorid` (`DoctorID`),
  KEY `operat_idx` (`OperationCode`),
  KEY `sabdasc_idx` (`AppointmentRecordNo`),
  CONSTRAINT `appontmentid` FOREIGN KEY (`AppointmentDetailNo`) REFERENCES `appointmentdetails_tbl` (`AppointmentDetailNo`) ON UPDATE CASCADE,
  CONSTRAINT `asd` FOREIGN KEY (`RoomNo`) REFERENCES `rooms_tbl` (`RoomNo`) ON UPDATE CASCADE,
  CONSTRAINT `doctorid` FOREIGN KEY (`DoctorID`) REFERENCES `doctor_operation_mm_tbl` (`doctorId`) ON UPDATE CASCADE,
  CONSTRAINT `operat` FOREIGN KEY (`OperationCode`) REFERENCES `doctor_operation_mm_tbl` (`operationCode`) ON UPDATE CASCADE,
  CONSTRAINT `sabdasc` FOREIGN KEY (`AppointmentRecordNo`) REFERENCES `appointmentrecord_tbl` (`AppointmentRecordNo`) ON UPDATE CASCADE
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `patientappointment_tbl`
--

LOCK TABLES `patientappointment_tbl` WRITE;
/*!40000 ALTER TABLE `patientappointment_tbl` DISABLE KEYS */;
INSERT INTO `patientappointment_tbl` VALUES (1,1,101,'BP102','D2025-000003','2025-04-14 16:00:00','2025-04-14 16:30:00','Absent'),(2,1,401,'MWD102','D2025-000004','2025-04-29 10:30:00','2025-04-29 11:15:00','Absent'),(3,2,101,'CK101','D2025-000004','2025-04-25 18:30:00','2025-04-25 20:00:00','Absent'),(4,2,101,'CK101','D2025-000004','2025-04-29 17:30:00','2025-04-29 19:00:00','Absent'),(5,2,101,'CK101','D2025-000004','2025-05-23 17:30:00','2025-05-23 19:00:00','Absent'),(6,3,301,'EE101','D2025-000002','2025-05-28 09:30:00','2025-05-28 11:10:00','Absent'),(7,4,401,'MSB1001','D2025-000004','2025-05-26 10:30:00','2025-05-26 11:15:00','Absent'),(8,5,301,'XR301','D2025-000002','2025-05-30 10:30:00','2025-05-30 11:00:00','Absent'),(9,6,301,'EE101','D2025-000002','2025-05-29 11:00:00','2025-05-29 12:40:00','Absent'),(10,7,103,'CK101','D2025-000006','2025-05-26 10:00:00','2025-05-26 11:30:00','Upcoming'),(11,8,201,'BT101','D2025-000005','2025-05-28 19:30:00','2025-05-28 20:30:00','Upcoming'),(12,9,101,'VCT102','D2025-000009','2025-05-29 10:00:00','2025-05-29 10:30:00','Upcoming'),(13,10,202,'EE101','D2025-000002','2025-05-31 13:30:00','2025-05-31 15:10:00','Upcoming'),(14,11,103,'BP102','D2025-000003','2025-05-31 17:30:00','2025-05-31 18:00:00','Upcoming'),(15,12,202,'EE101','D2025-000002','2025-06-04 11:00:00','2025-06-04 12:40:00','Upcoming'),(16,12,503,'DC100','D2025-000003','2025-06-03 11:00:00','2025-06-03 12:45:00','Upcoming');
/*!40000 ALTER TABLE `patientappointment_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `rooms_tbl`
--

DROP TABLE IF EXISTS `rooms_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `rooms_tbl` (
  `RoomNo` bigint NOT NULL,
  `RoomType` varchar(45) NOT NULL DEFAULT 'General',
  PRIMARY KEY (`RoomNo`),
  KEY `dfg_idx` (`RoomType`),
  CONSTRAINT `dfg` FOREIGN KEY (`RoomType`) REFERENCES `roomtype_tbl` (`Roomtype`) ON DELETE CASCADE ON UPDATE CASCADE
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `rooms_tbl`
--

LOCK TABLES `rooms_tbl` WRITE;
/*!40000 ALTER TABLE `rooms_tbl` DISABLE KEYS */;
INSERT INTO `rooms_tbl` VALUES (503,'Dental Room'),(504,'Dental Room'),(101,'Examination Room'),(103,'Examination Room'),(202,'Imaging Room'),(301,'Imaging Room'),(201,'Laboratory Room'),(401,'Treatment Room'),(402,'Treatment Room');
/*!40000 ALTER TABLE `rooms_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `roomtype_tbl`
--

DROP TABLE IF EXISTS `roomtype_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `roomtype_tbl` (
  `Roomtype` varchar(45) NOT NULL,
  `RoomDescription` varchar(200) NOT NULL,
  PRIMARY KEY (`Roomtype`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `roomtype_tbl`
--

LOCK TABLES `roomtype_tbl` WRITE;
/*!40000 ALTER TABLE `roomtype_tbl` DISABLE KEYS */;
INSERT INTO `roomtype_tbl` VALUES ('Dental Room','Used for dental treatment room is the type of room needed for dental procedures,'),('Examination Room','The examination room in a clinic is a versatile space used primarily for routine check-ups, diagnostic assessments, consultations, and minor procedures.'),('Imaging Room','Used for diagnostic imaging, such as X-rays, ultrasounds, or CT scans.'),('Laboratory Room','For conducting diagnostic tests, such as blood work, urine tests, and microbiological studies.'),('Treatment Room','Used for administering therapies like IV treatments, injections, wound care, or other forms of treatment.');
/*!40000 ALTER TABLE `roomtype_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `staff_tbl`
--

DROP TABLE IF EXISTS `staff_tbl`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `staff_tbl` (
  `StaffID` bigint NOT NULL AUTO_INCREMENT,
  `Username` varchar(45) NOT NULL,
  `Password` varchar(45) NOT NULL,
  `FirstName` varchar(45) DEFAULT NULL,
  `MiddleName` varchar(45) DEFAULT NULL,
  `LastName` varchar(45) DEFAULT NULL,
  `Age` int DEFAULT NULL,
  `Address` varchar(150) DEFAULT NULL,
  PRIMARY KEY (`StaffID`),
  UNIQUE KEY `Username_UNIQUE` (`Username`),
  CONSTRAINT `staff_tbl_chk_1` CHECK ((`age` > 0))
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `staff_tbl`
--

LOCK TABLES `staff_tbl` WRITE;
/*!40000 ALTER TABLE `staff_tbl` DISABLE KEYS */;
INSERT INTO `staff_tbl` VALUES (1,'Rafeala','12345','Rafeala','Rafeala','Ababa',21,'Davao City'),(2,'admin','admin',NULL,NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `staff_tbl` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping routines for database 'clinic'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-05-30 18:22:54
