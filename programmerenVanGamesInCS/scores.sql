-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Gegenereerd op: 25 nov 2021 om 21:42
-- Serverversie: 10.4.20-MariaDB
-- PHP-versie: 8.0.9

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `testdatabase`
--

-- --------------------------------------------------------

--
-- Tabelstructuur voor tabel `scores`
--

CREATE TABLE `scores` (
  `id` int(11) NOT NULL,
  `Naam` varchar(50) DEFAULT NULL,
  `datum` datetime DEFAULT NULL,
  `score` int(11) DEFAULT NULL,
  `game` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Gegevens worden geëxporteerd voor tabel `scores`
--

INSERT INTO `scores` (`id`, `Naam`, `datum`, `score`, `game`) VALUES
(39, 'Maarten', '2021-11-24 09:37:21', 328, 'FlappyBird'),
(40, 'Maarten', '2021-11-24 09:41:45', 20, 'Lingo'),
(41, 'Arwin', '2021-11-24 09:59:54', 40, 'Lingo'),
(42, 'Rogier', '2021-11-24 16:27:07', 10, 'Lingo'),
(43, 'Martine', '2021-11-24 22:12:56', 20, 'Lingo'),
(44, 'Martine', '2021-11-24 22:18:29', 14, 'FlappyBird'),
(45, 'Martine', '2021-11-24 22:38:55', 200, 'Lingo'),
(46, 'Arwin', '2021-11-25 12:32:16', 54, 'FlappyBird');

--
-- Indexen voor geëxporteerde tabellen
--

--
-- Indexen voor tabel `scores`
--
ALTER TABLE `scores`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT voor geëxporteerde tabellen
--

--
-- AUTO_INCREMENT voor een tabel `scores`
--
ALTER TABLE `scores`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=47;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
