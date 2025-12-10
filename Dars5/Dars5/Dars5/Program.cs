#region 1.5.0

#region Values 

var intValue = 0;
var numbersList = new List<int> { 1, 3, 12, 23, 659, 456, 2356, 7890, 25368, 34567, 458932, 890123 };
var stringValue = "";
var textList = new List<string> { "apple", "$banana", "cherry", "$date", "FIG", "grape" };
var boolValue = false;


#endregion



/*
// M: 1
static int ThereNumbers(List<int> numbers)
{
    var caunt = 0;
    foreach (var number in numbers)
    {
        if (99 < number && number < 1000)
        {
            caunt++;

        }
    }
    return caunt;
}

 intValue = ThereNumbers(numbersList);
Console.WriteLine(intValue);


// M: 2
static int CoupleCaunt(List<int> numbers)
{
    var caunt = 0;
    foreach (var number in numbers)
    {
        if (number % 2 == 0)
        {
            caunt++;
        }
    }
    return caunt;
}

intValue= CoupleCaunt(numbersList);
Console.WriteLine(intValue);


// M: 3
static int OddSum(List<int> numbers)
{
    var sum = 0;
    foreach (var number in numbers)
    {
        if (number % 2 != 0)
        {
            sum+=number;
        }
    }
    return sum;
}

intValue= OddSum(numbersList);
Console.WriteLine(intValue);


// M: 4
static int ThreeAndSevenCaunt(List<int> numbers)
{
    var caunt = 0;
    foreach (var number in numbers)
    {
        if (number % 3 == 0 && number % 7 == 0)
        {
            caunt++;
        }
    }
    return caunt;
}

intValue= ThreeAndSevenCaunt(numbersList);
Console.WriteLine(intValue);


// M: 5
static string OddAndTotal(List<int> numbers)
{
    var odd = 0;
    var totalSum = 0;
    foreach (var number in numbers)
    {
        
        if (number % 2 != 0)
        {
            odd++;
            totalSum += number;
        }
    }
    return $"Odd caunt: {odd}, Total sum: {totalSum}";
}

stringValue = OddAndTotal(numbersList);
Console.WriteLine(stringValue);


// M: 6
static List<int> OneReplacementLast(List<int> numbers)
{
    var lastIndex = numbers[0];
    var oneIndex = numbers[numbers.Count - 1];
    numbers[0] = oneIndex;
    numbers[numbers.Count - 1] = lastIndex;
    return numbers;
}

numbersList = OneReplacementLast(numbersList);
ConsoleWriteInt(numbersList);


// M: 7
static int ThreeSumInitial(List<int>  numbers  )
{
    var sum = 0;
    sum = numbers[0] + numbers[1] + numbers[2];
    return sum;
}

intValue = ThreeSumList(numbersList);
Console.WriteLine(intValue);


// M: 8
static int ThreeSumLast(List<int> numbers)
{
    var sum = 0;
    sum = numbers[numbers.Count - 1] + numbers[numbers.Count - 2] + numbers[numbers.Count - 3];
    return sum;
}

intValue = ThreeSumLast(numbersList);
Console.WriteLine(intValue);


// M: 9
static bool OddOrCouple(List<int> numbers)
{
    var cauntOdd = 0;
    var cauntCouple = 0;
    foreach (var number in numbers)
    {
        if (number % 2 != 0)
        {
            cauntOdd++;
        }
        else
        {
            cauntCouple++;
        }
    }
    return cauntOdd > cauntCouple;
}

boolValue = OddOrCouple(numbersList);
Console.WriteLine(boolValue);


// M: 10
static List<int> ThreeIncrease(List<int> numbers)
{
    for (var i = 0; i < numbers.Count; i++)
    {
        numbers[i] *= 3;
    }
    return numbers;
}

numbersList = ThreeIncrease(numbersList);
ConsoleWriteInt(numbersList);


// M: 11
static bool FiveMultiple(List<int> numbers)
{
    foreach (var number in numbers)
    {
        if (number % 5 != 0)
        {
            return false;
        }
    }
    return true;
}

boolValue = FiveMultiple(numbersList);
Console.WriteLine(boolValue);


// M: 12
static bool ThreeTwoRooms(List<int> numbers)
{
    var cauntTwo = 0;
    foreach (var number in numbers)
    {
        if (9 < number &&  number < 100)
        {
            cauntTwo++;
            if (cauntTwo >= 3)
            {
                return true;
            }
        }
    }
    return false;
}

boolValue = ThreeTwoRooms(numbersList);
Console.WriteLine(boolValue);


// M: 13
static bool CoupleTwoRoomAndOddTwoRoom(List<int> numbers)
{
    return (numbers[0]%2==0&& numbers[1]%2==0)
        &&
        (numbers[numbers.Count-2] % 2 != 0 && numbers[numbers.Count-1] % 2 != 0);
}

boolValue = CoupleTwoRoomAndOddTwoRoom(numbersList);
Console.WriteLine(boolValue);


// M: 14
static int ValueMinList(List<int> numbers)
{
    var min = numbers[0];
    foreach (var number in numbers)
    {
        if (number < min)
        {
            min = number;
        }
    }
    return min;
}

intValue = ValueMinList(numbersList);
Console.WriteLine(intValue);


// M: 15
static int MaxAndMinSum(List<int> numbers)
{
    var min = numbers[0];
    var max = numbers[0];
    foreach (var number in numbers)
    {
        if (number < min)
        {
            min = number;
        }
        if (number > max)
        {
            max = number;
        }
    }
    return min + max;
}

intValue = MaxAndMinSum(numbersList);
Console.WriteLine(intValue);


// M: 16
static List<int> TwoRoom(List<int > numbers)
{
    for (var i = 0; i < numbers.Count; i++)
    {
        if (9 < numbers[i] && numbers[i] < 100)
        {
            numbers[i] += 100;
        }
    }
    return numbers;
}

numbersList = TwoRoom(numbersList);
ConsoleWriteInt(numbersList);


// M: 17
static string PositiveAndNegativeCaunt(List<int> numbers)
{
    var positiveCaunt = 0;
    var negativeCaunt = 0;
    foreach (var number in numbers)
    {
        if (number >= 0)
        {
            positiveCaunt++;
        }
        else
        {
            negativeCaunt++;
        }
    }
    return $"Positive caunt: {positiveCaunt}, Negative caunt: {negativeCaunt}";
}

stringValue = PositiveAndNegativeCaunt(numbersList);
Console.WriteLine(stringValue);


// M: 18
static int OneMaxCaunt(List<int> numbers)
{
    var min =0;
    foreach (var number in numbers)
    {
        if (number < numbers[0])
        {
            min ++;
        }
    }
    
    return min;
}

intValue = OneMaxCaunt(numbersList);
Console.WriteLine(intValue);


// M: 19
static int LastMinSum(List<int> numbers)
{
    var min = 0;
    foreach (var number in numbers)
    {
        if (number > numbers[numbers.Count-1])
        {
            min+=number;
        }
    }

    return min;
}

intValue = LastMinSum(numbersList);
Console.WriteLine(intValue);


// M: 20
static string ForOrThree(List<int> numbers)
{
    var x = "hello";
    foreach (var number in numbers)
    {
        if (number % 4 != 0  )
        {
            if (number % 3 != 0)
            {
                return "salom";
            }
        }
        if (number % 3 != 0)
        {
            if (number % 4 != 0)
            {
                return "salom";
            }
        }
    }
    return x;
}

stringValue = ForOrThree(numbersList);
Console.WriteLine(stringValue);


// M: 21
static bool IncreasingList(List<int> numbers)
{
    for (var i = 0; i < numbers.Count - 1; i++)
    {
        if (numbers[i] > numbers[i + 1])
        {
            return false;
        }
    }
    return true;
}

boolValue = IncreasingList(numbersList);
Console.WriteLine(boolValue);


// M: 22
static bool DecreasingList(List<int> numbers)
{
    for (var i = 0; i < numbers.Count - 1; i++)
    {
        if (numbers[i] < numbers[i + 1])
        {
            return false;
        }
    }
    return true;
}

boolValue = DecreasingList(numbersList);
Console.WriteLine(boolValue);


// M: 23
static List<int> MaxEqualsMin(List<int> numbers)
{
    var min = numbers[0];
    var max = numbers[0];
    foreach (var number in numbers)
    {
        if (number < min)
        {
            min = number;
        }
        if (number > max)
        {
            max = number;
        }
    }
    for (var i = 0; i < numbers.Count; i++)
    {
        if (numbers[i] == max)
        {
            numbers[i] = min;
        }
        if (numbers[i] == min)
        {
            numbers[i] = max;
        }
    }
    return numbers;
}

numbersList = MaxEqualsMin(numbersList);
ConsoleWriteInt(numbersList);


// M: 24
//osson ( + )aniqlsh

// M: 25
static string MaxTwoSum(List<int> numbers)
{
    var maxSum = 0;
    var indexMax = 0;
    for (var i = 0; i < numbers.Count-1; i++)
    {
        if (numbers[i] + numbers[i+1] > maxSum)
        {
            maxSum = numbers[i] + numbers[i + 1];
            indexMax = i;
        }
    }
    return $"Index 1 : {numbers[indexMax]}, Index 2 : {numbers[indexMax +1]}";
}

stringValue = MaxTwoSum(numbersList);
Console.WriteLine(stringValue);


// M: 26
static int RightBigCaunt(List<int> numbers)
{
    var caunt = 0;
    for (var i = 0; i < numbers.Count - 1; i++)
    {
        if (numbers[i] < numbers[i + 1])
        {
            caunt++;
        }
    }
    return caunt;
}

intValue = RightBigCaunt(numbersList);
Console.WriteLine(intValue);


// M: 27
static List<long> EqualIncrease(List<int> number1,List<int > number2,List<long> NewList)
{
    var newValue = 0L;
    for (var i=0;i<number1.Count; i++)
    {
        for (var j=0;j<number2.Count; j++)
        {
            if (number1[i]==number2[j])
            {
                newValue = (long)number1[i]* (long)number2[j];
                NewList.Add(newValue);
            }
        }
    }
    return NewList;
}

var List1 = new List<int> { 3, 12, 23,5 };
var List2 = new List<int> { 5, 7, 3, 23,9 };
List<long> NewList= new List<long>();
NewList = EqualIncrease(List1, List2, NewList);
ConsoleWriteLong(NewList);


// M: 28
static int Determine(List<string> texts)
{
    var caunt = 0;
    foreach (var text in texts)
    {
        if (text[0] == '$')
        {
            caunt++;
        }
    }
    return caunt;
}

intValue = Determine(textList);
Console.WriteLine(intValue);


// M: 29
static void ToUpper(List<string> texts)
{
    var upperText = string.Empty;
    foreach (var text in texts)
    {
        upperText = text.ToUpper();
        if (text == upperText)
        {
            Console.WriteLine(text);
        }

    }
}

ToUpper(textList);


// M: 30
static List<int> CoupleIncrease(List<int> numbers)
{
    var couple = 0;
    foreach(var i in numbers)
    {
        if(i %2 ==0)
        {
            couple = i;
            break;
        }
    }
    for (var i = 0; i < numbers.Count ; i++)
    {
        if(i % 2 == 0)
        {
            numbers[i] += couple;
        }
        
    }
    return numbers;
}

var List1 = new List<int>() {2,3,4,5,6,7,8,9,10 };
numbersList = CoupleIncrease(List1);
ConsoleWriteInt(numbersList);


// M: 31
static List<int > OddIncrease(List<int> numbers)
{
    var odd = 0;
    for(var i = numbers.Count-1; i >= 0; i--)
    {
        if (i % 2 == 1)
        {
            odd = numbers[i];
            break;
        }
    }
    for(var i=0; i< numbers.Count; i++)
    {
        if(i % 2!=0)
        {
            numbers[i] += odd;
        }
    }
    return numbers;
}

var List1 = new List<int>() { 2, 3, 4, 5, 6, 7, 8, 9, 10 };
numbersList = OddIncrease(List1);
ConsoleWriteInt(numbersList);


// M: 32
static int CoupleMin(List<int> numbers)
{
    var minValue = 0;
    for(var i=0; i < numbers.Count;i+=2)
    {
        if (minValue > numbers[i])
        {
            minValue = numbers[i];
        }
    }
    return minValue;
}

intValue = CoupleMin(numbersList);
Console.WriteLine(intValue);


// M: 33
static List<int> OneListOrTowListMax(List<int> number1, List<int> number2, List<int> newList)
{
    for (var i = 0; i < number1.Count; i++)
    {
        newList.Add(Math.Max(number1[i], number2[i]));
    }
    return newList;
}

var List1 = new List<int>() { 5, 63, 98, 21, 2, 4 };
var List2 = new List<int>() { 3, 78, 5, 28, 1, 4 };
List<int> List3 = new List<int>();
List3 = OneListOrTowListMax(List1, List2, List3);
ConsoleWriteInt(List3);


// M: 34
static List<int> CoupleList(List<int> numbers,List<int> coupleList)
{
    foreach(var number in numbers)
    {
        if(number %2 == 0)
        {
            coupleList.Add(number);
        }
    }
    return coupleList;
}

var List1 = new List<int>() { 2,5,63,54,59,87,63,21,12,15,19,66};
var List2 = new List<int>();
numbersList = CoupleList(List1,List2);
ConsoleWriteInt(numbersList);
*/



#endregion

#region Funksia Full
static void ConsoleWriteInt(List<int> Values)
{
    foreach (var value in Values)
    {
        Console.WriteLine(value);
    }
}
static void ConsoleWriteString(List<string> Values)
{
    foreach (var value in Values)
    {
        Console.WriteLine(value);
    }
}
static void ConsoleWriteLong(List<long> Values)
{
    foreach (var value in Values)
    {
        Console.WriteLine(value);
    }
}
#endregion
