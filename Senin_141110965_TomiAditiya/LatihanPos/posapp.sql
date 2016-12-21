-- phpMyAdmin SQL Dump
-- version 4.5.1
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: 21 Des 2016 pada 07.19
-- Versi Server: 10.1.16-MariaDB
-- PHP Version: 5.6.24

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `posapp`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `account`
--

CREATE TABLE `account` (
  `id` int(11) NOT NULL,
  `username` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL,
  `level` varchar(45) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `account`
--

INSERT INTO `account` (`id`, `username`, `password`, `level`) VALUES
(1, 'admin', 'admin', 'Master');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tblbarang`
--

CREATE TABLE `tblbarang` (
  `idbarang` int(11) NOT NULL,
  `kodeBarang` varchar(20) NOT NULL,
  `namaBarang` varchar(100) NOT NULL,
  `jlhAwal` int(10) NOT NULL,
  `hrgHPP` decimal(16,2) NOT NULL,
  `hrgJual` decimal(16,2) NOT NULL,
  `created_at` datetime NOT NULL,
  `update_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tblbarang`
--

INSERT INTO `tblbarang` (`idbarang`, `kodeBarang`, `namaBarang`, `jlhAwal`, `hrgHPP`, `hrgJual`, `created_at`, `update_at`) VALUES
(3, '003', 'Soto Ayam', 2, '2000.00', '3000.00', '2016-12-14 11:04:30', '2016-12-14 11:04:30'),
(4, '004', 'Merica', 200, '500.00', '1000.00', '2016-12-14 11:07:12', '2016-12-14 11:07:12'),
(5, '005', 'Kecap Bango Botol', 5, '1200.00', '2500.00', '2016-12-14 11:09:16', '2016-12-21 02:18:31'),
(6, '006', 'Kecap Asin', 23, '1000.00', '1500.00', '2016-12-14 11:10:03', '2016-12-14 11:10:03'),
(7, '007', 'Kecap ABC', 26, '2500.00', '3000.00', '2016-12-14 11:12:09', '2016-12-14 11:12:09'),
(8, '008', 'Teh Bendera', 50, '2500.00', '3000.00', '2016-12-14 11:22:25', '2016-12-14 11:22:25'),
(11, '010', 'ayam', 5, '50000.00', '60000.00', '2016-12-14 13:44:37', '2016-12-14 13:44:37'),
(12, '012', 'Gula', 45, '45.00', '45.00', '2016-12-14 13:49:27', '2016-12-21 02:19:42'),
(13, '013', 'asd', 455, '455.00', '4555.00', '2016-12-14 13:51:13', '2016-12-14 13:51:13'),
(14, '0015', 'asd', 500, '500.00', '500.00', '2016-12-14 13:53:55', '2016-12-14 13:53:55'),
(15, '016', 'asd', 56, '56.00', '56.00', '2016-12-14 13:54:31', '2016-12-14 13:54:31'),
(16, '0015', 'Susu Milk', 5, '2000.00', '5000.00', '2016-12-20 15:24:13', '2016-12-20 15:24:13'),
(17, '0020', 'cendol', 150, '1500.00', '2000.00', '2016-12-20 15:30:22', '2016-12-20 15:30:22');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tblcustomer`
--

CREATE TABLE `tblcustomer` (
  `idcust` int(11) NOT NULL,
  `nama` varchar(50) NOT NULL,
  `alamat` varchar(255) NOT NULL,
  `kodepos` varchar(10) NOT NULL,
  `email` varchar(50) NOT NULL,
  `nohp` varchar(13) NOT NULL,
  `created_at` datetime NOT NULL,
  `updated_at` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `tblcustomer`
--

INSERT INTO `tblcustomer` (`idcust`, `nama`, `alamat`, `kodepos`, `email`, `nohp`, `created_at`, `updated_at`) VALUES
(2, 'Tommy', 'Jl Mana saja', '20132', 'tommyaditya0606@gmail.com', '085206925484', '2016-12-21 13:14:51', '2016-12-21 13:14:51');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `account`
--
ALTER TABLE `account`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tblbarang`
--
ALTER TABLE `tblbarang`
  ADD PRIMARY KEY (`idbarang`);

--
-- Indexes for table `tblcustomer`
--
ALTER TABLE `tblcustomer`
  ADD PRIMARY KEY (`idcust`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `account`
--
ALTER TABLE `account`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;
--
-- AUTO_INCREMENT for table `tblbarang`
--
ALTER TABLE `tblbarang`
  MODIFY `idbarang` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;
--
-- AUTO_INCREMENT for table `tblcustomer`
--
ALTER TABLE `tblcustomer`
  MODIFY `idcust` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
