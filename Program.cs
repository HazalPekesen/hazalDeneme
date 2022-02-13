using System;

namespace Kullanici
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("isim giriniz.");
            //string isim = Console.ReadLine();
            //Console.WriteLine("şifre giriniz.");
            //string sifre = Console.ReadLine();

            //Kullanici x = new Kullanici();   //default constructor elimizde old. için oluşturabildik.
            //Login login = new Login();  //default constructor elimizde old. için oluşturabildik.  // bu kod şuna da eşdeğer: var log = new Login();

            //login.isim = isim;
            //login.sifre = sifre;

            //var control = x.isGiris(login);  //bu metodu Kullanıcı class'ından oluşturduğumuz x referansı üzerinden yaratırız.

            //if (control)
            //{
            //    Console.WriteLine("giriş başarılı.." + control);
            //}
            //else
            //{
            //    Console.WriteLine("giriş başarısız.." + control);
            //}

            Kullanici kullanici = new Kullanici();
            kullanici.elemanEkleme1();
        }
    }
}
