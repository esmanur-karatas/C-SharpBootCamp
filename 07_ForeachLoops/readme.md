# 07_ForeachLoops Projesi

Bu proje, C# dilinde `foreach` döngüsünün kullanımını ve bir sınav sistemi uygulamasını örneklerle açıklamaktadır. Proje, çeşitli koleksiyonlar üzerinde `foreach` döngüsü kullanılarak işlem yapılmasını ve öğrencilerin sınav notlarıyla ilgili bir uygulamanın adım adım oluşturulmasını içerir.

---

## İçindekiler
1. Foreach Döngüsü Kullanımı
2. Örnek Sınav Sistemi Uygulaması

---

## Foreach Döngüsü Kullanımı

`foreach` döngüsü, diziler ve koleksiyonlar gibi veri yapıları üzerinde kolayca dolaşmak için kullanılır. `foreach` döngüsü dört ana bileşenden oluşur:
- **Değişken Türü:** Döngüde kullanmak istediğimiz elemanların türü.
- **Değişken Adı:** Döngü sırasında her bir elemanı temsil edecek değişkenin adı.
- **in:** Döngü yapısını başlatır ve liste, koleksiyon veya dizi üzerinde dönmeyi sağlar.
- **Liste, Koleksiyon, Dizi:** Üzerinde döngü yapılacak veri yapısı.

### Örnek Kullanımlar

1. **Şehirler Dizisi Üzerinde Döngü**  
   Bir `string` dizisi (`cities`) tanımlanır ve döngü ile bu dizideki her şehir ekrana yazdırılır. Bu işlem, dizideki her bir elemanın sırasıyla `city` değişkenine atanması ve ekrana yazdırılması ile yapılır.

2. **Sayılar Dizisi Üzerinde Döngü**  
   `int` türünde bir `numbers` dizisi tanımlanır ve her bir eleman sırasıyla `numberss` adlı değişkene atanarak ekrana yazdırılır. Bu işlem, sayıların tek tek ekrana gösterilmesini sağlar.

3. **Çift ve Tek Sayı Kontrolü**  
   `numbers` dizisindeki her elemanın çift veya tek olup olmadığını kontrol eder. Eğer eleman çiftse `true`, tekse `false` olarak ekrana yazdırılır. Bu işlem `%` operatörü ile yapılır.

4. **Sayıların Toplamını Hesaplama**  
   `numbers` dizisindeki tüm elemanlar toplanır ve sonuç `total` değişkeninde saklanır. `foreach` döngüsü her bir elemanı `i` değişkenine atayarak toplama işlemini gerçekleştirir.

5. **Liste Üzerinde Döngü**  
   `List<int>` türünde bir liste tanımlanır (`number`), ardından `foreach` döngüsü ile her bir eleman sırasıyla `i` değişkenine atanarak ekrana yazdırılır. Bu, listenin her bir elemanını görüntülemeyi sağlar.

6. **Kelimeyi Karakterlerine Ayırma**  
   `word` adlı bir kelimenin her bir karakteri döngü ile `c` değişkenine atanır ve ekrana yazdırılır. Bu işlem, kelimenin harf harf yazdırılmasını sağlar.

---

## Örnek Sınav Sistemi Uygulaması

Bu uygulamada kullanıcıdan öğrenci sayısı, öğrenci isimleri ve sınav notları istenerek öğrencilerin sınav ortalamaları hesaplanır. Her öğrencinin geçip kalma durumu ekrana yazdırılır.

### Adımlar

1. **Öğrenci Sayısını Kullanıcıdan Alma**  
   Kullanıcıya kaç öğrenci olduğunu sorar ve girilen sayı `studentCount` değişkenine atanır. Bu bilgi, sonraki adımlarda döngüyle veri girişi yapılacak öğrenci sayısını belirler.

2. **Öğrenci Bilgilerini ve Notlarını Saklamak İçin Diziler Oluşturma**  
   Öğrencilerin isimleri ve sınav ortalamalarını saklamak için `studentNames` ve `studentExamAvg` adlı iki dizi oluşturulur. Bu diziler, her öğrenci için ayrı ayrı bilgileri saklamayı sağlar.

3. **Öğrenci İsimlerini ve Sınav Notlarını Alma**  
   Kullanıcıdan her bir öğrencinin ismi alınır ve `studentNames` dizisine kaydedilir. Ardından her öğrenci için 3 sınav notu istenir ve bu notların toplamı `totalExamResult` değişkeninde saklanır. Notların toplamı 3’e bölünerek her öğrencinin ortalaması `studentExamAvg` dizisine kaydedilir.

4. **Sınav Ortalamalarını ve Geçip Kalma Durumlarını Yazdırma**  
   Her öğrenci için sınav ortalamaları ve geçip kalma durumları ekrana yazdırılır. Ortalama 50 veya daha yüksek olan öğrenciler "dersi geçti" olarak, 50'nin altında olanlar ise "dersten kaldı" olarak görüntülenir.

---

### Bu Projeyi Nasıl Kullanırsınız?

1. Projeyi çalıştırarak kullanıcıdan önce sınıftaki öğrenci sayısını girmeniz istenecektir.
2. Her öğrenci için isim girip 3 sınav notu ekleyeceksiniz.
3. Program, her öğrencinin ortalamasını hesaplayacak ve öğrencinin geçip kalma durumunu ekrana yazdıracaktır.

Bu proje, `foreach` döngüsü ile diziler ve koleksiyonlar üzerinde işlem yapmayı öğrenmek ve örnek bir sınav sistemi uygulaması geliştirmek için temel bir örnektir.


![image](https://github.com/user-attachments/assets/68d9a4c4-535b-4776-bd52-7f4d660ac1c5)
