using System.Security.Cryptography.X509Certificates;
using BankSystem.Classes;
using OOPADVANSED.Classes;
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
        Bank mijoz1=new Bank(user1,user1password,0);
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
    {
        Bankxodimlari bankxodimlari=new Bankxodimlari();
        bankxodimlari.kirishtizimi();
        Console.WriteLine("mijozlarni korish uchun 1 ni kiriting");
        Console.WriteLine("yangi faydalanuvchii qoshish uchun 2 ni kiritng");
        Console.WriteLine("foydalanuvchilarrni ochirish uchun 3 ni kiriting");
        int sddfcd=int.Parse(Console.ReadLine());
        switch(sddfcd)
        {
            case 1:
            
            break;

            case 2:
            break;

            case 3:
            break;
        }
    }
    else{Console.WriteLine("iltimos togri bolimni tanlang");}
}