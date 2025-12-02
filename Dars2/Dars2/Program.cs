#region  qo'shimcha
int intTwoRooms = 25;
int intThreeRooms = 495;
int intFourRooms = 8356;
int intFiveRooms = 15407;
int intEmpty = 0;
int emptyValue = 0;
int Bit = 8,
    Byt = Bit * 128,
    KB = Byt,
    MB = KB,
    GB = MB,
    TB = GB;
#endregion

#region easy ( osson ) VAQT O'LCHOV BIRLIKLARI (medium ( o'rta ) AXBOROT O'LCHOV BIRLIKLARI) M: 38
/*

//1 minute = 60 second
Console.WriteLine("\nHour (soat) : 2");
int hour = 2;
Console.WriteLine("Minute : "+ 60 * hour);

//2 hour = 3600 second
int oneWeekHour = 168;
Console.WriteLine("\nWeek (hafta) : 5");
int week = 5;
Console.WriteLine("Hour (soat) : "+oneWeekHour * week);

//3 day = 1440 minute
Console.WriteLine("\nMinute : 4");
int minuteToSecond = 4;
Console.WriteLine("Second (soniya) : "+ 60 * minuteToSecond);

//4 hour = 3600 second
Console.WriteLine("\nHour (soat) : 25");
int hourToSecond = 25;
Console.WriteLine("Second (soniya) : "+ 3600 * hourToSecond);

//5 week = 168 hour
Console.WriteLine("\nWeek (hafta) : 150");
int week2 = 150;
Console.WriteLine("Hour (soat) : " + oneWeekHour * week);

//6 day = 1440 minute
Console.WriteLine("\nDay : 4");
int dauyToMinute = 4;
Console.WriteLine("Minute (minut) : "+ 1440 * dauyToMinute);

//7 hour = 3600 second
Console.WriteLine("\nHour (soat) : 8");
int hourToSecond2 = 8;
Console.WriteLine("Second (soniya) : " + 3600 * hourToSecond2);

//8 hour = 1/24 day
Console.WriteLine("\nHour : 24");
int hourToDay = 24;
Console.WriteLine("Day : " + hourToDay / 24);

//9 day = 1/7 week
Console.WriteLine("\nDay : 24");
int dayToWeek = 24;
Console.WriteLine("Week (hafta) : " + dayToWeek / 7);

//10 second = hour/3600
Console.WriteLine("\nSecond (soniya) : 3600");
int secondToHour = 7200;
Console.WriteLine("Hour (soat) : " + secondToHour / 3600);

//11 second = minute/60
Console.WriteLine("\nSecond (soniya) : 2400");
int secondToMinute = 2400;
Console.WriteLine("Minute (minut) : " + secondToMinute / 60);

//12 second = week/604800
Console.WriteLine("\nSecond (soniya) : 2419200 ");
int secondToWeek = 2419200;
Console.WriteLine("Week (hafta) : " + secondToWeek / 604800);

// ----------------------------------------------------------------------------------------------------------------------------------

int Bit = 8, 
    Byt = Bit * 128,
    KB  = Byt, 
    MB  = KB, 
    GB  = MB,
    TB  = GB;

//1 GB = 1024 MB
Console.WriteLine("5  GB  = " + 5 * MB);

//2 MB = 1024 KB
Console.WriteLine("3  MB  = " + 3 * KB);

//3 TB = 1024 MB
Console.WriteLine("8  TB  = " + 8 * MB);

//4 = 1

//5 KB = 1024 byte
Console.WriteLine("8  KB  = " + 8 * Byt);

//6
Console.WriteLine("4  MB  = " + 4 * KB * Byt * Bit);

//7 Byte = 8 Bit
Console.WriteLine("3  Byt = " + 3 * Bit);

//8 MB = 1024 KB
Console.WriteLine("1  MB  = " + 1 * KB);

//9 TB = KB ga
Console.WriteLine("2  TB  = " + 2 * GB * MB * KB);

//10 MB = Byte ga
Console.WriteLine("12 MB  = " + 12 * KB * Byt);

Console.WriteLine();

//11 GB = TB ga 
Console.WriteLine("5000 GB = " + 5000 / TB);

//12 MB = GB ga
Console.WriteLine("3000 MB = " + 3000 / GB);

//13 Bit = KB ga
Console.WriteLine("12000 Bit = " + 12000 / (float)Bit / (float)KB );

//14 KB = MB ga
Console.WriteLine("2048 KB = " + 2048 / (float)MB);

//15
Console.WriteLine("16000 Bit = " + 16000 / (float)Bit / (float)KB);

//16 Byt = KB ga
Console.WriteLine("4096 Byt = " + 4096 / KB);

//17 Bit = Byte ga
Console.WriteLine("3200 Bit = " + 3200 / Byt);

//18 KB = MB ga
Console.WriteLine("1200 KB = " + 1200 / MB);

//19 Byt = MB ga
Console.WriteLine("48000 Byt = " + 48000 / (float)KB / (float)MB);

//20 MB = TB ga
Console.WriteLine("120000 MB = " + 120000 / (float)GB / (float)TB);

Console.WriteLine();

//21 
Console.WriteLine("3 MB + 8 KB = KB = " + 3 * KB + 8);

//22 
Console.WriteLine("7 GB + 11 MB = KB = " + ( 7 * MB * KB + 11 * KB ));

//23
Console.WriteLine("3 MB + 82 KB = Byt = " + ( 3 * KB * Byt + 82 * Byt) );

//24
Console.WriteLine("12 Byt + 8 KB = Bit = " + ( 12 * Bit + 8 * Byt * Bit ));

//25
Console.WriteLine("4 MB + 10 KB = Bit = " + ( 4 * KB * Byt * Bit + 10 * Byt * Bit ));

Console.WriteLine();

//
Console.WriteLine
   ("1.\n" +
    "   12345\n" +
    "   1234\n" +
    "   123\n" +
    "   12\n" +
    "   1\n\n" +

    "2.\n" +
    "   1\n" +
    "   12\n" +
    "   123\n" +
    "   1234\n" +
    "   12345\n\n" +

    "3.\n" +
    "   12345\n" +
    "    234\n" +
    "     3\n\n" +

    "4.\n" +
    "       1\n" +
    "      212\n" +
    "     32123\n" +
    "    4321234\n" +
    "   543212345\n\n" +

    "5.\n"+
    "       3\n" +
    "      232\n" +
    "     12321\n" +
    "      232\n" +
    "       3\n\n" +

    "6.\n" +
    "   1234321\n" +
    "    23432\n" +
    "     343\n" +
    "      4\n" +
    "      5\n" +
    "     656\n" +
    "    76567\n" +
    "   8765678\n\n" +

    "7.\n " +
    "   1111111\n" +
    "   1     1\n" +
    "   1     1\n" +
    "   1     1\n" +
    "   1111111\n\n" +
    "8.\n" +
    "   000000000\n" +
    "   00      0\n" +
    "   0 0     0\n" +
    "   0  0    0\n" +
    "   0   0   0\n" +
    "   0    0  0\n" +
    "   0     0 0\n" +
    "   0      00\n" +
    "   000000000\n\n");
*/
#endregion

