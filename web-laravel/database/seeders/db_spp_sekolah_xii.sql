-- Active: 1794273795310@@127.0.0.1@3306@db_spp_sekolah_xii
-- Active: 1794273795310@@127.0.0.1@3306@phpmyadmin
CREATE DATABASE db_spp_sekolah_xii;
CREATE Table spp(
    spp INT AUTO_INCREMENT PRIMARY KEY,
    tahun INT NOT NULL,
    nominal INT NOT NULL,
    keterengan  VARCHAR(100),
    created_at TIMESTAMP,
    updated_at TIMESTAMP
);
CREATE Table petugas(
    id_petugas INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(30)NOT NULL,
    password VARCHAR(255)NOT NULL,
    nama_petugas VARCHAR(50)NOT NULL,
    level 
    created_at TIMESTAMP,
    updated_at TIMESTAMP
);
CREATE Table kelas(
    id_kelas INT PRIMARY KEY,
    nama_kelas VARCHAR(15)NOT NULL,
    kompetensi_keahlian VARCHAR(50)NOT NULL,
    created_at TIMESTAMP,
    updated_at TIMESTAMP
);
CREATE Table siswa(
    nisn CHAR(10),
    nis CHAR(8),NOT NULL,
    nama VARCHAR(50),
    id_kelas INT PRIMARY KEY NOT NULL,
    alamat TEXT,
    no_telp VARCHAR(15),
    id_spp INT PRIMARY KEY NOT NULL,
    created_at TIMESTAMP,
    updated_at TIMESTAMP
);
CREATE Table pembayaran(
    
)