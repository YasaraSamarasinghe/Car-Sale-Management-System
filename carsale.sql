-- phpMyAdmin SQL Dump
-- version 3.5.1
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Aug 10, 2014 at 03:02 PM
-- Server version: 5.5.24-log
-- PHP Version: 5.3.13

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `carsale`
--

-- --------------------------------------------------------

--
-- Table structure for table `billingdetails`
--

CREATE TABLE IF NOT EXISTS `billingdetails` (
  `BillNumber` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerID` int(11) NOT NULL,
  `VehicleID` int(11) NOT NULL,
  `PhoneNo` int(10) NOT NULL,
  `Email` varchar(40) NOT NULL,
  `HandOverTo` varchar(30) NOT NULL,
  `TotalAmount` int(11) NOT NULL,
  PRIMARY KEY (`BillNumber`),
  KEY `CustomerID` (`CustomerID`),
  KEY `CustomerID_2` (`CustomerID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=10 ;

--
-- Dumping data for table `billingdetails`
--

INSERT INTO `billingdetails` (`BillNumber`, `CustomerID`, `VehicleID`, `PhoneNo`, `Email`, `HandOverTo`, `TotalAmount`) VALUES
(1, 0, 0, 0, '', '', 0),
(2, 0, 0, 322257227, 'hotmail', 'dhanoj', 0),
(3, 0, 0, 1516316, 'edededd', 'dedede', 0),
(4, 0, 0, 718807210, 'gamil', 'navoda', 0),
(5, 0, 0, 0, 'hj', 'hj', 0),
(6, 0, 0, 718807210, 'dhanojbtj619@hotmail.com', 'amila', 0),
(7, 3, 2, 322257227, 'gmail', 'subash', 10000),
(8, 0, 0, 0, '', '', 0),
(9, 2, 3, 55555, '55555', '55555', 55555);

-- --------------------------------------------------------

--
-- Table structure for table `customercomplains`
--

CREATE TABLE IF NOT EXISTS `customercomplains` (
  `ComplainNumber` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerID` int(11) NOT NULL,
  `VehicleID` int(11) NOT NULL,
  `Complains` varchar(255) NOT NULL,
  `ServiceType` varchar(15) NOT NULL,
  `Status` varchar(10) NOT NULL,
  PRIMARY KEY (`ComplainNumber`),
  KEY `CustomerID` (`CustomerID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=8 ;

--
-- Dumping data for table `customercomplains`
--

INSERT INTO `customercomplains` (`ComplainNumber`, `CustomerID`, `VehicleID`, `Complains`, `ServiceType`, `Status`) VALUES
(1, 0, 2, 'engin trouble', 'gold', 'repaired'),
(2, 0, 3, 'bad repair', 'Gold', 'repaired'),
(3, 0, 3, 'service not good', 'Silver', 'Not Repair'),
(4, 2, 3, 'bad', 'Gold', 'Repaired'),
(5, 2, 3, 'bad', 'Gold', 'Repaired'),
(6, 2, 15, 'not good ', 'Premier', 'Repaired'),
(7, 0, 0, '', '', '');

-- --------------------------------------------------------

--
-- Table structure for table `customerregistration`
--

CREATE TABLE IF NOT EXISTS `customerregistration` (
  `CustomerID` int(11) NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(30) NOT NULL,
  `LastName` varchar(30) NOT NULL,
  `DateOfBirth` date NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `PhoneNo` int(10) NOT NULL,
  `Email` varchar(30) NOT NULL,
  `VehicleID` int(11) NOT NULL,
  PRIMARY KEY (`CustomerID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=11 ;

--
-- Dumping data for table `customerregistration`
--

INSERT INTO `customerregistration` (`CustomerID`, `FirstName`, `LastName`, `DateOfBirth`, `Gender`, `Address`, `PhoneNo`, `Email`, `VehicleID`) VALUES
(6, 'ruvini', 'manage', '1990-06-12', 'female', 'maharagama', 710000000, 'ruvini@gmail.com', 2),
(7, 'navoda', 'wijenakaya', '1994-06-12', 'male', 'morotuwa', 710000000, 'navodafox@gmail.com', 1),
(8, 'pasidu', 'chamathka', '1994-06-12', 'male', 'kohuwala', 710000000, 'pasidu@gmail.com', 5),
(9, 'harani', 'cooray', '1994-06-12', 'female', 'panadura', 710000000, 'harini@gmail.com', 3),
(10, 'dhanoj', 'botheju', '1994-06-12', 'male', 'negombo', 710000000, 'dhanoj@gmail.com', 4);

-- --------------------------------------------------------

--
-- Table structure for table `customerresponses`
--

CREATE TABLE IF NOT EXISTS `customerresponses` (
  `ResponseNumber` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerID` int(11) NOT NULL,
  `VehicleID` int(11) NOT NULL,
  `Comments` varchar(255) NOT NULL,
  PRIMARY KEY (`ResponseNumber`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `customerresponses`
--

INSERT INTO `customerresponses` (`ResponseNumber`, `CustomerID`, `VehicleID`, `Comments`) VALUES
(1, 0, 2, 'good service'),
(2, 2, 2, 'sdsdsd'),
(3, 0, 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `dealerregistration`
--

CREATE TABLE IF NOT EXISTS `dealerregistration` (
  `DealerID` int(11) NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(35) NOT NULL,
  `Sername` varchar(30) NOT NULL,
  `DateOfBirth` date NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `Address` varchar(45) NOT NULL,
  `PhoneNo` int(10) NOT NULL,
  `Email` varchar(40) NOT NULL,
  PRIMARY KEY (`DealerID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `dealerregistration`
--

INSERT INTO `dealerregistration` (`DealerID`, `FirstName`, `Sername`, `DateOfBirth`, `Gender`, `Address`, `PhoneNo`, `Email`) VALUES
(1, 'Dhanoj', 'botheju', '0000-00-00', '', 'begombo', 322257227, 'hotmail'),
(2, '', 'wijenayaka', '2014-07-29', '', '', 0, ''),
(3, 'ruvini', 'manage', '1990-06-13', 'female', 'maharagama', 710000000, 'ruvini@gmail.com');

-- --------------------------------------------------------

--
-- Table structure for table `employeeregistration`
--

CREATE TABLE IF NOT EXISTS `employeeregistration` (
  `EmployeeID` int(11) NOT NULL AUTO_INCREMENT,
  `FirstName` varchar(35) NOT NULL,
  `Sername` varchar(30) NOT NULL,
  `DateOfBirth` date NOT NULL,
  `Gender` varchar(10) NOT NULL,
  `Address` varchar(50) NOT NULL,
  `PhoneNo` int(10) NOT NULL,
  `Email` varchar(30) NOT NULL,
  `Devision` varchar(15) NOT NULL,
  PRIMARY KEY (`EmployeeID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `employeeregistration`
--

INSERT INTO `employeeregistration` (`EmployeeID`, `FirstName`, `Sername`, `DateOfBirth`, `Gender`, `Address`, `PhoneNo`, `Email`, `Devision`) VALUES
(1, 'dhanoj', 'botheju', '0000-00-00', '', 'negombo', 322257227, 'hotmail', 'service'),
(2, 'navoda', 'wijenayaka', '2014-07-11', '', 'morotuwa', 718807210, 'gmail', 'service'),
(3, 'ruvini', 'manage', '1990-06-13', 'female', 'maharagama', 7100000, 'ruvini@hotmail.com', 'service'),
(4, 'Pasidu', 'Chamathka', '2014-07-01', 'male', 'nugegoda', 712257227, 'gmail', 'Driver'),
(5, 'dhanoj', 'botheju', '1994-03-23', 'male', 'negombo', 710000000, 'dhanoj@gmail.com', 'Car sale');

-- --------------------------------------------------------

--
-- Table structure for table `servicedetails`
--

CREATE TABLE IF NOT EXISTS `servicedetails` (
  `ServiceNumber` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerID` int(11) NOT NULL,
  `VehicleID` int(11) NOT NULL,
  `EquipmentsUsed` varchar(35) NOT NULL,
  `ServiceType` varchar(25) NOT NULL,
  `PartsChanged` varchar(100) NOT NULL,
  `ServiceCharges` int(5) NOT NULL,
  `TotalAmount` int(5) NOT NULL,
  PRIMARY KEY (`ServiceNumber`),
  KEY `VehicleID` (`VehicleID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=6 ;

--
-- Dumping data for table `servicedetails`
--

INSERT INTO `servicedetails` (`ServiceNumber`, `CustomerID`, `VehicleID`, `EquipmentsUsed`, `ServiceType`, `PartsChanged`, `ServiceCharges`, `TotalAmount`) VALUES
(1, 0, 2, 'equipments', 'gold', 'gear box', 20, 35),
(2, 0, 3, 'eqiup', 'Premier', 'breaks', 200, 2000),
(3, 0, 8, 'charger', 'Premier', 'gearbox', 21, 35),
(4, 2, 2, 'ghg', 'Platinum', 'ghg', 0, 0),
(5, 0, 0, '', '', '', 0, 0);

-- --------------------------------------------------------

--
-- Table structure for table `submissiondetails`
--

CREATE TABLE IF NOT EXISTS `submissiondetails` (
  `SubmissionNumber` int(11) NOT NULL AUTO_INCREMENT,
  `CustomerID` int(11) NOT NULL,
  `VehicleID` int(11) NOT NULL,
  `HandOverTo` varchar(40) NOT NULL,
  PRIMARY KEY (`SubmissionNumber`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `submissiondetails`
--

INSERT INTO `submissiondetails` (`SubmissionNumber`, `CustomerID`, `VehicleID`, `HandOverTo`) VALUES
(1, 0, 2, 'dhanoj'),
(2, 2, 3, 'akask'),
(3, 0, 0, '');

-- --------------------------------------------------------

--
-- Table structure for table `users`
--

CREATE TABLE IF NOT EXISTS `users` (
  `Username` varchar(20) NOT NULL,
  `Password` varchar(8) NOT NULL,
  PRIMARY KEY (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users`
--

INSERT INTO `users` (`Username`, `Password`) VALUES
('admin', '*196BDED'),
('dhanoj', 'pass'),
('navoda', 'passs'),
('new', 'pass'),
('pasidu', 'new'),
('ruvini', 'pass');

-- --------------------------------------------------------

--
-- Table structure for table `vehicalregistration`
--

CREATE TABLE IF NOT EXISTS `vehicalregistration` (
  `VehicleID` int(11) NOT NULL AUTO_INCREMENT,
  `VehicleType` varchar(10) NOT NULL,
  `VehicleModel` varchar(15) NOT NULL,
  `Color` varchar(10) NOT NULL,
  `Status` varchar(20) NOT NULL,
  `Transmission` varchar(10) NOT NULL,
  `Condition` varchar(20) NOT NULL,
  `Capacity` varchar(20) NOT NULL,
  `Paymenttype` varchar(15) NOT NULL,
  PRIMARY KEY (`VehicleID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `vehicles`
--

CREATE TABLE IF NOT EXISTS `vehicles` (
  `VehicleID` int(11) NOT NULL AUTO_INCREMENT,
  `VehicleType` varchar(10) NOT NULL,
  `VehicleModel` varchar(15) NOT NULL,
  `Color` varchar(10) NOT NULL,
  `Status` varchar(15) NOT NULL,
  `Transmission` varchar(10) NOT NULL,
  `CarCondition` varchar(15) NOT NULL,
  `CarCapacity` varchar(6) NOT NULL,
  `Payment` varchar(15) NOT NULL,
  PRIMARY KEY (`VehicleID`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=4 ;

--
-- Dumping data for table `vehicles`
--

INSERT INTO `vehicles` (`VehicleID`, `VehicleType`, `VehicleModel`, `Color`, `Status`, `Transmission`, `CarCondition`, `CarCapacity`, `Payment`) VALUES
(1, 'fff', 'ttt', 'ghjg', 'g', 'hg', '', 'hg', 'hghg'),
(2, 'dsds', 'dsdsdsds', 'sdsdsdsds', 'fghfg', 'gf', 'g', 'gf', 'g'),
(3, 'Threeweale', 'Bajaj', 'red', 'Unregistered', 'Manual', 'basic', '1000', 'Leasing');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
