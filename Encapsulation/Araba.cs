using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Araba
    {
        // Özellikler (Properties)
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }

        private int kapıSayısı;

        // Kapı Sayısı Özelliği
        public int KapıSayısı
        {
            get { return kapıSayısı; }
            set
            {
                // Kapı sayısının geçerli bir değer olup olmadığını kontrol et
                if (value == 2 || value == 4)
                {
                    kapıSayısı = value;
                }
                else
                {
                    Console.WriteLine("Uyarı: Kapı sayısı yalnızca 2 veya 4 olabilir. Kapı sayısı -1 olarak ayarlandı.");
                    kapıSayısı = -1; // Geçersiz değer durumunda -1 olarak ayarla
                }
            }
        }

        // Constructor (Yapıcı Metot)
        public Araba(string marka, string model, string renk, int kapıSayısı)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            KapıSayısı = kapıSayısı; // Kapsülleme işlemi burada geçerlidir
        }
    }
}
