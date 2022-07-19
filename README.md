PROGRAM TANITIMI

1-	Programın Amacı
Bu program örnek ATM uygulaması olarak verilerin veri tabanından programa aktarılıp, işlendikten sonra veri tabanında güncellenmesi amacıyla proje ödevi olarak yapılmıştır.

2.1- Son Kullanıcıya Yönelik Tasarım
![image](https://user-images.githubusercontent.com/61161197/179745455-910f1146-c88a-4458-880f-f78f4d9e9079.png)

 
Ekte yer alan numaralandırılmış Toolların açıklamaları şu şekildedir;
1-	Telefon numarası 05********* şeklinde olmalıdır. Harf veya özel karakteri girilmeye çalışıldığında uyarı verir.

2-	Şifre 6 haneli olmak zorundadır ve sadece rakam içermelidir.

3-	“Giriş Yap” butonu bilgiler eksiksiz doldurulduğunda aktif hale gelir ve bilgiler doğru ise “Home” formuna yönlendirir.

4-	Yeni Kayıt butonundan veri tabanına yeni kayıt eklenir.

5-	Her formda bulunan bu buton uygulamayı kapatır.

![image](https://user-images.githubusercontent.com/61161197/179745635-059e2481-efe4-42fd-96c4-faa8520fa9bc.png)
Yeni kayıt formunda “Onayla” buton tüm bilgiler eksiksiz doldurulduğunda aktif olur. Telefon numarası veri tabanında bulunuyorsa kayıt gerçekleşmez ve hata verir.
 
 
 
 ![image](https://user-images.githubusercontent.com/61161197/179746821-7162c9d4-6d18-4c06-bfd7-dd2dd6be53fd.png)
“Home” sayfasında sol üstte kullanılabilir limit gösterilmektedir.
Hızlı Para Çekme butonları ile hızlı para çekilebilir. Bu sayfada bulundan soldaki menülerden Çek, Yatır, Havale/EFT, Fatura Öde sayfalarına erişilebilir. İşlemlerden sonra veri tabanında veri güncellenir.
Sağ üstte bulunan çark butonuyla ad, soyad ve şifre bilgileri değiştirilebilir. Information butonu ile hakkında sayfasına erişilir.
 
EFT/Havale formunda para gönderilmek istenen telefon numarası ve tutar girilir. Yeterli bakiye olmadığında hata mesajı verilir ve telefon numarası sistemde kayıtlı değilse yine bilgilendirici hata verecektir. 

Fatura Öde sayfasında ödeme yapılacak kurum seçilir.
 ![image](https://user-images.githubusercontent.com/61161197/179745533-a220b86d-eb98-4e8e-9f49-b4e893edc26b.png)
![image](https://user-images.githubusercontent.com/61161197/179745560-2b56d30c-4c45-4ff9-b702-8c06af3de9fe.png)

 
FaturaOlustur() metodu ile belirlenen değerler arasında rastgele bir fatura oluşturulur. Ödemeyi Tamamla butonuyla miktar bakiyeden düşülür ve sayfadan çıkış yapılana kadar ödeme yapılan kuruma ait yeni fatura oluşturulmaz. 
![image](https://user-images.githubusercontent.com/61161197/179745870-429e5889-8736-4d0c-80d6-f156ab84542b.png)




![image](https://user-images.githubusercontent.com/61161197/179745889-2f9ed0ab-1837-4cb6-a01c-769cfc8beb99.png)

Para Yatır ve Para Çekme formlarında TextBox a sadece rakam girilmesine izin verilir ve yazılan tutar hesaptan çekilir veya yatırılır.

2.2- Programlamaya Yönelik Tasarım

 ![image](https://user-images.githubusercontent.com/61161197/179745594-f0912c83-11c1-4b31-b802-594b157383a7.png)

2.3.- Algoritmik Yapı

Bu programda DB First yöntemi kullanılmıştır. KeyPress Event ile yanlış verinin önüne geçmeyi amaçlamıştır. Yine de yanlış veri tabanı tarafında kontrol edilip sonuç göstermektedir. 


3-	Veri Tabanı

 ![image](https://user-images.githubusercontent.com/61161197/179745981-ba561dcb-0a95-4436-a150-9be7ae284161.png)

