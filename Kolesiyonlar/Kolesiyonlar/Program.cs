using System;
using System.Collections.Generic;

namespace Kolesiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //string[] isimler = new string[] { "Engin", "Yunus", "eMRE", "Halil" };

            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5]; //Burada new demek bellekte yeni yer açıyoruz yani üsteki diziye 5 elamanı ekledik anlamına gelmiyor
            //isimler[4] = "mansur";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);// yani şurda gelip engini yazdırmaz new dediğimiz anda yeni adres oluşur ddiğerlerini boş atama yapar

       

            List<string> isimler2 = new List<string> { "Engin", "Yunus", "eMRE", "Halil" }; //Arraylistler =koleksiyonlar

            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Ahmet");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);


        }
    }
}
