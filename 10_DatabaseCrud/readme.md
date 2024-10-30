# _10_DatabaseCrud

Bu proje, C# ve ADO.NET kullanarak basit bir CRUD (Create, Read, Update, Delete) işlemleri gerçekleştiren bir konsol uygulamasıdır. Bu uygulama, SQL Server veritabanı üzerinde `Category` ve `Product` tabloları ile etkileşime geçerek veri ekleme, listeleme, güncelleme ve silme işlemlerini gösterir.

## Özellikler

### 1. Kategori Ekleme
Bu özellik, kullanıcıdan alınan kategori adını `Category` tablosuna ekler. 

#### Kod Açıklaması:
- Kullanıcıdan yeni bir kategori adı girmesi istenir.
- SQL bağlantısı açılır ve bir `INSERT INTO` sorgusu kullanılarak kategori adı veritabanına eklenir.
- Bağlantı kapatılır ve ekleme işleminin başarılı olduğu mesajı gösterilir.

### 2. Ürün Listeleme
Bu özellik, `Product` tablosundaki tüm verileri konsola listeleyen bir fonksiyon içerir.

#### Kod Açıklaması:
- `Product` tablosundaki tüm kayıtları almak için `SELECT * FROM Product` sorgusu kullanılır.
- Bir `SqlDataAdapter` ve `DataTable` kullanarak sorgu sonucu veriler doldurulur.
- Tüm satırlar döngüyle konsola yazdırılır.

### 3. Ürün Silme
Bu özellik, kullanıcı tarafından girilen `ProductId` değerine göre bir ürünü `Product` tablosundan siler.

#### Kod Açıklaması:
- Silinmek istenen ürünün `ProductId` değeri kullanıcıdan alınır.
- `DELETE FROM Product WHERE ProductId = @productId` sorgusu ile ürün, veritabanından silinir.
- Bağlantı kapatılır ve silme işleminin yapıldığına dair mesaj gösterilir.

### 4. Ürün Güncelleme
Bu özellik, `Product` tablosundaki bir ürünün adı ve fiyatını güncellemeyi sağlar.

#### Kod Açıklaması:
- Güncellenecek ürünün `ProductId`, `ProductName` ve `ProductPrice` değerleri kullanıcıdan alınır.
- `UPDATE Product SET ProductName = @productName, ProductPrice = @productPrice WHERE ProductId = @productId` sorgusu ile belirtilen `ProductId`'ye sahip ürün güncellenir.
- Bağlantı kapatılır ve güncelleme işleminin başarılı olduğu mesajı gösterilir.

## Kullanım
- Uygulama çalıştırıldığında, ekrana çeşitli CRUD işlemleri gelir.
- Kullanıcı, konsol üzerinden işlemler için gerekli değerleri girdikten sonra veritabanı üzerinde ilgili işlem yapılır ve sonuç konsola yazdırılır.

## Gereksinimler
- SQL Server'da `BootcampDb` adında bir veritabanı ve `Category`, `Product` gibi tablolar olmalıdır.
- C# .NET Framework veya .NET Core SDK

Bu uygulama, temel veritabanı işlemlerini öğrenmek için harika bir örnektir.
