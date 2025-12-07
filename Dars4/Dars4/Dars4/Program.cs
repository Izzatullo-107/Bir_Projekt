

#region
/*
//
var text = "davay";
var result = "";

// almashtiradi
//var result = text.Replace("salom", "hello").Replace("Hello", "Salom");

//M: 1

// oxirgi 3 ta belgini oladi
result = text.Substring((text.Length - 3));
Console.WriteLine(result);

// 2 indx dan oxirgi n-2 index gacha oladi
result = text.Substring((text.Length-(text.Length-2)),(text.Length-4));
Console.WriteLine(result);
*/
#endregion

#region Variables
var text = string.Empty;
var text2 = string.Empty;
var intValue1 = 0;
var inValue2 = 0;
#endregion

#region 1.4.0

/*
// M: 2

static string xISyISz (string text)
{
    var text2= string.Empty;
    if (text == string.Empty)
    {
        return "String bo'sh";
    }
    foreach (char i in text)
    {
        if (i == 'x')
        {
            text2 += 'y';
        }
        else if (i == 'y')
        {
            text2 += 'z';
        }
        else
        {
            text2 += i;
        }

    }

    return text2;
}

text = "xayr";
text2 = xISyISz(text);
Console.WriteLine(text2);


// M: 3
static int isLowert(string text)
{
    var cauntr = 0;
    if (text == string.Empty)
    {
        return 0;
    }
    foreach (char i in text)
    {
        if (char.IsLower(i))
        {
            cauntr++;
        }
    }
    return cauntr;
}

text = "Salom Dunyo!";
Console.WriteLine(isLovercase(text));


// M: 4
static int oddCaunter(int intValue1,int inValue2)
{
    var count = 0;
    if (intValue1 >= inValue2)
    {
        return 0;
    }
    for(var i = intValue1; i<= inValue2;i++ )
    {
        if (i %2 == 1)
        {
            count++;
        }
    }
    return count;
}

intValue1 = 3;
inValue2 = 10;
Console.WriteLine(oddCaunter(intValue1, inValue2));


// M: 5
static int roomsCaunter(int intValue1)
{
    var count = 0;
    if (intValue1 == 0 )
    {
        return 1;
    }
    for (;intValue1 > 0; )
    {
       intValue1 /= 10;
       count++;
        
    }
    return count;
}

intValue1 = 4567;
Console.WriteLine(roomsCaunter(intValue1));


// M: 6
static bool isDigitText(string text)
{
    bool result = true;
    foreach (char i in text)
    {
        if (!char.IsDigit(i))
        {
            result = false;
            break;
        }
    }
    return result;
}

text = "123456";
Console.WriteLine(isDigitText(text));


// M: 7
static string bottomDigit(int intValue1)
{
    var result = "Tub son";
    var caunt = 0;
    for (var i=1 ;i <= intValue1/2 ; i++ )
    {
        if (intValue1 % i == 0)
        {
            caunt++;
        }
        if (caunt == 2)
        {
            result = "Tub emas";
            break;
        }
    }
    return result;
}

intValue1 = 47;
Console.WriteLine(bottomDigit(intValue1));


// M: 8
static string reverseString(string text)
{
    string reversed = string.Empty;
    for (int i = text.Length - 1; i >= 0; i--)
    {
        reversed += text[i];
    }
    return reversed;
}

text = "Salom";
Console.WriteLine(reverseString(text));


// M: 9 
static int spacelarCaunter(string text)
{
    var count = 0;
    foreach (char i in text)
    {
        if (char.IsWhiteSpace(i))
        {
            count++;
        }
    }
    return count;
}

text = "Salom Dunyo, Qalay siz";
Console.WriteLine(spacelarCaunter(text));


// M: 10
static bool palindrom(string text)
{
    var j = 0;

    for (var i = text.Length - 1; i > text.Length / 2; i--)
    {
        if (text[j] != text[i])
        {
            return false;
        }
        j++;
    }
    return true;
}

text = "madam";
Console.WriteLine(palindrom(text));


// M: 11 == 6


// M: 12
static int isDigit(string text)
{
    var cauntr = 0;
    if (text == string.Empty)
    {
        return 0;
    }
    foreach (char i in text)
    {
        if (char.IsDigit(i))
        {
            cauntr++;
        }
    }
    return cauntr;
}

text = "Salom Dunyo 123!";
Console.WriteLine(isDigit(text));


// M: 13
static int isUpper(string text)
{
    var cauntr = 0;
    if (text == string.Empty)
    {
        return 0;
    }
    foreach (char i in text)
    {
        if (char.IsUpper(i))
        {
            cauntr++;
        }
    }
    return cauntr;
}

text = "Salom Dunyo!";
Console.WriteLine(isUpper(text));


// M: 14
static bool isUpper(string text)
{
    
    if (text == string.Empty)
    {
        return false;
    }
    foreach (char i in text)
    {
        if (char.IsLower(i))
        {
            return false;
        }
    }
    return true;
}

text = "SALOM DUNYO!";
Console.WriteLine(isUpper(text));

// M: 15
static bool isUpper(string text)
{

    if (text == string.Empty)
    {
        return false;
    }
    foreach (char i in text)
    {
        if (char.IsUpper(i)||char.IsDigit(i) )
        {
            return false;
        }
    }
    return true;
}

text = "salom dunyo";
Console.WriteLine(isUpper(text));


// M: 16
static string toUpper(string text)
{
    text=text.ToUpper();
    return text;
}

text = "salom dunyo";
Console.WriteLine(toUpper(text));


// M: 17
static int CountOk(string text)
{
    int count = 0;

    for (int i = 0; i < text.Length - 1; i++)
    {
        if (text[i] == 'o' && text[i + 1] == 'k')
        {
            count++;
        }
    }
    return count;
}

text = "okokokoko";
Console.WriteLine(CountOk(text));


// M: 18
static string isDigit(string text)
{
    var text2= string.Empty;
    if (text == string.Empty)
    {
        return string.Empty;
    }
    foreach (char i in text)
    {
        if (char.IsLower(i))
        {
            text2+="*";
        }
        else
        {
            text2+=i;
        }
    }
    return text2;
}

text = "Salom Dunyo!";
Console.WriteLine(isDigit(text));


// M: 19
static string isUpperToLower(string text)
{
    var text2 = string.Empty;
    if (text == string.Empty)
    {
        return string.Empty;
    }
    foreach (char i in text)
    {
        if (char.IsUpper(i))
        {
            text2 +=char.ToLower(i);
        }
        else
        {
            text2 += i;
        }
    }
    return text2;
}

text = "Salom Dunyo!";
Console.WriteLine(isUpperToLower(text));


// M: 20
static string isLowerToUpper(string text)
{
    text = text.ToUpper();
    return text;
}

text = "Salom Dunyo!";
Console.WriteLine(isLowerToUpper(text));


// M: 21 
static int isCaunt(string text)
{
    var cauntr = 0;
    if (text == string.Empty)
    {
        return 0;
    }
    foreach (char i in text)
    {
        if (i == '@')
        {
            cauntr++;
        }
    }
    return cauntr;
}

text = "Salom@ Dunyo@!";
Console.WriteLine(isCaunt(text));
*/
#endregion

