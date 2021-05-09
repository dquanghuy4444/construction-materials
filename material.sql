-- phpMyAdmin SQL Dump
-- version 5.0.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: May 09, 2021 at 12:47 PM
-- Server version: 10.4.17-MariaDB
-- PHP Version: 8.0.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `material`
--

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `id` int(11) NOT NULL,
  `fullname` varchar(45) DEFAULT NULL,
  `address` varchar(200) DEFAULT NULL,
  `phone` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `created_at` varchar(32) NOT NULL,
  `description` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`id`, `fullname`, `address`, `phone`, `email`, `created_at`, `description`) VALUES
(1, 'Đặng Qiuang', 'Cổ Nhuế', '0963181689', 'abc#gmail.com', '0000-00-00 00:00:00', '1'),
(2, 'Huy 123', 'HN', '0963181681', 'abc@gmail.com', '', '111');

-- --------------------------------------------------------

--
-- Table structure for table `product`
--

CREATE TABLE `product` (
  `id` int(11) NOT NULL,
  `fullname` varchar(45) DEFAULT NULL,
  `group_id` int(11) DEFAULT NULL,
  `description` varchar(200) DEFAULT NULL,
  `create_at` varchar(45) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `product`
--

INSERT INTO `product` (`id`, `fullname`, `group_id`, `description`, `create_at`) VALUES
(1, 'Sắt 30kg', 1, '1', NULL),
(2, 'Sắt 20kg', 2, '1', NULL),
(3, 'Sắt 20kg', 1, '1', NULL),
(4, 'Sắt 20kg', 1, '1', NULL),
(5, 'Sắt 20kg', 1, '1', NULL),
(6, 'Sắt 20kg', 1, '1', NULL),
(7, 'Sắt 20kg', 1, '1', NULL),
(8, 'Đá cẩm thạch', 2, '', NULL),
(9, 'Xi măng 20', 3, '', NULL),
(10, 'Bê tông 20', 5, 'Bê tông cứng', NULL);

-- --------------------------------------------------------

--
-- Table structure for table `product_group`
--

CREATE TABLE `product_group` (
  `id` int(11) NOT NULL,
  `fullname` varchar(45) DEFAULT NULL,
  `status` int(11) DEFAULT NULL,
  `description` varchar(200) DEFAULT NULL,
  `create_at` varchar(45) DEFAULT NULL,
  `unit_id` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `product_group`
--

INSERT INTO `product_group` (`id`, `fullname`, `status`, `description`, `create_at`, `unit_id`) VALUES
(1, 'Sắt phi', 1, 'Sắt', NULL, 1),
(2, 'Đá', 1, 'Đá', NULL, 4),
(3, 'Xi măng', 1, 'Xi măng', NULL, 5),
(4, 'Gạch', 1, 'Gạch', NULL, 2),
(5, 'Bê tông', 1, 'Bê tông', NULL, 2),
(6, 'Thép', NULL, '', NULL, 1);

-- --------------------------------------------------------

--
-- Table structure for table `product_unit`
--

CREATE TABLE `product_unit` (
  `id` int(11) NOT NULL,
  `fullname` varchar(45) DEFAULT NULL,
  `description` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `product_unit`
--

INSERT INTO `product_unit` (`id`, `fullname`, `description`) VALUES
(1, 'kilogram', ''),
(2, 'bao', NULL),
(3, 'miếng', NULL),
(4, 'thanh ngang', 'Thanh dài 1m\nCó cân nặng 20kg\n'),
(5, 'tấm', 'tấm nặng trung bình 100 kg'),
(6, 'thùng', '');

-- --------------------------------------------------------

--
-- Table structure for table `supplier`
--

CREATE TABLE `supplier` (
  `id` int(11) NOT NULL,
  `fullname` varchar(200) DEFAULT NULL,
  `description` varchar(200) DEFAULT NULL,
  `phone` varchar(45) DEFAULT NULL,
  `address` varchar(200) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `created_at` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `supplier`
--

INSERT INTO `supplier` (`id`, `fullname`, `description`, `phone`, `address`, `email`, `created_at`) VALUES
(1, 'Cty AB', 'Huy', '0978787872', 'Hà nội \nádasd', 'abc123@gmail.com', '0000-00-00 00:00:00'),
(2, 'Cty ABC', 'Cty A', 'Cty A', 'Cty A', 'abc@gmail.com', '0000-00-00 00:00:00'),
(9, 'Huy', '1', '0963181679', '1', 'wepio@gmail.com', '');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `username` varchar(45) DEFAULT NULL,
  `password` varchar(45) DEFAULT NULL,
  `fullname` varchar(45) DEFAULT NULL,
  `birthday` varchar(32) DEFAULT NULL,
  `sex` int(11) DEFAULT NULL,
  `phone` varchar(45) DEFAULT NULL,
  `email` varchar(45) DEFAULT NULL,
  `address` varchar(45) DEFAULT NULL,
  `created_at` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id`, `username`, `password`, `fullname`, `birthday`, `sex`, `phone`, `email`, `address`, `created_at`) VALUES
(1, 'huy', 'c4ca4238a0b923820dcc509a6f75849b', 'Đặng Quang Huy', '08 May 2020', 1, '5555123', 'Đặng Quang Huy 123665', 'Hà Nội', '0000-00-00 00:00:00');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UC_customer` (`id`,`fullname`) USING BTREE;

--
-- Indexes for table `product`
--
ALTER TABLE `product`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `product_group`
--
ALTER TABLE `product_group`
  ADD UNIQUE KEY `id_UNIQUE` (`id`);

--
-- Indexes for table `product_unit`
--
ALTER TABLE `product_unit`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `supplier`
--
ALTER TABLE `supplier`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `UC_supplier` (`id`,`fullname`) USING BTREE;

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `product`
--
ALTER TABLE `product`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `product_group`
--
ALTER TABLE `product_group`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `product_unit`
--
ALTER TABLE `product_unit`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `supplier`
--
ALTER TABLE `supplier`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
