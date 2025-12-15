


#region Ref and Out
/*
// M: 1
int a = 5;
Ref1(ref a);
Console.WriteLine( a );
static int Ref1(ref int s)
{
    return s * 2;
}


// M: 2
int a2;
Out1(out a2);
Console.WriteLine(a2);
static int Out1(out int a)
{
    a = int.Parse(Console.ReadLine());
    return a;
}

// M: 3
int a3 = 3;
int b3 = 7;
static int Ref2(ref int a,ref int b )
{
   (a, b) = (b, a);
    return 0;
    
}
Ref2(ref a3,ref b3);
Console.WriteLine(a3);
Console.WriteLine(b3);

// M: 4
int a4;
static int Out4(out int a)
{
    a= int.Parse(Console.ReadLine());   
    return a * a;
}
Out4(out a4);
Console.WriteLine(a4);

// M: 5
int a5=10;
static int Ref5(ref int a)
{
    if(a%2==0)
    {
        a = 0;
        return a;
    }
    return a;
}
Ref5(ref a5);
Console.WriteLine(a5);

// M: 6
int a6=-10;
static void Ref6(ref int a)
{
    if(a<0)
    {
        a *= -1;
    }

}
Ref6(ref a6);
Console.WriteLine(a6);

// M: 7 
int a7=10;
int b7 = 5;
int yig; int kop ;

static void Out7(int a,int b, out int yig,out int kop)
{
    yig = a + b;
    kop = a * b;
}
Out7(a7, b7, out yig, out kop);
Console.WriteLine(yig);
Console.WriteLine(kop);

// M: 8
int a8 = 1000;
static void Ref8(ref int a)
{
    int b = int.Parse(Console.ReadLine());
    if(a>b)
    {
        a -= b;
    }
}
Ref8(ref a8);
Console.WriteLine(a8 );

// M: 9
int a9;
static bool Out9(out int a)
{
    a = int.Parse(Console.ReadLine());
    if(a%2==0)
    {
        return true;
    }
    return false;
}
Out9(out a9);
Console.WriteLine(a9);

// M: 10 
int a10=1;
static void Ref10(ref int a)
{
    a++;
}
for(var i=1;i<=10;i++)
{
Ref10(ref a10);
    Console.WriteLine(a10);
}
*/
/*List<int> n = new List<int>(999999999);
for(var i=0;i<1000000000;i++)
{
    n.Add(i);
    Console.WriteLine($"{i} => {n[i]}");
}
*/
#endregion

//---------------------------------------------------------------------------------------

#region  AD bo'lim

