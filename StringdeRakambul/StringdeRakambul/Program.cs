using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringdeRakambul
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ad_arama, soyad_arama;
            Console.WriteLine("adınızı giriniz");
            string ad = Console.ReadLine();
            Console.WriteLine("soyadınızı giriniz");
            string soyad = Console.ReadLine();
            ad_arama = rakambul(ad); //ad arama true yada false olacak cunku bool
            soyad_arama = rakambul(soyad); //soyad arama true yada false olacak cunku bool
            if (ad_arama == true)
                Console.WriteLine("ad içinde rakam bulunmamalıdır");
            if (soyad_arama == true)
                Console.WriteLine("soyad içinde rakam bulunmamalıdır");
            if (ad_arama == false && soyad_arama == false)
                Console.WriteLine("Kayıt başarıyla yapılmıştır");
            Console.ReadKey();
        }
        public static bool rakambul(string aranacakmetin) //aşağıdaki her koşul içerip içermemesine göre true ya da false döndürecek
        { //yukarda rakam bul metodu kullanılınca aşağıdakilerle rakam bulursa true döner ve kullanılan yere gönderir.
            if (aranacakmetin.Contains('0'))
                return true;
            else if (aranacakmetin.Contains('1'))
                return true;
            else if (aranacakmetin.Contains('2'))
                return true;
            else if (aranacakmetin.Contains('3'))
                return true;
            else if (aranacakmetin.Contains('4'))
                return true;
            else if (aranacakmetin.Contains('5'))
                return true;
            else if (aranacakmetin.Contains('6'))
                return true;
            else if (aranacakmetin.Contains('7'))
                return true;
            else if (aranacakmetin.Contains('8'))
                return true;
            else if (aranacakmetin.Contains('9'))
                return true;
            else
                return false;

      


        }

    }
}
