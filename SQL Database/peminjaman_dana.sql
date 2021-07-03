-- phpMyAdmin SQL Dump
-- version 3.4.5
-- http://www.phpmyadmin.net
--
-- Host: localhost
-- Generation Time: Aug 29, 2019 at 05:38 AM
-- Server version: 5.5.16
-- PHP Version: 5.3.8

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `peminjaman_dana`
--

-- --------------------------------------------------------

--
-- Table structure for table `data_nasabah`
--

CREATE TABLE IF NOT EXISTS `data_nasabah` (
  `NIK` varchar(16) NOT NULL,
  `Nama` varchar(25) NOT NULL,
  `Alamat` varchar(50) NOT NULL,
  `Usia` int(3) NOT NULL,
  `Pekerjaan` varchar(25) NOT NULL,
  `Penghasilan` varchar(10) NOT NULL,
  `Tanggal` varchar(25) NOT NULL,
  PRIMARY KEY (`NIK`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `data_nasabah`
--

INSERT INTO `data_nasabah` (`NIK`, `Nama`, `Alamat`, `Usia`, `Pekerjaan`, `Penghasilan`, `Tanggal`) VALUES
('1234123412341234', 'ARI PRANATA', 'SEI SILAU', 27, 'Karyawan', '2000000', ''),
('1234567812345678', 'Sri Dwiyani', 'Buntu pane', 22, 'Karyawan', '2000000', '29 Agustus 2019'),
('1234567891234567', 'ANA', 'SILAU', 34, 'Karyawan', '2000000', '29 Agustus 2019');

-- --------------------------------------------------------

--
-- Table structure for table `laporan`
--

CREATE TABLE IF NOT EXISTS `laporan` (
  `NIK` varchar(16) NOT NULL,
  `Nama` varchar(25) NOT NULL,
  `Alamat` varchar(50) NOT NULL,
  `Pekerjaan` varchar(25) NOT NULL,
  `Penghasilan` varchar(15) NOT NULL,
  `Syarat_adm` varchar(25) NOT NULL,
  `Agunan` varchar(25) NOT NULL,
  `Jenis_Kredit` varchar(25) NOT NULL,
  `Jumlah_Pinjaman` varchar(25) NOT NULL,
  `Keputusan` varchar(25) NOT NULL,
  PRIMARY KEY (`NIK`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `laporan`
--

INSERT INTO `laporan` (`NIK`, `Nama`, `Alamat`, `Pekerjaan`, `Penghasilan`, `Syarat_adm`, `Agunan`, `Jenis_Kredit`, `Jumlah_Pinjaman`, `Keputusan`) VALUES
('121212', 'ANISA', '', 'Peg Bank', '4000000', 'LENGKAP', 'BPKB SEPEDA MOTOR', 'konsumtif', '10000000', 'LAYAK'),
('1234567812345678', 'Sri Dwiyani', '', 'Karyawan', '2000000', 'Lengkap', 'BPKB Sepeda Motor', 'Konsumtif', '10.000.000,-', 'LAYAK'),
('1234567891234567', 'ANA', '', 'Karyawan', '2000000', 'Lengkap', 'BPKB Sepeda Motor', 'Konsumtif', '10.000.000,-', 'LAYAK'),
('98980976546767', 'INAYAH', '', 'KARYAWAN', '2000000', 'LENGKAP', 'BPKB SEPEDA MOTOR', 'KONSUMTIF', '10000000', 'LAYAK');

-- --------------------------------------------------------

--
-- Table structure for table `operasional`
--

CREATE TABLE IF NOT EXISTS `operasional` (
  `NIP` varchar(12) NOT NULL,
  `Username` int(25) NOT NULL,
  `Password` int(12) NOT NULL,
  PRIMARY KEY (`NIP`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `seleksi_nasabah`
--

CREATE TABLE IF NOT EXISTS `seleksi_nasabah` (
  `NIK` varchar(16) NOT NULL,
  `Nama` varchar(25) NOT NULL,
  `Pekerjaan` varchar(25) NOT NULL,
  `Penghasilan` varchar(25) NOT NULL,
  `Syarat_adm` varchar(25) NOT NULL,
  `Agunan` varchar(25) NOT NULL,
  `Jenis_Kredit` varchar(25) NOT NULL,
  `Jumlah_Pinjaman` varchar(25) NOT NULL,
  `Keputusan` varchar(15) NOT NULL,
  `Keterangan` text NOT NULL,
  PRIMARY KEY (`NIK`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `seleksi_nasabah`
--

INSERT INTO `seleksi_nasabah` (`NIK`, `Nama`, `Pekerjaan`, `Penghasilan`, `Syarat_adm`, `Agunan`, `Jenis_Kredit`, `Jumlah_Pinjaman`, `Keputusan`, `Keterangan`) VALUES
('123412341234', 'AGUNG PRAMUNA', 'KARYAWAN', '2000000', 'LENGKAP', 'SERTIFIKAT RUMAH', 'MODAL KERJA', '25000000', 'LAYAK', ''),
('1234123412341234', 'ARI PRANATA', 'KARYAWAN', '2000000', 'LENGKAP', 'BPKB SEPEDA MOTOR', 'KONSUMTIF', '10000000', 'LAYAK', ''),
('1234565433568676', 'SARINAH', 'Pegawai Bank', '4000000', 'Lengkap', 'BPKB Mobil', 'Investasi', '50.000.000,-', '-', ''),
('1234567812345678', 'Sri Dwiyani', 'Karyawan', '2000000', 'Lengkap', 'BPKB Sepeda Motor', 'Modal kerja', '10.000.000,-', 'LAYAK', ''),
('1234567891234567', 'ANA', 'Karyawan', '2000000', 'Lengkap', 'BPKB Sepeda Motor', 'Konsumtif', '10.000.000,-', 'LAYAK', ''),
('5678567856785678', 'PRIHATIN MANGKU BUMI', 'PNS', '7000000', 'LENGKAP', 'SERTIFIKAT TANAH', 'INVESTASI', '100000000', 'LAYAK', ''),
('9876987698769876', 'JANUAR', 'POLRI', '5000000', 'Tidak Lengkap', 'BPKB Mobil', 'Modal kerja', '50.000.000,-', '-', '');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