#region  OSSON  Quyidagi vazifalarni cin>>variable yordamida ishlang.  M: 23
/*
//1
int intValus = 5;
intValus += 10;
Console.WriteLine(intValus);

//2
int intValus2 = 23;
intValus2 -= 10;
Console.WriteLine(intValus2);

//3
int intValus3 = 5;
intValus3 *= 10;
Console.WriteLine(intValus3);

//4
int intValus4 = 5;
intValus4 *= intValus4;
Console.WriteLine(intValus4);

//5
int intValus5 = 5;
intValus5 *= intValus5;
intValus5 *= intValus5;
Console.WriteLine(intValus5);

//6
int intValus6 = 10;
for(int i = 0; i < 5; i++)
{ intValus6 *= 10; }
Console.WriteLine(intValus6);

//7
int intValus7 = 1000;
int intValus72 = 25;
intValus7 += intValus72;
Console.WriteLine(intValus7);

//8
int intValus8 = 25;
int intValus82 = 25;
intValus8 += intValus82;
Console.WriteLine(intValus8);

//9
int intValus9 = 50;
int intValus92 = 25;
int intValus93 = 2;
int intValus94 = 5;
intValus9 += (intValus92+intValus93+intValus94);
Console.WriteLine(intValus9);

//10
float floatValus = 10.9f;
float floatValus12 = 3.5556f;
float floatValus13 = 1.444f;
floatValus += (floatValus12 + floatValus13);
floatValus /= 3;
Console.WriteLine(floatValus);

//11
float floatValus2 = 10.95f;
float floatValus22 = 3.556f;
float floatValus23 = 4.454f;
float floatValus24 = 5.454f;
float floatValus25 = 8.454f;
floatValus2 += (floatValus22 + floatValus23 + floatValus24 + floatValus25);
floatValus2 /= 5;
Console.WriteLine(floatValus2);

//12
float floatValus3 = 100.99f;
float floatValus32 = 200.88f;
float floatValus33 = 300.77f;
float floatValus34 = 900.66f;
float floatValus35 = 500.55f;
float floatValus36 = 50.55f;
float floatValus37 = 300.55f;
float floatValus38 = 20.55f;
floatValus3 += (floatValus32 + floatValus33 + floatValus34 + floatValus35 + floatValus36 + floatValus37 + floatValus38);
floatValus3 /= 8;
Console.WriteLine(floatValus3);

//13
int intValus10 = 5;
int intValus101 = 10;
(intValus10,intValus101)=(intValus101,intValus10);
Console.WriteLine(intValus10 + " " + intValus101);

//14
int intValus11 = 3;
intValus11 *= 60;
Console.WriteLine(intValus11);

//15
int intValus12 = 2;
intValus12 *= 3600;
Console.WriteLine(intValus12);

//16
int intValus13 = 2;
intValus13 *= 24 * 60;
Console.WriteLine(intValus13);

//17
int intValus14 = 180;
intValus14 /= 60;
Console.WriteLine(intValus14);

//18
int intValus15 = 7200;
intValus15 /= 1440;
Console.WriteLine(intValus15);

//19
int intValus16 = 14;
intValus16 = 2025 - intValus16;
Console.WriteLine(intValus16);

//20
int intValus17 = 50;
Console.WriteLine(intValus17 - 1 + " " + intValus17 + 1);

//21
int intValus18 = 13;
if (intValus18 >= 10 && intValus18 <= 15)
    Console.WriteLine(intValus18);

//22
int intValus19 = 8;
int intValus192 = 2;
Console.WriteLine((intValus19+intValus192)+"\n"+ (intValus19-intValus192)+ "\n" + (intValus19 * intValus192) + "\n"+(intValus19 / intValus192) );

//23
int intValus20 = 20;
Console.WriteLine(intValus20 * 3);
Console.WriteLine(intValus20 * 4);
Console.WriteLine(intValus20 * 5);
*/
#endregion

