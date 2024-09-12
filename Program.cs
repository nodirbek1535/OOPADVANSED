using System.Security.Cryptography.X509Certificates;
using BankSystem.Classes;
using Bankxodimlari.Classes;
using Admin.Classes;
while (true)
{
    Console.WriteLine("Assalomu alekum NNN bankning dasturiga xush kelibsiz aytingchi siz mijozmisiz yoki xodim");
    string login1=Console.ReadLine();
    if(login1=="mijoz")
    {
        Console.WriteLine("Afsus bank xizmatlaridan foydalanish uchun hisob yaratishimiz kerak iltimos ismingizni kiriting:");
        string user1=Console.ReadLine();
        string hisobraqam=Bank.hisobraqamyaratish();
        Console.WriteLine($"Tabriklaymiz siz bank mijoziga aylandingiz sizning ismingiz loginingiz:{user1} , hisob raqamingiz: {hisobraqam}");
        Console.WriteLine("Yuqoridagi malumotlarni yodingizdan chiqarmang sizni hisobingizni himoyalash uchun parol yarating:");
        string user1password=Console.ReadLine();
        Bank mijoz1=new Bank(hisobraqam,user1,0,user1password);
        Console.WriteLine("Iltimos parolingizni va hisob raqamingizni yodingizda saqlang(ismingiz login vazifasini bajaradi)");
        mijoz1.tizimgakirish();
        Console.WriteLine("Sizning hisobingiz 0 USD ga teng iltimos hisobingizni malum miqdorga toldiring");
        mijoz1.hisobnitoldirish();
        bool qaytar=true;
        while(qaytar)
        {
            Console.WriteLine("Qanday amaliyot bajarmoqchisiz:");
            Console.WriteLine("Hisobni korish uchun 1 raqamini kiriting:");
            Console.WriteLine("Naqd pul yechish uchun 2 raqamini kiriting:");
            Console.WriteLine("Otkazmalar uchun 3 raqamini kiriting:");
            Console.WriteLine("Depzid ochish uchun 4 raqamini kiriting:");
            Console.WriteLine("hisobni toldirish uchun 5 raqamini kiriting");
            Console.WriteLine("chiqish uchun 6 raqamini kiriting:");
            int input=int.Parse(Console.ReadLine());
            switch(input)
            {
                case 1:
                    mijoz1.hisobnikorish();
                break;
                
                case 2:
                mijoz1.pulyechish();
                break;
                
                case 3:
                        mijoz1.pulotkazish();
                break;  
                
                case 4:
                    mijoz1.depozidochish();
                    if(mijoz1.a=="yoq")
                    {
                        break;
                    }
                break;

                case 5:
                    mijoz1.hisobnitoldirish();
                break;
                
                case 6:
                    qaytar=false;
                break;
            }
        }
    }
    else if(login1=="xodim")
    {   bool boling=true;
            Admin.Classes.Admin admin=new Admin.Classes.Admin();
            Bankxodimi bankxodimlari=new Bankxodimi();
            bankxodimlari.kirishtizimi();
        while(boling)
        {
            
            Console.WriteLine("mijozlarni korish uchun 1 ni kiriting");
            Console.WriteLine("yangi faydalanuvchii qoshish uchun 2 ni kiritng");
            Console.WriteLine("foydalanuvchilarrni ochirish uchun 3 ni kiriting");
            Console.WriteLine("asosiy menuga qaytish uchun 4 ni kiriting");
            int s=int.Parse(Console.ReadLine());
            switch(s)
            {
                case 1:
                    admin.Barchamijozlarnikorish();
                break;

                case 2:
                    admin.Mijozqoshish();
                break;

                case 3:
                    admin.Mijozochirish();
                break;
                case 4:
                boling=false;
                break;
            }
        }
    }
    else{Console.WriteLine("iltimos togri bolimni tanlang");}
}