internal class Program
{
    static List<string> AD = new List<string>();
    private static void Main(string[] args)
    {
        while (true)
        {
            var ad = string.Empty;
            var adU = string.Empty;

            #region  Boshlanish
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" 1. Create");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(" 2. Delete");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(" 3. Update");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(" 4. Read");
            Console.ResetColor();

            Console.WriteLine();
            #endregion


            Console.Write(" Ammalni tanlang: ");
            int.TryParse(Console.ReadLine(), out int amal);


            switch (amal)
            {
                // 1. Create
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(" AD");
                    Console.ResetColor();
                    Console.Write(" kiriting: ");

                    ad = Consol();

                    if (Standartlika(ad))
                    {
                        if (!SearchAD(ad))
                        {
                            Console.WriteLine();
                            CreateAD(ad);
                            Console.Write($" {ad} muvafaqiyatli saqlandi ");

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("☻");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.Write($" {ad} mavjud saqlanmadi ");

                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("x");
                            Console.ResetColor();
                        }
                    }
                    else
                    {

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write($" AD");
                        Console.ResetColor();
                        Console.Write(" to'gri farmatda emas");

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"! {ad}");
                        Console.ResetColor();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($" AD");
                        Console.ResetColor();
                        Console.Write(" to'gri farmat: ");

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("AD1234567");
                        Console.ResetColor();

                    }
                    break;


                // 2. Delete
                case 2:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(" AD");
                    Console.ResetColor();
                    Console.Write(" kiriting: ");

                    ad = Consol();

                    if (Standartlika(ad))
                    {
                        if (SearchAD(ad))
                        {
                            Console.WriteLine();
                            Console.WriteLine($" Rostan ham shu {ad} o'chirmoqchimisiz!");

                            Console.Write(" 1.");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine(" Ha ");
                            Console.ResetColor();

                            Console.Write(" 2.");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(" Yo'q ");

                            Console.ResetColor();

                            Console.Write(" Tanlang: ");
                            int.TryParse(Console.ReadLine(), out int ha);

                            switch(ha)
                            {
                                case 1:
                                DeleteAD(ad);
                                Console.Write($" {ad} muvafaqiyatli o'chirildi ");

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("☻");
                                Console.ResetColor();
                                    break;

                                case 2: Console.WriteLine(" Yaxshi. "); break;
                                default: Console.WriteLine(" Bunday amal mavjud emas! "); break;
                            }
                            
                        }
                        else
                        {
                            Console.Write($" {ad} topilmadi ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("!");
                            Console.ResetColor();
                        }
                    }
                    else if (ad != string.Empty)
                    {
                        Console.Write($" {ad} to'gri farmatda emas");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"! {ad}");
                        Console.ResetColor();

                        Console.Write(" AD to'gri farmat: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("AD1234567");
                        Console.ResetColor();

                    }
                    break;


                // 3. Update
                case 3:
                    
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(" AD");
                    Console.ResetColor();
                    Console.Write(" kiriting: ");
                    ad = Consol();

                    if (Standartlika(ad))
                    {
                        if (SearchAD(ad))
                        {
                            Console.WriteLine();
                            Console.Write($" {ad} ni qaysi");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(" AD");
                            Console.ResetColor();
                            Console.WriteLine(" ga o'zgartirmoqchisiz? ");

                            Console.Write(" Yangi");
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(" AD");
                            Console.ResetColor();
                            Console.Write(" kiriting: ");

                            adU = Consol();
                            if (Standartlika(adU))
                            {
                                if (!SearchAD(adU))
                                {
                                    //AD[AD.IndexOf(ad)] = adU;
                                    UpdateAD(ad,adU);
                                    Console.ForegroundColor = ConsoleColor.Blue;
                                    Console.Write(" AD");
                                    Console.ResetColor();
                                    Console.Write(" muvafaqiyatli almashtirildi ");

                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine("☻");
                                    Console.ResetColor();

                                }
                                else
                                {
                                    Console.Write($" {ad} mavjud emas ");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("x");
                                    Console.ResetColor();
                                }
                            }
                            else if (ad != string.Empty)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Write(" AD");
                                Console.ResetColor();
                                Console.Write($" to'gri farmatda emas");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine($"! {adU}");
                                Console.ResetColor();

                                Console.Write(" AD to'gri farmat: ");
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("AD1234567");
                                Console.ResetColor();

                            }


                        }
                        else 
                        {
                            Console.Write($" {ad} topilmadi ");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("!");
                            Console.ResetColor();

                        }

                    }
                    else if(ad != string.Empty)
                    {
                        Console.Write($" AD to'gri farmatda emas");
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"! {ad}");
                        Console.ResetColor();

                        Console.Write(" AD to'gri farmat: ");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("AD1234567");
                        Console.ResetColor();

                    }
                    break;


                // 4. Read
                case 4: ReadAD(); break;

                // Default
                default: Console.WriteLine(" Bunday amal mavjud emas! "); break;

            }

            Console.ReadKey();
            Console.Clear();
        }

    }

    static void CreateAD(string ad)
    {
        AD.Add(ad.ToUpper());
    }

    static void DeleteAD(string ad)
    {
        AD.Remove(ad);
    }

    static void UpdateAD(string ad,string adU)
    {
        AD[AD.IndexOf(ad)] = adU;
    }

    static void ReadAD()
    {
        var caunt = 0;
        foreach (var adch in AD)
        {
            caunt++;
            Console.WriteLine(caunt + ". " + adch);
        }
        Console.WriteLine();
    }




    //
    //Lisda borligini qidiradi
    static bool SearchAD(string ad)
    {
        if (AD.IndexOf(ad) != -1)
        {
            return true;
        }
        return false;

    }

    //
    //Standart qoydada qilish
    static bool Standartlika(string ad)
    {

        int ADletter = 0;
        int ADdigit = 0;
        for (var adch = 0; adch < ad.Length; adch++)
        {
            if (char.IsLetter(ad[adch]) && adch < 2)
            {
                ADletter++;
            }
            if (char.IsDigit(ad[adch]) && adch > 1)
            {
                ADdigit++;
            }
        }

        if (ADletter == 2 && ADdigit == 7)
        {
            return true;
        }
        return false;
    }

    //
    // Qiymat olish
    static string Consol()
    {
        var ad = Console.ReadLine().ToUpper();
        return ad;
    }
}



#endregion





