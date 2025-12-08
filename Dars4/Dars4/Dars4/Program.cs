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
var text3 = string.Empty;
var intValue1 = 0;
var intValue2 = 0;
var charValue = '\0';
#endregion

//--------------------------------------------------------------------------------------------------------------------------

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

//--------------------------------------------------------------------------------------------------------------------------

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

//--------------------------------------------------------------------------------------------------------------------------

#region 1.4.2
/*
// M: 1
static string textAndText2(int intValue1, string text, string text2,int intValue2)
{
    if (text.Length < intValue1 || text2.Length < intValue2)
    {
        return string.Empty;
    }

    return text.Substring(0, intValue1) + text2.Substring(text2.Length - intValue2);
}

text = "Hello";
text2 = "World";
intValue1 = 2;
intValue2 = 3;
Console.WriteLine(textAndText2(intValue1, text, text2, intValue2));


// M: 2
static string charX2(string text, char ch)
{
    var result = string.Empty;
    foreach (char i in text)
    {
        result += i;
        if (i == ch)
        {
            result += ch;
        }
    }
    return result;
}

text = "hello";
charValue = 'o';
Console.WriteLine(charX2(text, charValue));


// M: 3
static string charS1AndS2(char charValue, string text, string text2)
{
    var result = string.Empty;
    for (var i = 0; i < text.Length - 1; i++)
    { 
        if(text[i]==charValue)
        {
            result += text2;
        }
        result += text[i];
    }
    return result;
}

text = "ab3cde3f";
text2 = "X";
charValue = '3';
Console.WriteLine(charS1AndS2(charValue, text, text2));


// M: 4
static string charS1AndS2(char charValue, string text, string text2)
{
    var result = string.Empty;
    for (var i = 0; i < text.Length - 1; i++)
    {
        result += text[i];
        if (text[i] == charValue)
        {
            result += text2;
        }
    }
    return result;
}

text = "ab3cde3f";
text2 = "X";
charValue = '3';
Console.WriteLine(charS1AndS2(charValue, text, text2));


// M: 5
//static int cauntS2AndS1(string text2, string text)
//{
//    var count = 0;
//    for (var i = 0; i < text2.Length-1; i++)
//    {

//        if (text2.IndexOf(text) != -1)
//        {
//            i++;
//            count++;
//        }
//    }
//    return count;
//}
static int cauntS2AndS1(string text, string text2)
{
    int count = 0;
    int index = 0; // Qidirishni boshlash indeksi

    // Asosiy satr (text) ichida izlanayotgan satrni (text2) qidiramiz
    while ((index = text.IndexOf(text2, index)) != -1)
    {
        count++;
        // Keyingi qidirishni topilgan joydan keyin darhol boshlash
        index += text2.Length;
    }
    return count;
}

text = "hihihihello";
text2 = "hi";
Console.WriteLine(cauntS2AndS1(text, text2));


// M: 6
static string S1AndS2(string text, string text2)
{
    text = text.Remove(text.IndexOf(text2), text2.Length);
    return text;
}

text = "abcpqrabcxyz";
text2 = "abc";
Console.WriteLine(S1AndS2(text, text2));


// M: 7
static string S1OldS2(string text, string text2)
{
    for (var i = text.Length - 1; i > -1; i--)
    {
        if (text.IndexOf(text2, i) != -1)
        {
            text = text.Remove(i, text2.Length);
            return text;
        }

    }
    return text;
}

text = "acpqrabcxyz";
text2 = "abc";
Console.WriteLine(S1OldS2(text, text2));


// M: 8
static string S1OldS2(string text, string text2)
{
    for (var i = text.Length - 1; i > -1; i--)
    {
        if (text.IndexOf(text2, i) != -1)
        {
            text = text.Remove(i, text2.Length);
        }

    }
    return text;
}

text = "abcpqrabcxyzabc";
text2 = "abc";
Console.WriteLine(S1OldS2(text, text2));


// M: 9
static string S1OldS2(string text, string text2, string text3)
{
    var resault = string.Empty;
    if (text.IndexOf(text2) != -1)
    {
        text = text.Substring(0, text.IndexOf(text2)) + text3
             + text.Substring(text.IndexOf(text2) + text2.Length);

        //return text;
    }
    return text;
}

text = "abcpqrabcxyz";
text2 = "abc";
text3 = "XYZ";
Console.WriteLine(S1OldS2(text, text2, text3));


// M: 10
static string S1AndS2AndS3(string text, string text2,string text3)
{
    for (var i = text.Length - 1; i > -1; i--)
    {
        if (text.IndexOf(text2, i) != -1)
        {
            text = text.Substring(0, i) + text3
             + text.Substring(i + text2.Length);
            return text;
        }

    }
    return text;
}

text = "abcpqrabcxyzabc";
text2 = "abc";
text3 = "XYZ";
Console.WriteLine(S1AndS2AndS3(text, text2,text3));


// M: 11
static string S1AndS2AndS3(string text, string text2, string text3)
{
    for (var i = text.Length - 1; i > -1; i--)
    {
        if (text.IndexOf(text2, i) != -1)
        {
            text = text.Substring(0, i) + text3
             + text.Substring(i + text2.Length);
        }

    }
    return text;
}

text = "abcpqrabcxyzabc";
text2 = "abc";
text3 = "XYZ";
Console.WriteLine(S1AndS2AndS3(text, text2, text3));


// M: 12
static string S1AndS2AndS3(string text)
{
    var caunt = 0;
    var text2 = string.Empty;
    if (text.IndexOf(' ') == -1)
    {
        return string.Empty;
    }

    for (var i = text.Length - 1; i > -1; i--)
    {
        if (text.IndexOf(text2, i) != -1)
        {
            caunt++;
        }
    }

    if (caunt==1)
    {
        return string.Empty;
    }
    if(caunt > 1)
    {
        text = text.Remove(0, text.IndexOf(' ')+1);
        text = text.Substring(0, text.IndexOf(' '));
    }

    return text;
}

text = "abc pq rabc xyzabc";
Console.WriteLine(S1AndS2AndS3(text));


// M: 13
static bool catDog(string text)
{
    var cat = 0;
    var dog = 0;
    for (var i = text.Length - 1; i > -1; i--)
    {
        if (text.IndexOf("cat", i) != -1)
        {
            text = text.Remove(i, 3);
            cat++;
        }
        if (text.IndexOf("dog", i) != -1)
        {
            text = text.Remove(i, 3);
            dog++;
        }
    }
    return cat == dog;
}

text = "catdogdogcat";
Console.WriteLine(catDog(text));


// M: 14
static int countCode(string text)
{
    var count = 0;
    for (var i = 0; i < text.Length - 3; i++)
    {
        if (text[i] == 'c' && text[i + 1] == 'o' && text[i + 3] == 'e')
        {
            count++;
        }
    }
    return count;
}

text = "codecopecode";
Console.WriteLine(countCode(text));


// M: 15
static bool endOther(string a, string b)
{
    a = a.ToLower();
    b = b.ToLower();
    if (a.Length < b.Length)
    {
        return b.EndsWith(a);
    }
    else
    {
        return a.EndsWith(b);
    }
}

text = "Hiabc";
text2 = "abc";
Console.WriteLine(endOther(text, text2));


// M: 16
static bool xyzThere(string text)
{
    if (text.IndexOf('.') > text.IndexOf("xyz"))
    {
        return true;
    }
    return false;
}

text = "xyz.abc";
Console.WriteLine(xyzThere(text));


// M: 17
static string mixString(string a, string b)
{
    var result = string.Empty;
    var minLength = Math.Min(a.Length, b.Length);
    for (var i = 0; i < minLength; i++)
    {
        result += a[i];
        result += b[i];
    }
    if (a.Length > minLength)
    {
        result += a.Substring(minLength);
    }
    else if (b.Length > minLength)
    {
        result += b.Substring(minLength);
    }
    return result;
}

text = "abc";
text2 = "XYZ123";
Console.WriteLine(mixString(text, text2));


// M: 18
static string repeatEnd(string text, int n)
{
    var result = string.Empty; 
    for (var i = 0; i < n; i++)
    {
        result += text.Substring(text.Length - n);
    }
    return result;
}

text = "Hello";
Console.WriteLine(repeatEnd(text, 3));


// M: 19
static string repeatFront(string text, int n)
{
    var result = string.Empty;
    for (var i = n; i > 0; i--)
    {
        result += text.Substring(0, i);
    }
    return result;
}

text = "Chocolate";
Console.WriteLine(repeatFront(text, 4));


// M: 20
static string repeatSeparator(string text, string text2, int n)
{
    var result = string.Empty;
    for (var i = 0; i < n; i++)
    {
        result += text;
        if (i < n - 1)
        {
            result += text2;
        }
    }
    return result;
}

text = "This";
text2 = "And";
Console.WriteLine(repeatSeparator(text, text2, 2));


// M: 21
static bool prefixAgain(string text, int n)
{
    var prefix = text.Substring(0, n);
    for (var i = n; i <= text.Length - n; i++)
    {
        if (text.IndexOf(prefix,n)!=-1)
        {
            return true;
        }
    }
    return false;
}

text = "abcpqrabcxyz";
Console.WriteLine(prefixAgain(text, 3));


// M: 22
static bool xyzMiddle(string text)
{
    var mid = text.Length / 2;
    if (text.Length < 3)
    {
        return false;
    }
    if (text.Length % 2 == 0)
    {
        if (text.Substring(mid - 1, 3) == "xyz" || text.Substring(mid - 2, 3) == "xyz")
        {
            return true;
        }
    }
    else
    {
        if (text.Substring(mid - 1, 3) == "xyz")
        {
            return true;
        }
    }
    return false;
}

text = "A AxyzBB";
Console.WriteLine(xyzMiddle(text));


// M: 23
static string getSandwich(string text)
{
    var firstIndex = text.IndexOf("bread");
    var lastIndex = text.LastIndexOf("bread");
    if (firstIndex == -1 || firstIndex == lastIndex)
    {
        return string.Empty;
    }
    return text.Substring(firstIndex + 5, lastIndex - (firstIndex + 5));
}

text = "breadjambread";
Console.WriteLine(getSandwich(text));


// M: 24
static bool sameStarChar(string text)
{
    for (var i = 1; i < text.Length - 1; i++)
    {
        if (text[i] == '*')
        {
            if (text[i - 1] != text[i + 1])
            {
                return false;
            }
        }
    }
    return true;
}

text = "xy*yzz";
Console.WriteLine(sameStarChar(text));


// M: 25
static string zipZap(string text)
{
    var result = string.Empty;
    for (var i = 0; i < text.Length; i++)
    {
        if (i < text.Length - 2 && text[i] == 'z' && text[i + 2] == 'p')
        {
            result += "zp";
            i += 2;
        }
        else
        {
            result += text[i];
        }
    }
    return result;
}

text = "zzzopzop";
Console.WriteLine(zipZap(text));


// M: 26 
static string plusOut(string text, string word)
{
    var result = string.Empty;
    var i = 0;
    while (i < text.Length)
    {
        if (i <= text.Length - word.Length && text.Substring(i, word.Length) == word)
        {
            result += word;
            i += word.Length;
        }
        else
        {
            result += "+";
            i++;
        }
    }
    return result;
}

text = "12xy34xyabcxy";
text2 = "xy";
Console.WriteLine(plusOut(text, text2));


// M: 27
static string wordEnds(string text, string word)
{
    var result = string.Empty;

    for (var i = 0; i <= text.Length - word.Length; i++)
    {
        if (text.Substring(i, word.Length) == word)
        {
            if (i > 0)
            {
                result += text[i - 1];
            }
            if (i + word.Length < text.Length)
            {
                result += text[i + word.Length];
            }
        }
    }
    return result;
}

text = "abcXY123XYijk";
text2 = "XY";
Console.WriteLine(wordEnds(text, text2));


// M: 28
static int countYZ(string text)
{
    var count = 0;
    text = text.ToLower();
    for (var i = 0; i < text.Length; i++)
    {
        if ((text[i] == 'y' || text[i] == 'z') &&
            (i == text.Length - 1 || !char.IsLetter(text[i + 1])))
        {
            count++;
        }
    }
    return count;
}

text = "fez day";
Console.WriteLine(countYZ(text));


// M: 29
static string withoutString(string text, string word)
{
    var result = string.Empty;
    var i = 0;
    while (i < text.Length)
    {
        if (i <= text.Length - word.Length && text.Substring(i, word.Length) == word)
        {
            i += word.Length;
        }
        else
        {
            result += text[i];
            i++;
        }
    }
    return result;
}

text = "Hello there";
text2 = "llo";
Console.WriteLine(withoutString(text, text2));

// M: 30
static bool equalIsNot(string text)
{
    var isCount = 0;
    var notCount = 0;
    for (var i = 0; i < text.Length; i++)
    {
        if (i <= text.Length - 2 && text.Substring(i, 2) == "is")
        {
            isCount++;
        }
        if (i <= text.Length - 3 && text.Substring(i, 3) == "not")
        {
            notCount++;
        }
    }
    return isCount == notCount ;
}

text = "This is notnot";
Console.WriteLine(equalIsNot(text));


// M: 31
static bool gHappy(string text)
{
    for (var i = 0; i < text.Length; i++)
    {
        if (text[i] == 'g')
        {
            if ((i > 0 && text[i - 1] == 'g') || (i < text.Length - 1 && text[i + 1] == 'g'))
            {
                continue;
            }
            return false;
        }
    }
    return true;
}

text = "xxgggxyx";
Console.WriteLine(gHappy(text));


// M: 32
static int countTriple(string text)
{
    var count = 0;
    for (var i = 0; i < text.Length - 2; i++)
    {
        if (text[i] == text[i + 1] && text[i] == text[i + 2])
        {
            count++;
        }
    }
    return count;
}

text = "abcXXXabc";
Console.WriteLine(countTriple(text));


// M: 33
static int sumDigits(string text)
{
    var sum = 0;
    foreach (char i in text)
    {
        if (char.IsDigit(i))
        {
            sum += (i - '0'); /// char ni int ga aylantirish
        }
    }
    return sum;
}

text = "aa1bb2cc3";
Console.WriteLine(sumDigits(text));


// M: 34
static string sameEnds(string text)
{
    var result = string.Empty;
    for (var i = text.Length / 2; i > 0; i--)
    {
        if (text.Substring(0, i) == text.Substring(text.Length - i))
        {
            result = text.Substring(0, i);
            break;
        }
    }
    return result;
}

text = "abXYab";
Console.WriteLine(sameEnds(text)); 


// M: 35
static int maxBlock(string text)
{
    var maxCount = 0;
    var currentCount = 0;
    for (var i = 0; i < text.Length; i++)
    {
        for (var j = 0; j < text.Length; j++)
        {
            if (text[i] == text[j])
            {
                currentCount++;
            }
        }
        if (maxCount < currentCount)
        {
            maxCount = currentCount;
        }
        currentCount = 0;
    }

    return maxCount;
}

text = "hoopla";
Console.WriteLine(maxBlock(text));

// M: 36
static int sumNumbers(string text)
{
    var sum = 0;
    var currentNumber = string.Empty;

    for (var i = 0; i < text.Length; i++)
    {
        if (char.IsDigit(text[i]))
        {
            currentNumber += text[i]; 
        }
        else
        {
            if (currentNumber != "")
            {
                sum += int.Parse(currentNumber);
                currentNumber = ""; 
            }
        }
    }
    if (currentNumber != "")
    {
        sum += int.Parse(currentNumber);
    }

    return sum;
}

text = "abc123xyz";
Console.WriteLine(sumNumbers(text));
*/

// M: 37
static string notReplace(string text)
{
    var result = string.Empty;
    for (var i = 0; i < text.Length; i++)
    {
        if (i <= text.Length - 2 && text.Substring(i, 2) == "is" &&
            (i == 0 || !char.IsLetter(text[i - 1])) &&
            (i + 2 == text.Length || !char.IsLetter(text[i + 2])))
        {
            result += "is not";
            i++;
        }
        else
        {
            result += text[i];
        }
    }
    return result;
}

#endregion
//--------------------------------------------------------------------------------------------------------------------------
