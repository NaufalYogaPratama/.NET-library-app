# **Aplikasi Perpustakaan Sederhana (.NET Web Forms)**

Ini adalah aplikasi web sederhana yang dibangun dengan C\# dan ASP.NET Web Forms. Aplikasi ini berfungsi sebagai formulir untuk mensimulasikan proses peminjaman buku di perpustakaan.

## **Deskripsi Proyek**

Aplikasi ini menyediakan antarmuka formulir di mana pengguna dapat memasukkan informasi pribadi mereka, memilih buku dari daftar yang tersedia, dan memilih tanggal peminjaman. Setelah formulir dikirim, sistem akan menampilkan ringkasan konfirmasi peminjaman.

## **Fitur**

* **Input Data Pengguna**: Pengguna dapat memasukkan nama dan alamat email.  
* **Pemilihan Buku**: Terdapat daftar dropdown berisi beberapa judul buku yang bisa dipilih.  
* **Pemilihan Tanggal**: Pengguna dapat memilih tanggal peminjaman menggunakan kontrol kalender interaktif.  
* **Tampilan Konfirmasi**: Setelah menekan tombol submit, aplikasi akan menampilkan pesan konfirmasi yang merangkum detail peminjaman.

## **Teknologi yang Digunakan**

* **Backend**: C\#  
* **Framework**: ASP.NET Web Forms  
* **Target Framework**: .NET Framework 4.8  
* **IDE**: Visual Studio

## **Cara Menjalankan Proyek**

Untuk menjalankan proyek ini di lingkungan lokal Anda, ikuti langkah-langkah berikut:

1. **Prasyarat**:  
   * Pastikan Anda telah menginstal **Visual Studio** (versi 2017 atau yang lebih baru direkomendasikan).  
   * Pastikan **.NET Framework 4.8** (atau versi yang kompatibel) terinstal di mesin Anda.  
2. **Clone Repositori**:  
   git clone \<URL\_REPOSITORI\_ANDA\>  
   cd \<NAMA\_FOLDER\_PROYEK\>

3. **Buka di Visual Studio**:  
   * Buka file solusi Modul3\_Tugas.sln dengan Visual Studio.  
   * Visual Studio akan secara otomatis memulihkan paket-paket (dependencies) yang diperlukan.  
4. **Jalankan Aplikasi**:  
   * Tekan tombol F5 atau klik tombol **Start** (biasanya dengan ikon panah hijau) di toolbar Visual Studio.  
   * Aplikasi akan dicompile dan dijalankan di server pengembangan IIS Express, lalu halaman LibraryForm.aspx akan terbuka di browser default Anda.

## **Cara Menggunakan Aplikasi**

1. Buka aplikasi di browser Anda.  
2. Isi kolom **Nama Lengkap** dan **Alamat Email**.  
3. Pilih **Judul Buku** yang ingin dipinjam dari daftar dropdown.  
4. Pilih **Tanggal Peminjaman** dari kalender yang muncul.  
5. Klik tombol **Pinjam Buku**.  
6. Sebuah pesan konfirmasi akan muncul di bagian bawah formulir dengan detail peminjaman Anda.

Dibuat oleh Naufal Yoga Pratama.
