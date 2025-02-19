-- phpMyAdmin SQL Dump
-- version 6.0.0-dev+20240523.2997b5272e
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 17 Jul 2024 pada 06.41
-- Versi server: 10.4.24-MariaDB
-- Versi PHP: 8.1.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbs_apotek`
--

-- --------------------------------------------------------

--
-- Struktur dari tabel `items`
--

CREATE TABLE `items` (
  `kd_obat` varchar(10) NOT NULL,
  `nama_obat` varchar(100) DEFAULT NULL,
  `description` text DEFAULT NULL,
  `stock` int(200) DEFAULT NULL,
  `harga` int(15) DEFAULT NULL,
  `jenis_obat` varchar(50) DEFAULT NULL,
  `image_path` varchar(255) DEFAULT NULL,
  `kd_kategori` varchar(10) DEFAULT NULL,
  `kd_suplier` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `items`
--

INSERT INTO `items` (`kd_obat`, `nama_obat`, `description`, `stock`, `harga`, `jenis_obat`, `image_path`, `kd_kategori`, `kd_suplier`) VALUES
('OBT001', 'Stimuno Forte', 'Suplemen untuk memperkuat daya tahan tubuh', 59, 52000, 'Vitamin', 'images/stimuno_forte.jpg', 'KT001', 'SP001'),
('OBT002', 'Bisolvon', 'Untuk batuk berdahak', 200, 30000, 'Sirup', 'images/bisolvon.jpg', 'KT001', 'SP001'),
('OBT003', 'Vitamin C', 'Untuk menjaga kesehatan tubuh', 11, 25000, 'Vitamin', 'images/vitaminC.jpg', 'KT001', 'SP002'),
('OBT004', 'Dulcalactol', 'Untuk mengatasi konstipasi', 75, 40000, 'Sirup', 'images/dulcalactol.jpg', 'KT002', 'SP002'),
('OBT009', 'Kalpanax Krim', 'Infeksi jamur pada kulit, seperti kutu air, panu, kadas, dan kurap', 50, 5000, 'Salep', 'images/kalpanax_krim.jpg', 'KT002', 'SP002'),
('OBT010', 'Paratusin', 'Flu dan sakit kepala', 50, 5000, 'Sirup', 'images/paratusin.jpg', 'KT002', 'SP002'),
('OBT011', 'Diapet', 'Kapsul Untuk mencret', 50, 5000, 'Kapsul', 'images/diapet.jpg', 'KT002', 'SP002'),
('OBT012', 'Salep 88', 'Mengatasi penyakit yang disebabkan oleh jamur serta infeksi bakteri ringan seperti panu, kudis, kurap dan kutu air', 50, 5000, 'Salep', 'images/salep88.jpeg', 'KT002', 'SP002'),
('OBT013', 'Krim Funginderm', 'Mengobati infeksi jamur di kulit dan kuku, seperti kutu air, panu, kadas, atau kandidiasis', 50, 5000, 'Salep', 'images/krim_funginderm.jpg', 'KT002', 'SP002'),
('OBT014', 'Blackmores', 'Membantu mencukupi kebutuhan vitamin D harian, serta menjaga kesehatan tulang dan daya tahan tubuh', 50, 5000, 'Vitamin', 'images/blackmores.png', 'KT002', 'SP002'),
('OBT015', 'Imboost', 'Meningkatkan daya tahan tubuh', 50, 5000, 'Vitamin', 'images/imboost.jpeg', 'KT002', 'SP002'),
('OBT016', 'Bioplacenton', 'Mengobati luka bakar, luka dengan infeksi, serta luka kronik dan jenis luka yang lain.', 50, 5000, 'Salep', 'images/bioplacenton.jpg', 'KT002', 'SP002'),
('OBT017', 'Bodrex', 'Obat Sakit Kepala', 50, 5000, 'Tablet', 'images/bodrex.jpg', 'KT001', 'SP001');

-- --------------------------------------------------------

--
-- Struktur dari tabel `kategoris`
--

CREATE TABLE `kategoris` (
  `kd_kategori` varchar(10) NOT NULL,
  `nama_kategori` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `kategoris`
--

INSERT INTO `kategoris` (`kd_kategori`, `nama_kategori`) VALUES
('KT001', 'Obat Bebas'),
('KT002', 'Obat Resep');

-- --------------------------------------------------------

--
-- Struktur dari tabel `sessions`
--

CREATE TABLE `sessions` (
  `id` varchar(255) COLLATE utf8mb4_unicode_ci NOT NULL,
  `user_id` bigint(20) UNSIGNED DEFAULT NULL,
  `ip_address` varchar(45) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `user_agent` text COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `payload` longtext COLLATE utf8mb4_unicode_ci NOT NULL,
  `last_activity` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;

--
-- Dumping data untuk tabel `sessions`
--

INSERT INTO `sessions` (`id`, `user_id`, `ip_address`, `user_agent`, `payload`, `last_activity`) VALUES
('jb6u2wggi6OQhYe1Ynbup1CmjKcyYXfvmmeIO0hy', NULL, '127.0.0.1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/126.0.0.0 Safari/537.36', 'YTo0OntzOjY6Il90b2tlbiI7czo0MDoiRVE3RnBqTFJOUDhYRnVjMkxIdklJc3VPek5GMk5SejZQVU9aeFZZRyI7czo5OiJfcHJldmlvdXMiO2E6MTp7czozOiJ1cmwiO3M6MjE6Imh0dHA6Ly8xMjcuMC4wLjE6ODAwMCI7fXM6NjoiX2ZsYXNoIjthOjI6e3M6Mzoib2xkIjthOjA6e31zOjM6Im5ldyI7YTowOnt9fXM6MzoidXJsIjthOjE6e3M6ODoiaW50ZW5kZWQiO3M6Mjg6Imh0dHA6Ly8xMjcuMC4wLjE6ODAwMC9sb2dvdXQiO319', 1721152843),
('LoiCpAd8bAfbVJlMVBuxvZr6erWtb6DbTu10pbnb', NULL, '127.0.0.1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/126.0.0.0 Safari/537.36', 'YTo0OntzOjY6Il90b2tlbiI7czo0MDoiTGlHcXhkckhOV09hbnV4OWxqNGpsU0tIR2xaUW52eXJZeVo0YjMzNCI7czo5OiJfcHJldmlvdXMiO2E6MTp7czozOiJ1cmwiO3M6MjY6Imh0dHA6Ly8xMjcuMC4wLjE6ODAwMC91c2VyIjt9czo2OiJfZmxhc2giO2E6Mjp7czozOiJvbGQiO2E6MDp7fXM6MzoibmV3IjthOjA6e319czozOiJ1cmwiO2E6MTp7czo4OiJpbnRlbmRlZCI7czoyODoiaHR0cDovLzEyNy4wLjAuMTo4MDAwL2xvZ291dCI7fX0=', 1721150637),
('SBCM6ydmbMDag9bDkKjMyphQM2Pbot4ztARsgiS5', NULL, '127.0.0.1', 'Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/126.0.0.0 Safari/537.36 Edg/126.0.0.0', 'YTo0OntzOjY6Il90b2tlbiI7czo0MDoiWldlMDNSUnpKQllQVjA0TUdKYzE3bmN3NmcxM2JSR2NNd1pyQ0xUSSI7czo5OiJfcHJldmlvdXMiO2E6MTp7czozOiJ1cmwiO3M6MzE6Imh0dHA6Ly8xMjcuMC4wLjE6ODAwMC9kYXNoYm9hcmQiO31zOjY6Il9mbGFzaCI7YToyOntzOjM6Im9sZCI7YTowOnt9czozOiJuZXciO2E6MDp7fX1zOjM6InVybCI7YToxOntzOjg6ImludGVuZGVkIjtzOjI4OiJodHRwOi8vMTI3LjAuMC4xOjgwMDAvbG9nb3V0Ijt9fQ==', 1721188054);

-- --------------------------------------------------------

--
-- Struktur dari tabel `supliers`
--

CREATE TABLE `supliers` (
  `kd_suplier` varchar(10) NOT NULL,
  `nama_suplier` varchar(100) DEFAULT NULL,
  `no_tlpn` varchar(20) DEFAULT NULL,
  `alamat` varchar(255) DEFAULT NULL,
  `perusahaan` varchar(100) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `supliers`
--

INSERT INTO `supliers` (`kd_suplier`, `nama_suplier`, `no_tlpn`, `alamat`, `perusahaan`) VALUES
('SP001', 'asep', '1234567890', 'Jl. Supplier A No. 1', 'PT Supplier A'),
('SP002', 'agus', '0987654321', 'Jl. Supplier B No. 2', 'PT Supplier B');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_user`
--

