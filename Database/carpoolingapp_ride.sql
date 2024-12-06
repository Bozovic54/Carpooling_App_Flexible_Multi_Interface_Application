CREATE DATABASE  IF NOT EXISTS `carpoolingapp` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_0900_ai_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `carpoolingapp`;
-- MySQL dump 10.13  Distrib 8.0.40, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: carpoolingapp
-- ------------------------------------------------------
-- Server version	8.0.40

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
-- Table structure for table `ride`
--

DROP TABLE IF EXISTS `ride`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `ride` (
  `ride_id` int NOT NULL AUTO_INCREMENT,
  `start_location` varchar(120) NOT NULL,
  `end_location` varchar(120) NOT NULL,
  `date` date NOT NULL,
  `departure_time` time NOT NULL,
  `arrival_time` time NOT NULL,
  `price` decimal(10,2) NOT NULL,
  `seats_available` int NOT NULL,
  `customer_id` int NOT NULL,
  PRIMARY KEY (`ride_id`),
  KEY `customer_id` (`customer_id`),
  CONSTRAINT `ride_ibfk_1` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`customer_id`)
) ENGINE=InnoDB AUTO_INCREMENT=60 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `ride`
--

LOCK TABLES `ride` WRITE;
/*!40000 ALTER TABLE `ride` DISABLE KEYS */;
INSERT INTO `ride` VALUES (2,'Beograd','Kragujevac','2024-10-24','12:00:00','15:00:00',1000.00,2,1),(3,'Novi Sad','Subotica','2024-11-01','08:00:00','10:30:00',1500.00,3,2),(4,'Niš','Beograd','2024-11-02','14:00:00','18:00:00',2000.00,2,3),(5,'Kragujevac','Čačak','2024-11-03','09:00:00','11:00:00',1200.00,4,4),(6,'Beograd','Novi Sad','2024-11-04','07:30:00','09:00:00',1300.00,2,1),(8,'Beograd','Novi Sad','2024-11-04','07:30:00','09:00:00',1300.00,2,1),(9,'Subotica','Novi Sad','2024-11-05','15:00:00','16:30:00',1200.00,3,3),(10,'Zrenjanin','Beograd','2024-11-06','10:00:00','11:45:00',1000.00,4,4),(11,'Novi Pazar','Kraljevo','2024-11-07','09:00:00','11:30:00',1500.00,2,1),(12,'Valjevo','Beograd','2024-11-08','12:00:00','14:00:00',1800.00,3,2),(13,'Sombor','Subotica','2024-11-09','08:30:00','09:45:00',900.00,2,3),(14,'Jagodina','Beograd','2024-11-10','13:00:00','15:30:00',1600.00,4,4),(16,'Kragujevac','Novi Sad','2024-11-11','06:00:00','08:45:00',2000.00,3,3),(17,'Leskovac','Niš','2024-11-12','10:00:00','11:15:00',700.00,2,1),(18,'Čačak','Kragujevac','2024-11-13','09:30:00','11:00:00',1100.00,3,4),(19,'Kraljevo','Niš','2024-11-16','19:30:00','23:30:00',2100.00,3,4),(20,'Beograd','Novi Sad','2024-11-04','07:30:00','09:00:00',1300.00,2,1),(21,'Subotica','Novi Sad','2024-11-05','15:30:00','17:00:00',1200.00,3,3),(22,'Zrenjanin','Beograd','2024-11-06','10:30:00','12:00:00',1000.00,4,4),(23,'Novi Pazar','Kraljevo','2024-11-07','09:30:00','11:30:00',1500.00,2,1),(24,'Valjevo','Beograd','2024-11-08','12:30:00','14:30:00',1800.00,3,2),(25,'Sombor','Subotica','2024-11-09','09:00:00','10:15:00',900.00,2,3),(26,'Jagodina','Beograd','2024-11-10','13:30:00','15:30:00',1600.00,4,4),(27,'Kragujevac','Novi Sad','2024-11-11','06:30:00','08:45:00',2000.00,3,3),(28,'Leskovac','Niš','2024-11-12','10:30:00','11:30:00',700.00,2,1),(29,'Kraljevo','Niš','2024-11-16','20:00:00','23:00:00',2100.00,3,4),(30,'Beograd','Kragujevac','2024-11-10','20:00:00','23:00:00',2100.00,3,4),(31,'Beograd','Kragujevac','2024-11-10','19:00:00','21:00:00',2100.00,3,6),(32,'Beograd','Kragujevac','2024-11-10','19:00:00','21:00:00',1000.00,3,10),(33,'Beograd','Kragujevac','2024-11-10','18:00:00','20:00:00',1200.00,3,11),(34,'Beograd','Kragujevac','2024-11-10','10:00:00','12:00:00',850.00,3,9),(35,'Beograd','Novi Sad','2024-11-21','08:00:00','10:00:00',1200.00,3,1),(36,'Beograd','Niš','2024-11-21','09:00:00','13:30:00',2500.00,2,2),(37,'Novi Sad','Beograd','2024-11-21','07:30:00','09:30:00',1100.00,4,3),(38,'Niš','Kragujevac','2024-11-21','10:00:00','12:30:00',1500.00,2,4),(39,'Subotica','Beograd','2024-11-21','06:00:00','09:00:00',2000.00,5,5),(40,'Beograd','Novi Sad','2024-11-22','08:00:00','10:00:00',1200.00,3,6),(41,'Beograd','Niš','2024-11-22','09:00:00','13:30:00',2500.00,2,7),(42,'Novi Sad','Beograd','2024-11-22','07:30:00','09:30:00',1100.00,4,8),(43,'Niš','Kragujevac','2024-11-22','10:00:00','12:30:00',1500.00,2,9),(44,'Subotica','Beograd','2024-11-22','06:00:00','09:00:00',2000.00,5,10),(45,'Beograd','Novi Sad','2024-11-23','08:00:00','10:00:00',1200.00,3,11),(46,'Beograd','Niš','2024-11-23','09:00:00','13:30:00',2500.00,2,12),(47,'Novi Sad','Beograd','2024-11-23','07:30:00','09:30:00',1100.00,4,13),(48,'Niš','Kragujevac','2024-11-23','10:00:00','12:30:00',1500.00,2,14),(49,'Subotica','Beograd','2024-11-23','06:00:00','09:00:00',2000.00,5,1),(50,'Beograd','Novi Sad','2024-11-24','08:00:00','10:00:00',1200.00,3,2),(51,'Beograd','Niš','2024-11-24','09:00:00','13:30:00',2500.00,2,3),(52,'Novi Sad','Beograd','2024-11-24','07:30:00','09:30:00',1100.00,4,4),(53,'Niš','Kragujevac','2024-11-24','10:00:00','12:30:00',1500.00,2,5),(54,'Subotica','Beograd','2024-11-24','06:00:00','09:00:00',2000.00,5,6),(55,'Beograd','Novi Sad','2024-11-25','08:00:00','10:00:00',1200.00,3,7),(56,'Beograd','Niš','2024-11-25','09:00:00','13:30:00',2500.00,2,8),(57,'Novi Sad','Beograd','2024-11-25','07:30:00','09:30:00',1100.00,4,9),(58,'Niš','Kragujevac','2024-11-25','10:00:00','12:30:00',1500.00,2,10),(59,'Subotica','Beograd','2024-11-25','06:00:00','09:00:00',2000.00,5,11);
/*!40000 ALTER TABLE `ride` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-21 20:05:34
