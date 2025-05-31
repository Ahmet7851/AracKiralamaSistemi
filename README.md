Anladım, `README.MF` uzantılı bir dosya istiyorsunuz.

Öncelikle küçük bir bilgilendirme yapmak isterim:
`README.MF` dosyası genellikle Java dünyasında JAR (Java Archive) dosyaları için kullanılan bir "Manifest" dosyasıdır. Bu dosyalar genellikle `Anahtar: Değer` şeklinde meta-veriler içerir (örneğin, `Manifest-Version: 1.0`, `Main-Class: com.example.MyApplication`).

Proje hakkında genel açıklamalar, kurulum bilgileri, kullanılan teknolojiler gibi dokümantasyon amaçlı bilgiler için standart dosya adı ve formatı `README.md` (Markdown formatında) olur. Bu dosya, metin editörleri ve platformlar (GitHub, GitLab vb.) tarafından güzel bir şekilde formatlanarak gösterilir.

Eğer proje dokümantasyonu için bir dosya istiyorsanız, büyük ihtimalle `README.md` dosyasını kastediyorsunuz. Size daha önce hazırladığım ve tüm bilgileri içeren `README.md` içeriğini aşağıya **tek bir metin bloğu** olarak bırakıyorum. Bu metni kopyalayıp projenizin ana dizininde `README.md` adlı bir dosyaya yapıştırabilirsiniz.

Eğer özel bir sebepten dolayı gerçekten de `README.MF` formatında (çok daha basit, genellikle anahtar-değer çiftleri içeren bir yapıda) bir dosyaya ihtiyacınız varsa, lütfen belirtin. O zaman proje bilgilerini o formata uygun, daha kısıtlı bir yapıda sunmaya çalışabilirim. Ancak bu, detaylı dokümantasyon için standart bir yöntem değildir.

**Aşağıdaki metin, `README.md` dosyası içindir:**

