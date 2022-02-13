using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kullanici
{
    public class Kullanici
    {
        public string isim { get; set; }
        public string sifre { get; set; }

        public DateTime girisZamanı;

        List<Login> logins = new List<Login>() { //logins listenin referansı.
            new Login("mehmet","12345"),   //burada referansa ihtiyaç duymadık. liste ref. üzerinden erişebiliriz.
            new Login("hazal","234"),
            new Login(){isim="hazal", sifre="123"}
        };
        public Kullanici()  //default constructor
        {
            girisZamanı = DateTime.Now;
        }
        public Kullanici(string isim, string sifre, DateTime zaman)  //constructor
        {
            girisZamanı = zaman;
            this.isim = isim;
            this.sifre = sifre;
        }
        public bool isGiris(Login login)  //metot obj parametresi alıyor. parametre çokluğunu engelledik.
        {
            //var a = new Login();
            //a.isim = "mehmet";
            //a.sifre = "12345";
            //var v = new Login() { isim = "mehmet", sifre = "12345" }; //yukarıdaki kod'a eşdeğer.
            //Login v = new Login("mehmet", "12345"); //yukarıdaki kod'a eşdeğer. //iki parametreli login constructor'ı kullandık.


            //if (login.isim == "mehmet" && login.sifre == "12345")
            //    return true;
            //else
            //    return false;


            foreach (var item in logins)
            {
                if (item.isim == login.isim && item.sifre == login.sifre)
                {
                    Console.WriteLine("Şifre kırıldı.");
                    return true;
                }
                else
                {
                    Console.WriteLine("Şifre deneniyor."); //listede 3 eleman var. her bir elemanı döner.
                }
            }
            return false;
        }

        #region deneme elemanEkleme1
        public void elemanEkleme1()
        {
            for (int i = 0; i < 2; i++)  //iki adet kullanıcı girişi alınıyor.
            {
                Login data = new Login();
                Console.WriteLine(i + "-isim giriniz.");
                data.isim = Console.ReadLine();
                Console.WriteLine(i + "-şifre giriniz.");
                data.sifre = Console.ReadLine();
                for (int k = 0; k < logins.Count; k++)
                {
                    var item = logins[k];  //listedeki her bir elemanı değişkene atadık.
                    if (item.isim == data.isim)   //enes,mehmet,samet  //her defasında enes ile kontrol edilecek.
                    {
                        Console.WriteLine("bu kullanıcı adı mevcut.");
                        if (item.sifre == data.sifre)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("daha önce böyle bir kullanıcı tanımlandı.");
                            Console.BackgroundColor = ConsoleColor.Red;
                            i--;
                            break;
                        }
                        else
                        {
                            logins.Add(data);
                            Console.WriteLine("kullanıcı eklendi.");
                            break;
                        }
                    }
                    else
                    {
                        logins.Add(data);
                        Console.WriteLine("kullanıcı eklendi.");
                        break;
                    }
                }
            }
            Goster1();  //metot çağırıldı.
        }
        public void Goster1() //listedeki her bir elemanı ekrana yazdırmak için.
        {
            int count = 1;
            foreach (var item in logins)
            {
                Console.WriteLine(count + " " + item.isim + " " + item.sifre);
                count++;
            }
        }



        #endregion



        #region sonuc elemanEkleme

        public void elemanEkleme()
        {
            for (int i = 0; i < 2; i++)  //iki adet kullanıcı girişi alınıyor.
            {
                Login data = new Login();
                Console.WriteLine(i + "-isim giriniz.");
                data.isim = Console.ReadLine();
                Console.WriteLine(i + "-şifre giriniz.");
                data.sifre = Console.ReadLine();
                bool y = true;
                for (int k = 0; k < logins.Count; k++)
                {
                    var item = logins[k];  //listedeki her bir elemanı değişkene atadık.
                    if (item.isim == data.isim)   //enes,mehmet,samet  //her defasında enes ile kontrol edilecek.
                    {
                        Console.WriteLine("bu kullanıcı adı mevcut.");
                        if (item.sifre == data.sifre)
                        {
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.WriteLine("daha önce böyle bir kullanıcı tanımlandı.");
                            Console.BackgroundColor = ConsoleColor.Black;
                            y = false;
                            i--;

                            break;
                        }
                    }
                }
                if (y == true)
                {
                    logins.Add(data);
                    Console.WriteLine("kullanıcı eklendi.");
                }
            }
            Goster();  //metot çağırıldı.
        }
        public void Goster() //listedeki her bir elemanı ekrana yazdırmak için.
        {
            int count = 1;
            foreach (var item in logins)
            {
                Console.WriteLine(count + " " + item.isim + " " + item.sifre);
                count++;
            }
        }
        public void Silme()
        {
            logins.RemoveAt(0);
        }

        #endregion

    }

    public class Login  //yukarıdaki metodun parametre değişkenleri bu class altında tanımlandı.
    {
        public string isim { get; set; }
        public string sifre { get; set; }
        public Login(string isim, string sifre)  //constructor
        {
            this.isim = isim;
            this.sifre = sifre;
        }
        public Login()   //default constructor
        {

        }
    }
}
