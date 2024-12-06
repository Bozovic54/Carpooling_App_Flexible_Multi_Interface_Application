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
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `customer_id` int NOT NULL AUTO_INCREMENT,
  `first_name` varchar(30) NOT NULL,
  `last_name` varchar(30) NOT NULL,
  `date_of_birth` date NOT NULL,
  `email` varchar(40) NOT NULL,
  `phone_number` varchar(20) NOT NULL,
  `photo` blob,
  `car` varchar(20) DEFAULT NULL,
  `experience_level` varchar(10) DEFAULT NULL,
  `rating` int DEFAULT NULL,
  `about` varchar(120) DEFAULT NULL,
  PRIMARY KEY (`customer_id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (1,'Mateja','Božović','2002-07-18','matejabozovic02@gmail.com','061234567',NULL,'Audi a4','4',3,NULL),(2,'Jovana','Mirković','1999-03-15','jovana.mirkovic99@gmail.com','069876543',NULL,'Toyota Corolla','3',5,'Friendly and experienced driver.'),(3,'Marko','Petrović','1985-11-23','markopetrovic85@yahoo.com','062123456',NULL,'Volkswagen Golf','5',5,'Punctual and safe driver with years of experience.'),(4,'Ana','Stanković','1995-08-10','anastankovic95@hotmail.com','064789012',NULL,'Mercedes C-Class','4',5,'Friendly, reliable driver who loves road trips.'),(5,'Marko','Nikolić','1990-06-25','marko.nikolic90@gmail.com','061234567',NULL,'BMW 320i','5',5,'Professional and punctual driver.'),(6,'Ana','Petrović','1985-11-30','ana.petrovic85@gmail.com','064345678',NULL,'Audi A3','4',5,'Friendly and safe driver with a lot of experience.'),(7,'Luka','Jovanović','1992-05-05','luka.jovanovic92@gmail.com','069876543',NULL,'Mercedes A-Class','2',4,'Easy-going driver with a love for cars.'),(8,'Maja','Kovačević','1987-07-22','maja.kovacevic87@gmail.com','062123456',NULL,'Volkswagen Golf','6',5,'Experienced and polite driver with great customer service skills.'),(9,'Stefan','Dimitrijević','1995-02-17','stefan.dimitrijevic95@gmail.com','061112233',NULL,'Ford Focus','4',5,'Dependable driver with excellent driving record.'),(10,'Ivana','Savić','1993-08-13','ivana.savic93@gmail.com','068334455',NULL,'Honda Civic','3',4,'Polite driver, always willing to help.'),(11,'Nikola','Marinković','1989-12-01','nikola.marinkovic89@gmail.com','060223344',NULL,'Skoda Octavia','7',5,'Highly experienced and very reliable driver.'),(12,'Tamara','Lukić','1996-04-18','tamara.lukic96@gmail.com','065556677',NULL,'Renault Clio','2',4,'Young but very capable driver.'),(13,'Jovan','Stojanović','1994-01-25','jovan.stojanovic94@gmail.com','063445566',NULL,'Peugeot 308','4',5,'Great attitude and excellent driving skills.'),(14,'Katarina','Đorđević','1988-09-11','katarina.djordjevic88@gmail.com','067788899',NULL,'Fiat 500','5',5,'Charismatic driver with attention to detail.');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
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
