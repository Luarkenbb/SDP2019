-- phpMyAdmin SQL Dump
-- version 4.6.4
-- https://www.phpmyadmin.net/
--
-- 主機: 127.0.0.1
-- 產生時間： 2019-06-05 11:12:46
-- 伺服器版本: 5.7.14
-- PHP 版本： 5.6.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- 資料庫： `sdp`
--
CREATE DATABASE IF NOT EXISTS `sdp` DEFAULT CHARACTER SET utf8 COLLATE utf8_general_ci;
USE `sdp`;

-- --------------------------------------------------------

--
-- 資料表結構 `dealer`
--

DROP TABLE IF EXISTS `dealer`;
CREATE TABLE `dealer` (
  `dealerID` int(5) NOT NULL,
  `name` varchar(30) NOT NULL,
  `address` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `dealer`
--

INSERT INTO `dealer` (`dealerID`, `name`, `address`) VALUES
(1, 'alan po', 'vtc233333333333333333333'),
(2, 'kong fu', 'vtc23333'),
(3, 'peter ma', 'vtc 23111');

-- --------------------------------------------------------

--
-- 資料表結構 `department`
--

DROP TABLE IF EXISTS `department`;
CREATE TABLE `department` (
  `departmentID` int(2) NOT NULL,
  `departmentName` varchar(20) NOT NULL,
  `description` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `department`
--

INSERT INTO `department` (`departmentID`, `departmentName`, `description`) VALUES
(1, 'Sales', NULL),
(2, 'FreeRider', NULL);

-- --------------------------------------------------------

--
-- 資料表結構 `invoice`
--

DROP TABLE IF EXISTS `invoice`;
CREATE TABLE `invoice` (
  `orderSerial` varchar(7) NOT NULL,
  `weight` double(4,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- 資料表結構 `orderlist`
--

DROP TABLE IF EXISTS `orderlist`;
CREATE TABLE `orderlist` (
  `orderSerial` varchar(7) NOT NULL,
  `dealerID` int(5) NOT NULL,
  `invoiceAddress` varchar(100) DEFAULT NULL,
  `deliverAddress` varchar(100) NOT NULL,
  `orderDate` date NOT NULL,
  `logonID` int(5) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `orderlist`
--

INSERT INTO `orderlist` (`orderSerial`, `dealerID`, `invoiceAddress`, `deliverAddress`, `orderDate`, `logonID`) VALUES
('000001', 1, NULL, 'hong kong', '2019-05-02', 1);

-- --------------------------------------------------------

--
-- 資料表結構 `orderspare`
--

DROP TABLE IF EXISTS `orderspare`;
CREATE TABLE `orderspare` (
  `orderSpareID` varchar(10) NOT NULL,
  `orderSerial` varchar(7) NOT NULL,
  `spareID` varchar(7) NOT NULL,
  `quantityTotal` int(5) NOT NULL,
  `pricePerItem` double(7,2) NOT NULL,
  `status` varchar(10) NOT NULL,
  `toDeliverQuantity` int(5) NOT NULL,
  `followOrderID` varchar(7) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `orderspare`
--

INSERT INTO `orderspare` (`orderSpareID`, `orderSerial`, `spareID`, `quantityTotal`, `pricePerItem`, `status`, `toDeliverQuantity`, `followOrderID`) VALUES
('S000000001', '000001', 'AA00001', 100, 5000.00, 'packing', 100, NULL);

-- --------------------------------------------------------

--
-- 資料表結構 `reorder`
--

DROP TABLE IF EXISTS `reorder`;
CREATE TABLE `reorder` (
  `reOrderID` varchar(7) NOT NULL,
  `spareID` varchar(7) NOT NULL,
  `quantitySafeLine` int(5) NOT NULL,
  `status` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- 資料表結構 `saledata`
--

DROP TABLE IF EXISTS `saledata`;
CREATE TABLE `saledata` (
  `SpareID` varchar(7) NOT NULL,
  `date` date NOT NULL,
  `quantity` int(5) NOT NULL,
  `quantitySafeLine` int(5) NOT NULL,
  `description` varchar(50) NOT NULL,
  `price` double(7,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- 資料表結構 `spare`
--

DROP TABLE IF EXISTS `spare`;
CREATE TABLE `spare` (
  `SpareID` varchar(7) NOT NULL,
  `quantity` int(5) NOT NULL,
  `quantitySafeLine` int(5) NOT NULL,
  `description` varchar(50) DEFAULT NULL,
  `price` double(7,2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `spare`
--

INSERT INTO `spare` (`SpareID`, `quantity`, `quantitySafeLine`, `description`, `price`) VALUES
('AA00001', 950, 50, 'screw001', 5000.00),
('AA00002', 1000, 50, NULL, 400.00);

-- --------------------------------------------------------

--
-- 資料表結構 `tofolloworderspare`
--

DROP TABLE IF EXISTS `tofolloworderspare`;
CREATE TABLE `tofolloworderspare` (
  `followOrderID` varchar(7) NOT NULL,
  `orderSpareID` varchar(10) NOT NULL,
  `quantity` int(5) NOT NULL,
  `status` varchar(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- 資料表結構 `user`
--

DROP TABLE IF EXISTS `user`;
CREATE TABLE `user` (
  `logonID` int(5) NOT NULL,
  `logonPassword` varchar(255) NOT NULL,
  `name` varchar(30) NOT NULL,
  `userType` varchar(10) NOT NULL,
  `departmentID` int(2) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- 資料表的匯出資料 `user`
--

INSERT INTO `user` (`logonID`, `logonPassword`, `name`, `userType`, `departmentID`) VALUES
(1, 'MoC8yU7TqCjbo9FxVlEYiQ==', 'tsang ka ming', 'staff', 1),
(2, 'MoC8yU7TqCjbo9FxVlEYiQ==', 'Martin', 'admin', 1);

--
-- 已匯出資料表的索引
--

--
-- 資料表索引 `dealer`
--
ALTER TABLE `dealer`
  ADD PRIMARY KEY (`dealerID`);

--
-- 資料表索引 `department`
--
ALTER TABLE `department`
  ADD PRIMARY KEY (`departmentID`);

--
-- 資料表索引 `invoice`
--
ALTER TABLE `invoice`
  ADD PRIMARY KEY (`orderSerial`),
  ADD KEY `orderSerial` (`orderSerial`);

--
-- 資料表索引 `orderlist`
--
ALTER TABLE `orderlist`
  ADD PRIMARY KEY (`orderSerial`);

--
-- 資料表索引 `orderspare`
--
ALTER TABLE `orderspare`
  ADD PRIMARY KEY (`orderSpareID`);

--
-- 資料表索引 `reorder`
--
ALTER TABLE `reorder`
  ADD PRIMARY KEY (`reOrderID`);

--
-- 資料表索引 `saledata`
--
ALTER TABLE `saledata`
  ADD PRIMARY KEY (`SpareID`,`date`);

--
-- 資料表索引 `spare`
--
ALTER TABLE `spare`
  ADD PRIMARY KEY (`SpareID`);

--
-- 資料表索引 `tofolloworderspare`
--
ALTER TABLE `tofolloworderspare`
  ADD PRIMARY KEY (`followOrderID`);

--
-- 資料表索引 `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`logonID`);

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
