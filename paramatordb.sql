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

-- tablo yapısı dökülüyor paramatordb.about
CREATE TABLE IF NOT EXISTS `about` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(200) COLLATE utf8_turkish_ci DEFAULT '0',
  `subtitle` varchar(200) COLLATE utf8_turkish_ci DEFAULT '0',
  `detail` longtext COLLATE utf8_turkish_ci,
  `isview` tinyint(1) DEFAULT NULL,
  `order` int DEFAULT NULL,
  `image` varchar(200) COLLATE utf8_turkish_ci DEFAULT '0',
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=6 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_turkish_ci;

-- paramatordb.about: 2 rows tablosu için veriler indiriliyor
/*!40000 ALTER TABLE `about` DISABLE KEYS */;
INSERT INTO `about` (`id`, `title`, `subtitle`, `detail`, `isview`, `order`, `image`) VALUES
	(4, 'LOREMLOREM', 'jabalhaoba', 'jabalhaoba', 1, 2, 'mission-1.jpg'),
	(5, 'ab ash baol', 'asacascaHSBAHBALSHCBABA', 'asacascaHSBAHBALSHCBABA', 1, 1, 'mission-1.jpg');
/*!40000 ALTER TABLE `about` ENABLE KEYS */;

-- tablo yapısı dökülüyor paramatordb.message
CREATE TABLE IF NOT EXISTS `message` (
  `int` int NOT NULL AUTO_INCREMENT,
  `title` varchar(100) COLLATE utf8_turkish_ci DEFAULT NULL,
  `subtitle` varchar(150) COLLATE utf8_turkish_ci DEFAULT NULL,
  `url` varchar(150) COLLATE utf8_turkish_ci DEFAULT NULL,
  `urlText` varchar(150) COLLATE utf8_turkish_ci DEFAULT NULL,
  `urlTarget` varchar(50) COLLATE utf8_turkish_ci DEFAULT NULL,
  `isview` tinyint(1) DEFAULT NULL,
  `order` int DEFAULT NULL,
  PRIMARY KEY (`int`)
) ENGINE=MyISAM AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_turkish_ci;

-- paramatordb.message: 1 rows tablosu için veriler indiriliyor
/*!40000 ALTER TABLE `message` DISABLE KEYS */;
INSERT INTO `message` (`int`, `title`, `subtitle`, `url`, `urlText`, `urlTarget`, `isview`, `order`) VALUES
	(1, 'MESSAGE', 'message', '/about-us', 'Hakkımızda\'ya git', '_self', 1, 1);
/*!40000 ALTER TABLE `message` ENABLE KEYS */;

-- tablo yapısı dökülüyor paramatordb.service
CREATE TABLE IF NOT EXISTS `service` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(100) COLLATE utf8_turkish_ci DEFAULT '0',
  `subtitle` varchar(150) COLLATE utf8_turkish_ci DEFAULT '0',
  `url` varchar(200) COLLATE utf8_turkish_ci DEFAULT NULL,
  `urlText` varchar(200) COLLATE utf8_turkish_ci DEFAULT NULL,
  `urlTarget` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT NULL,
  `image` varchar(150) COLLATE utf8_turkish_ci DEFAULT NULL,
  `isview` tinyint(1) DEFAULT NULL,
  `order` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_turkish_ci;

-- paramatordb.service: 3 rows tablosu için veriler indiriliyor
/*!40000 ALTER TABLE `service` DISABLE KEYS */;
INSERT INTO `service` (`id`, `title`, `subtitle`, `url`, `urlText`, `urlTarget`, `image`, `isview`, `order`) VALUES
	(1, 'MErt', 'LOREM albaelebaeobhao', '/service', 'Git', '_self', 'project-1.jpg', 1, 1),
	(2, 'C5', 'baba', '/service', 'GO', '_self', 'c5.jpg', 1, 2),
	(3, 'aynen', 'blablablabla', '/service', 'BLABLA', '_self', 'project-4.jpg', 1, 3);
/*!40000 ALTER TABLE `service` ENABLE KEYS */;

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
	(1, 'PARAMATOR Turkey- Yamaç Paraşütü', 'www.youtube.com', 'ozogulmert7@gmail.com', 'Türkiyede paramotor', 'https://www.facebook.com', 'https://www.twitter.com', 'https://www.instagram.com/mert.the0/', 'https://www.youtube.com/channel/UCuoXvUFX0pgH32EUopx5aAA', 'paramator.png', 'favicon.png');
/*!40000 ALTER TABLE `site` ENABLE KEYS */;

-- tablo yapısı dökülüyor paramatordb.slide
CREATE TABLE IF NOT EXISTS `slide` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(150) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT NULL,
  `subtitle` text CHARACTER SET utf8 COLLATE utf8_turkish_ci,
  `url` varchar(250) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT NULL,
  `urlText` varchar(250) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT NULL,
  `image` varchar(250) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT NULL,
  `urlTarget` varchar(50) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT NULL,
  `isview` tinyint(1) DEFAULT '0',
  `order` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_turkish_ci;

