-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: localhost
-- Waktu pembuatan: 07 Des 2023 pada 08.05
-- Versi server: 5.6.53-ndb-7.4.33-cluster-gpl
-- Versi PHP: 7.4.33

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `siak`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `admin`
--

CREATE TABLE `admin` (
  `nip` varchar(11) NOT NULL,
  `nama` varchar(30) DEFAULT NULL,
  `username` varchar(30) DEFAULT NULL,
  `password` text,
  `akses` varchar(1) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `admin`
--

INSERT INTO `admin` (`nip`, `nama`, `username`, `password`, `akses`) VALUES
('32730105102', 'admin front', 'admin', 'admin', '1'),
('32730105201', 'admin pelayanan', 'admin2', 'admin2', '2'),
('32730105301', 'admin kasipelayanan', 'admin3', 'admin3', '3');

-- --------------------------------------------------------

--
-- Struktur dari tabel `kk`
--

CREATE TABLE `kk` (
  `no_reg` int(5) NOT NULL,
  `tgl_reg` date DEFAULT NULL,
  `tgl_selesai` date DEFAULT NULL,
  `jenis_permohonan` varchar(15) DEFAULT NULL,
  `nik` varchar(16) DEFAULT NULL,
  `status` varchar(15) DEFAULT NULL,
  `keterangan` varchar(30) DEFAULT NULL,
  `tgl_diambil` date DEFAULT NULL,
  `nip_petugas` varchar(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `kk`
--

INSERT INTO `kk` (`no_reg`, `tgl_reg`, `tgl_selesai`, `jenis_permohonan`, `nik`, `status`, `keterangan`, `tgl_diambil`, `nip_petugas`) VALUES
(4, '2017-05-01', '2017-05-15', 'Baru', '3237364768464642', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(5, '2017-05-01', '2017-05-15', 'Baru', '3237365433454444', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(6, '2017-05-10', '2017-05-24', 'Baru', '3237365657457524', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(7, '2017-05-10', '2017-05-24', 'Baru', '3237366458215454', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(8, '2017-05-10', '2017-05-24', 'Baru', '3237367475675763', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(9, '2017-05-15', '2017-05-29', 'Baru', '3237367478476433', 'Gagal', 'kurang akte', NULL, '32730105101'),
(10, '2017-05-15', '2017-05-29', 'Baru', '3237367576565543', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(11, '2017-05-15', '2017-05-29', 'Baru', '3237374678444562', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(12, '2017-05-20', '2017-06-03', 'Baru', '3237374725598528', 'Gagal', 'bawa akte', NULL, '32730105101'),
(13, '2017-05-20', '2017-06-03', 'Baru', '3237375453633661', 'Gagal', 'bawa akte', NULL, '32730105101'),
(14, '2017-05-25', '2017-06-08', 'Baru', '3237375554745585', 'Salah Cetak', 'Nama Rehan', NULL, '32730105101'),
(15, '2017-05-25', '2017-06-08', 'Baru', '3237375645365352', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(16, '2017-05-30', '2017-06-13', 'Baru', '3237375645465533', 'Salah Cetak', 'Tanggal lahir', NULL, '32730105101'),
(17, '2017-05-30', '2017-06-13', 'Baru', '3237375747864645', 'Salah Cetak', 'Salah Alamat', NULL, '32730105101'),
(18, '2017-06-01', '2017-06-15', 'Baru', '3237375757475758', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(19, '2017-06-05', '2017-06-19', 'Baru', '3237376785764647', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(20, '2017-06-05', '2017-06-19', 'Baru', '3237378655556533', 'Selesai', 'Selesai Cetak', '2018-01-09', '32730105101'),
(21, '2017-06-09', '2017-06-23', 'Baru', '3237386826598269', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(22, '2017-06-09', '2017-06-23', 'Baru', '3237386834698236', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(23, '2017-06-09', '2017-06-23', 'Baru', '3237396286416421', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(24, '2017-06-12', '2017-06-26', 'Perubahan Data', '3273044564566643', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(25, '2017-06-12', '2017-06-26', 'Baru', '3273050001234501', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(26, '2017-06-12', '2017-06-26', 'Baru', '3273050001234502', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(32, '2017-06-15', '2017-06-29', 'Baru', '3274752309750349', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(33, '2017-06-15', '2017-06-29', 'Baru', '3274728111122271', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(34, '2017-06-15', '2017-06-29', 'Baru', '3273666666666667', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(35, '2017-06-15', '2017-06-29', 'Baru', '3273945678934582', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(36, '2017-06-15', '2017-06-29', 'Baru', '3273756543546454', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(37, '2017-06-15', '2017-06-29', 'Baru', '3273756453533443', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(38, '2017-06-16', '2017-06-30', 'Baru', '3273058726423847', 'Salah Cetak', 'Salah Nama', NULL, '32730105101'),
(39, '2017-06-16', '2017-06-30', 'Baru', '3273576757575757', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(40, '2017-06-16', '2017-06-30', 'Baru', '3273050404538247', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(41, '2017-06-16', '2017-06-30', 'Baru', '3273564445343541', 'Gagal', 'kurang surat pindah', NULL, '32730105101'),
(42, '2017-06-16', '2017-06-30', 'Baru', '3273237377474747', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(43, '2017-06-16', '2017-06-30', 'Baru', '3273050304058395', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(44, '2017-06-16', '2017-06-30', 'Baru', '3273575543564645', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(45, '2017-06-16', '2017-06-30', 'Baru', '3273656787698798', 'Selesai', 'Selesai Cetak', NULL, '32730105101'),
(46, '2017-07-27', '2017-08-10', 'Perubahan Data', '3273998977665544', 'Proses', NULL, NULL, '32730105201'),
(47, '2017-08-10', '2017-08-24', 'Baru', '3273777848874884', 'Proses', NULL, NULL, '32730105201'),
(48, '2018-01-09', '2018-01-23', 'Baru', '3273969624204221', 'Selesai', 'Selesai Cetak', '2018-01-09', ''),
(49, '2018-01-09', '2018-01-23', 'Perubahan Data', '3223342343232323', 'Proses', '', '0000-00-00', '32730105101'),
(64, '2018-01-10', '2018-01-24', 'Perubahan Data', '3237364647575871', 'Proses', '', '0000-00-00', ''),
(65, '2018-01-14', '2018-01-28', 'Perubahan Data', '32233423432433', 'Proses', '', '0000-00-00', '32730105201');

-- --------------------------------------------------------

--
-- Struktur dari tabel `ktp`
--

CREATE TABLE `ktp` (
  `no_reg` int(5) NOT NULL,
  `tgl_reg` varchar(20) DEFAULT NULL,
  `tgl_selesai` varchar(20) DEFAULT NULL,
  `jenis_permohonan` varchar(15) DEFAULT NULL,
  `nik` varchar(16) DEFAULT NULL,
  `status` varchar(15) DEFAULT NULL,
  `keterangan` varchar(30) DEFAULT NULL,
  `tgl_diambil` varchar(20) DEFAULT NULL,
  `nip_petugas` varchar(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `ktp`
--

INSERT INTO `ktp` (`no_reg`, `tgl_reg`, `tgl_selesai`, `jenis_permohonan`, `nik`, `status`, `keterangan`, `tgl_diambil`, `nip_petugas`) VALUES
(97, '2018-01-15', '2018-01-29', 'Baru', '3237364683264232', 'Selesai', 'Selesai Cetak', '2018-01-15', '32730105201');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pendatang`
--

CREATE TABLE `pendatang` (
  `no_reg` int(5) NOT NULL,
  `nik2` varchar(16) NOT NULL,
  `tgl_reg` varchar(20) DEFAULT NULL,
  `no_kk` varchar(20) DEFAULT NULL,
  `namakepalakeluarga` varchar(30) DEFAULT NULL,
  `alamatasal` varchar(50) DEFAULT NULL,
  `kelurahanasal` varchar(30) DEFAULT NULL,
  `kecasal` varchar(20) DEFAULT NULL,
  `kotaasal` varchar(30) NOT NULL,
  `provinsi` varchar(30) NOT NULL,
  `namalengkap` varchar(30) NOT NULL,
  `alasanpindah` varchar(30) NOT NULL,
  `alamatpindah` varchar(30) NOT NULL,
  `kelurahanpindah` varchar(30) NOT NULL,
  `kecpindah` varchar(30) NOT NULL,
  `kotapindah` varchar(30) NOT NULL,
  `provinsipindah` varchar(30) NOT NULL,
  `klasifikasipindah` varchar(30) NOT NULL,
  `jenispindah` varchar(30) NOT NULL,
  `nip_petugas` varchar(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `pendatang`
--

INSERT INTO `pendatang` (`no_reg`, `nik2`, `tgl_reg`, `no_kk`, `namakepalakeluarga`, `alamatasal`, `kelurahanasal`, `kecasal`, `kotaasal`, `provinsi`, `namalengkap`, `alasanpindah`, `alamatpindah`, `kelurahanpindah`, `kecpindah`, `kotapindah`, `provinsipindah`, `klasifikasipindah`, `jenispindah`, `nip_petugas`) VALUES
(14, '1', '2018-01-11', '1', ' pilih ..', '1', ' pilih ..', 'ANDIR', 'BANDUNG', 'JAWA BARAT', '1', '1', '1', '1', '1', 'Bandung', 'Jawa Barat', 'Antar Kecamatan', 'Anggota keluarga', ''),
(15, '2', '2018-01-12', '2', ' pilih ..', '2', ' pilih ..', 'ANDIR', 'BANDUNG', 'JAWA BARAT', '2', '22', '2', '2', '2', 'Bandung', 'Jawa Barat', 'Antar Kecamatan', 'Anggota keluarga', '32730105201'),
(16, '21', '2018-01-15', '12', ' pilih ..', '12', ' pilih ..', 'ANDIR', 'BANDUNG', 'JAWA BARAT', '12', '12', '1212', '12', '12', 'Bandung', 'Jawa Barat', 'Antar Kecamatan', 'Anggota keluarga', '32730105201');

-- --------------------------------------------------------

--
-- Struktur dari tabel `penduduk`
--

CREATE TABLE `penduduk` (
  `nik` varchar(16) NOT NULL,
  `no_kk` varchar(16) DEFAULT NULL,
  `nama` varchar(30) DEFAULT NULL,
  `tempat_lahir` varchar(30) DEFAULT NULL,
  `tanggal_lahir` varchar(20) DEFAULT NULL,
  `jenis_kelamin` varchar(10) DEFAULT NULL,
  `golongan_darah` varchar(2) DEFAULT NULL,
  `agama` varchar(10) DEFAULT NULL,
  `alamat` varchar(50) DEFAULT NULL,
  `rt` varchar(2) DEFAULT NULL,
  `rw` varchar(2) DEFAULT NULL,
  `kelurahan` varchar(30) DEFAULT NULL,
  `kecamatan` varchar(30) DEFAULT NULL,
  `kota` varchar(30) DEFAULT NULL,
  `provinsi` varchar(30) DEFAULT NULL,
  `kode_pos` varchar(5) DEFAULT NULL,
  `kewarganegaraan` varchar(30) DEFAULT NULL,
  `pendidikan` varchar(10) DEFAULT NULL,
  `pekerjaan` varchar(30) DEFAULT NULL,
  `status_perkawinan` varchar(20) DEFAULT NULL,
  `status_hubungan_keluarga` varchar(20) DEFAULT NULL,
  `nama_ayah` varchar(30) DEFAULT NULL,
  `nama_ibu` varchar(30) DEFAULT NULL,
  `foto` varchar(30) DEFAULT NULL,
  `domisili` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `penduduk`
--

INSERT INTO `penduduk` (`nik`, `no_kk`, `nama`, `tempat_lahir`, `tanggal_lahir`, `jenis_kelamin`, `golongan_darah`, `agama`, `alamat`, `rt`, `rw`, `kelurahan`, `kecamatan`, `kota`, `provinsi`, `kode_pos`, `kewarganegaraan`, `pendidikan`, `pekerjaan`, `status_perkawinan`, `status_hubungan_keluarga`, `nama_ayah`, `nama_ibu`, `foto`, `domisili`) VALUES
('1', '1', '1', '1', '2018-1-11', 'Laki-Laki', ' p', ' pilih ..', '1', '1', '1', ' pilih ..', 'ANDIR', 'BANDUNG', 'JAWA BARAT', '1', 'WNI', ' pilih ..', ' pilih ..', ' pilih ..', ' pilih ..', '1', '1', '', 'Pindah'),
('2', '2', '2', '2', '2018-1-12', 'Laki-Laki', ' p', ' pilih ..', '2', '2', '2', ' pilih ..', 'ANDIR', 'BANDUNG', 'JAWA BARAT', '2', 'WNI', ' pilih ..', ' pilih ..', ' pilih ..', ' pilih ..', '2', '2', '', 'Pindah'),
('21', '12', '12', '12', '2018-1-15', 'Laki-Laki', ' p', ' pilih ..', '12', '12', '12', ' pilih ..', 'ANDIR', 'BANDUNG', 'JAWA BARAT', '12', 'WNI', ' pilih ..', ' pilih ..', ' pilih ..', ' pilih ..', '12', '12', '', 'Pindah'),
('2373474848969696', '3237366447557566', 'TATANG SUPRATMAN', 'BANDUNG', '1996-06-11', 'Laki-laki', 'B', 'Islam', 'jln garuda', '04', '03', 'Ciroyom', 'Andir', 'Bandung', 'Jawa Barat', '43453', 'WNI', 'S1', 'PNS', 'Kawin', 'Kepala Keluarga', 'nanang', 'vada', '20170629033230.jpeg', 'Pindah'),
('3', '3', '3', '3', '2018-1-15', 'Laki-Laki', ' p', ' pilih ..', '3', '3', '3', ' pilih ..', 'ANDIR', 'BANDUNG', 'JAWA BARAT', '3', 'WNI', ' pilih ..', ' pilih ..', ' pilih ..', ' pilih ..', '3', '3', '', ''),
('3223342343232323', '3432423423232323', 'YUSUP MAULANI', 'BANDUNG', '2017-12-6', 'Perempuan', 'B', 'ISLAM', 'NYENANG', '03', '03', 'Ciroyom', 'ANDIR', 'BANDUNG', 'JAWA BARAT', '4022', 'WNI', 'Belum Tama', 'Tidak Bekerja', 'BELUM KAWIN', 'Anak', 'TERWR', 'EWREW', '2014-05-11 06.44.41.jpg', 'Pindah'),
('32233423432433', '34324234234233', 'YUSUP MAULANA', 'BANDUNG', '2017-12-6', 'Laki-Laki', 'B', 'ISLAM', 'NYENANG', '03', '03', 'Ciroyom', 'ANDIR', 'BANDUNG', 'JAWA BARAT', '4022', 'WNI', 'Belum Tama', 'Tidak Bekerja', 'BELUM KAWIN', 'Anak', 'TERWR', 'EWREW', '2014-05-11 11.48.52.jpg', 'Pindah'),
('3237364647575871', '3237374747747442', 'RICHAN ASMIRA', 'BANDUNG', '1992-03-10', 'Perempuan', 'B', 'Islam', 'jln jendral sudirman', '01', '06', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '44995', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'eman', 'isop', '20170617074504.jpeg', 'Pindah'),
('3237364647657575', '3237344553536768', 'DUDI', 'BANDUNG', '2000-06-25', 'Laki-laki', 'O', 'Islam', 'jln campaka', '05', '03', 'Campaka', 'Andir', 'Bandung', 'Jawa Barat', '44556', 'WNI', 'S2', 'PNS', 'Kawin', 'Isteri', 'popi', 'eah', '', ''),
('3237364683264232', '3237346453435232', 'TITA', 'BANDUNG', '1990-06-29', 'Perempuan', 'O', 'Islam', 'jln maleber', '06', '06', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '88765', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'hartono', 'santi', '', ''),
('3237364768464642', '3237356637335374', 'BAGJA', 'BANDUNG', '2000-06-15', 'Laki-laki', 'O', 'Islam', 'jln maleber', '05', '04', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '48876', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'mukod', 'marya', '', ''),
('3237365433454444', '3237364545434334', 'DEWI PRATIWI', 'BANDUNG', '2000-06-18', 'Perempuan', 'O', 'Islam', 'jln maleber utara', '03', '02', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '23532', 'WNI', 'SMA', 'Buruh', 'Belum Kawin', 'Anak', 'sartono', 'endah', '', 'Pindah'),
('3237365657457524', '3237376468462665', 'HENDI', 'BANDUNG', '1985-06-21', 'Laki-laki', 'A', 'Kristen', 'jln campaka', '05', '02', 'Campaka', 'Andir', 'Bandung', 'Jawa Barat', '54334', 'WNI', 'SMA', 'Pelajar', 'Kawin', 'Kepala Keluarga', 'ujang', 'tati', '20170617074241.jpeg', 'Pindah'),
('3237366458215454', '3237376362466474', 'ELA PAMELA', 'BANDUNG', '0000-00-00', 'Perempuan', 'O', 'Islam', 'jl dungs cariang', '03', '02', 'Dunguscariang', 'Andir', 'Bandung', 'Jawa Barat', '65445', 'WNI', 'S1', 'Karyawan Swasta', 'Kawin', 'Kepala Keluarga', 'santo', 'titin', '', ''),
('3237367475675763', '3237364673675635', 'ATEP', 'BANDUNG', '2000-06-18', 'Laki-laki', 'A', 'Islam', 'jln dungus cariang', '04', '03', 'Dunguscariang', 'Andir', 'Bandung', 'Jawa Barat', '87654', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'anto', 'titi', '', ''),
('3237367478476433', '3237374646464433', 'ENI CABENI', 'BANDUNG', '2000-06-11', 'Perempuan', 'B', 'Islam', 'jln maleber', '05', '05', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '86875', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'yoyo', 'mumu', '20170625140055.jpeg', ''),
('3237367576565543', '3237356475857573', 'MIMIN SUMINAH', 'BANDUNG', '1988-04-05', 'Perempuan', 'O', 'Islam', 'jln dungus cariang', '06', '04', 'Dunguscariang', 'Andir', 'Bandung', 'Jawa Barat', '76545', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Kepala Keluarga', 'tata', 'entin', '20170617074835.jpeg', 'Pindah'),
('3237374678444562', '3237375768967562', 'ANIS', 'BANDUNG', '2000-06-14', 'Perempuan', 'AB', 'Islam', 'jln maleber', '06', '04', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '54434', 'WNI', 'S1', 'Pelajar', 'Belum Kawin', 'Kepala Keluarga', 'nono', 'nining', '20170617074126.jpeg', ''),
('3237374725598528', '3237368264862754', 'BUBUN', 'BANDUNG', '2000-06-20', 'Laki-laki', 'AB', 'Kristen', 'jln campaka', '05', '03', 'Campaka', 'Andir', 'Bandung', 'Jawa Barat', '45634', 'WNI', 'SMA', 'Buruh', 'Belum Kawin', 'Kepala Keluarga', 'nana', 'nurul', '20170617074147.jpeg', ''),
('3237374775479497', '3237366447557566', 'KARINA KARIN', 'BANDUNG', '1997-9-13', 'Perempuan', 'AB', 'Islam', 'jln maleber', '03', '04', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '43454', 'WNI', 'S1', 'PNS', 'Kawin', 'Isteri', 'zainal', 'umi', '20170629033344.jpeg', 'Pindah'),
('3237375453633661', '3237364768568441', 'PAMELA', 'BANDUNG', '1992-06-05', 'Perempuan', 'B', 'Islam', 'jln maleber utara', '06', '04', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '88765', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'toto', 'eneng', '20170617074309.jpeg', ''),
('3237375554745585', '3237367554756325', 'RAIHAN', 'BANDUNG', '1996-09-12', 'Laki-laki', 'B', 'Islam', 'jln maleber', '04', '05', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '43223', 'WNI', 'S1', 'Tidak Bekerja', 'Belum Kawin', 'Anak', 'santo', 'hartii', '20170617074542.jpeg', ''),
('3237375645365352', '3237367364734273', 'TUTI ASUTI', 'BANDUNG', '1984-10-19', 'Perempuan', 'AB', 'Islam', 'jln maleber', '08', '05', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '76543', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Kepala Keluarga', 'endang', 'sani', '20170617074700.jpeg', ''),
('3237375645465533', '3233643245465722', 'CECEP', 'BANDUNG', '1990-06-27', 'Laki-laki', 'B', 'Islam', 'jl maleber', '05', '05', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '40226', 'WNI', 'SMA', 'Wiraswasta', 'Kawin', 'Kepala Keluarga', 'toto', 'eneng', '', ''),
('3237375747864645', '3237367476467464', 'MUHAMMAD GUNUR', 'BANDUNG', '1987-09-24', 'Laki-laki', 'AB', 'Islam', 'jln campaka', '04', '04', 'Campaka', 'Andir', 'Bandung', 'Jawa Barat', '45678', 'WNI', 'S1', 'PNS', 'Kawin', 'Kepala Keluarga', 'saleh', 'mari', '20170617074349.jpeg', ''),
('3237375757475758', '3237347646877474', 'INTAN SUHARTI', 'BANDUNG', '1989-06-28', 'Perempuan', 'B', 'Islam', 'jln maleber', '06', '04', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '40665', 'WNI', 'S1', 'Buruh', 'Kawin', 'Isteri', 'jojo', 'nani', '', ''),
('3237375775857594', '3237344757578552', 'BUBU', 'BANDUNG', '2000-06-25', 'Laki-laki', 'B', 'Kristen', 'jln maleber utara', '04', '03', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '49966', 'WNA', 'S1', 'Pelajar', 'Belum Kawin', 'Anak', 'weret', 'chers', '', ''),
('3237375787675474', '3237374636474656', 'BOLANG', 'MEDAN', '2000-06-19', 'Laki-laki', 'A', 'Hindu', 'jln ambles', '04', '03', 'Ciroyom', 'Andir', 'Bandung', 'Jawa Barat', '44554', 'WNI', 'SD', 'Pelajar', 'Belum Kawin', 'Anak', 'ceceng', 'mbok', '', ''),
('3237376575454461', '3237365644546441', 'SUSI URARA', 'TOKYO', '2000-04-20', 'Perempuan', 'AB', 'Kristen', 'jln osaka', '04', '04', 'Campaka', 'Andir', 'Bandung', 'Jawa Barat', '64533', 'WNA', 'S1', 'Pelajar', 'Belum Kawin', 'Anak', 'shiraishi kodama', 'shiraisi yuzuha', '20170629063900.jpeg', ''),
('3237376785764647', '3237357647658757', 'NANI', 'BANDUNG', '2000-06-20', 'Perempuan', 'O', 'Islam', 'jln campaka', '04', '03', 'Campaka', 'Andir', 'Bandung', 'Jawa Barat', '88765', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'moon', 'tati', '', ''),
('3237378655556533', '3237376657553533', 'ICA', 'BANDUNG', '2000-06-14', 'Perempuan', 'O', 'Islam', 'ln maleber utara', '07', '04', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '99877', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'annang', 'mami', '', ''),
('3237386826598269', '3237386126498166', 'NANING', 'BANDUNG', '2000-06-04', 'Perempuan', 'O', 'Islam', 'jln maleber utara', '03', '05', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '43567', 'WNI', 'S3', 'Guru/Dosen', 'Kawin', 'Isteri', 'bani', 'nuri', '', ''),
('3237386834698236', '3237386842894589', 'RURI', 'BANDUNG', '2000-06-04', 'Perempuan', 'AB', 'Islam', 'jln dungus cariang', '04', '02', 'Dunguscariang', 'Andir', 'Bandung', 'Jawa Barat', '43452', 'WNI', 'S2', 'PNS', 'Belum Kawin', 'Anak', 'aceng', 'maria', '', ''),
('3237396286416421', '3237329681486812', 'NUNUNG', 'BANDUNG', '2000-06-16', 'Perempuan', 'B', 'Islam', 'jln campaka', '04', '03', 'Campaka', 'Andir', 'Bandung', 'Jawa Barat', '45534', 'WNI', 'SMA', 'Buruh', 'Kawin', 'Anak', 'jamal', 'sanam', '', ''),
('3273044564566643', '3273566767687979', 'DEDI MULYADI', 'BANDUNG', '1999-10-18', 'Laki-laki', 'AB', 'Islam', 'jl.andir', '09', '09', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '40223', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'ISAN MAULANA', 'INDAH NUR ZANAH', '', ''),
('3273050001234501', '3273050001234501', 'MANSYAH', 'BANDUNG', '2000-06-25', 'Laki-laki', 'O', 'Islam', 'jln garuda', '03', '04', 'Garuda', 'Andir', 'Bandung', 'Jawa Barat', '43233', 'WNI', 'SMA', 'Buruh', 'Belum Kawin', 'Anak', 'aceng', 'ela', '', ''),
('3273050001234502', '3273050001234502', 'BAGAS', 'BANDUNG', '2000-06-06', 'Laki-laki', 'B', 'Islam', 'jln dungus cariang', '04', '03', 'Dunguscariang', 'Andir', 'Bandung', 'Jawa Barat', '45323', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'dudi', 'mara', '', ''),
('3273050001234503', '3273050001234503', 'ACEP', 'BANDUNG', '1990-06-06', 'Laki-laki', 'AB', 'Islam', 'jln maleber', '04', '03', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '45678', 'WNI', 'S1', 'PNS', 'Kawin', 'Kepala Keluarga', 'agus', 'nurul', '20170617063623.jpeg', ''),
('3273050001234504', '3273050001234503', 'RERE REDIANA', 'BANDUNG', '1991-06-27', 'Perempuan', 'AB', 'Kristen', 'jln garuda', '05', '04', 'Garuda', 'Andir', 'Bandung', 'Jawa Barat', '45564', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Isteri', 'pipo', 'aisyah', '20170727140212.jpeg', ''),
('3273050001234505', '3273050001234505', 'TATI HERAWATI', 'BANDUNG', '2000-06-05', 'Perempuan', 'AB', 'Islam', 'jln maleber', '05', '04', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '88765', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'asep', '', '', ''),
('3273050202900001', '3273050123012341', 'ASEP HIDAYAT', 'SUKABUMI', '1968-08-30', 'Laki-laki', 'AB', 'Islam', 'Jl.Srigunting No.70', '02', '02', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '40212', 'WNI', 'SMA', 'Karyawan Swasta', 'Kawin', 'Kepala Keluarga', 'Ahmad', 'Yanti', '', ''),
('3273050304058395', '3273050123012341', 'NOVI NOVIAN', 'BANDUNG', '1970-11-20', 'Perempuan', 'O', 'Islam', 'Jl.Srigunting no.70', '03', '04', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '40212', 'WNI', 'SMP', 'Mengurus Rumah Tangga', 'Kawin', 'Isteri', 'heri', 'ikoh', '', ''),
('3273050404538247', '3273050123012341', 'ILHAM UDIN', 'BANDUNG', '1996-09-21', 'Laki-laki', 'O', 'Islam', 'Jl.Srigunting No.70', '02', '02', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '40212', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'ASEP HIDAYAT', 'NOVI NOVIAN', '', ''),
('3273051232124445', '3273051232124445', 'MONIC', 'MEDAN', '1991-03-18', 'Perempuan', 'AB', 'Kristen', 'jln maleber', '04', '04', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '55644', 'WNI', 'S1', 'Pelajar', 'Belum Kawin', 'Anak', 'santo', 'melek', '20170617063326.jpeg', ''),
('3273051232124452', '3273051232122245', 'TASNI TANSIAH', 'BANDUNG', '2004-08-04', 'Perempuan', 'AB', 'Islam', 'jln jendral sudirman', '01', '06', 'Ciroyom', 'Andir', 'Bandung', 'Jawa Barat', '44885', 'WNI', 'SMP', 'Pelajar', 'Belum Kawin', 'Anak', 'eman ', 'isop', '20170730045037.jpeg', ''),
('3273056334596070', '3274728498799475', 'ADE MAULUDIN', 'BANDUNG', '1969-05-30', 'Laki-laki', 'O', 'Islam', 'jl.cijerah', '02', '03', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '40212', 'WNI', 'S1', 'PNS', 'Kawin', 'Kepala Keluarga', 'asep', 'iis', '20170517043056.jpeg', ''),
('3273057867564544', '3274844498998594', 'PIKOH SURIKOH', 'BANDUNH', '1989-06-14', 'Perempuan', 'AB', 'Islam', 'jln munuyui', '09', '05', 'Garuda', 'Andir', 'Bandung', 'Jawa Barat', '75565', 'WNA', 'SMP', 'Mengurus Rumah Tangga', 'Kawin', 'Isteri', 'komirun', 'popon', '20170727140831.jpeg', ''),
('3273058726423847', '3273566767687979', 'INDAH NUR ZANAH', 'DEPOK', '1980-07-12', 'Perempuan', 'B', 'Islam', 'jl.andir', '09', '09', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '40223', 'WNI', 'SMP', 'Mengurus Rumah Tangga', 'Kawin', 'Isteri', 'adi', 'ucu', '', ''),
('3273059876543210', '3274728498799475', 'ANTO', 'BANDUNG', '2000-06-19', 'Laki-laki', 'B', 'Islam', 'jln maleber utara', '04', '03', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '43323', 'WNI', 'S1', 'Pelajar', 'Belum Kawin', 'Anak', 'nias', 'tuti', '20170727140409.jpeg', ''),
('3273059876543211', '3273059876543211', 'WADIAH', 'BANDUNG', '2000-06-18', 'Perempuan', 'B', 'Islam', 'jln arjuna', '04', '03', 'Ciroyom', 'Andir', 'Bandung', 'Jawa Barat', '45554', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'muid', 'merlia', '', ''),
('3273059876543212', '3274728498799475', 'TUTI ZANAH', 'BANDUNG', '1979-06-15', 'Perempuan', 'AB', 'Islam', 'jln maleber', '04', '03', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '87654', 'WNI', 'SMA', 'Pelajar', 'Kawin', 'Isteri', 'entis', 'wati', '20170617074754.jpeg', ''),
('3273059876543213', '3273059876543213', 'LALA', 'BANDUNG', '2000-06-26', 'Perempuan', 'B', 'Kristen', 'jln dunguscariang', '04', '02', 'Dunguscariang', 'Andir', 'Bandung', 'Jawa Barat', '66554', 'WNI', 'S1', 'Pelajar', 'Belum Kawin', 'Anak', 'toto', 'mimin', '', ''),
('3273059876543214', '3273059876543214', 'CUCU', 'BANDUNG', '2000-06-04', 'Perempuan', 'AB', 'Islam', 'jln maleber', '06', '06', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '88766', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'dadang', '', '', ''),
('3273059876543268', '3273059876543268', 'SANTI NOVIANTI', 'BANDUNG', '2000-06-16', 'Perempuan', 'AB', 'Islam', 'jln maleber', '02', '06', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '43231', 'WNI', 'SMA', 'Tidak Bekerja', 'Belum Kawin', 'Anak', 'yusuf', 'farida', '', ''),
('3273059876543269', '3273059876543269', 'TUTU', 'BANDUNG', '2000-06-21', 'Laki-laki', 'B', 'Islam', 'jln maleber', '06', '05', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '66775', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'tatang', 'entin', '', ''),
('3273237377474747', '3273237374747474', 'MAMIH', 'BANDUNG', '2000-06-25', 'Perempuan', 'B', 'Islam', 'jln maleber', '06', '05', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '87765', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'toto', 'entin', '', ''),
('3273286429499944', '3273793275977324', 'GAGAN', 'BANDUNG', '2000-06-06', 'Laki-laki', 'AB', 'Islam', 'jln maleber', '04', '03', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '43423', 'WNI', 'D3', 'Tidak Bekerja', 'Belum Kawin', 'Anak', 'ene', 'dadin', '', ''),
('3273337373737373', '3273736763256226', 'ANA ANDYUNI', 'BANDUNG', '1969-06-20', 'Perempuan', 'AB', 'Islam', 'jln ahmad yani 60', '03', '04', 'Kebonjeruk', 'Andir', 'Bandung', 'Jawa Barat', '43464', 'WNI', 'SMP', 'Tidak Bekerja', 'Kawin', 'Kepala Keluarga', 'acep', 'ica', '', ''),
('3273338485596685', '3273744985985848', 'CINDY MARSELA', 'BANDUNG', '1998-06-05', 'Perempuan', 'B', 'Islam', 'jln ahmad yani', '04', '02', 'Ciroyom', 'Andir', 'Bandung', 'Jawa Barat', '43234', 'WNI', 'S1', 'Pelajar', 'Belum Kawin', 'Anak', 'wawan', 'ninig', '', ''),
('3273448589858574', '3273737875886068', 'RIRIN K NISA', 'BANDUNG', '1995-06-20', 'Perempuan', 'AB', 'Islam', 'jln ciroyom', '05', '03', 'Ciroyom', 'Andir', 'Bandung', 'Jawa Barat', '43234', 'WNI', 'S1', 'Mengurus Rumah Tangga', 'Kawin', 'Isteri', 'sutisna', 'atem', '', ''),
('3273474874774874', '3273647474747448', 'VIVA', 'BANDUNG', '1990-06-07', 'Perempuan', 'AB', 'Islam', 'jln garua utara', '04', '03', 'Garuda', 'Andir', 'Bandung', 'Jawa Barat', '44565', 'WNI', 'SMA', 'Buruh', 'Belum Kawin', 'Anak', 'tata', 'nun', '', ''),
('3273474989849848', '3274844498998594', 'ENDANG', 'BANDUNG', '1965-06-11', 'Laki-laki', 'B', 'Kristen', 'jln garuda', '03', '05', 'Ciroyom', 'Andir', 'Bandung', 'Jawa Barat', '43234', 'WNI', 'S1', 'PNS', 'Kawin', 'Kepala Keluarga', 'anang', 'asyanti', '', ''),
('3273478747485846', '3273736763256226', 'TUTI ASTUTI', 'BANDUNG', '2000-06-15', 'Perempuan', 'AB', 'Islam', 'jln malber utara 32', '04', '03', 'Dunguscariang', 'Andir', 'Bandung', 'Jawa Barat', '43234', 'WNI', 'S1', 'Karyawan Swasta', 'Kawin', 'Anak', 'ahmad ', 'neneng', '20170727141258.jpeg', ''),
('3273487487474874', '3274844498998594', 'VYUN', 'BANDUNG', '2000-06-07', 'Perempuan', 'AB', 'Kristen', 'jln garuda', '04', '02', 'Garuda', 'Andir', 'Bandung', 'Jawa Barat', '43456', 'WNI', 'SMA', 'Buruh', 'Belum Kawin', 'Anak', 'rerwe', 'terty', '20170727140924.jpeg', ''),
('3273498268946396', '3273658360956363', 'ICA', 'BANDUNG', '1998-06-06', 'Perempuan', 'AB', 'Islam', 'jln maleber', '04', '04', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '43454', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'yuyu', 'muis', '', ''),
('3273564445343541', '3273444447777777', 'ONOI', 'BANDUNG', '2000-06-11', 'Laki-laki', 'B', 'Islam', 'jln andir', '07', '03', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '55743', 'WNI', 'SMA', 'Petani', 'Belum Kawin', 'Anak', 'toto', 'macici', '20170727141534.jpeg', ''),
('3273564579344624', '3273736763256226', 'AMANDA KARIN', 'BANDUNG', '2000-06-14', 'Perempuan', 'AB', 'Islam', 'jln kebon jati', '03', '02', 'Kebonjeruk', 'Andir', 'Bandung', 'Jawa Barat', '43231', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'oct', 'uyuy', '20170629063734.jpeg', ''),
('3273567574576455', '3273243646884576', 'BUYULLLL', 'CIKAMPEK', '2000-06-20', 'Laki-laki', 'B', 'Islam', 'jln aceh', '06', '06', 'Kebonjeruk', 'Andir', 'Bandung', 'Jawa Barat', '56545', 'WNI', 'SMA', 'Buruh', 'Belum Kawin', 'Anak', 'suharto', 'kokom', '', ''),
('3273575543564645', '3273564535475435', 'PUPUT SARI', 'CIANJUR', '2000-06-10', 'Perempuan', 'AB', 'Islam', 'jln munuro', '07', '04', 'Ciroyom', 'Andir', 'Bandung', 'Jawa Barat', '68685', 'WNI', 'S1', 'PNS', 'Belum Kawin', 'Anak', 'sukoo', 'mariyam', '', ''),
('3273575775858577', '3273567586969686', 'PEBRIANTI', 'SURABAYA', '2000-06-04', 'Perempuan', 'AB', 'Kristen', 'jln cempaka', '3', '1', 'Campaka', 'Andir', 'Bandung', 'Jawa Barat', '54457', 'WNI', 'S1', 'Karyawan Swasta', 'Kawin', 'Isteri', 'susanto', 'suhartini', '', ''),
('3273576757575757', '3273566767687979', 'ISAN MAULANA', 'SUBANG', '1980-09-08', 'Laki-laki', 'B', 'Islam', 'jl.andir', '09', '09', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '40223', 'WNI', 'SMA', 'Wiraswasta', 'Kawin', 'Kepala Keluarga', 'iin', 'aas', '20170523041133.jpeg', ''),
('3273588325453285', '3273650910590932', 'GESHA', 'BANDUNG', '1998-06-04', 'Laki-laki', 'O', 'Islam', 'jln kebonjati', '04', '02', 'Kebonjeruk', 'Andir', 'Bandung', 'Jawa Barat', '43234', 'WNI', 'S1', 'Pelajar', 'Kawin', 'Isteri', 'imran', 'uti', '20170727141112.jpeg', ''),
('3273636774747473', '3274747447464653', 'HANIFAH', 'BANDUNG', '2000-06-15', 'Perempuan', 'O', 'Islam', 'jlnciroyom', '04', '02', 'Ciroyom', 'Andir', 'Bandung', 'Jawa Barat', '43234', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'mahmud', 'intan', '', 'Pindah'),
('3273640969632964', '3273650910590932', 'UDIN', 'BANDUNG', '1995-06-13', 'Laki-laki', 'AB', 'Islam', 'jln maleber', '03', '02', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '43454', 'WNI', 'S1', 'PNS', 'Kawin', 'Kepala Keluarga', 'andi', 'mami', '', ''),
('3273646576879809', '3273767686868674', 'GUSTI', 'BANDUNG', '1998-06-21', 'Laki-laki', 'AB', 'Islam', 'jln cianjuran', '03', '02', 'Dunguscariang', 'Andir', 'Bandung', 'Jawa Barat', '43234', 'WNI', 'S2', 'Wiraswasta', 'Belum Kawin', 'Anak', 'anang', 'cucu', '20170727141553.jpeg', ''),
('3273646747474748', '3234767877474774', 'TAKENI', 'BANDUNG', '2000-06-07', 'Perempuan', 'B', 'Islam', 'jln kebon jati', '04', '02', 'Kebonjeruk', 'Andir', 'Bandung', 'Jawa Barat', '43234', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'anton', 'endah', '', ''),
('3273647784748787', '3273444447777777', 'REHAND', 'BANDUNG', '1998-06-20', 'Laki-laki', 'AB', 'Islam', 'jln dungus cariang', '04', '03', 'Dunguscariang', 'Andir', 'Bandung', 'Jawa Barat', '44456', 'WNI', 'SMA', 'Mengurus Rumah Tangga', 'Belum Kawin', 'Anak', 'soron', 'ana', '20170727141646.jpeg', ''),
('3273656787698798', '3273647474874846', 'SASA SALSABILA', 'BANDUNG', '2000-06-01', 'Perempuan', 'A', 'Islam', 'jln jendral sudirman', '1', '2', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '44566', 'WNI', 'SMA', 'Karyawan Swasta', 'Belum Kawin', 'Isteri', 'budu utomo', 'susanti', '', ''),
('3273664583825893', '3273444447777777', 'ASEP SUDRAJAT', 'BANDUNG', '1997-06-13', 'Laki-laki', 'AB', 'Islam', 'jln arjuna 18', '03', '02', 'Ciroyom', 'Andir', 'Bandung', 'Jawa Barat', '42312', 'WNI', 'S1', 'PNS', 'Belum Kawin', 'Anak', 'atang', 'eni', '20170727141511.jpeg', ''),
('3273666666666667', '3273444447777777', 'ASEP SAEPUL', 'GARUT', '1965-05-27', 'Laki-laki', 'B', 'Islam', 'jl.rajawali no.88', '03', '04', 'Dunguscariang', 'Andir', 'Bandung', 'Jawa Barat', '40221', 'WNI', 'SMA', 'Wiraswasta', 'Cerai Mati', 'Kepala Keluarga', 'isal', 'asih', '20170525080134.jpeg', ''),
('3273737347448435', '3273636353763485', 'ENI TARINA', 'BANDUNG', '1965-06-12', 'Perempuan', 'AB', 'Islam', 'jln cijerah', '03', '04', 'Ciroyom', 'Andir', 'Bandung', 'Jawa Barat', '43212', 'WNI', 'S1', 'PNS', 'Kawin', 'Isteri', 'aming', 'hesti', '', ''),
('3273747476474744', '3273353776487487', 'BANI', 'BANDUNG', '2000-06-12', '', 'AB', 'Kristen', 'jln aceh', '03', '03', 'Kebonjeruk', 'Andir', 'Bandung', 'Jawa Barat', '43223', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'gani', 'lela', '', ''),
('327374748747h748', '3273536363636338', 'HANAFI', 'BANDUNG', '2000-06-21', 'Laki-laki', 'O', 'Islam', 'jln garuda', '04', '03', 'Garuda', 'Andir', 'Bandung', 'Jawa Barat', '43454', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'toni', 'fitri', '', 'Pindah'),
('3273747644747487', '3273474747474474', 'DARYANTO', 'BANDUNG', '1995-06-19', 'Laki-laki', 'O', 'Islam', 'jln campaka', '04', '02', 'Campaka', 'Andir', 'Bandung', 'Jawa Barat', '45678', 'WNI', 'S1', 'Pelajar', 'Belum Kawin', 'Anak', 'hariyanto', 'sarimin', '', ''),
('3273747676464631', '3273646364476471', 'UCUY SUPRIADI', 'BANDUNG', '1990-06-25', 'Laki-laki', 'B', 'Islam', 'jln maleber utara', '04', '03', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '43323', 'WNI', 'SMA', 'Karyawan Swasta', 'Belum Kawin', 'Anak', 'atep', 'aas', '', ''),
('3273747874887487', '3273474487478487', 'ACENG', 'BANDUNG', '2000-06-13', 'Laki-laki', 'B', 'Islam', 'jln unggara', '04', '03', 'Kebonjeruk', 'Andir', 'Bandung', 'Jawa Barat', '43454', 'WNI', 'S1', 'Pelajar', 'Belum Kawin', 'Anak', 'buyl', 'nani', '', ''),
('3273748748478748', '3273599859859855', 'MUMUN', 'BANDUNG', '1997-06-12', 'Perempuan', 'O', 'Islam', 'jln maleber', '04', '03', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '45674', 'WNI', 'S3', 'Guru/Dosen', 'Kawin', 'Isteri', 'ninuk', 'intre', '', ''),
('3273756453533443', '3273425533647586', 'TACICU LELA', 'BATAM', '1993-06-13', 'Laki-laki', 'O', 'Kristen', 'jln puncrut', '05', '03', 'Kebonjeruk', 'Andir', 'Bandung', 'Jawa Barat', '56575', 'WNI', 'SMP', 'Petani', 'Kawin', 'Kepala Keluarga', 'sukirno', 'sukijat', '', ''),
('3273756543546454', '3273655343545545', 'DADANG', 'BANDUNG', '1990-06-26', 'Laki-laki', 'A', 'Islam', 'jln cukipur', '07', '03', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '64644', 'WNI', 'SMA', 'Buruh', 'Kawin', 'Kepala Keluarga', 'poplon', 'koyuy', '', ''),
('3273757858985985', '3273585385493539', 'AULIA DARUSMAN', 'BANDUNG', '2000-06-22', 'Perempuan', 'O', 'Islam', 'jln kebon jati', '03', '05', 'Kebonjeruk', 'Andir', 'Bandung', 'Jawa Barat', '43423', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'usman', 'entin', '', ''),
('3273775858596969', '3273422425626363', 'CITRA ARINI SADA', 'BANDUNG', '1995-04-19', 'Perempuan', 'B', 'Islam', 'jln kebon jati', '04', '03', 'Kebonjeruk', 'Andir', 'Bandung', 'Jawa Barat', '40212', 'WNI', 'SMP', 'Buruh', 'Belum Kawin', 'Anak', 'suepdin', 'maisaroh', '', 'Pindah'),
('3273777848874884', '3273477447487487', 'ISMAIL', 'BANDUNG', '1997-06-21', 'Laki-laki', 'A', 'Islam', 'jln ahad yani', '03', '05', 'Garuda', 'Andir', 'Bandung', 'Jawa Barat', '43212', 'WNI', 'S1', 'Wiraswasta', 'Kawin', 'Kepala Keluarga', 'tatang', 'ikoh', '', ''),
('3273838869696969', '3273586548538458', 'ROY RIANA', 'BANDUNG', '1998-06-06', 'Laki-laki', 'AB', 'Islam', 'jln meirose 24', '03', '02', 'Kebonjeruk', 'Andir', 'Bandung', 'Jawa Barat', '43234', 'WNI', 'S2', 'Wiraswasta', 'Belum Kawin', 'Anak', 'muhammad ijal', 'fatmawati', '', ''),
('3273864892364896', '3273864092635669', 'HANIF', 'BANDUNG', '2000-06-12', 'Laki-laki', 'B', 'Islam', 'jln maleber', '04', '03', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '45463', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'dadi', 'binin', '', 'Pindah'),
('3273864896469221', '3273649823959221', 'BINTANG', 'BANDUNG', '1996-06-05', 'Perempuan', 'A', 'Islam', 'jln garuda', '03', '03', 'Garuda', 'Andir', 'Bandung', 'Jawa Barat', '44345', 'WNI', 'SMA', 'Wiraswasta', 'Belum Kawin', 'Anak', 'maryadi', 'haryati', '', ''),
('3273887487474878', '3273473773737373', 'FANI', 'BANDUNG', '1999-06-12', 'Perempuan', 'A', 'Kristen', 'jln ahma yani', '04', '02', 'Kebonjeruk', 'Andir', 'Bandung', 'Jawa Barat', '43234', 'WNI', 'S1', 'Karyawan Swasta', 'Kawin', 'Isteri', 'jaeal', 'haryati', '', ''),
('3273945678934582', '3273485684578430', 'WAHYUDIN', 'BANDUNG', '1995-02-13', 'Laki-laki', 'AB', 'Islam', 'jl.sudirman no.800', '05', '07', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '40212', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Kepala Keluarga', 'een', 'asih', '', ''),
('3273946634691364', '3273985495139459', 'PRASETYA', 'BANDUNG', '1998-06-19', 'Laki-laki', 'B', 'Islam', 'jln ciroyom', '03', '02', 'Ciroyom', 'Andir', 'Bandung', 'Jawa Barat', '42314', 'WNI', 'S1', 'Wiraswasta', 'Kawin', 'Kepala Keluarga', 'Sutedjo', 'Sulastri', '', ''),
('3273964962949326', '3273649862469629', 'ISMED SOFIAN', 'BANDUNG', '1998-06-05', 'Laki-laki', 'A', 'Islam', 'jln ciroyom', '05', '05', 'Ciroyom', 'Andir', 'Bandung', 'Jawa Barat', '43456', 'WNI', 'SMA', 'Buruh', 'Kawin', 'Kepala Keluarga', 'ade', 'ati', '', ''),
('3273965093209562', '3273825498598542', 'UNUNG', 'BANDUNG', '1987-06-06', 'Perempuan', 'AB', 'Islam', 'jln maleber', '05', '03', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '43355', 'WNI', 'S1', 'Pelajar', 'Belum Kawin', 'Anak', 'qceng', 'hujun', '', ''),
('3273969624204221', '3272640926094609', 'NINING', 'BANDUNG', '2000-06-05', 'Laki-laki', 'O', 'Kristen', 'jln maleber', '04', '03', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '43543', 'WNI', 'D3', 'Tidak Bekerja', 'Belum Kawin', 'Anak', 'habib', 'uning', '', ''),
('3273970975329759', '3273949239046943', 'RERE', 'BANDUNG', '2000-06-09', 'Perempuan', 'AB', 'Islam', 'jln garuda 45', '03', '02', 'Garuda', 'Andir', 'Bandung', 'Jawa Barat', '45543', 'WNI', 'SMP', 'Mengurus Rumah Tangga', 'Kawin', 'Isteri', 'hanif', 'endah', '', ''),
('3273974070750375', '3273970973209750', 'YANI', 'BANDUNG', '1997-06-05', 'Perempuan', 'AB', 'Islam', 'jln maleber', '04', '03', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', '43425', 'WNI', 'D3', 'Mengurus Rumah Tangga', 'Kawin', 'Kepala Keluarga', 'juju', 'inuy', '', ''),
('3273986498623649', '3273836423946244', 'GURI', 'BANDUMG', '2000-06-05', 'Perempuan', 'B', 'Kristen', 'jln dungus cariang', '04', '03', 'Dunguscariang', 'Andir', 'Bandung', 'Jawa Barat', '43234', 'WNI', 'SMA', 'Pelajar', 'Belum Kawin', 'Anak', 'toto', 'uyuy', '', ''),
('3273998977665544', '3273998900665522', 'MUHAMMAD ADUL', 'SUBANG', '1987-12-14', 'Laki-laki', 'A', 'Islam', 'jl.rajawali timur no.55', '05', '08', 'Dunguscariang', 'Andir', 'Bandung', 'Jawa Barat', '40221', 'WNI', 'SMA', 'Buruh', 'Belum Kawin', 'Kepala Keluarga', 'asep ', 'ioh', '20170727142352.jpeg', ''),
('3274728111122271', '3273728498799475', 'EUIS SIEUIS', 'BANDUNG', '1990-07-03', 'Perempuan', 'B', 'Islam', 'Jl. Rajawali no.88', '04', '06', 'Garuda', 'Andir', 'Bandung', 'Jawa Barat', '40212', 'WNI', 'SMA', 'Mengurus Rumah Tangga', 'Kawin', 'Isteri', 'Ahmad', 'Siti', '20170523043809.jpeg', ''),
('3274752309750349', '3273879465654709', 'DADAN SHOLEH', 'PURWAKARTA', '1969-04-06', 'Laki-laki', 'O', 'Islam', 'jl.garuda no.3', '02', '09', 'Garuda', 'Andir', 'Bandung', 'Jawa Barat', '40221', 'WNI', 'S1', 'PNS', 'Kawin', 'Kepala Keluarga', 'ibas', '', '20170517043615.jpeg', '');

-- --------------------------------------------------------

--
-- Struktur dari tabel `pindah`
--

CREATE TABLE `pindah` (
  `no_reg` int(5) NOT NULL,
  `nik2` varchar(16) NOT NULL,
  `tgl_reg` varchar(20) DEFAULT NULL,
  `no_kk` varchar(20) DEFAULT NULL,
  `namakepalakeluarga` varchar(30) DEFAULT NULL,
  `alamatasal` varchar(50) DEFAULT NULL,
  `kelurahanasal` varchar(30) DEFAULT NULL,
  `kecasal` varchar(20) DEFAULT NULL,
  `kotaasal` varchar(30) NOT NULL,
  `provinsi` varchar(30) NOT NULL,
  `namalengkap` varchar(30) NOT NULL,
  `alasanpindah` varchar(30) NOT NULL,
  `alamatpindah` varchar(30) NOT NULL,
  `kelurahanpindah` varchar(30) NOT NULL,
  `kecpindah` varchar(30) NOT NULL,
  `kotapindah` varchar(30) NOT NULL,
  `provinsipindah` varchar(30) NOT NULL,
  `klasifikasipindah` varchar(30) NOT NULL,
  `jenispindah` varchar(30) NOT NULL,
  `nip_petugas` varchar(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data untuk tabel `pindah`
--

INSERT INTO `pindah` (`no_reg`, `nik2`, `tgl_reg`, `no_kk`, `namakepalakeluarga`, `alamatasal`, `kelurahanasal`, `kecasal`, `kotaasal`, `provinsi`, `namalengkap`, `alasanpindah`, `alamatpindah`, `kelurahanpindah`, `kecpindah`, `kotapindah`, `provinsipindah`, `klasifikasipindah`, `jenispindah`, `nip_petugas`) VALUES
(11, '2373474848969696', '2018-01-11', '3237366447557566', 'TATANG SUPRATMAN', 'jln garuda 04 / 03', 'Ciroyom', 'Andir', 'Bandung', 'Jawa Barat', 'TATANG SUPRATMAN', 'a', 'a', 'Ciroyom', 'Andir', 'Bandung', 'Jawa Barat', 'Antar Kecamatan', 'Anggota keluarga', ''),
(12, '2373474848969696', '2018-01-11', '3237366447557566', 'TATANG SUPRATMAN', 'jln garuda 04 / 03', 'Ciroyom', 'Andir', 'Bandung', 'Jawa Barat', 'TATANG SUPRATMAN', 'a', 'a', 'Ciroyom', 'Andir', 'Bandung', 'Jawa Barat', 'Antar Kecamatan', 'Anggota keluarga', ''),
(13, '3273775858596969', '2018-01-11', '3273422425626363', 'CITRA ARINI SADA', 'jln kebon jati 04 / 03', 'Kebonjeruk', 'Andir', 'Bandung', 'Jawa Barat', 'CITRA ARINI SADA', '', '', '', '', 'Bandung', 'Jawa Barat', 'Antar Kecamatan', 'Anggota keluarga', ''),
(17, '3237364647575871', '2018-01-11', '3237374747747442', 'RICHAN ASMIRA', 'jln jendral sudirman 01 / 06', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', 'RICHAN ASMIRA', '1', '1', '1', '1', 'Bandung', 'Jawa Barat', 'Antar Kecamatan', 'Anggota keluarga', ''),
(18, '3237367576565543', '2018-01-14', '3237356475857573', 'MIMIN SUMINAH', 'jln dungus cariang 06 / 04', 'Dunguscariang', 'Andir', 'Bandung', 'Jawa Barat', 'MIMIN SUMINAH', 'cc', 'cc', 'cc', 'cc', 'Bandung', 'Jawa Barat', 'Antar Kecamatan', 'Anggota keluarga', '32730105201'),
(19, '3223342343232323', '2018-01-15', '3432423423232323', 'YUSUP MAULANI', 'NYENANG 03 / 03', 'Ciroyom', 'Andir', 'BANDUNG', 'JAWA BARAT', 'YUSUP MAULANI', 'rwer', 'ewrwer', 'wer', 'werwer', 'Bandung', 'Jawa Barat', 'Antar Kecamatan', 'Anggota keluarga', '32730105201'),
(20, '3237374775479497', '2018-01-15', '3237366447557566', 'TATANG SUPRATMAN', 'jln maleber 03 / 04', 'Maleber', 'Andir', 'Bandung', 'Jawa Barat', 'KARINA KARIN', '', '', '', '', 'Bandung', 'Jawa Barat', 'Antar Kecamatan', 'Anggota keluarga', '32730105201');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `admin`
--
ALTER TABLE `admin`
  ADD PRIMARY KEY (`nip`);

--
-- Indeks untuk tabel `kk`
--
ALTER TABLE `kk`
  ADD PRIMARY KEY (`no_reg`),
  ADD UNIQUE KEY `nik` (`nik`);

--
-- Indeks untuk tabel `ktp`
--
ALTER TABLE `ktp`
  ADD PRIMARY KEY (`no_reg`),
  ADD UNIQUE KEY `nik` (`nik`);

--
-- Indeks untuk tabel `pendatang`
--
ALTER TABLE `pendatang`
  ADD PRIMARY KEY (`no_reg`);

--
-- Indeks untuk tabel `penduduk`
--
ALTER TABLE `penduduk`
  ADD PRIMARY KEY (`nik`);

--
-- Indeks untuk tabel `pindah`
--
ALTER TABLE `pindah`
  ADD PRIMARY KEY (`no_reg`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `kk`
--
ALTER TABLE `kk`
  MODIFY `no_reg` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=66;

--
-- AUTO_INCREMENT untuk tabel `ktp`
--
ALTER TABLE `ktp`
  MODIFY `no_reg` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=98;

--
-- AUTO_INCREMENT untuk tabel `pendatang`
--
ALTER TABLE `pendatang`
  MODIFY `no_reg` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT untuk tabel `pindah`
--
ALTER TABLE `pindah`
  MODIFY `no_reg` int(5) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `kk`
--
ALTER TABLE `kk`
  ADD CONSTRAINT `b` FOREIGN KEY (`nik`) REFERENCES `penduduk` (`nik`);

--
-- Ketidakleluasaan untuk tabel `ktp`
--
ALTER TABLE `ktp`
  ADD CONSTRAINT `a` FOREIGN KEY (`nik`) REFERENCES `penduduk` (`nik`) ON DELETE NO ACTION ON UPDATE NO ACTION;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
