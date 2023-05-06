-- --------------------------------------------------------
-- Sunucu:                       127.0.0.1
-- Sunucu sürümü:                8.0.27 - MySQL Community Server - GPL
-- Sunucu İşletim Sistemi:       Win64
-- HeidiSQL Sürüm:               12.1.0.6537
-- --------------------------------------------------------

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET NAMES utf8 */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;


-- paramatordb için veritabanı yapısı dökülüyor
CREATE DATABASE IF NOT EXISTS `paramatordb` /*!40100 DEFAULT CHARACTER SET utf8 COLLATE utf8_turkish_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `paramatordb`;

-- tablo yapısı dökülüyor paramatordb.site
CREATE TABLE IF NOT EXISTS `site` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(250) COLLATE utf8_turkish_ci DEFAULT NULL,
  `url` varchar(250) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT NULL,
  `email` varchar(250) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT NULL,
  `description` longtext CHARACTER SET utf8 COLLATE utf8_turkish_ci,
  `facebook` varchar(250) COLLATE utf8_turkish_ci DEFAULT NULL,
  `twitter` varchar(250) COLLATE utf8_turkish_ci DEFAULT NULL,
  `instagram` varchar(250) COLLATE utf8_turkish_ci DEFAULT NULL,
  `youtube` varchar(250) COLLATE utf8_turkish_ci DEFAULT NULL,
  `logo` varchar(250) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT NULL,
  `favicon` varchar(250) COLLATE utf8_turkish_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_turkish_ci;

-- paramatordb.site: 1 rows tablosu için veriler indiriliyor
/*!40000 ALTER TABLE `site` DISABLE KEYS */;
INSERT INTO `site` (`id`, `title`, `url`, `email`, `description`, `facebook`, `twitter`, `instagram`, `youtube`, `logo`, `favicon`) VALUES
	(1, 'PARAMATOR Turkey- Yamaç Paraşütü', 'www.youtube.com', 'ozogulmert7@gmail.com', 'Türkiyede paramotor', 'https://www.facebook.com/paramotorturkey', 'https://www.twitter.com/paramotorturkey', 'https://www.instagram.com/paramotorturkey', 'https://www.youtube.com/paramotorturkey', 'paramator.png', 'favicon.png');
/*!40000 ALTER TABLE `site` ENABLE KEYS */;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
