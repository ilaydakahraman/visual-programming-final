-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1:3306
-- Üretim Zamanı: 03 Oca 2023, 14:12:59
-- Sunucu sürümü: 5.7.36
-- PHP Sürümü: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `kayit`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `tasimacilik`
--

DROP TABLE IF EXISTS `tasimacilik`;
CREATE TABLE IF NOT EXISTS `tasimacilik` (
  `tid` int(11) NOT NULL AUTO_INCREMENT,
  `sehir` varchar(200) COLLATE utf8_turkish_ci NOT NULL,
  `nereden` varchar(200) COLLATE utf8_turkish_ci NOT NULL,
  `nereye` varchar(200) COLLATE utf8_turkish_ci NOT NULL,
  `asayi` varchar(200) COLLATE utf8_turkish_ci NOT NULL,
  `eadet` varchar(200) COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`tid`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `tasimacilik`
--

INSERT INTO `tasimacilik` (`tid`, `sehir`, `nereden`, `nereye`, `asayi`, `eadet`) VALUES
(1, '04 Agri', '05 Amasya', '05 Amasya', '2', '3'),
(2, '06 Ankara', '05 Amasya', '08 Artvin', '2', '3'),
(3, '07 Antalya', '08 Artvin', '04 Agri', 'dewd', 'dwdwd'),
(4, '11 Bilecik', '11 Bilecik', '08 Artvin', '2', '2');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `uyeler`
--

DROP TABLE IF EXISTS `uyeler`;
CREATE TABLE IF NOT EXISTS `uyeler` (
  `id` int(11) NOT NULL AUTO_INCREMENT,
  `ad` varchar(200) COLLATE utf8_turkish_ci NOT NULL,
  `sifre` varchar(200) COLLATE utf8_turkish_ci NOT NULL,
  `soyad` varchar(200) COLLATE utf8_turkish_ci NOT NULL,
  `telefon` varchar(200) COLLATE utf8_turkish_ci NOT NULL,
  `adres` varchar(200) COLLATE utf8_turkish_ci NOT NULL,
  `mail` varchar(200) COLLATE utf8_turkish_ci NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=MyISAM AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_turkish_ci;

--
-- Tablo döküm verisi `uyeler`
--

INSERT INTO `uyeler` (`id`, `ad`, `sifre`, `soyad`, `telefon`, `adres`, `mail`) VALUES
(1, 'eqweqw', '12312', 'wqeqwe', '123123', 'qsdqwedwq', 'qweqwe'),
(2, 'hihihh', '12312', 'wqeqwe', '123123', 'qweqwe', 'weqweqw'),
(3, 'qwewqe1', '123123', 'asdsad', '123123', 'dqwdqwdq', 'wdwqdqw'),
(4, 'gjg', 'gdfgrg', 'fefef', '343', 'rfsfs', 'fsfs');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
