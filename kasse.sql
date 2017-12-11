-- phpMyAdmin SQL Dump
-- version 4.7.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 24. Nov 2017 um 13:56
-- Server-Version: 10.1.28-MariaDB
-- PHP-Version: 7.1.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `kasse`
--

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `history`
--

CREATE TABLE `history` (
  `UID` int(11) NOT NULL,
  `order_ID` int(11) NOT NULL,
  `itemname` text NOT NULL,
  `vat_tax` float NOT NULL,
  `price` float NOT NULL,
  `date` timestamp NOT NULL DEFAULT CURRENT_TIMESTAMP
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `items`
--

CREATE TABLE `items` (
  `IID` int(11) NOT NULL,
  `item_name` text NOT NULL,
  `item_price` float NOT NULL,
  `item_category` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Daten für Tabelle `items`
--

INSERT INTO `items` (`IID`, `item_name`, `item_price`, `item_category`) VALUES
(1, 'Hamburger', 4.5, 'burger'),
(2, 'Cheeseburger', 4.5, 'burger'),
(3, 'BBQ Bacon Cheese', 7, 'burger'),
(4, 'Veggieburger', 15, 'burger'),
(5, 'Big Shak', 6.5, 'burger'),
(6, 'Coke 0.5', 3, 'drink'),
(7, 'Coke 0.4', 2, 'drink'),
(8, 'Coke 0.3', 1.5, 'drink'),
(9, 'Coke 0.3', 1.5, 'drink'),
(10, 'Kaffee 0.5', 2, 'drink'),
(11, 'Kaffee 0.4', 1.5, 'drink'),
(12, 'Kaffee 0.3', 1, 'drink'),
(13, 'Pommes Groß', 2.2, 'pommes'),
(14, 'Pommes Mittel', 1.8, 'pommes'),
(15, 'Pommes Klein', 1.5, 'pommes');

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `history`
--
ALTER TABLE `history`
  ADD PRIMARY KEY (`UID`);

--
-- Indizes für die Tabelle `items`
--
ALTER TABLE `items`
  ADD PRIMARY KEY (`IID`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `history`
--
ALTER TABLE `history`
  MODIFY `UID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `items`
--
ALTER TABLE `items`
  MODIFY `IID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