```markdown
# Araç Kiralama Sistemi (C# WinForms)

Bu proje, C# programlama dili ve Windows Forms (WinForms) teknolojisi kullanılarak geliştirilmiş, Nesne Yönelimli Programlama (OOP) kavramlarını temel alan bir araç kiralama sistemi uygulamasıdır.

## Proje Amacı

Farklı türdeki araçların (Sedan, SUV, Kamyonet vb.) kiralanabildiği, müşteri bilgilerinin yönetilebildiği ve kiralama sözleşmelerinin oluşturulup takip edilebildiği masaüstü bir uygulama geliştirmektir. Proje, OOP'nin temel prensipleri olan Kalıtım, Arayüz Kullanımı, Polimorfizm ve Soyutlama kavramlarını pratik bir senaryo üzerinde uygulamayı hedefler.

## Kullanılan Teknolojiler

*   **Programlama Dili:** C#
*   **Platform:** .NET Framework (veya projenizin .NET sürümüne göre güncelleyin: .NET Core/5/6/7/8)
*   **Arayüz Teknolojisi:** Windows Forms (WinForms)
*   **Veri Saklama (Mevcut Durum):** Çalışma zamanında `List<T>` koleksiyonları (Kalıcı depolama için geliştirilmeye açık)

## Temel OOP Kavramları ve Uygulanışı

Bu projede aşağıdaki Nesne Yönelimli Programlama kavramları aktif olarak kullanılmıştır:

1.  **Kalıtım (Inheritance):**
    *   `Arac` adında soyut bir ana sınıf oluşturulmuştur.
    *   `Sedan`, `SUV`, `Kamyonet` gibi spesifik araç türleri, `Arac` sınıfından miras alarak ortak özellikleri ve davranışları devralır, aynı zamanda kendi özeliklerini de eklerler.
    *   **Örnek:** `public class Sedan : Arac { ... }`

2.  **Arayüzler (Interfaces):**
    *   `IKiralik`: Bir nesnenin kiralanabilir olduğunu ve ilgili metotları (örn: `KiraHesapla`, `Kirala`) implemente etmesi gerektiğini belirten bir sözleşmedir. `Arac` sınıfı bu arayüzü uygular.
    *   `IAracOzellikleri`: Bir aracın özelliklerini standart bir şekilde sunabilme yeteneğini tanımlar. `Arac` sınıfı bu arayüzü de uygular.
    *   **Örnek:** `public interface IKiralik { decimal KiraHesapla(...); }`

3.  **Polimorfizm (Polymorphism):**
    *   Farklı araç türlerinin (`Sedan`, `SUV` vb.) `Arac` ana sınıfı üzerinden referans alınarak aynı metot çağrısına (örn: `KiraHesapla()`, `OzellikleriGoster()`) kendi özel davranışlarıyla yanıt vermesi sağlanmıştır.
    *   **Örnek:** `Arac seciliArac = ...; decimal tutar = seciliArac.KiraHesapla(...);` // `seciliArac`'ın gerçek tipine göre doğru metot çalışır.

4.  **Soyutlama (Abstraction):**
    *   `Arac` sınıfının `abstract` olarak tanımlanması, doğrudan "genel bir araç" nesnesi oluşturulmasını engeller ve alt sınıfların belirli metotları (örn: `OzellikleriGoster()`) implemente etmesini zorunlu kılar.
    *   Arayüzler, implementasyon detaylarını gizleyerek sadece "ne yapılacağını" belirten bir sözleşme sunar.
    *   Kullanıcı arayüzü (Formlar), iş mantığı detaylarını bilmeden Servis katmanı üzerinden işlemlerini gerçekleştirir.

## Proje Modülleri ve İşlevleri

1.  **Ana Menü (`AnaForm`):**
    *   Sistemin diğer modüllerine (Araç Yönetimi, Müşteri Yönetimi, Kiralama, Raporlar) erişim sağlar.

2.  **Araç Yönetimi (`AracYonetimForm`):**
    *   Yeni araç (Sedan, SUV, Kamyonet) ekleme.
    *   Mevcut araçların bilgilerini (marka, model, plaka, günlük kira bedeli, araca özel özellikler) güncelleme.
    *   Araçları sistemden silme (kirada olmayan araçlar için).
    *   Tüm araçları listeleme.
    *   Araç tipine göre dinamik olarak ek özellik giriş alanları sunma.

3.  **Müşteri Kayıt ve Yönetimi (`MusteriKayitForm`):**
    *   Yeni müşteri kaydı oluşturma (Ad, Soyad, TC Kimlik No, Telefon, Adres).
    *   Mevcut müşteri bilgilerini güncelleme.
    *   Müşterileri sistemden silme (aktif kiralaması olmayan müşteriler için).
    *   Tüm müşterileri listeleme.

4.  **Kiralama Sözleşmesi Oluşturma (`KiralamaForm`):**
    *   Sistemde kayıtlı müşterilerden birini seçme.
    *   Sadece müsait (kirada olmayan) araçlardan birini seçme.
    *   Kiralama başlangıç ve bitiş tarihlerini belirleme.
    *   Seçilen araç ve tarihlere göre toplam kiralama bedelini (polimorfik olarak) otomatik hesaplama ve gösterme.
    *   Seçilen aracın temel özelliklerini gösterme.
    *   Kiralama işlemini onaylayarak yeni bir kiralama sözleşmesi oluşturma.
    *   Kiralanan aracın durumunu "Kirada" olarak güncelleme.

5.  **Raporlama (`RaporForm`):**
    *   **Aktif Kiralamalar:** Anlık olarak hangi araçların hangi müşteriler tarafından kiralandığını, kiralama tarihlerini ve toplam ücreti gösteren bir liste sunar.
        *   Bu listeden seçilen bir kiralama için "Teslim Al" işlemi yapılarak aracın müsait duruma getirilmesi ve sözleşmenin tamamlanması.
    *   **En Çok Kiralanan Araçlar:** Belirli bir periyotta (veya tüm zamanlar için) en çok kiralama işlemi yapılan araçları listeler.

## Proje Yapısı (Klasörler)

```
AracKiralamaSistemi/
|-- AracKiralamaSistemi.csproj
|-- Program.cs
|-- Models/                 # Veri modelleri (Arac, Sedan, Musteri vb.)
|   |-- Arac.cs
|   |-- Sedan.cs
|   |-- SUV.cs
|   |-- Kamyonet.cs
|   |-- Musteri.cs
|   |-- KiralamaSozlesmesi.cs
|-- Interfaces/             # Arayüz tanımları (IKiralik, IAracOzellikleri)
|   |-- IKiralik.cs
|   |-- IAracOzellikleri.cs
|-- Services/               # İş mantığı ve veri yönetimi servisleri
|   |-- AracYonetimiServisi.cs
|   |-- MusteriYonetimiServisi.cs
|   |-- KiralamaServisi.cs
|   |-- RaporlamaServisi.cs
|-- Forms/                  # Windows Forms arayüz dosyaları
|   |-- AnaForm.cs
|   |-- AracYonetimForm.cs
|   |-- MusteriKayitForm.cs
|   |-- KiralamaForm.cs
|   |-- RaporForm.cs
|-- Data/                   # Geçici veri depolama (List<T> kullanan statik sınıf)
    |-- VeriDeposu.cs
