-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 16 Bulan Mei 2025 pada 19.53
-- Versi server: 10.4.32-MariaDB
-- Versi PHP: 8.1.25

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `renobuilding`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `tabel_barang`
--

CREATE TABLE `tabel_barang` (
  `id_barang` int(11) NOT NULL,
  `nama_barang` varchar(100) DEFAULT NULL,
  `harga_barang` decimal(10,2) DEFAULT NULL,
  `stok` int(11) DEFAULT NULL,
  `stok_minimum` int(11) DEFAULT NULL,
  `jenis_material` varchar(50) DEFAULT NULL,
  `merek` varchar(50) DEFAULT NULL,
  `kategori` varchar(50) DEFAULT 'Bangunan'
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tabel_barang`
--

INSERT INTO `tabel_barang` (`id_barang`, `nama_barang`, `harga_barang`, `stok`, `stok_minimum`, `jenis_material`, `merek`, `kategori`) VALUES
(1, 'pipa', 100.00, 30, 1, 'besi', 'adidos', 'Pipa'),
(2, 'genteng', 8.00, 94, 4, 'besi', 'bumiku', 'Bangunan'),
(4, 'semen', 5.00, 18, 5, 'besi', 'bumi', 'Bangunan'),
(11, 'paku', 1.00, 18, 10, 'besi', 'uhuy', 'Bangunan'),
(13, 'cat warna hitam', 55.00, 10, 5, 'cairan', 'akumahbebas', 'Bangunan');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tabel_penjualan`
--

CREATE TABLE `tabel_penjualan` (
  `id_penjualan` int(11) NOT NULL,
  `id_barang` int(11) DEFAULT NULL,
  `jumlah` int(11) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tabel_penjualan`
--

INSERT INTO `tabel_penjualan` (`id_penjualan`, `id_barang`, `jumlah`, `total`) VALUES
(1, NULL, NULL, NULL),
(2, 1, 3, 300.00),
(3, 1, 1, 100.00),
(4, 1, 1, 100.00),
(5, 2, 100, 800.00),
(6, 2, 12, 96.00),
(7, 2, 10, 80.00),
(8, NULL, 0, 0.00),
(9, NULL, 0, 0.00),
(10, 4, 0, 0.00),
(11, 4, 1, 5.00),
(12, 2, 1, 8.00),
(13, 2, 1, 8.00),
(14, 2, 1, 8.00),
(15, NULL, 1, 0.00),
(16, NULL, 0, 0.00),
(17, NULL, 0, 0.00),
(18, NULL, 1, 0.00),
(19, 2, 1, 8.00),
(20, 4, 5, 25.00),
(21, 2, 2, 16.00),
(22, 4, 2, 10.00),
(23, 11, 2, 2.00);

-- --------------------------------------------------------

--
-- Struktur dari tabel `tabel_user`
--

CREATE TABLE `tabel_user` (
  `id_user` int(11) NOT NULL,
  `username` varchar(50) DEFAULT NULL,
  `password` varchar(100) DEFAULT NULL,
  `role` enum('pemilik','pelanggan') DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tabel_user`
--

INSERT INTO `tabel_user` (`id_user`, `username`, `password`, `role`) VALUES
(1, 'reno', 'admin', 'pemilik'),
(2, 'orang', 'orang', 'pelanggan'),
(3, 'aku', 'mahasigma', 'pelanggan'),
(4, 'iam', '123', 'pelanggan'),
(5, 'ojan', '123', 'pelanggan'),
(25, 'budi', '123', 'pelanggan');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tabel_barang`
--
ALTER TABLE `tabel_barang`
  ADD PRIMARY KEY (`id_barang`);

--
-- Indeks untuk tabel `tabel_penjualan`
--
ALTER TABLE `tabel_penjualan`
  ADD PRIMARY KEY (`id_penjualan`),
  ADD KEY `id_barang` (`id_barang`);

--
-- Indeks untuk tabel `tabel_user`
--
ALTER TABLE `tabel_user`
  ADD PRIMARY KEY (`id_user`),
  ADD UNIQUE KEY `username` (`username`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `tabel_barang`
--
ALTER TABLE `tabel_barang`
  MODIFY `id_barang` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT untuk tabel `tabel_penjualan`
--
ALTER TABLE `tabel_penjualan`
  MODIFY `id_penjualan` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- AUTO_INCREMENT untuk tabel `tabel_user`
--
ALTER TABLE `tabel_user`
  MODIFY `id_user` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=26;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tabel_penjualan`
--
ALTER TABLE `tabel_penjualan`
  ADD CONSTRAINT `tabel_penjualan_ibfk_1` FOREIGN KEY (`id_barang`) REFERENCES `tabel_barang` (`id_barang`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
