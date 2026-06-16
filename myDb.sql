-- MySQL dump 10.13  Distrib 8.0.44, for Win64 (x86_64)
--
-- Host: localhost    Database: tvrepairdb
-- ------------------------------------------------------
-- Server version	8.0.44

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
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
  `Customer_ID` varchar(10) NOT NULL,
  `Customer_Name` varchar(50) NOT NULL,
  `Customer_Add` varchar(50) DEFAULT NULL,
  `Customer_Tel` varchar(20) DEFAULT NULL,
  `Customer_Email` varchar(50) DEFAULT NULL,
  `Customer_Gender` varchar(10) DEFAULT NULL,
  `Customer_Age` int DEFAULT NULL,
  PRIMARY KEY (`Customer_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES ('C01','Emi','Bangkok','065487542','emiemily@gmail.com','Female',28),('C02','Bonnie','Bangkok','06524301478','beobonny@gmail.com','Female',22),('C03','Charlie','Yangon','09351651516','poe123@gmail.com','Male',25);
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee` (
  `EmployeeID` varchar(15) NOT NULL,
  `EmpName` varchar(20) NOT NULL,
  `EmpPosition` varchar(20) NOT NULL,
  `EmpPhone` varchar(15) DEFAULT NULL,
  `EmpEmail` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`EmployeeID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES ('E01','Tim','Administrator','0965165165','tim123@gmail.com'),('E02','Kelly','Accountant','096516501','kelly04@gmail.com'),('E03','Daniel','System manager','096541651','dandan@gmail.com'),('E04','Ginny','Staff','0951151501','ginny44@gmail.com');
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `inventory`
--

DROP TABLE IF EXISTS `inventory`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `inventory` (
  `ItemID` varchar(15) NOT NULL,
  `ItemName` varchar(20) NOT NULL,
  `ItemQuantity` int DEFAULT NULL,
  `ItemPurchaseDate` varchar(10) DEFAULT NULL,
  `ItemDesc` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`ItemID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `inventory`
--

LOCK TABLES `inventory` WRITE;
/*!40000 ALTER TABLE `inventory` DISABLE KEYS */;
INSERT INTO `inventory` VALUES ('I01','Display panel',50,'5-05-2026','null'),('I02','Power boards',89,'15-05-2026',''),('I03','Remote controls',100,'27-04-2026','samsung'),('I04','LED strips',30,'20-05-2026','null'),('I05','Speakers',45,'21-05-2026','null');
/*!40000 ALTER TABLE `inventory` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier`
--

DROP TABLE IF EXISTS `supplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `supplier` (
  `SupplierID` varchar(10) NOT NULL,
  `SName` varchar(20) NOT NULL,
  `SPhone` varchar(15) DEFAULT NULL,
  `SAddress` varchar(20) DEFAULT NULL,
  `SEmail` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`SupplierID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier`
--

LOCK TABLES `supplier` WRITE;
/*!40000 ALTER TABLE `supplier` DISABLE KEYS */;
INSERT INTO `supplier` VALUES ('S01','4U Supplies ','09355615155','Singapore','4usupplies@gmail.com'),('S02','RemoteHub ','096581611','Bangkok','remotehub@gmail.com'),('S03','SoundMart','096414165','Ayuttaya','soundmart@gmail.com'),('S04','Display World','09841651651','Bangkok','dW123@gmail.com');
/*!40000 ALTER TABLE `supplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tvproductsandservices`
--

DROP TABLE IF EXISTS `tvproductsandservices`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tvproductsandservices` (
  `TVproduct_ID` varchar(10) NOT NULL,
  `TVproduct_Name` varchar(50) DEFAULT NULL,
  `TVproduct_Type` varchar(50) DEFAULT NULL,
  `TVproduct_Quantity` int DEFAULT NULL,
  `TVproduct_Price` float DEFAULT NULL,
  `Customer_ID` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`TVproduct_ID`),
  KEY `Customer_ID` (`Customer_ID`),
  CONSTRAINT `tvproductsandservices_ibfk_1` FOREIGN KEY (`Customer_ID`) REFERENCES `customer` (`Customer_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tvproductsandservices`
--

LOCK TABLES `tvproductsandservices` WRITE;
/*!40000 ALTER TABLE `tvproductsandservices` DISABLE KEYS */;
INSERT INTO `tvproductsandservices` VALUES ('P01','Samsung smart TV','LED',10,800,'C02'),('P02','Sony Bravia TV','OLED',2,1000,'C01');
/*!40000 ALTER TABLE `tvproductsandservices` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `userlogin`
--

DROP TABLE IF EXISTS `userlogin`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `userlogin` (
  `user_ID` varchar(20) NOT NULL,
  `password` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`user_ID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `userlogin`
--

LOCK TABLES `userlogin` WRITE;
/*!40000 ALTER TABLE `userlogin` DISABLE KEYS */;
INSERT INTO `userlogin` VALUES ('adm01','admpsw01'),('adm02','admpsw02');
/*!40000 ALTER TABLE `userlogin` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2026-05-09  2:01:57
