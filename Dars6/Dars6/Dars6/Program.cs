/*
 * 2 ta float berilsa ham, 3 ta float berilsa ham,
 * 2 ta string berilsa ham Add() funksiyasini yaratib bering overloading yordamida.
 */



internal class Program
{
    private static void Main(string[] args)
    {
        #region Value
        var i1 = 1;
        var i2 = 2;
        var i3 = 3;
        var i4 = 10;
        var f1 = 2.5f;
        var f2 = 2f;
        var f3 = 3.5f;
        var s1 = "2.5";
        var s2 = "2.5";
        #endregion

        #region klasda

        /*
        // M: 1
        var f1 = 2.5f;
        var f2 = 2f;
        var f3 = 3.5f;
        var fs = "2.5";
        var fs2 = "2.5";

        Console.WriteLine(Add(f1, f2));
        Console.WriteLine(Add(f1, f2, f3));
        Console.WriteLine(Add(fs, fs2));

        // M: 2
        i1 = 2;
        i2 = 2;
        i3 = 3;

        Console.WriteLine(Calculate(i1,i2));
        Console.WriteLine(Calculate(i1,i2,i3));


        // M: 3

        Console.WriteLine(Multiplication(i3));
        Console.WriteLine(Multiplication(i1,i2));
        Console.WriteLine(Multiplication(i1,i2,i3));
        */
        #endregion



        // ----------------------------------------------------------------------------------------
        #region 1.6.0
        /*
        // M: 1
        f1 = 2.5f;
        f2 = 2f;
        f3 = 3.5f;
        fs = "2.5";
        fs2 = "2.5";

        Console.WriteLine(Add(f1, f2));
        Console.WriteLine(Add(f1, f2, f3));
        Console.WriteLine(Add(fs, fs2));
        
        // M: 2
        i1= 3;
        i2= 4;
        Repeat(3);
        Repeat(4,3);
        

        // M: 3
        Console.WriteLine(Calculate(i1, i2));
        Console.WriteLine(Calculate(i1, i2, i3));


        // M: 4
        ConsolAdd(GetAmountDigit(i4));
        ConsolAdd(GetAmountDigit("rt564gyw258"));


        // M: 5
        ConsolAdd(FindMax(i1,i2,i3));
        ConsolAdd(FindMax(i1,i2,i3,i4,i1));


        // M: 6
        i1 = 2;
        i2 = 2;
        i3 = 3;
        Console.WriteLine(Multiplication(i3));
        Console.WriteLine(Multiplication(i1, i2));
        Console.WriteLine(Multiplication(i1, i2, i3));

        // M: 7
        ConsolAdd(DigitCaunt(875));


        // M: 8 
        ConsolAdd(Total(i1,i4));
*/



        #endregion


    }



    #region 1.6.0 ning funksiyasi

    #region M: 1 Add() 
    static float Add(float f1, float f2)
    {
        return f1 + f2;
    }
    static float Add(float f1, float f2, float f3)
    {
        var f = f1 + f2 + f3;
        return f;
    }
    static string Add(string f1, string f2)
    {
        return f1 + f2;
    }
    #endregion

    #region M: 2 Repeat() 
    static void Repeat(int a)
    {
        for (var i = 1; i <= a; i++)
        {
            ConsolAdd(a);
        }
    }
    static void Repeat(int a, int b)
    {
        for (var i = 1; i <= b; i++)
        {
            ConsolAdd(a);
        }
    }
    #endregion

    #region M: 3 Calculate()
    static int Calculate(int a, int b)
    {
        return a + b;
    }
    static int Calculate(int a, int b, int c)
    {
        return a * b * c;
    }

    #endregion

    #region M: 4 GetAmountDigit()
    static int GetAmountDigit(int a)
    {
        var caunt = 0;
        for (var i = 1; a != 0; i++)
        {
            caunt = i;
            a /= 10;
        }
        return caunt;
    }
    static int GetAmountDigit(string text)
    {
        var cauntDigit = 0;
        foreach (char i in text)
        {
            if (char.IsDigit(i))
            {
                cauntDigit++;
            }
        }
        return cauntDigit;
    }

    #endregion

    #region M: 5 FindMax()
    static int FindMax(int a, int b, int c)
    {
        var intmax = Math.Max(a, Math.Max(b, c));
        return intmax;
    }
    static int FindMax(int a, int b, int c, int d)
    {
        var intmax = Math.Max(a, Math.Max(b, Math.Max(c, d)));
        return intmax;
    }
    static int FindMax(int a, int b, int c, int d, int e)
    {
        var intmax = Math.Max(a, Math.Max(b, Math.Max(c, Math.Max(d, e))));
        return intmax;
    }
    #endregion

