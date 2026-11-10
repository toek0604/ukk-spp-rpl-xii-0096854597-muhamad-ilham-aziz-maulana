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
CREATE Table kelas(
    kelas INT AUTO_INCREMENT PRIMARY KEY,
    
)