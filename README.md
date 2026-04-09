# 🏭 ASP.NET Core 8.0 — ERP Üretim Yönetim Sistemi

Masaüstü ortamda geliştirilen ERP sisteminin web tabanlı 
arayüzü, **ASP.NET Core 8.0 Web API** kullanılarak web arayüzü oluşturulmaktadır. 
Proje aktif olarak geliştirilmeye devam etmektedir.

---

## 🚀 Kullanılan Teknolojiler

| Katman | Teknoloji |
|--------|-----------|
| Backend | ASP.NET Core 8.0, C#, Web API |
| ORM | Entity Framework Core, LINQ |
| Veritabanı | MSSQL |
| Mimari | N-Tier Architecture, DTO, AutoMapper |
| Frontend | HTML, CSS, Bootstrap, JavaScript |
| Araçlar | Swagger, Git, GitHub |

---

## 📁 Proje Mimarisi

```
AspNetCore-Api-ERP-Production-Management/
├── Erp.EntityLayer/       # Entity modelleri
├── Erp.DataAccessLayer/   # Repository, DbContext
├── Erp.BusinessLayer/     # İş kuralları, servisler
├── Erp.DtoLayer/          # DTO sınıfları
├── ErpApi/                # Web API, Controller'lar
└── ErpWebUI/              # MVC arayüz katmanı
```

---

## ⚙️ Özellikler

- ✅ N-Tier Architecture ile tam katmanlı mimari
- ✅ DTO katmanı ve AutoMapper entegrasyonu
- ✅ Entity Framework Core ile Code First yaklaşımı
- ✅ RESTful API geliştirildi ve Swagger ile test edildi
- ✅ İlişkili tablolar ve veritabanı yönetimi
- ✅ API ve WebUI katmanları birbirinden bağımsız
- 🔄 Geliştirme devam etmektedir

---

## 🛠️ Kurulum

### Gereksinimler
- .NET 8.0 SDK
- MSSQL Server
- Visual Studio 2022 veya VS Code

### Adımlar
```bash
# 1. Repoyu klonla
git clone https://github.com/enes-ozdemir23/AspNetCore-Api-ERP-Production-Management.git

# 2. ErpApi/appsettings.json dosyasında bağlantı dizesini düzenle
"ConnectionStrings": {
  "DefaultConnection": "Server=.;Database=ErpDb;Trusted_Connection=True;"
}

# 3. Migration uygula
dotnet ef database update

# 4. API'yi çalıştır
cd ErpApi
dotnet run

# 5. WebUI'yi çalıştır
cd ErpWebUI
dotnet run
```

---

## 📸 Ekran Görüntüleri

> _(Eklenecek)_

---

## 👤 Geliştirici

**Enes Özdemir**
📧 ozdemir.enes2323@gmail.com
🔗(https://github.com/enes-ozdemir23)
