# FastRentAPI

## Deskripsi Project
FastRentAPI adalah REST API untuk sistem rental kendaraan yang menyediakan fitur CRUD data kendaraan, pengguna, dan transaksi rental.

## Domain / Tema
Tema yang dipilih adalah **rental kendaraan**, karena memudahkan pengelolaan data kendaraan dan transaksi penyewaan.

## Teknologi yang Digunakan
| Komponen | Teknologi |
|---|---|
| Bahasa | C# |
| Framework | ASP.NET Core Web API |
| Database | PostgreSQL |
| ORM | Entity Framework Core |
| Dokumentasi API | Swagger |

## Cara Menjalankan Project
1. Clone repository
2. Buka project di Visual Studio
3. Restore NuGet package
4. Jalankan project dengan `F5`
5. Swagger akan terbuka otomatis

## Cara Import Database
1. Buka pgAdmin
2. Buat database `fast_rent`
3. Jalankan file `database.sql`
4. Pastikan tabel berhasil dibuat

## Daftar Endpoint
| Method | URL | Keterangan |
|---|---|---|
| GET | /api/Vehicles | Menampilkan semua kendaraan |
| GET | /api/Vehicles/{id} | Menampilkan kendaraan berdasarkan id |
| POST | /api/Vehicles | Menambah data kendaraan |
| PUT | /api/Vehicles/{id} | Mengubah data kendaraan |
| DELETE | /api/Vehicles/{id} | Menghapus data kendaraan |