#region
/*


//1
Console.WriteLine(intTwoRooms%10);

//2
Console.WriteLine(intThreeRooms/10%10);

//3
Console.WriteLine(intThreeRooms/100);

//4
Console.WriteLine(intFiveRooms/1000%10);

//5
Console.WriteLine(intFourRooms/100%10);

//6
intEmpty = 0;
emptyValue = intThreeRooms;
for(int i = 0; i < 3; i++)
{
    intEmpty += emptyValue % 10;
    emptyValue /= 10;
}
Console.WriteLine(intEmpty);

//7
intEmpty = 1;
emptyValue = intThreeRooms;
for (int i = 0; i < 3; i++)
{
    intEmpty *= emptyValue % 10;
    emptyValue /= 10;
}
Console.WriteLine(intEmpty);

//8
intEmpty = 1;
emptyValue = intTwoRooms;
for (int i = 0; i < 2; i++)
{
    intEmpty *= emptyValue % 10;
    emptyValue /= 10;
}
Console.WriteLine(intEmpty);

//9
intEmpty = 0;
emptyValue = intFiveRooms;
for (int i = 0; i < 5; i++)
{
    intEmpty += emptyValue % 10;
    emptyValue /= 10;
}
Console.WriteLine(intEmpty);

//10
intEmpty = 0;
emptyValue = intThreeRooms;
for (int i = 0; i < 3; i++)
{
    intEmpty = intEmpty*10+emptyValue % 10;
    emptyValue /= 10;
}
Console.WriteLine(intEmpty);

//11
intEmpty = 0;
intEmpty = intFourRooms /100 *100;
intEmpty += intFourRooms % 10 * 10 + intFourRooms / 10 % 10;
Console.WriteLine(intEmpty);

//12
intEmpty = 0;
intEmpty += 
    (intThreeRooms /10 %10 *100) + 
    (intThreeRooms /100 *10) + 
    (intThreeRooms %10);
Console.WriteLine(intEmpty);

//13
intEmpty = 0;//8356
intEmpty +=
    (intFourRooms / 10 % 10 *1000) +//5000
    (intFourRooms / 100 % 10 * 100) +//5300
    (intFourRooms / 1000 *10) +//5380
    (intFourRooms % 10 );//5386
Console.WriteLine(intEmpty);


//------------------------------------------------------------------
int Bit = 8,
    Byt = Bit * 128,
    KB = Byt,
    MB = KB,
    GB = MB,
    TB = GB;

//14
int intValus22 = 10;
Console.WriteLine(intValus22 * MB);

//15
int intValus23 = Bit * Byt * KB * MB * 10;

//16
int intValus24 = 5000 / TB;
Console.WriteLine(intValus24);

//17
int intValus25 = 2048 / 2;
Console.WriteLine(intValus25);

//18
int intValus26 = 12000 / 5;
Console.WriteLine(intValus26);

//19
emptyValue = 0;
emptyValue = (intThreeRooms %100 *10) + intThreeRooms /100;
Console.WriteLine(emptyValue);

//20
emptyValue = 0;
emptyValue = (intThreeRooms % 10 * 100) + intThreeRooms /100 *10+ intThreeRooms /10 %10;
Console.WriteLine(emptyValue);

//21


//22

*/
#endregion

