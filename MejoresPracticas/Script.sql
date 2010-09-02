-- MySQL Administrator dump 1.4
--
-- ------------------------------------------------------
-- Server version	5.1.47-community


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;


--
-- Create schema mejores_practicas
--

CREATE DATABASE IF NOT EXISTS mejores_practicas;
USE mejores_practicas;

--
-- Definition of table `persona`
--

DROP TABLE IF EXISTS `persona`;
CREATE TABLE `persona` (
  `Codigo` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Descripcion` varchar(100) NOT NULL,
  `Nombres` varchar(100) NOT NULL,
  `Apellidos` varchar(100) NOT NULL,
  PRIMARY KEY (`Codigo`),
  FULLTEXT KEY `FT_NOMB_APE` (`Nombres`,`Apellidos`)
) ENGINE=MyISAM AUTO_INCREMENT=21 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `persona`
--

/*!40000 ALTER TABLE `persona` DISABLE KEYS */;
INSERT INTO `persona` (`Codigo`,`Descripcion`,`Nombres`,`Apellidos`) VALUES 
 (1,'Gerente','Miguel','Melgar'),
 (2,'Gerente','Marty','Paucara'),
 (3,'Jefe','Pepito','Juarez'),
 (4,'Jefe','Pancho','Villa'),
 (5,'Jefe','Bananero','Pelotudo'),
 (6,'Empleado','Alan','Garcia'),
 (7,'Empleado','Alejandro','Toledo'),
 (8,'Empleado','Lourdes','Flores'),
 (9,'Empleado','Alex','Kouri'),
 (10,'Empleado','Keiko','Fujimori'),
 (11,'Empleado','Jaime','Bayly'),
 (12,'Empleado','Magaly','Medina'),
 (13,'Secretaria','Larissa','Riquelme'),
 (14,'Secretaria','Tilsa','Losano'),
 (15,'Secretaria','Vanessa','Tello'),
 (16,'Secretaria','Karen','Dejo'),
 (17,'Vagos','Beto','Ortiz'),
 (18,'Vagos','Vladimiro','Montesinos'),
 (19,'Vagos','Carlos','Raffo'),
 (20,'Vagos','Oyanta','Humala');
/*!40000 ALTER TABLE `persona` ENABLE KEYS */;


--
-- Definition of procedure `SP_OBTENER_PERSONAS`
--

DROP PROCEDURE IF EXISTS `SP_OBTENER_PERSONAS`;

DELIMITER $$

/*!50003 SET @TEMP_SQL_MODE=@@SQL_MODE, SQL_MODE='STRICT_TRANS_TABLES,NO_AUTO_CREATE_USER,NO_ENGINE_SUBSTITUTION' */ $$
CREATE DEFINER=`root`@`localhost` PROCEDURE `SP_OBTENER_PERSONAS`(
P_NOMB_APE VARCHAR(100)
)
BEGIN
  SELECT Codigo, Descripcion, Nombres, Apellidos FROM persona
  WHERE MATCH(Nombres, Apellidos) AGAINST (P_NOMB_APE IN NATURAL LANGUAGE MODE);
END $$
/*!50003 SET SESSION SQL_MODE=@TEMP_SQL_MODE */  $$

DELIMITER ;



/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
