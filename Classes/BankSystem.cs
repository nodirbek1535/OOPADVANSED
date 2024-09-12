using System.Dynamic;
using System.Security.Cryptography.X509Certificates;
using Bankxodimlari.Classes;

namespace BankSystem.Classes
{
    public class Bank
    {
        public string Hisobraqam{ get ; private set;}
        public string Mijozismi{ get ; private set ;}
        public double Mijozhisobbalansi{ get ; private set ;}
        public string Mijozparoli{ get ; private set ;}

        public Bank(string hisobraqam, string mijozismi, double mijozhisobbalansi, string mijozparoli)
        {
            Hisobraqam=hisobraqam;
            Mijozismi=mijozismi;
            Mijozhisobbalansi=mijozhisobbalansi;
            Mijozparoli=mijozparoli;
        }


        public Bank(string hisobraqam, string mijozismi, double mijozhisobbalansi)
        {
            Hisobraqam=hisobraqam;
            Mijozismi=mijozismi;
            Mijozhisobbalansi=mijozhisobbalansi;
        }


        





        public static string  hisobraqamyaratish()
        {
            Random random=new Random();
            string hraqam="";
            for(int i=0;i<20;i++)
            {
                hraqam+=random.Next(0,10);
            }
            return hraqam;
        }





        public  void  hisobnitoldirish()
        { 
            bool a=true;
            Console.WriteLine("Hisobingizni qanchaga toldirmoqchisiz?");
            double plusbalance=double.Parse(Console.ReadLine());
            while(a)
            {
                Console.WriteLine("Iiltimos amalni bajarish uchun parolingizni kiriting");
                if(Mijozparoli==Console.ReadLine())
                {
                    Console.WriteLine("balansingiz toldirildi");
                    Mijozhisobbalansi=Mijozhisobbalansi+plusbalance;
                    a=false;
                }
                else
                {
                    Console.WriteLine("parol notogri");
                }
            }
           
           
        }






        public void hisobnikorish()
        { 
            bool a=true;
            while(a)
            {
                Console.WriteLine("iltimos amalni bajarish uchun parolingizni kiriting");
                if(Mijozparoli==Console.ReadLine())
                {
                    Console.WriteLine($"Sizning hisobingiz:{Mijozhisobbalansi}");
                    a=false;
                }
                else
                {
                    Console.WriteLine("parol notogri");
                }
            }
            
        }






        public void  pulyechish()
        {
            Console.WriteLine("Qancha miqdorda pul yechmoqchisiz:");
            int yechilayotganpul=int.Parse(Console.ReadLine());
            if(Mijozhisobbalansi>=yechilayotganpul)
            {   
                bool a=true;
                while(a)
                {
                    Console.WriteLine("iltimos amalni bajarish uchun parolingizni kiriting");
                    if(Mijozparoli==Console.ReadLine())
                    {
                        Console.WriteLine("Amal muvafaqqiyatli bajarildi:");
                        Mijozhisobbalansi=Mijozhisobbalansi-yechilayotganpul;
                        a=false;
                    }
                    else
                    {
                        Console.WriteLine("parol notogri");
                    }
                }
            }
            else
            {
                Console.WriteLine("Sizning hisobingizda bunday miqdorda mablag mavjud emas iltimos qaytadan urinib koring!");
            }
        }





        public string a;
        public void depozidochish()
        {
            Console.WriteLine("Bankimizda yillik 30% bilan depozid ochishingiz mumkin");
            Console.WriteLine("Qancha miqdorda pul qoymoqchisiz:");
            double user1depozid=double.Parse(Console.ReadLine());
            if(Mijozhisobbalansi>=user1depozid)
            {
                Console.WriteLine("Necha yillga qoymoqchisiz:");
                int user1depozidage=int.Parse(Console.ReadLine());
                for(int i=0;i<user1depozidage;i++)
                {
                    user1depozid+=user1depozid*0.3;
                    Console.WriteLine((i+1)+"-yildan keyin sizning pulingiz:"+user1depozid+" USD ga teng boladi");
                }
                Console.WriteLine("Depozit ochasizmi(ha yoki yoq)");
                a=Console.ReadLine();
                if(a=="ha")
                {
                    bool a=true;
                    while(a)
                    {
                        Console.WriteLine("iltimos amalni bajarish uchun parolingizni kiriting");
                        if(Mijozparoli==Console.ReadLine())
                        {
                            Mijozhisobbalansi=Mijozhisobbalansi-user1depozid;
                            Console.WriteLine("Depozit muvafaqqiyatli ochildi.");
                            a=false;
                        }
                        else
                        {
                            Console.WriteLine("parol notogri");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("Sizning hisobingizda bunday mablag mavjud emas!");
            }
        }
        
        public void tizimgakirish()
        {
            bool acses=false;
            while(!acses)
            {
                Console.WriteLine(" Tizimga kirish uchun ism(login)ingizni kiriting:");
                string inputuser1=Console.ReadLine();
                Console.WriteLine("parolingizni kiriting");
                string inputuser1password=Console.ReadLine();
                if(Mijozismi==inputuser1 && Mijozparoli==inputuser1password)
                {
                    acses=true;
                    Console.WriteLine("tabriklayman siz tizimga kirdingiz");
                }
                else
                {   
                    Console.WriteLine("login yoki parol xato iltimos qaytadan urinib koring!");
                }
            }
        }







        public void pulotkazish()
        {
            bool jaska=true;
            while(jaska)
            {
                Console.WriteLine("pul otkazmoqchi bolgaan hisob raqamni kiriting");
                string init=Console.ReadLine();
                bool number=true;
                for(int i=0;i<20;i++)
                {
                    if(char.IsDigit(init[i]))
                    {
                        continue;
                    }
                    else
                    {
                        number=false;
                        break;
                    }
                }
                if(init.Length==20 && number)
                {
                    bool a1=true;
                    while(a1)
                    {
                        Console.WriteLine("otkazma miqdorini kiriting:");
                        double sskd=double.Parse(Console.ReadLine());
                        if(Mijozhisobbalansi>=sskd)
                        {
                            bool a=true;
                            while(a)
                            {
                                Console.WriteLine("iltimos amalni bajarish uchun parolingizni kiriting");
                                if(Mijozparoli==Console.ReadLine())
                                {
                                    Mijozhisobbalansi=Mijozhisobbalansi-sskd;
                                    Console.WriteLine("Otkazma   muvafaqqiyatli amalga oshirildi");
                                    a=false;
                                }
                                else
                                {
                                    Console.WriteLine("parol notogri");
                                }
                            }   
                            a1=false;
                        }
                        else
                        {
                            Console.WriteLine("sizda bunday mablag mavjud emas");
                        }
                    }
                    jaska=false;
                }
            }
        }






        
    }
}