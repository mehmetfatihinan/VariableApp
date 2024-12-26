using System;
using static System.Math;
namespace VariableApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string national_id_number;
            string name;
            string surname;
            string user_phone_number;       
            byte age;                
            double total_price;  
            double first_product_price;
            double second_product_price;       
            double price_discount;    

            Console.Write("TC Kimlik Numarasi : ");
            national_id_number = Console.ReadLine();
            if (national_id_number.Length != 11)
            {
                Console.Write("TC Kimlik Numarasi 11 Haneli olması gerekiyor. Lütfen TC Kimlik Numaranızı tekrar yazınız");
                Console.Write("TC Kimlik Numarasi : ");
                national_id_number = Console.ReadLine();

                
            }
           
            Console.Write("Adi : ");
            name = Console.ReadLine();

            Console.Write("Soyadi : ");
            surname = Console.ReadLine();

            Console.Write("Telefon Numarasi : ");
            user_phone_number = Console.ReadLine();
            
            Console.Write("Yas: ");
            age = Convert.ToByte(Console.ReadLine());

            Console.Write("Ilk Aldiginiz Urun Fiyati: ");
            first_product_price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ikinci Aldiginiz Urun Fiyati: ");
            second_product_price = Convert.ToDouble(Console.ReadLine());

            total_price = first_product_price + second_product_price;
            price_discount = Math.Round(total_price * 0.10,2);
            Console.WriteLine($"{national_id_number} T.C. Numarali {name} {surname} isimli kisi icin kayit olusturulmustur.");
            Console.WriteLine($"{user_phone_number} telefon numarasina bildirim mesaji gonderilmistir.");
            Console.WriteLine($"{total_price} toplam harcama karsiligi kazanilan %10 patika puan miktari -> {price_discount} TL'dir.");

        }
    }
}