#region 1.4.1
/*
// M: 1
static string helloName(string name)
{
    return $"Hello {name}!";
}

text = "Alice";
Console.WriteLine(helloName(text));


// M: 2
static string makeAbba(string a, string b)
{
    return a + b + b + a;
}

text = "Hi";
text2 = "Bye";
Console.WriteLine(makeAbba(text, text2));


// M: 3
static string makeOutWord(string text1, string text2)
{
    return text1.Substring(0, 2) + text2 + text1.Substring(2, 2);
}

text = "<<>>";
text2 = "Yay";
Console.WriteLine(makeOutWord(text, text2));


// M: 4
static string extraEnd(string text)
{
    if (text.Length < 2)
    {
        return text;
    }
    text = text.Substring(text.Length - 2);
    return text + text + text;
}

text = "Hello";
Console.WriteLine(extraEnd(text));


// M: 5
static string firstTwo(string text)
{
    if (text.Length < 2)
    {
        return text;
    }
    text = text.Substring(0,2);
    return text ;
}

text = "Hello";
Console.WriteLine(firstTwo(text));


// M: 6
static string firstHalf(string text)
{
    if (text.Length % 2 != 0)
    {
        return string.Empty;
    }
    text = text.Substring(0, text.Length / 2);
    return text;
}

text = "WooHoo";
Console.WriteLine(firstHalf(text));


// M: 7
static string withoutEnd(string text)
{
    if (text.Length < 2)
    {
        return string.Empty;
    }
    text = text.Substring(1, text.Length - 2);
    return text;
}

text = "Hello";
Console.WriteLine(withoutEnd(text));


// M: 8
static string comboString(string a, string b)
{
    if (a.Length < b.Length)
    {
        return a + b + a;
    }
    else
    {
        return b + a + b;
    }
}

text = "Hello";
text2 = "hi";
Console.WriteLine(comboString(text, text2));


// M: 9
static string nonStart(string a, string b)
{
    if (a.Length < 1 || b.Length < 1)
    {
        return string.Empty;
    }
    return a.Substring(1) + b.Substring(1);
}

text = "Hello";
text2 = "There";
Console.WriteLine(nonStart(text, text2));


// M: 10
static string left2(string text)
{
    if (text.Length < 2)
    {
        return text;
    }
    return text.Substring(2) + text.Substring(0, 2);
}

text = "Hello";
Console.WriteLine(left2(text));


// M: 11
static string theEnd(string text, bool front)
{
    if (text.Length < 1)
    {
        return string.Empty;
    }
    if (front)
    {
        return text.Substring(0, 1);
    }
    else
    {
        return text.Substring(text.Length - 1);
    }
}

text = "Hello";
Console.WriteLine(theEnd(text, true));


// M: 12
static string nTwice(string text, int n)
{
    if (text.Length < n)
    {
        return text;
    }
    return text.Substring(0, n) + text.Substring(text.Length - n);
}

text = "Hello";
Console.WriteLine(nTwice(text, 2));


// M: 13
static string middleThree(string text)
{
    if (text.Length < 3 || text.Length % 2 == 0)
    {
        return string.Empty;
    }
    var midIndex = text.Length / 2;
    return text.Substring(midIndex - 1, 3);
}

text = "Cany";
Console.WriteLine(middleThree(text));


// M: 14
static string conCat(string a, string b)
{
    if (a.Length < 1 || b.Length < 1)
    {
        return a + b;
    }
    if (a[a.Length - 1] == b[0])
    {
        return a + b.Substring(1);
    }
    return a + b;
}

text = "hello";
text2 = "olly";
Console.WriteLine(conCat(text, text2));


// M: 15
static string lastTwo(string text)
{
    if (text.Length < 2)
    {
        return text;
    }
    return text.Substring(0, text.Length - 2) + text[text.Length - 1] + text[text.Length - 2];
}

text = "coding";
Console.WriteLine(lastTwo(text));


// M: 16
static string seeColor(string text)
{
    if (text.StartsWith("red"))
    {
        return "red";
    }
    else if (text.StartsWith("blue"))
    {
        return "blue";
    }
    return string.Empty;
}

text = "bluecar";
Console.WriteLine(seeColor(text));


// M: 17
static bool frontAgain(string text)
{
    if (text.Length < 2)
    {
        return false;
    }
    if (text.Substring(0, 2) == text.Substring(text.Length - 2))
    {
        return true;

    }
    return false;
}

text = "edited";
Console.WriteLine(frontAgain(text));


// M: 18
static string minCat(string a, string b)
{
    if (a.Length < 1 || b.Length < 1)
    {
        return a + b;
    }
    if (a.Length > b.Length)
    {
        return a.Substring(a.Length - b.Length) + b;
    }
    else if (b.Length > a.Length)
    {
        return a + b.Substring(b.Length - a.Length);
    }
    return a + b;
}

text = "Hello";
text2 = "Hi";
Console.WriteLine(minCat(text, text2));


// M: 19
static string deFront(string text)
{
    var result = string.Empty;
    if (text.Length < 1)
    {
        return string.Empty;
    }

   
    if (text.Length >= 1)
    {
        if (text[0] == 'a')
        {
            result += 'a';
        }
    }
    if (text.Length >= 2)
    {
        if (text[1] == 'b')
        {
            result += 'b';
        }
    }
    if (text.Length > 2)
    {
        result += text.Substring(2);
    }
    return result;
}

text = "cbcde";
Console.WriteLine(deFront(text));


// M: 20
static string withoutX(string text)
{
    if (text.Length < 1)
    {
        return string.Empty;
    }

    if (text.Length >= 1 && text[0] == 'x')
    {
        text = text.Substring(1);
    }
    if (text.Length >= 1 && text[text.Length - 1] == 'x')
    {
        text = text.Substring(0, text.Length - 1);
    }
    return text;
}

text = "xHixi";
Console.WriteLine(withoutX(text));


// M: 21
static string noDigit(string text)
{
    var result = string.Empty;
    foreach (char i in text)
    {
        if (!char.IsDigit(i))
        {
            result += i;
        }
    }
    return result;
}

text = "a1b2c3d4";
Console.WriteLine(noDigit(text));


// M: 22
static string noUpper(string text)
{
    var result = string.Empty;
    foreach (char i in text)
    {
        if (!char.IsUpper(i))
        {
            result += i;
        }
    }
    return result;
}

text = "aBcDeF";
Console.WriteLine(noUpper(text));


// M: 23
static string noLower(string text)
{
    var result = string.Empty;
    foreach (char i in text)
    {
        if (!char.IsLower(i))
        {
            result += i;
        }
    }
    return result;
}

text = "aBcDeF";
Console.WriteLine(noLower(text));


// M: 24
static string noDog(string text)
{
    var result = string.Empty;
    foreach (char i in text)
    {
        if ((i) != '@')
        {
            result += i;
        }
    }
    return result;
}

text = "aBc@DeF@";
Console.WriteLine(noDog(text));


// M: 25
static string noSpace(string text)
{
    var result = string.Empty;
    foreach (char i in text)
    {
        if (!char.IsWhiteSpace(i))
        {
            result += i;
        }
    }
    return result;
}

text = "a Bc @D eF @";
Console.WriteLine(noSpace(text));
*/
#endregion

#region 1.4.2








#endregion