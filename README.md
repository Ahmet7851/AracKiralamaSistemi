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

## Proje Görselleri (Ekran Görüntüleri)

Bu bölümde, uygulamanın temel pencerelerine ait ekran görüntüleri yer alacaktır.

### 1. Ana Menü (`AnaForm.cs`)
![image](https://github.com/user-attachments/assets/ab7f3e3f-dbdf-4988-848e-dfa6c19e39f3)
**Açıklama:** Uygulama açıldığında kullanıcıyı karşılayan ve diğer modüllere navigasyon sağlayan ana pencere.

### 2. Araç Yönetim Penceresi (`AracYonetimForm.cs`)
![image](https://github.com/user-attachments/assets/86e51ed9-ae75-48b8-82f1-9c6b192703b3)
**Açıklama:** Araçların eklendiği, güncellendiği, silindiği ve listelendiği pencere. Araç tipi seçimine göre farklı özellik alanları aktifleşir.

### 3. Müşteri Kayıt Penceresi (`MusteriKayitForm.cs`)
![image](https://github.com/user-attachments/assets/f86819ad-1fd1-48d8-abaf-6c358361e0a1)
**Açıklama:** Müşteri bilgilerinin yönetildiği pencere.

### 4. Yeni Kiralama Sözleşmesi Penceresi (`KiralamaForm.cs`)
![image](https://github.com/user-attachments/assets/0f24693a-1ec4-4323-a1be-cd015c91a3c0)
**Açıklama:** Müşteri ve araç seçilerek kiralama sözleşmesinin oluşturulduğu, tarihlerin ve ücretin belirlendiği pencere.

### 5. Raporlar Penceresi (`RaporForm.cs`)
![image](https://github.com/user-attachments/assets/f386b6de-cb64-49e9-828c-22c0fd2e7567)
![image](https://github.com/user-attachments/assets/0f3bc108-309e-428f-8f30-4b05742b037c)
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
