﻿using System;

namespace ConsoleApp1
{
    internal class Program
  {
     static void Main(string[] args)
  {
            // tür dönüşümleri 
          //  int a = 0;   
            //int b = new int();
            //string c = a.ToString() + b.ToString();
            //string s = "";
            //string e = "merhaba \n";
            //string t = "feyza";
            //string p = e+ t;
            //System.Console.WriteLine(c + "\n" + p);

            //byte veri = 5;
            //byte veri2 = 9;
            //int veri3 = veri+veri2;

            //int veri4 = a;
            //int veri5 = veri4 + 8;
            //int veri6 = a*veri4;
            //bool veri7 = false;
            //s = a.ToString();
             //s = s + "8";

             //Console.ReadLine();
           

    //  object x;
     // x=10;
     // Console.WriteLine(x.GetType());
   //   x="B";
   //   Console.WriteLine(x.GetType());
    //  x=8.78d;
    //  Console.WriteLine(x.GetType());
     // x=false ;
   //   Console.WriteLine(x.GetType());
     // x=5.489M;
    //  Console.WriteLine(x.GetType());
   //   x="a";
     // Console.WriteLine(x.GetType());
      
    // Console.Readline();
            //int i = 256;
            //byte b;
            ////checked
            //{
            //    b = (byte)i;
            //}
            //Console.WriteLine(b);
            //Console.ReadLine();

            //byte i = 254;
            //int j = 500;
            //byte b, c;
            //checked
            //{
            //    b = (byte)i;
            //    Console.WriteLine(b);
            //}
            //unchecked
            //{
            //    c = (byte)j;
            //    Console.WriteLine(c);
            //}
            //Console.ReadLine(); 

            //int a = 500;
            //object b = (object)a;

            //int a = 500;
            //object b = a;

            //int i = 15;
            //object o = i; // boxing
            //int j = (short)o; // unboxing
            //Console.WriteLine(i);
            //Console.WriteLine(j);
            //Console.ReadLine(); 
          //int i = 15;
//object o = i;
//short j = (short)o;
//Console.WriteLine(i);
//Console.WriteLine(j);
//Console.ReadLine();

//int i = 15;
//object o = i;
//int j =(int)o;
//Console.WriteLine(i);
//Console.WriteLine(j);
//Console.ReadLine();


// toplama yapan C#  kodu 


//string s1, s2, s3;
//int i1, i2, i3;

//Console.WriteLine("1.sayıyı girin ");
//s1 = Console.ReadLine();

//Console.WriteLine("2.sayıyı girin");
//s2 = Console.ReadLine();

//Console.WriteLine("3.sayıyı girin");
//s3 = Console.ReadLine();

//i1 = Convert.ToInt32(s1);
//i2 = Convert.ToInt32(s2);
//i3 = Convert.ToInt32(s3);

//i3 = i1 + i2 + i3;

//Console.WriteLine("toplam: " + i3);
//Console.ReadLine();


            //OPERATÖRLER( derste yaptıklarımız)
            //int i = 5 * 4 / 6;
            //Console.WriteLine(i);

            //işlem önceliğine önem verir.

            //örnek:

            //i = 5 * (4 / 6);
            //Console.WriteLine(i);
            //Console.ReadLine();

            //int i = 5 + -4;
            //Console.WriteLine(i);
            //Console.ReadLine();

            // operatör önceliği  

            //int i = 8 / 3;
            //float j = 8 / 3;
            //float k = 8f / 3f;
            //Console.WriteLine("{0} \n {1} \n {2} \n",i,j,k);
            //Console.ReadLine();

            //arttırma azaltma

            //int a = 10;
            //Console.WriteLine(a++);
            ////a = 10;
            //Console.WriteLine(++a);
            //Console.ReadLine();

            //int a = 10;
            //int b = a++;
            //Console.WriteLine("a++ atamasında b:" +b);
            //Console.WriteLine("a++ atamasında:"+ a + "\n");
            //b = ++a;
            //Console.WriteLine("++a atamasında b:" + b);
            //Console.WriteLine("++a atamasında a:" + a);
            //Console.ReadLine();
            
            // karşılaştırma operatörleri

            //bool a = 30 == 45;
            //bool b = 30 > 45;
            //bool c = 30 < 45;
            //bool d = 30 != 45;
            //bool e = 30 <= 45;
            //bool f = 30 >= 45;
            //Console.WriteLine("{0} \n {1} \n {2} \n {3} \n {4} \n {5}\n ",a,b,c,d,e,f);
            //Console.ReadLine();

            //   AS ve İS  operatörü

            //object o = 25;
            //string s = o as string;
            //int i = 17;
            //bool b = i is int;
            //bool c = i is double ;
            //Console.WriteLine("{0} \n {1} \n {2} \n {3} \n {4} \n  ",o,s,i,b,c);
            //Console.ReadLine();
         
            

 //bitsel operatörler
 //byte b =   255;
 //byte c= (byte) ~ b;
 //Console.WriteLine("{0} \n {1} \n", b, c);
 //Console.ReadLine();

 // bitsel ve "&&" operatörü

 //byte a = 145;
 //byte b = 73;
 //int c = (byte) ( a & b );
 //Console.WriteLine("{0} \n {1} \n {2} \n" ,a, b, c );
 //Console.ReadLine();

 // bitsel veya "||" operatörü 
 //byte a = 145;
 //byte b = 73;
 //int c = (byte)(a | b);
 //Console.WriteLine("{0} \n {1} \n {2} \n", a, b, c);
 //Console.ReadLine();

 // bitsel özel veya "^"  (xor) operatörü 

 //byte a = 10;
 //byte b = 99;
 //byte c = (byte)( b ^ a );
 //Console.WriteLine("{0} \n {1} \n {2} \n", a, b, c);
 //Console.WriteLine(c);
 //Console.ReadLine();


 // Atama ve İşlemli Atama Operatörleri 

 // "="  operatörü bir değişkene herhangi bir değeri atamak için kullanılır.
 //int a = 15;
 //int b = 20;
//int c = 30;
 //int d = 50;
//a *= b;
//c = a++;
//d = ++c;
//d -= c;
//Console.WriteLine(d);
//Console.ReadLine();

         
            // bool g isimli bir veri tipi tanımlayınız.İçerisine veri tipini kontrol eden operatörü kullanarak f nin int olma durumunu atayınız .


            // double f ;
            // f = (double)c ;

            //bool g = f is int ;
            // Console.WriteLine(g) ;
            // Console.WriteLine(f) ;
            // Console.ReadLine() ;
     // özel amaçlı operatörler
//string str = "hüdayi emre ";
//int sayi = 1;
//str = str + (sayi == 2 ? "" : "lar  "); /* if else gibi çalışır. */
//Console.WriteLine(str);
//Console.ReadLine();

//string str = "hüdayi emre";
//int sayi = 3;
//str = str + ((sayi == 1 || sayi == 0) ? "" : "ler");
//Console.WriteLine(str);
//sayi = 1;
//str = "hüdayi" + ((sayi == 1 || (sayi == 0) ? "" : "lar"));
//Console.WriteLine(str);
//Console.ReadLine();

//int a = 15;
//int b = 20;
//int c = 30;
//int d = 50;
//a *= b;
//c = a++;
//d = ++c;
//d -= c;
//Console.WriteLine(d);
//Console.ReadLine();

//double f;
//f = (double)c;

//bool g = f is int;
//string s = g ? "f integer" : " f is not integer  ";
//string a = g ? "f integer" : "f   " + f.GetType().Name + " tipindedir ";

//Console.WriteLine(s);
//Console.WriteLine(a);
//Console.ReadLine();

//Console.WriteLine(g);
//Console.WriteLine(f);
//Console.ReadLine();

//karar yapıları (if else elseif switch keys)
//int a = 15, b = 20, c, d;
//a *= b;
//Console.WriteLine(a);
//c = a++;
//Console.WriteLine(c);
//d = ++c;
//Console.WriteLine(d);
//d -= c;
//Console.WriteLine(d);
//double f = (double)c;
//bool g = f is int;
//string s;
////string s = g ? "f integer" : "f verisi  " + f.GetType().Name + " tipindedir ";

//if (g)
//{
//    s = "f verisi integer tipinde";

//}
//else
//    s = "f verisi" + f.GetType().Name + "tipindedir";

//Console.WriteLine(s);
//Console.ReadLine();
// vize ve final notlarını harfe dökme 
//Console.WriteLine("Vize ve final notunu giriniz:");
//int vize = Convert.ToInt32(Console.ReadLine());
//int final = Convert.ToInt32(Console.ReadLine());
//int ortalama = (vize + final) / 2;
//string harf;

//if (ortalama >= 90 && ortalama <= 100)
//{
//    Console.WriteLine(harf = "AA");
//}
//else if (ortalama >= 85 && ortalama <= 89)
//{
//    Console.WriteLine(harf = "BA");
//}
//else if (ortalama >= 80 && ortalama <= 84)
//{
//    Console.WriteLine(harf = "BB");
//}
//else if (ortalama >= 75 && ortalama <= 79)
//{
//    Console.WriteLine(harf = "CB");
//}
//else if (ortalama >= 60 && ortalama <= 74)
//{
//    Console.WriteLine(harf = "CC");
//}
//else if (ortalama >= 55 && ortalama <= 59)
//{
//    Console.WriteLine(harf = "DC");
//}
//else if (ortalama >= 50 && ortalama <= 54)
//{
//    Console.WriteLine(harf = "DD");
//}
//else if (ortalama <= 49)
//{
//    Console.WriteLine(harf = "FF");
//}
//Console.ReadLine();


            ////switch- case ifadesi
            //int a = 1;
            //switch (a)
            //{
            //   case 1:
            //        Console.WriteLine("case 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("case 2");
            //        break;
            //    case 3:
            //        Console.WriteLine("case3");
            //        break;
            //    default:
            //        Console.WriteLine("bu sayı burada yok");
            //        break;
            //}
            //Console.ReadLine();
                        /* ÖRNEKLER */

            //girilen 3 basamaklı sayıyı basamaklarına ayıran kodu yazınız
            //Console.WriteLine("3 basamaklı sayıyı giriniz: ");
            //int sayi = Convert.ToInt32(Console.ReadLine());

            //int yuzler = sayi / 100;
            //sayi = sayi - (yuzler * 100);
            //int onlar = sayi / 10;
            //sayi = sayi - (onlar * 10);
            //int birler = sayi;

            //Console.WriteLine($"Yüzler: {yuzler}");
            //Console.WriteLine($"Onlar: {onlar}");
            //Console.WriteLine($"birler : {birler}");
            //Console.ReadLine();

            //  kullanıcıdan aldığı tam sayı çift ise  sayının yarısını, tek ise sayının  3 katını ekrana yazdır.

            //Console.WriteLine("sayı girin:     ");
            //int sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi % 2 == 0)
            //{
            //    Console.WriteLine($"sayının yarısı:  {sayi / 2} ");
            //}
            //else
            //{
            //    Console.WriteLine($"sayının üç katı :  {sayi * 3} ");
            //}
            //Console.ReadLine();

            // iki iç açısı girilen üçgenin diğer açısını bulan kod 

            //Console.WriteLine("üçgenin iki açısını siz girin diğerini biz bulalım :   ");
            //int aci = Convert.ToInt32(Console.ReadLine());
            //int aci2 = Convert.ToInt32(Console.ReadLine());
            //aci = 180 - (aci + aci2);
            //Console.WriteLine();
            //Console.ReadLine();

            // kullanıcıdan ürün fiyatı alınsın 100 TL üzerinde ise 20 TL,100 TL altında ise 30 tl , 300 Tl ise 0 tl kargo ücreti ekleyen kodu yazınız.

            //Console.WriteLine("ürünün fiyatını giriniz:  ");
            //int ürün = Convert.ToInt32(Console.ReadLine());
            //{
            //    Console.WriteLine($"ürünün fiyatı : {ürün + 10 }");
            //}
            //else if (ürün < 100)  
            //{
            //    Console.WriteLine($"ürünün fiyatı :  {ürün + 30}");
            //}
            //else if (ürün >= 300)
            //{
            //    Console.WriteLine(" bu kargoyu satıcı karşılıyor o yüzden sizden para almadık  :)  ");
            //}
            //else 
            //{
            //    Console.WriteLine("geçersiz işlem,lütfen tekrar deneyiniz ");
            //}
            //Console.ReadLine();


            // ürün fiyatını aldır . 100 - 200 arası % 5  200 - 400 arası % 10 400  ve üzeri % 15 indirim yap.

            //Console.WriteLine("ürünün fiyatını giriniz:  ");
            //int urun = Convert.ToInt32(Console.ReadLine());
            //if (urun >= 100 && urun < 200)
            //{
            //    Console.WriteLine("ürünün indirimli fiyatı: " + (urun  - (urun * 0.25)));
            //}
            //else if (urun >= 200 && urun <= 400)
            //{
            //    Console.WriteLine("ürünün indirimli fiyatı: " + (urun - (urun * 0.1)));
            //}
            //else if (urun > 400)
            //{
            //    Console.WriteLine("ürünün indirimli fiyatı: " + (urun - (urun * 0.15)));
            //}
            //else
            //{
            //    Console.WriteLine("diğer ürünlerimizde  indirim bulunmamaktadır. ");
            //}
            //Console.ReadLine();

            //  girilen mevsimin aylarını ekrana yazdıran switch case kodu  .

            //Console.WriteLine("mevsimin adını yazınız:  ");
            //string mevsim = Console.ReadLine();
            //switch (mevsim)
            //{
            //    case "yaz":
            //        Console.WriteLine("TEMMUZ, AĞUSTOS, EYLÜL");
            //        break;

            //    case "sonbahar":
            //        Console.WriteLine("EKİM , KASIM, ARALIK");
            //        break;
            //    case "kış":
            //        Console.WriteLine("OCAK, ŞUBAT, MART");
            //        break ;
            //    case "ilkbahar":
            //        Console.WriteLine("NİSAN, MAYIS, HAZİRAN");
            //        break;
            //    default:
            //        Console.WriteLine("tüm mevsimler yazıldı ");
            //        break;
            //}
            //Console.ReadLine();

            /* for döngüsü */

            //int i ;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadLine();

            // 1'den 100'e kadar olan,5 e tam bölünüp 7 ye tam bölünemeyen sayıları ekrana yazdıran kod.

            //for (int i = 0; i < 100; i++)
            //{
            //    if (i % 5 == 0 && i % 7 != 0)
            //        Console.WriteLine(i);
            //}
            //Console.ReadLine();

            /* 7 satır 4 sutün (*) olan kodu for döngüsü ile yazınız.*/
            // for(int  i = 0;i < 7;i++)
            //{
            //    for ( int j = 0; j <4;  j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Read();

            /* yıldız karakteri ile  dik üçgen oluştur.*/

            //for(int i  = 0; i < 7; i++)
            //{
            //    for(int  j = 0; j < i; j++) {

            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            //Console.Read();

            /*Döngüler ve atlama deyimleri(for-while-do while- foreach)  */

            /* bu kod kullanıcıdan değer istemekte ve girilen değer "q" değilse ekrana yazdırmaktadır.Girilen değer "q" ise programı sonlandırmaktadır.*/

            //char ch;
            //for (ch = Convert.ToChar(Console.ReadLine()); ch != 'q'; ch = Convert.ToChar(Console.ReadLine())) ;
            //Console.WriteLine(ch);

            /*for ile döngüleri*/
            //int k = 0;
            // for (; k < 10; ++k)
            // {
            //     Console.WriteLine(k);
            // }
            // Console.Read();

            // int k = 0;
            // for(; k < 10;)
            // {
            //     Console.WriteLine(k);
            //     ++k;
            // }
            // Console.Read();

            /* sonsuz dongu */
            //int k = 0;
            //for (; ; )
            //{
            //    Console.WriteLine(k);
            //    ++k ;
            //}
            //Console.Read();

            /* While döngüsü */
            //int n = 0;
            //int toplam = 0;
            //while (n <= 100)
            //{
            //    toplam += n;
            //    n+= 2;
            //}
            //Console.WriteLine(toplam);
            //Console.ReadLine();
            /* iki tam sayı girilmesi isteyiniz.Bu iki tam sayı arasındaki sayıların ortalamasını ekrana yazdıran kodu yazdırınız. */

            //Console.Write("Birinci sayıyı giriniz: ");
            //int sayi1 = Convert.ToInt32(Console.ReadLine());

            //Console.Write("İkinci sayıyı giriniz: ");
            //int sayi2 = Convert.ToInt32(Console.ReadLine());

            //int toplam = 0;
            //int sayac = 0;

            //for (int i = sayi1; i <= sayi2; i++)
            //{
            //    toplam += i;
            //    sayac++;
            //}

            //double ortalama = (double)toplam / sayac;

            //Console.WriteLine("Girilen sayılar arasındaki sayıların ortalaması: " + ortalama);
            //Console.Read();

            /* kullanıcıdan 20 tam sayı alınacaktır. Girilen sayılardan kaç tanesi 100'den buyuk ekrana yazdırın*/
            //int sayac = 0;
            //for (int i = 0; i < 20; i++)
            //{
            //    Console.WriteLine("sayi girin");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    if (sayi > 100)
            //    {
            //        sayac++;
            //    }
            //}
            //Console.WriteLine("girilen sayılardan " + sayac + " tanesi 100'den büyüktür");
            //Console.ReadLine();
             
        }
    }
}
    
     
