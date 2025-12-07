

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
var text = string.Empty;
var resultText = string.Empty;
var intValue1 = 0;
var inValue2 = 0;

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
resultText = xISyISz(text);
Console.WriteLine(resultText);


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