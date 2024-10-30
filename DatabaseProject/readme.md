# C# Veri Tabanlı Ürün-Kategori Bilgi Sistemi

Bu proje, C# ve ADO.NET kullanarak SQL veritabanına bağlanmayı ve veritabanındaki bilgileri çekip konsolda görüntülemeyi amaçlamaktadır. Program, kullanıcıya bir menü sunarak farklı veritabanı tablolarından veri çekme seçeneği sunar.

## Proje Özeti

Program, veritabanındaki `Category` tablosundan bilgileri çekip ekranda listelemektedir. Çalıştırıldığında, kullanıcıya basit bir menü sunulur ve kullanıcı bu menüden bir tablo seçebilir:

- **1-Kategoriler**: Veritabanındaki kategorileri listeler.
- **2-Ürünler**: Ürünlerle ilgili işlemleri kapsayacak şekilde ayrılmıştır (şu an örnek kodda işlenmemiş).
- **3-Siparişler**: Sipariş bilgilerine erişim sağlanması beklenir (şu an örnek kodda işlenmemiş).
- **4-Çıkış Yap**: Programdan çıkış yapma seçeneğidir.

## Kod Açıklaması

### Ado.net Bağlantısı

Kodun ilk kısmında, ADO.NET kullanılarak SQL Server’a bağlantı kurulmuştur. Bu bağlantı, `SqlConnection` nesnesi ile gerçekleştirilmiştir.

### SQL Komutu ve Data Adapter

Veritabanından `Category` tablosunu seçmek için `SqlCommand` komutu ve `SqlDataAdapter` kullanılarak veri çekme işlemi gerçekleştirilmiştir.

### DataTable ve Verilerin Konsola Yazdırılması

`DataTable`, çekilen veriyi saklamak için kullanılmıştır. `adapter.Fill(dataTable);` komutu ile veriler `DataTable` içerisine aktarılmış ve ardından bağlantı kapatılmıştır.

### Verilerin Konsolda Görüntülenmesi

Her satırdaki her öğe, iç içe `foreach` döngüleri kullanılarak `DataTable` içerisinden alınmış ve konsola yazdırılmıştır.

## Kullanım

1. Uygulamayı çalıştırın.
2. Ekranda bir ana menü görüntülenecektir.
3. İlgili tabloyu çekmek için bir sayı girin (örneğin, "1" girerek kategorileri listeleyebilirsiniz).
4. Veritabanından çekilen veriler konsola yazdırılacaktır.

Bu program, SQL bağlantısı ve veritabanından veri çekme işlemlerini temel seviyede göstermektedir. Geliştiriciler bu kodu genişleterek farklı tablolardan veri çekme, veri ekleme veya silme gibi işlemleri de ekleyebilir.

## Gereksinimler

- SQL Server (`BootcampDb` veritabanı içinde `Category` tablosu oluşturulmuş olmalıdır).
- .NET Framework veya .NET Core

Bu README dosyası, programın işleyişi ve amacı hakkında genel bilgi sunmaktadır.

![image](https://github.com/user-attachments/assets/eaf16935-d3cc-4f83-840c-47eba2dcb538)