-- paramatordb.slide: 2 rows tablosu için veriler indiriliyor
/*!40000 ALTER TABLE `slide` DISABLE KEYS */;
INSERT INTO `slide` (`id`, `title`, `subtitle`, `url`, `urlText`, `image`, `urlTarget`, `isview`, `order`) VALUES
	(1, 'Business with Finance', 'Subtitle', 'https://github.com/ozogulmert7', 'Explore Us', 'slider-1.jpg', '_self', 1, 1),
	(2, 'abndjkl', '2.SLİDE', 'https://github.com/ozogulmert7', 'MERt', 'slider-2.jpg', '_self', 1, 2);
/*!40000 ALTER TABLE `slide` ENABLE KEYS */;

-- tablo yapısı dökülüyor paramatordb.success
CREATE TABLE IF NOT EXISTS `success` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(100) COLLATE utf8_turkish_ci DEFAULT '0',
  `subtitle` varchar(200) COLLATE utf8_turkish_ci DEFAULT '0',
  `url` varchar(200) COLLATE utf8_turkish_ci DEFAULT NULL,
  `urlText` varchar(150) COLLATE utf8_turkish_ci DEFAULT NULL,
  `urlTarget` varchar(50) COLLATE utf8_turkish_ci DEFAULT NULL,
  `image` varchar(100) COLLATE utf8_turkish_ci DEFAULT NULL,
  `isview` tinyint(1) DEFAULT NULL,
  `order` int DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_turkish_ci;

-- paramatordb.success: 2 rows tablosu için veriler indiriliyor
/*!40000 ALTER TABLE `success` DISABLE KEYS */;
INSERT INTO `success` (`id`, `title`, `subtitle`, `url`, `urlText`, `urlTarget`, `image`, `isview`, `order`) VALUES
	(1, 'VAR success', 'ajbalbhalhaoa', 'https://github.com/ozogulmert7', 'GİTHUB', '_self', 'success-1.jpg', 1, 2),
	(2, 'AIBGIAB AL', 'SUCCESS var', 'https://github.com/ozogulmert7', 'GİTHUB', '_self', 'success-2.jpg', 1, 1);
/*!40000 ALTER TABLE `success` ENABLE KEYS */;

-- tablo yapısı dökülüyor paramatordb.team
CREATE TABLE IF NOT EXISTS `team` (
  `id` int NOT NULL AUTO_INCREMENT,
  `title` varchar(200) COLLATE utf8_turkish_ci DEFAULT '0',
  `subtitle` varchar(250) COLLATE utf8_turkish_ci DEFAULT '0',
  `image` varchar(250) COLLATE utf8_turkish_ci DEFAULT '0',
  `isview` tinyint(1) DEFAULT NULL,
  `order` int DEFAULT NULL,
  `facebook` varchar(200) COLLATE utf8_turkish_ci DEFAULT NULL,
  `twitter` varchar(200) COLLATE utf8_turkish_ci DEFAULT NULL,
  `instagram` varchar(200) COLLATE utf8_turkish_ci DEFAULT NULL,
  `youtube` varchar(200) COLLATE utf8_turkish_ci DEFAULT NULL,
  `linkedin` varchar(200) CHARACTER SET utf8 COLLATE utf8_turkish_ci DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8mb3 COLLATE=utf8_turkish_ci;

-- paramatordb.team: 4 rows tablosu için veriler indiriliyor
/*!40000 ALTER TABLE `team` DISABLE KEYS */;
INSERT INTO `team` (`id`, `title`, `subtitle`, `image`, `isview`, `order`, `facebook`, `twitter`, `instagram`, `youtube`, `linkedin`) VALUES
	(1, 'MUHAMMET', '...', 'mamimo.png', 1, 4, 'https://www.facebook.com', 'https://www.twitter.com', 'https://www.instagram.com', 'https://www.youtube.com/@MertJokjeck', 'https://www.linkedin.com/in/mert-özoğul-107925259/'),
	(2, 'Tenta batın', 'Bişeyler yapıyor', 'batintenta-2.png', 1, 3, 'https://www.facebook.com', NULL, 'https://www.instagram.com', 'https://www.youtube.com/@MertJokjeck', 'https://www.linkedin.com/in/mert-özoğul-107925259/'),
	(3, 'Emir Yasin Bolat', 'Flutter Developer', 'mksular.png', 1, 2, 'https://www.facebook.com', NULL, NULL, 'https://www.youtube.com/@MertJokjeck', 'https://www.linkedin.com/in/mert-özoğul-107925259/'),
	(4, 'Ahmet', 'ABİM', 'ahmet.png', 1, 1, 'https://www.facebook.com', NULL, NULL, 'https://www.youtube.com/@MertJokjeck', 'https://www.linkedin.com/in/mert-özoğul-107925259/');
/*!40000 ALTER TABLE `team` ENABLE KEYS */;

/*!40103 SET TIME_ZONE=IFNULL(@OLD_TIME_ZONE, 'system') */;
/*!40101 SET SQL_MODE=IFNULL(@OLD_SQL_MODE, '') */;
/*!40014 SET FOREIGN_KEY_CHECKS=IFNULL(@OLD_FOREIGN_KEY_CHECKS, 1) */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40111 SET SQL_NOTES=IFNULL(@OLD_SQL_NOTES, 1) */;