```

## Proje Görselleri (Ekran Görüntüleri)

Bu bölümde, uygulamanın temel pencerelerine ait ekran görüntüleri yer alacaktır.

### 1. Ana Menü (`AnaForm.cs`)
*(Buraya AnaForm'un ekran görüntüsünü ekleyin. Markdown formatında: `![Ana Form](screenshots/ana_form.png)` şeklinde veya sadece dosya adıyla `![Ana Form](ana_form.png)` eğer README ile aynı dizindeyse)*
```
[AnaForm Ekran Görüntüsü Buraya Gelecek]
```
**Açıklama:** Uygulama açıldığında kullanıcıyı karşılayan ve diğer modüllere navigasyon sağlayan ana pencere.

### 2. Araç Yönetim Penceresi (`AracYonetimForm.cs`)
*(Buraya AracYonetimForm'un ekran görüntüsünü ekleyin. Markdown formatında)*
```
[AracYonetimForm Ekran Görüntüsü Buraya Gelecek - Sedan seçiliyken özel alanlar görünebilir]
```
**Açıklama:** Araçların eklendiği, güncellendiği, silindiği ve listelendiği pencere. Araç tipi seçimine göre farklı özellik alanları aktifleşir.

### 3. Müşteri Kayıt Penceresi (`MusteriKayitForm.cs`)
*(Buraya MusteriKayitForm'un ekran görüntüsünü ekleyin. Markdown formatında)*
```
[MusteriKayitForm Ekran Görüntüsü Buraya Gelecek]
```
**Açıklama:** Müşteri bilgilerinin yönetildiği pencere.

### 4. Yeni Kiralama Sözleşmesi Penceresi (`KiralamaForm.cs`)
*(Buraya KiralamaForm'un ekran görüntüsünü ekleyin. Markdown formatında)*
```
[KiralamaForm Ekran Görüntüsü Buraya Gelecek - Araç ve müşteri seçilmiş, fiyat hesaplanmış olabilir]
```
**Açıklama:** Müşteri ve araç seçilerek kiralama sözleşmesinin oluşturulduğu, tarihlerin ve ücretin belirlendiği pencere.

### 5. Raporlar Penceresi (`RaporForm.cs`)
*(Buraya RaporForm'un ekran görüntüsünü ekleyin. Markdown formatında - Aktif Kiralamalar sekmesi açık olabilir)*
```
[RaporForm Ekran Görüntüsü Buraya Gelecek - Örneğin Aktif Kiralamalar sekmesi]
```
**Açıklama:** Aktif kiralamaların ve en çok kiralanan araçların görüntülendiği, teslim alma işlemlerinin yapıldığı sekmeli rapor penceresi.

## Kurulum ve Çalıştırma

1.  Projeyi bilgisayarınıza klonlayın veya ZIP olarak indirin.
2.  Visual Studio (Önerilen sürüm: 2019 veya üstü) ile `AracKiralamaSistemi.sln` dosyasını açın.
3.  Proje bağımlılıklarının otomatik olarak yüklenmesini bekleyin (genellikle .NET projelerinde ek bir adım gerektirmez).
4.  Visual Studio'da "Start" (Başlat) butonuna tıklayarak veya F5 tuşuna basarak uygulamayı çalıştırın.

## Gelecekteki Olası Geliştirmeler

*   **Kalıcı Veri Depolama:** Verilerin uygulama kapatıldığında kaybolmaması için SQLite, SQL Server gibi bir veritabanı sistemi veya JSON/XML dosyalarına kayıt entegrasyonu.
*   **Kullanıcı Giriş Sistemi:** Yetkilendirme için kullanıcı adı ve şifre ile giriş mekanizması.
*   **Gelişmiş Raporlar:** Tarih aralığına göre gelir, müşteri bazlı kiralama geçmişi gibi daha detaylı raporlar.
*   **Arama ve Filtreleme:** Araç ve müşteri listelerinde daha kapsamlı arama ve filtreleme özellikleri.
*   **Görsel İyileştirmeler:** Daha modern bir görünüm ve kullanıcı deneyimi için arayüz iyileştirmeleri.
*   **Birim Testleri (Unit Tests):** Servis katmanındaki metotların doğruluğunu sağlamak için birim testleri yazılması.

---
```