#region 
/*
//1
int a = 3;
emptyValue = a * a;
a = emptyValue * emptyValue;
Console.WriteLine(a);

//2
a = 2;
emptyValue = a * a;
a = emptyValue * emptyValue * emptyValue;
Console.WriteLine(a);

//3
a = 2;
emptyValue = a * a;
emptyValue = emptyValue * emptyValue;
a = emptyValue * emptyValue;
Console.WriteLine(a);

//4
int soat = 5;
soat += 24 * 2;
Console.WriteLine(soat);

//5
int hafta = 7 * 2;
soat = 25 / 24;
hafta += soat;
Console.WriteLine(hafta);

//6
int minu = 60 * 3;
soat = 3600 * 2;
minu += soat;
Console.WriteLine(minu);

//7
double fayl = 2048 / KB;
Console.WriteLine(fayl);

//8
fayl = (1.8 - (int)1.8) * 1000;
fayl = (((int)1.8 * MB) + fayl) * KB / 750;
Console.WriteLine(fayl);

//9
int dollarYevroSum = 12600 * 1;
dollarYevroSum += 14500 * 1;
Console.WriteLine(dollarYevroSum);

//10
a = 2;
int a1 = a * a;
emptyValue = a1 * a1;
a = emptyValue * emptyValue * a1;
Console.WriteLine(a);

//11
int anvarK = 720 * 50 * 152;
anvarK = anvarK / (KB * MB);
Console.WriteLine(anvarK);

//12
int daqBelg = 15;
double suzSon;
suzSon = daqBelg * 2.5 / 5;
Console.WriteLine((int)suzSon);

//13 (a,b)=(b,a);


//14
int A = 5, B = 10,
    C = 15;
(A, B, C) = (C, A, B);
Console.WriteLine(A + " " + B + " " + C);

//15
int patrik = 120;
int juli = 80;
emptyValue = (patrik - juli) / 2;
Console.WriteLine(emptyValue);

//16
int kmM = 1000 * 2, m = 100;
emptyValue = (kmM + m) * 10;
Console.WriteLine(emptyValue);

//17
a = 2;
emptyValue = a * a*a;//3
a1 = emptyValue * emptyValue;//6
a1 = a1 * a1;//12
a= a1 *emptyValue;//15
Console.WriteLine(a);

//18
a = 3;
int b= 4,c=5,d=10;
emptyValue= (a*b*c*d)/2;
Console.WriteLine(emptyValue);

//19
soat = 60* 2 ;
minu = 15;
int sekund = 180 / 60;
minu += sekund + soat;
Console.WriteLine(minu);

//20
int x = 2,y=2;
a = 20000; b=30000;
int xa=3,yb=4;
xa = (a / x) * xa;
yb = (b / y) * yb;
Console.WriteLine(xa +" "+ yb);
*/
#endregion