    #region M: 6 Multiplication()
    static int Multiplication(int a)
    {
        var i = 1;
        for (var j = 1; j <= a; j++)
        {
            i *= j;
        }
        return i;
    }
    static int Multiplication(int a, int b)
    {
        var i = 1;
        for (var j = a; j <= b; j++)
        {
            i *= j;
        }
        return i;
    }
    static int Multiplication(int a, int b, int c)
    {

        return a * b * c;
    }
    #endregion

    #region M: 7 DigitCaunt()
    static int DigitCaunt(int a)
    {
        var i = 1;
        a /= 10;
        if (a == 0)
        {
            return i;
        }
        return i + DigitCaunt(a);
    }
    #endregion

    #region M: 8 Total()
    static int Total(int a, int b)
    {
        if (a == b)
        {
            return a;
        }
        return a + Total(a + 1, b);
    }

    #endregion

    #region M: 9 !
    #endregion

    #region M: 10 Maxx()
    static int Maxx(int a, int b)
    {
        if (a > b)
        {
            return a;
        }
        else if (b > a)
        {
            return b;
        }
        return a;
    }
    static float Maxx(float a, float b)
    {
        if (a > b)
        {
            return a;
        }
        else if (b > a)
        {
            return b;
        }
        return a;
    }
    static double Maxx(double a, double b)
    {
        if (a > b)
        {
            return a;
        }
        else if (b > a)
        {
            return b;
        }
        return a;
    }
    #endregion

    # region M: 11 Abss()
    static int Abss(int a)
    {
        if (a < 0)
        {
            a *= -1;
        }
        return a;
    }
    static float Abss(float a)
    {
        if (a < 0)
        {
            a *= -1f;
        }
        return a;
    }
    static double Abss(double a)
    {
        if (a < 0)
        {
            a *= -1.0;
        }
        return a;
    }
    #endregion

    #region M: 12 IiUpperr()
    static bool IiUpperr(char a)
    {
        if (64 < a && a < 91)
        {
            return true;
        }
        return false;
    }
    #endregion

    #region M: 13 ToUpperr()
    static string ToUpperr(string a)
    {
        var text = string.Empty;
        for (var i = 0; i < a.Length; i++)
        {
            if (96 < a[i] && a[i] < 123)
            {
                switch (a[i])
                {
                    case 'a': text += 'A'; break;
                    case 'b': text += 'B'; break;
                    case 'c': text += 'C'; break;
                    case 'd': text += 'D'; break;
                    case 'e': text += 'E'; break;
                    case 'f': text += 'F'; break;
                    case 'g': text += 'G'; break;
                    case 'h': text += 'H'; break;
                    case 'i': text += 'I'; break;
                    case 'j': text += 'J'; break;
                    case 'k': text += 'K'; break;
                    case 'l': text += 'L'; break;
                    case 'm': text += 'M'; break;
                    case 'n': text += 'N'; break;
                    case 'o': text += 'O'; break;
                    case 'p': text += 'P'; break;
                    case 'q': text += 'Q'; break;
                    case 'r': text += 'R'; break;
                    case 's': text += 'S'; break;
                    case 't': text += 'T'; break;
                    case 'u': text += 'U'; break;
                    case 'v': text += 'V'; break;
                    case 'w': text += 'W'; break;
                    case 'x': text += 'X'; break;
                    case 'y': text += 'Y'; break;
                    case 'z': text += 'Z'; break;
                }
            }
            else
            {
                text += a[i];
            }
        }
        return text;
    }
    static char ToUpperr(char a)
    {
        var text = ' ';
        if (96 < a && a < 123)
        {
            switch (a)
            {
                case 'a': text = 'A'; break;
                case 'b': text = 'B'; break;
                case 'c': text = 'C'; break;
                case 'd': text = 'D'; break;
                case 'e': text = 'E'; break;
                case 'f': text = 'F'; break;
                case 'g': text = 'G'; break;
                case 'h': text = 'H'; break;
                case 'i': text = 'I'; break;
                case 'j': text = 'J'; break;
                case 'k': text = 'K'; break;
                case 'l': text = 'L'; break;
                case 'm': text = 'M'; break;
                case 'n': text = 'N'; break;
                case 'o': text = 'O'; break;
                case 'p': text = 'P'; break;
                case 'q': text = 'Q'; break;
                case 'r': text = 'R'; break;
                case 's': text = 'S'; break;
                case 't': text = 'T'; break;
                case 'u': text = 'U'; break;
                case 'v': text = 'V'; break;
                case 'w': text = 'W'; break;
                case 'x': text = 'X'; break;
                case 'y': text = 'Y'; break;
                case 'z': text = 'Z'; break;
            }
        }
        else
        {
            text = a;
        }

        return text;
    }
    #endregion

