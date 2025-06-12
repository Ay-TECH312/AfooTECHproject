-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 12, 2025 at 05:30 PM
-- Server version: 10.4.22-MariaDB
-- PHP Version: 7.4.27

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `spms`
--

-- --------------------------------------------------------

--
-- Table structure for table `email_notifications`
--

CREATE TABLE `email_notifications` (
  `id` int(11) NOT NULL,
  `slotId` int(11) DEFAULT NULL,
  `userId` int(11) DEFAULT NULL,
  `emailSentTo` varchar(100) DEFAULT NULL,
  `message` text DEFAULT NULL,
  `is_active` tinyint(1) DEFAULT 1,
  `sent_at` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `gate_control`
--

CREATE TABLE `gate_control` (
  `gateControlId` int(11) NOT NULL,
  `slot_id` int(11) NOT NULL,
  `statusId` int(11) NOT NULL,
  `auto_close_enabled` tinyint(1) DEFAULT 1,
  `updated_at` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `location_tab`
--

CREATE TABLE `location_tab` (
  `locationId` varchar(100) NOT NULL,
  `locationName` varchar(50) NOT NULL,
  `addedBy` varchar(100) DEFAULT NULL,
  `createdTime` datetime DEFAULT NULL,
  `last_updated` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `parking_log`
--

CREATE TABLE `parking_log` (
  `parkingLogId` int(11) NOT NULL,
  `userId` int(11) DEFAULT NULL,
  `slotId` int(11) DEFAULT NULL,
  `statusId` int(11) NOT NULL,
  `timestamp` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `parking_slot_tab`
--

CREATE TABLE `parking_slot_tab` (
  `parkingSlotId` int(100) NOT NULL,
  `sensor_code` varchar(50) NOT NULL,
  `locationId` varchar(100) DEFAULT NULL,
  `statusId` int(11) NOT NULL,
  `last_updated` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `setup_gender_tab`
--

CREATE TABLE `setup_gender_tab` (
  `genderId` int(11) NOT NULL,
  `genderName` varchar(50) NOT NULL,
  `createdTime` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `setup_gender_tab`
--

INSERT INTO `setup_gender_tab` (`genderId`, `genderName`, `createdTime`) VALUES
(1, 'MALE', '2025-06-09 08:54:34'),
(2, 'FEMALE', '2025-06-09 08:54:34');

-- --------------------------------------------------------

--
-- Table structure for table `setup_role_tab`
--

CREATE TABLE `setup_role_tab` (
  `roleId` int(11) NOT NULL,
  `roleName` varchar(50) NOT NULL,
  `createdTime` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `setup_role_tab`
--

INSERT INTO `setup_role_tab` (`roleId`, `roleName`, `createdTime`) VALUES
(1, 'SUPER ADMIN', '2025-06-09 08:56:52'),
(2, 'ADMIN', '2025-06-09 08:56:52'),
(3, 'STAFF', '2025-06-09 08:56:52'),
(4, 'USER', '2025-06-09 08:56:52');

-- --------------------------------------------------------

--
-- Table structure for table `setup_status_tab`
--

CREATE TABLE `setup_status_tab` (
  `statusId` int(11) NOT NULL,
  `statusName` varchar(50) NOT NULL,
  `createdTime` datetime DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `setup_status_tab`
--

INSERT INTO `setup_status_tab` (`statusId`, `statusName`, `createdTime`) VALUES
(1, 'ACTIVE', '2025-06-09 08:56:00'),
(2, 'OCCUPIED', '2025-06-09 08:56:00'),
(3, 'VACANT', '2025-06-09 08:56:00'),
(4, 'OPEN', '2025-06-09 08:56:00'),
(5, 'CLOSED', '2025-06-09 08:56:00'),
(6, 'RESERVED', '2025-06-09 08:56:00'),
(7, 'CANCELLED', '2025-06-09 08:56:00'),
(8, 'COMPLETED', '2025-06-09 08:56:00'),
(9, 'EXITED', '2025-06-09 08:56:00'),
(10, 'ENTERED', '2025-06-09 08:56:00'),
(11, 'PENDING', '2025-06-09 08:56:00'),
(12, 'RESOLVED', '2025-06-09 08:56:00');

-- --------------------------------------------------------

--
-- Table structure for table `staff_tab`
--

CREATE TABLE `staff_tab` (
  `sn` int(11) NOT NULL,
  `staffId` varchar(55) NOT NULL,
  `firstName` varchar(255) NOT NULL,
  `middleName` varchar(255) DEFAULT NULL,
  `lastName` varchar(255) NOT NULL,
  `mobileNumber` varchar(50) NOT NULL,
  `emailAddress` varchar(255) NOT NULL,
  `genderId` int(11) NOT NULL,
  `roleId` int(11) NOT NULL,
  `statusId` int(11) NOT NULL,
  `passport` varchar(255) DEFAULT NULL,
  `password` varchar(255) NOT NULL,
  `otp` varchar(10) DEFAULT NULL,
  `lastLogin` datetime DEFAULT NULL,
  `createdTime` datetime DEFAULT current_timestamp(),
  `updatedTime` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `system_settings`
--

CREATE TABLE `system_settings` (
  `id` int(11) NOT NULL,
  `key_name` varchar(100) NOT NULL,
  `value` text DEFAULT NULL,
  `updated_at` datetime DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `user_feedback`
--

CREATE TABLE `user_feedback` (
  `id` int(11) NOT NULL,
  `userId` int(11) DEFAULT NULL,
  `message` text NOT NULL,
  `reply` text DEFAULT NULL,
  `statusId` int(11) NOT NULL,
  `submitted_at` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `user_reservation`
--

CREATE TABLE `user_reservation` (
  `id` int(11) NOT NULL,
  `userId` int(11) NOT NULL,
  `slotId` int(11) NOT NULL,
  `statusId` int(11) NOT NULL,
  `startTime` datetime DEFAULT NULL,
  `endTime` datetime DEFAULT NULL,
  `createdTime` datetime DEFAULT current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Table structure for table `user_tab`
--

CREATE TABLE `user_tab` (
  `sn` int(11) NOT NULL,
  `userId` varchar(55) NOT NULL,
  `firstName` varchar(255) NOT NULL,
  `middleName` varchar(255) DEFAULT NULL,
  `lastName` varchar(255) NOT NULL,
  `mobileNumber` varchar(50) NOT NULL,
  `emailAddress` varchar(255) NOT NULL,
  `genderId` int(11) NOT NULL,
  `statusId` int(11) NOT NULL,
  `passport` varchar(255) DEFAULT NULL,
  `password` varchar(255) NOT NULL,
  `otp` varchar(10) DEFAULT NULL,
  `lastLogin` datetime DEFAULT NULL,
  `createdTime` datetime DEFAULT current_timestamp(),
  `updatedTime` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `email_notifications`
--
ALTER TABLE `email_notifications`
  ADD PRIMARY KEY (`id`),
  ADD KEY `slotId` (`slotId`),
  ADD KEY `userId` (`userId`);

--
-- Indexes for table `gate_control`
--
ALTER TABLE `gate_control`
  ADD PRIMARY KEY (`gateControlId`),
  ADD KEY `slot_id` (`slot_id`),
  ADD KEY `statusId` (`statusId`);

--
-- Indexes for table `location_tab`
--
ALTER TABLE `location_tab`
  ADD PRIMARY KEY (`locationId`);

--
-- Indexes for table `parking_log`
--
ALTER TABLE `parking_log`
  ADD PRIMARY KEY (`parkingLogId`),
  ADD KEY `userId` (`userId`),
  ADD KEY `slotId` (`slotId`),
  ADD KEY `statusId` (`statusId`);

--
-- Indexes for table `parking_slot_tab`
--
ALTER TABLE `parking_slot_tab`
  ADD PRIMARY KEY (`parkingSlotId`),
  ADD UNIQUE KEY `sensor_code` (`sensor_code`),
  ADD KEY `statusId` (`statusId`),
  ADD KEY `locationId` (`locationId`);

--
-- Indexes for table `setup_gender_tab`
--
ALTER TABLE `setup_gender_tab`
  ADD PRIMARY KEY (`genderId`);

--
-- Indexes for table `setup_role_tab`
--
ALTER TABLE `setup_role_tab`
  ADD PRIMARY KEY (`roleId`);

--
-- Indexes for table `setup_status_tab`
--
ALTER TABLE `setup_status_tab`
  ADD PRIMARY KEY (`statusId`);

--
-- Indexes for table `staff_tab`
--
ALTER TABLE `staff_tab`
  ADD PRIMARY KEY (`sn`),
  ADD UNIQUE KEY `staffId` (`staffId`),
  ADD UNIQUE KEY `emailAddress` (`emailAddress`),
  ADD KEY `genderId` (`genderId`),
  ADD KEY `roleId` (`roleId`),
  ADD KEY `statusId` (`statusId`);

--
-- Indexes for table `system_settings`
--
ALTER TABLE `system_settings`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `key_name` (`key_name`);

--
-- Indexes for table `user_feedback`
--
ALTER TABLE `user_feedback`
  ADD PRIMARY KEY (`id`),
  ADD KEY `userId` (`userId`),
  ADD KEY `statusId` (`statusId`);

--
-- Indexes for table `user_reservation`
--
ALTER TABLE `user_reservation`
  ADD PRIMARY KEY (`id`),
  ADD KEY `userId` (`userId`),
  ADD KEY `slotId` (`slotId`),
  ADD KEY `statusId` (`statusId`);

--
-- Indexes for table `user_tab`
--
ALTER TABLE `user_tab`
  ADD PRIMARY KEY (`sn`),
  ADD UNIQUE KEY `userId` (`userId`),
  ADD UNIQUE KEY `emailAddress` (`emailAddress`),
  ADD KEY `genderId` (`genderId`),
  ADD KEY `statusId` (`statusId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `email_notifications`
--
ALTER TABLE `email_notifications`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `gate_control`
--
ALTER TABLE `gate_control`
  MODIFY `gateControlId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `parking_log`
--
ALTER TABLE `parking_log`
  MODIFY `parkingLogId` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `staff_tab`
--
ALTER TABLE `staff_tab`
  MODIFY `sn` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `system_settings`
--
ALTER TABLE `system_settings`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `user_feedback`
--
ALTER TABLE `user_feedback`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `user_reservation`
--
ALTER TABLE `user_reservation`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `user_tab`
--
ALTER TABLE `user_tab`
  MODIFY `sn` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `email_notifications`
--
ALTER TABLE `email_notifications`
  ADD CONSTRAINT `email_notifications_ibfk_1` FOREIGN KEY (`slotId`) REFERENCES `parking_slot_tab` (`parkingSlotId`),
  ADD CONSTRAINT `email_notifications_ibfk_2` FOREIGN KEY (`userId`) REFERENCES `user_tab` (`sn`);

--
-- Constraints for table `gate_control`
--
ALTER TABLE `gate_control`
  ADD CONSTRAINT `gate_control_ibfk_1` FOREIGN KEY (`slot_id`) REFERENCES `parking_slot_tab` (`parkingSlotId`),
  ADD CONSTRAINT `gate_control_ibfk_2` FOREIGN KEY (`statusId`) REFERENCES `setup_status_tab` (`statusId`);

--
-- Constraints for table `parking_log`
--
ALTER TABLE `parking_log`
  ADD CONSTRAINT `parking_log_ibfk_1` FOREIGN KEY (`userId`) REFERENCES `user_tab` (`sn`),
  ADD CONSTRAINT `parking_log_ibfk_2` FOREIGN KEY (`slotId`) REFERENCES `parking_slot_tab` (`parkingSlotId`),
  ADD CONSTRAINT `parking_log_ibfk_3` FOREIGN KEY (`statusId`) REFERENCES `setup_status_tab` (`statusId`);

--
-- Constraints for table `parking_slot_tab`
--
ALTER TABLE `parking_slot_tab`
  ADD CONSTRAINT `parking_slot_tab_ibfk_1` FOREIGN KEY (`statusId`) REFERENCES `setup_status_tab` (`statusId`),
  ADD CONSTRAINT `parking_slot_tab_ibfk_2` FOREIGN KEY (`locationId`) REFERENCES `location_tab` (`locationId`);

--
-- Constraints for table `staff_tab`
--
ALTER TABLE `staff_tab`
  ADD CONSTRAINT `staff_tab_ibfk_1` FOREIGN KEY (`genderId`) REFERENCES `setup_gender_tab` (`genderId`),
  ADD CONSTRAINT `staff_tab_ibfk_2` FOREIGN KEY (`roleId`) REFERENCES `setup_role_tab` (`roleId`),
  ADD CONSTRAINT `staff_tab_ibfk_3` FOREIGN KEY (`statusId`) REFERENCES `setup_status_tab` (`statusId`);

--
-- Constraints for table `user_feedback`
--
ALTER TABLE `user_feedback`
  ADD CONSTRAINT `user_feedback_ibfk_1` FOREIGN KEY (`userId`) REFERENCES `user_tab` (`sn`),
  ADD CONSTRAINT `user_feedback_ibfk_2` FOREIGN KEY (`statusId`) REFERENCES `setup_status_tab` (`statusId`);

--
-- Constraints for table `user_reservation`
--
ALTER TABLE `user_reservation`
  ADD CONSTRAINT `user_reservation_ibfk_1` FOREIGN KEY (`userId`) REFERENCES `user_tab` (`sn`),
  ADD CONSTRAINT `user_reservation_ibfk_2` FOREIGN KEY (`slotId`) REFERENCES `parking_slot_tab` (`parkingSlotId`),
  ADD CONSTRAINT `user_reservation_ibfk_3` FOREIGN KEY (`statusId`) REFERENCES `setup_status_tab` (`statusId`);

--
-- Constraints for table `user_tab`
--
ALTER TABLE `user_tab`
  ADD CONSTRAINT `user_tab_ibfk_1` FOREIGN KEY (`genderId`) REFERENCES `setup_gender_tab` (`genderId`),
  ADD CONSTRAINT `user_tab_ibfk_2` FOREIGN KEY (`statusId`) REFERENCES `setup_status_tab` (`statusId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