#region  if M: 33
/*
//1
int n = 56;
if (n % 2 == 0)
    Console.WriteLine("Juft");

//2 
n = 55;
if (n % 2 == 1)
    Console.WriteLine("Toq");

//3
n = 90;
if (10<= n && n<100)
    Console.WriteLine("Ikki xonali");

//4
n = 5048;
if (1000 <= n && n < 10000)
    Console.WriteLine("To'rt xonali");

//5
n = 90;
if (n % 2 == 0 && 10 <= n && n < 100)
    Console.WriteLine("Juft va ikki xonali");

//6
n = 835;
if (n % 2 == 1 && 100 <= n && n < 1000)
    Console.WriteLine("Toq va uch xonali");

//7
n = 5048;
if (n % 2 == 0 && 1000 <= n && n < 10000)
    Console.WriteLine("Juft va to'rt xonali");

//8
n = 15;
int n2 = 25;
if (n % 2 == 0 && n2 % 2 == 0)
    Console.WriteLine("Ikkalasi ham toq");

//9
n = 12;
n2 = 28;
if (n % 2 == 0 && n2 % 2 == 0)
    Console.WriteLine("Ikkalasi ham juft");

//10
n = 12;
n2 = 28;
if (n % 2 == 1 && n2 % 2 == 1 && 10 <= n && n < 100)
    Console.WriteLine("2 lasi ham toq va 2 xonali");


//11
n = 33;
if (n / 10 == n % 10)
    Console.WriteLine("Raqamlari teng");

//12
n = 92;
if (n / 10 + n % 10 > 10)
        Console.WriteLine("Raqamlari yig'indisi 10 dan katta");

//13
n = 92;
if (n / 10 * n % 10 > 20)
    Console.WriteLine("Raqamlari ko'paytmasi 20 dan katta");

//14
n = 33;
if ((n / 10)% 2 == 1 && (n % 10)% 2 == 1)
    Console.WriteLine("Ikkalasi ham toq");

//15
n = 33;
if ((n / 10) > 5 && (n % 10) > 5)
    Console.WriteLine("Ikkalasi ham > 5");

//16
n= 78;
if (n % 3 == 0)
    Console.WriteLine("3 ga qoldiqsiz bo'linadi");

//17
n = 21;
if (n  % 7 == 0 )
    Console.WriteLine("7 ga qoldiqsiz bo'linadi");

//18
n = 24;
if (n % 3 == 0 && n % 8 == 0)
    Console.WriteLine("3 va 8 ga qoldiqsiz bo'linadi");

//19
n = 36;
if (n % 7 == 0 || n % 9 == 0)
    Console.WriteLine("7 yoki 9 ga qoldiqsiz bo'linadi");

//20 == 16


//21
n = 46;
if (n % 5 != 0)
    Console.WriteLine("5 ga bo'linmaydi");

//22                            
n = 16;
if (n % 4 == 0 && n % 3 != 0)
    Console.WriteLine("4 ga bo'linadi va 3 ga bo'linmaydi");

//23
n = 18;
n2 = 13;
if (n > n2)
    Console.WriteLine("a sonini b sonidan katta");

//24
n = 13;
n2 = 13;
if (n == n2)
    Console.WriteLine("a soni b soniga teng");

//25
n = 7;
n2 = 5;
int n3 = 3;
if (n > n2 && n > n3)
    Console.WriteLine("a soni eng katta");

//26
n = 7;
n2 = 9;
n3 = 11;
if (n3 > n && n3 > n2)
    Console.WriteLine("c soni eng katta");

//27
n = 9;
n2 = 7;
n3 = 11;
if (n > n2 && n3 > n2)
    Console.WriteLine("b soni eng kichik");

//28
n = 50;
n2 = 25;
if (n == n2 * 2)
    Console.WriteLine("a soni b soninga 2 barobarga katta");

//29
n = 10;
n2 = 50;
if (n2 == n * 5)
    Console.WriteLine("b soni a soninga 5 barobarga katta");

//30
n = 10;
n2 = 50;
if (n2 == n * 4 || n == n2 * 4)
    Console.WriteLine("Sonlardan biri ikkinchisining 4 barobarga katta");

//31
n = 60;
n2 = 30;
if (n == n2 + 30)
    Console.WriteLine("a soni b sonidan  30 ga katta");

//32
n = 90;
n2 = 98;
n3 = 30;
int n4 = 80;
if (n2 > n && n2 > n3 && n2 > n4 && n2 % 2 == 0)
    Console.WriteLine("b soni eng katta va juft son");

//33
n = 90;
n2 = 35;
n3 = 98;
n4 = 80;
if (n3 > n && n3 > n2 && n3 > n4 && n3 % 2 == 0)
    Console.WriteLine("c soni eng katta va juft son");
*/
#endregion

