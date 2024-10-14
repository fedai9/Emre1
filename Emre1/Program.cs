using System;

namespace Emre1
{
    internal class Program
    {
        static int sayi = 15;
        static void Main(string[] args)
        {
            //Console.WriteLine("Güzel olan sevgili değildir, sevgili olan güzeldir.");
            //Console.WriteLine("Tolstoy");

            var sayii = 19.5; //açıklaması altta

            float sayi = 3.12f;
            double _sayi = 4.19;

            const byte a = 30;
            double d = 40;

            byte e, f; e=20 ; f=20;

            d = 100;
            Console.WriteLine(a*d+e+f);

            string isim = Console.WriteLine
            string soyisim = "Arslan";

            Console.ReadKey();
        }
    }
}

//namespace:İçinde classları bulunduran yapılardır.

//Scope(Blok yapıları): {} Parantezleri arasındaki yapılardır.

//Class: İçinde metodları bulunduran yapılardır.(Bu tanım şimdilik yüzeysel olarak yapılmıştır).

//Metod: İş yapan kod bloklarına metod denir.

//Main metodu: Console uygulamalarının başlangıç noktalarıdır.

//CTRL+F5: Uygulamayı hata ayıklama modu olmadan başlatır.

//Syntax:Kod yazım kuralları
//1-Açılan her parantez mutlaka kapatılmalıdır.
//2-Scope tanımlamaları sonunda ; kullanılmaz ancak komut satırları sonlarında kullanılır.

//Syntax Hatalarını Nasıl Anlarız?
//1-Hata olan kodun altı kırmızı işaretleme yapılır
//2-Scrool bar'da hata lan yere kırmızı işaretleme yapılır
//-VS kod editörünün alt çubuğunda kırmızı renkli x ve yanındahata sayısı görünür.

//Syntax hatası olan program çalışır mı? Hayır, çünkü program derlenmez.(010101)
//IntelliSense: Kod yazarken Açılan pencere ile karşımıza çıkan öneriler.
//IntelliCode: Yapay zeka destekli kod yazım yardımcısı.Gelen önerileri TAB tuşu ile kabul edebiliriz.

//Solution->Projects(s)
//View->Slutions Projects 
//Hiyerarşiyi düzeltme=CTRL+K+D
//Açıklamaya çevirme=CTRK+K+C 
//Açıklamayı eski haine getirme=CTRL+K+U

//C# -> Derleme -> MS-IL -> .NetRuntime(Derleme) -> 0-1(Binary)
//MS-IL: Microsoft Intermediate Languaege

//namespace ler kütüphanelerdir
//Globalusing: projenin heryerinde kullanmak
//Solutionlar projenin patch ini(dosya konumunu)bilir
//Değişkenler:

//C# dilinde temel olarak veri türleri 2 ye ayrılır
//1- önceden tanımlanmış veri türleri               
//2- kullanıcı tarafından tanımlanan veri türleri  
      
//1"in açıklaması: Değer tipleri ve Referans tipleri

//bellekte veri saklama alanları
//stack bölgesi: değer tipleri burda saklanır
//Heap bölgesi: referans tipleri burda saklanır

//:Değişken tanımlama 
// byte a;
// double d;
// a=30 d=40
//Statik değişkenler: Program çalıştıkça bellekten atılmaz
//const byte a = 30;  DEĞERİ DEĞİŞMEZ DEMEKTİR.
// Değişken tanımlarken byte ya da int gibi değişken İSMİNİN ÖNÜNE SADECE "_" GELEBİLİR. BOŞLUK KULLANILMAZ

//byte= 8 bitlik işaretsiz sayılar için kullanılır 0-255 arasında değişir
//bit ne demek: depolma birimi
//1bayt=8 bit
//1 kilobayt=1024 bayt
//1 megabayt=1024 kilobayt
//1 Gigabayt=1024 megabayt
//int=32 bitlik işaretli sayılar için kullanılır
//sbyte= Signed Byte= 8 bit -128 ile +127 arasında değer alır
//short= 16 bit -32000ve+32000
//ushort= 16 bit 0 65000
//long=64 bit işaretli 
//ulong= 64 bit işaretsiz
//float=32 bitlik reel sayılar için

//var = komutu en uygun metoda koyar

// explicit= veri tipinin açıkça belirtilmesi 
// implicit= veri tipinin kapalı verilmesi

// bool sonuc = false;  "DOĞRU YA DA YANLIŞ

// char= tek bir karakter saklamak için kullanılır

// string= metinsel ifadeler için kullanılır