CREATE TABLE `tbl_user` (
  `id` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `tbl_user`
--

INSERT INTO `tbl_user` (`id`, `username`, `password`, `role`) VALUES
(4, 'apoteker', 'apoteker123', 'apoteker'),
(5, 'kasir1', 'kasir123', 'kasir'),
(6, 'kasir2', 'kasir456', 'kasir');

-- --------------------------------------------------------

--
-- Struktur dari tabel `transactions`
--

CREATE TABLE `transactions` (
  `nota` varchar(50) NOT NULL,
  `kd_kategori` varchar(50) DEFAULT NULL,
  `kd_suplier` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `transaction_items`
--

CREATE TABLE `transaction_items` (
  `id` int(11) NOT NULL,
  `nota` varchar(50) DEFAULT NULL,
  `kd_obat` varchar(50) DEFAULT NULL,
  `nama_obat` varchar(100) DEFAULT NULL,
  `harga` decimal(10,2) DEFAULT NULL,
  `jumlah` int(11) DEFAULT NULL,
  `total` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

-- --------------------------------------------------------

--
-- Struktur dari tabel `users`
--

CREATE TABLE `users` (
  `id` int(11) NOT NULL,
  `name` varchar(100) NOT NULL,
  `email` varchar(255) NOT NULL,
  `password` varchar(255) NOT NULL,
  `role` enum('Menager','Kasir','Apoteker','') NOT NULL,
  `created_at` timestamp NOT NULL DEFAULT current_timestamp(),
  `updated_at` timestamp NOT NULL DEFAULT current_timestamp() ON UPDATE current_timestamp()
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data untuk tabel `users`
--

INSERT INTO `users` (`id`, `name`, `email`, `password`, `role`, `created_at`, `updated_at`) VALUES
(1, 'isal', 'isal@isal.com', '$2y$12$k2QbL4bUCEdPgdhhoF63yuX/h2yAh7P6PisB1gHO/tVyB.F8e4QUe', 'Menager', '2024-07-16 15:13:09', '2024-07-16 16:27:40'),
(2, 'Salmon', 'admin@admin.com', '$2a$10$4KDXnXpdlgq8mYdwJB/Fbuwa7VgRhSwNpUp8XLleNzbut76YFP.7O', 'Menager', '2024-07-16 15:45:08', '2024-07-16 17:44:11');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `sessions`
--
ALTER TABLE `sessions`
  ADD PRIMARY KEY (`id`),
  ADD KEY `sessions_user_id_index` (`user_id`),
  ADD KEY `sessions_last_activity_index` (`last_activity`);

--
-- Indeks untuk tabel `transactions`
--
ALTER TABLE `transactions`
  ADD PRIMARY KEY (`nota`);

--
-- Indeks untuk tabel `transaction_items`
--
ALTER TABLE `transaction_items`
  ADD PRIMARY KEY (`id`),
  ADD KEY `nota` (`nota`);

--
-- Indeks untuk tabel `users`
--
ALTER TABLE `users`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `email` (`email`);

--
-- AUTO_INCREMENT untuk tabel yang dibuang
--

--
-- AUTO_INCREMENT untuk tabel `transaction_items`
--
ALTER TABLE `transaction_items`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT untuk tabel `users`
--
ALTER TABLE `users`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `transaction_items`
--
ALTER TABLE `transaction_items`
  ADD CONSTRAINT `transaction_items_ibfk_1` FOREIGN KEY (`nota`) REFERENCES `transactions` (`nota`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
