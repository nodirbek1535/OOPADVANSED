using System.Runtime.InteropServices.Marshalling;
using BankSystem.Classes;
using Bankxodimlari.Classes;

namespace Admin.Classes
{
    public class Admin
    {
        private List<Bank> mijozlar = new List<Bank>
        {
            new Bank("12345678901234567890", "Nodir", 5000.00, "password1"),
            new Bank("98765432109876543210", "Bob", 3000.00, "password2"),
            new Bank("11112222333344445555", "Alice", 10000.50, "password3")
        };
        
        public void Barchamijozlarnikorish()
        {
            foreach (var mijoz in mijozlar)
            {
                Console.WriteLine($"mijoz hisob raqami:{mijoz.Hisobraqam}, mijoz ismi:{mijoz.Mijozismi}, mijoz hisob balansi:{mijoz.Mijozhisobbalansi} USD");
            }
        }        


        public void Mijozqoshish()
        {
            string mijozhisobraqam=Bank.hisobraqamyaratish();
            Console.WriteLine("Mijozning ismini kiriting(biz mijoz uchun avtomatik hisob raqam yaratamiz):");
            string mijozismi=Console.ReadLine();
            Console.WriteLine("mijozning hisobidagi balansini kiriting:");
            double mijozbalansi=double.Parse(Console.ReadLine());
            Console.WriteLine("mijozning parolini kiriting");
            string mijozparoli=Console.ReadLine();
            mijozlar.Add(new Bank(mijozhisobraqam,mijozismi,mijozbalansi,mijozparoli));
            Console.WriteLine($"mijoz hisobraqami:{mijozhisobraqam}, ismi;{mijozismi}, balansi:{mijozbalansi}");
            Console.WriteLine("mijoz muvafaqqiyatli qoshildi");
        }


        public void Mijozochirish()
        {
            Console.WriteLine("ochirilayotgan mijozning hisobraqamini kiriting:");
            string mijozhisobraqami=Console.ReadLine();
            var mijozniOchir = mijozlar.Find(m => m.Hisobraqam == mijozhisobraqami);
            if(mijozniOchir!=null)
            {
                 mijozlar.Remove(mijozniOchir);
                Console.WriteLine($"{mijozhisobraqami} raqamli mijoz o'chirildi.");
            }
            else
            {
                Console.WriteLine($"{mijozhisobraqami} li mijoz topilmadi");
            }
        }
    }
}