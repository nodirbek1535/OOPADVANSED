using System.Dynamic;
using Admin.Classes;

namespace Bankxodimlari.Classes
{
    public class Bankxodimi
    {
        private string Xodimlogin="nodirbek";
        private string Xodimparol="n@dirbek1535";
        public void kirishtizimi()
        {
            bool tru=true;
            while(tru)
            {
                Console.WriteLine("tizimga kirish uchun loginni kiriting:");
                string a=Console.ReadLine();
                Console.WriteLine("parolni kiriting");
                string b=Console.ReadLine();
                if(a==Xodimlogin && b==Xodimparol)
                {
                    Console.WriteLine("Tizimga kirdingiz.");
                    tru=false;
                }
                else
                {
                    Console.WriteLine("login yoki parol xato");
                }
            }
        }
    }
}