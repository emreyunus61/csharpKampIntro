using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {

        public void Ekle(Urun urun) // Parametre olarak sınıfı gönderdik
        {
            Console.WriteLine("Sepete Eklendi. : "+ urun.Adi);
        }

    }
}