    #region M: 14 IsDigitt()
    static bool IsDigitt(char a)
    {
        if (47< a && a<58)
        {
            return true;
        }
        return false;
    }
    #endregion

    #region M: 15 IsLowerr()
    static bool IsLowerr(char a)
    {
        if (96 < a && a < 123)
        {
            return true;
        }
        return false;
    }

    #endregion

    #region M: 16 ToLowerr()
    static string ToLowerr(string a)
    {
        var text = string.Empty;
        for (var i = 0; i < a.Length; i++)
        {
            if (64< a[i] && a[i] < 91)
            {
                switch (a[i])
                {
                    case 'A': text += 'a'; break;
                    case 'B': text += 'b'; break;
                    case 'C': text += 'c'; break;
                    case 'D': text += 'd'; break;
                    case 'E': text += 'e'; break;
                    case 'F': text += 'f'; break;
                    case 'G': text += 'g'; break;
                    case 'H': text += 'h'; break;
                    case 'I': text += 'i'; break;
                    case 'J': text += 'j'; break;
                    case 'K': text += 'k'; break;
                    case 'L': text += 'l'; break;
                    case 'M': text += 'm'; break;
                    case 'N': text += 'n'; break;
                    case 'O': text += 'o'; break;
                    case 'P': text += 'p'; break;
                    case 'Q': text += 'q'; break;
                    case 'R': text += 'r'; break;
                    case 'S': text += 's'; break;
                    case 'T': text += 't'; break;
                    case 'U': text += 'u'; break;
                    case 'V': text += 'v'; break;
                    case 'W': text += 'w'; break;
                    case 'X': text += 'x'; break;
                    case 'Y': text += 'y'; break;
                    case 'Z': text += 'z'; break;
                }
            }
            else
            {
                text += a[i];
            }
        }
        return text;
    }
    static char ToLowerr(char a)
    {
        var text = ' ';
        if (64 < a && a < 91)
        {
            switch (a)
            {
                case 'A': text = 'a'; break;
                case 'B': text = 'b'; break;
                case 'C': text = 'c'; break;
                case 'D': text = 'd'; break;
                case 'E': text = 'e'; break;
                case 'F': text = 'f'; break;
                case 'G': text = 'g'; break;
                case 'H': text = 'h'; break;
                case 'I': text = 'i'; break;
                case 'J': text = 'j'; break;
                case 'K': text = 'k'; break;
                case 'L': text = 'l'; break;
                case 'M': text = 'm'; break;
                case 'N': text = 'n'; break;
                case 'O': text = 'o'; break;
                case 'P': text = 'p'; break;
                case 'Q': text = 'q'; break;
                case 'R': text = 'r'; break;
                case 'S': text = 's'; break;
                case 'T': text = 't'; break;
                case 'U': text = 'u'; break;
                case 'V': text = 'v'; break;
                case 'W': text = 'w'; break;
                case 'X': text = 'x'; break;
                case 'Y': text = 'y'; break;
                case 'Z': text = 'z'; break;
            }
        }
        else
        {
            text = a;
        }

        return text;
    }
    #endregion

    #region M: 17 Poww()
    static int Poww(int a,int b)
    {
        var pow = 1;
        for (var i =1; i<=b; i++)
        {
            pow *= a;
        }
        return pow;
    }
    static float Poww(float a,float b)
    {
        var pow = 1f;
        for (var i =1; i<=b; i++)
        {
            pow *= a;
        }
        return pow;
    }
    static double Poww(double a,double b)
    {
        var pow = 1.0;
        for (var i =1; i<=b; i++)
        {
            pow *= a;
        }
        return pow;
    }
    #endregion


    #endregion

    // ----------------------------------------------------------------------------------------

    #region Qo'shimcha ishlatishga
    static void ConsolAdd(int a)
    {
        Console.WriteLine(a);
    }
    #endregion

}