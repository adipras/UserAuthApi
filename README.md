# User API - .NET Core & MySQL

## 🚀 Deskripsi
API ini adalah implementasi RESTful API menggunakan .NET Core terbaru dengan database MySQL. API ini memiliki fitur autentikasi JWT, CRUD user, validasi input, serta menerapkan clean architecture.

## 📌 Fitur
- User authentication dengan JWT token
- CRUD User
- Akses CRUD hanya bisa dilakukan jika user sudah login
- Validasi input menggunakan DataAnnotations
- Migration dan seeding contoh data
- Dokumentasi API dengan Swagger

## 🛠️ Teknologi yang Digunakan
- .NET Core (versi terbaru)
- Entity Framework Core
- MySQL
- BCrypt untuk hashing password
- JWT Authentication
- Swagger untuk dokumentasi API

## 🏗️ Instalasi & Menjalankan API
### 1️⃣ Clone Repository
```sh
git clone https://github.com/adipras/UserAuthApi.git
cd UserAuthApi
```

### 2️⃣ Konfigurasi Database
Pastikan MySQL sudah terinstall dan jalankan MySQL server.

Buat file **appsettings.json** di root project dan sesuaikan dengan konfigurasi MySQL Anda:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=userapi;User=root;Password=yourpassword;"
  },
  "Jwt": {
    "Key": "your_secret_key",
    "Issuer": "your_issuer",
    "Audience": "your_audience"
  }
}
```

### 3️⃣ Instal Dependensi
```sh
dotnet restore
```

### 4️⃣ Jalankan Migrasi Database
```sh
dotnet ef migrations add InitialCreate
dotnet ef database update
```

### 5️⃣ Jalankan API
```sh
dotnet run
```

API akan berjalan di `http://localhost:5150`

## 🔍 Dokumentasi API dengan Swagger
Buka browser dan akses:
```
http://localhost:5000/swagger
```

## 🛠️ Testing API dengan Postman
### 📌 Register User
- **Endpoint:** `POST /api/auth/register`
- **Body:**
```json
{
  "name": "John Doe",
  "email": "john@example.com",
  "phoneNumber": "08123456789",
  "password": "Secret123"
}
```

### 📌 Login User
- **Endpoint:** `POST /api/auth/login`
- **Body:**
```json
{
  "email": "john@example.com",
  "password": "Secret123"
}
```
- **Response:** `{ "token": "your-jwt-token" }`

### 📌 Fetch Users (Butuh Token)
- **Endpoint:** `GET /api/users`
- **Headers:**
```
Authorization: Bearer your-jwt-token
```


