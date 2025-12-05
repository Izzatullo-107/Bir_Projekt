
//int intVaule1 = int.Parse(Console.ReadLine());
//int intVaule2 = int.Parse(Console.ReadLine());

// M: 1  [ 3-xonali raqamlari toq bo'lganlari. ]
/*
for(int i= 100; i<1000; i++)
{
    if ((i % 10) % 2 == 1)
    {
        if ((i / 10 % 10) % 2 == 1)
        {
            if ((i / 100) % 2 == 1)
            {
                Console.Write($"{i}, ");
            }
        }
    }
}
*/


//Uy ishi
#region qisqartma uchun
var caunt = 0;
var sum = 0;
var fullSum = 0;
var intVaule1 = 0;
var intVaule2 = 0;
var intVaule3 = 0;
#endregion

#region 1.3.1
/*
//M: 1 =>  15
for (var i = 100; i < 1000; i++)
{
    sum = 0;
    sum += i / 1 % 10;
    sum += i / 10 % 10;
    sum += i / 100 % 10;
    if (sum > 20)
    {
        Console.Write($"{i}, ");
    }
}

// M: 2
for (var i = 100; i < 1000; i++)
{
    if (i / 100 == i % 10  && i /10 %10 != i %10)
    {
        Console.Write($"{i}, ");
    }
}

// M: 3
for (var i = 10; i < 100; i++)
{
    sum = 1;
    sum *= i / 1 % 10;
    sum *= i / 10 % 10;
    if (sum > 12)
    {
        caunt++;
        fullSum += sum;
    }
}
Console.WriteLine($"Count(N) : {caunt}, FullSum(+) : {fullSum}");

// M: 4
for (var i = 100; i < 1000; i++)
{
    sum = i / 10 % 10;
    if (sum == 2 || sum == 5)
    {
        Console.Write($"{i}, ");
    }
}

// M: 5
intVaule1 = 5;
for (var i = 0; i < intVaule1; i++)
{
    Console.Write($"{intVaule1}, ");
}

// M: 6 => 20
intVaule1 = 3;
intVaule2 = 7;
for (var i = 0; i < intVaule2; i++)
{
    Console.Write($"{intVaule1}, ");
}

// M: 7
intVaule1 = 3;
intVaule2 = 7;
for (var i = 0; i < intVaule1; i++)
{
    Console.Write($"{intVaule2}, ");
}

// M: 8
intVaule1 = 9;
for(var i=1; i <= intVaule1; i++)
{
    if (intVaule1 % i == 0)
    {
        Console.Write($"{i}, ");
    }
}

// M: 9
intVaule1 = 9;
caunt = 0;
for (var i = 1; i <= intVaule1; i++)
{

    if (intVaule1 % i == 0)
    {
        caunt++;
    }
}
Console.WriteLine($"{caunt}");

// M: 10
intVaule1 = 9;
fullSum = 0;
for (var i = 1; i <= intVaule1; i++)
{

    if (intVaule1 % i == 0)
    {
       fullSum += i;
    }
}
Console.WriteLine($"{fullSum}");

// M: 11 => 25
intVaule1 = 11;
caunt = 0;
for (var i = 2; i <= intVaule1; i++)
{
    if (intVaule1 % i == 0)
    {
        caunt++;
    }
}
if (caunt == 1)
{
    Console.WriteLine($"{intVaule1} soni tub son");
}
else
{
    Console.WriteLine($"{intVaule1} soni tub son emas");
}

// M: 12
intVaule1 = 11;
intVaule2 = 7;
caunt = 0;
for (var i = 1; i <= intVaule1; i++)
{
    if (intVaule1 % i == 0)
    {
        caunt++;
    }
}
for (var i = 1; i <= intVaule2; i++)
{
    if (intVaule1 % i == 0)
    {
        sum++;
    }
}
if (caunt == 2 && sum == 2)
{
    Console.WriteLine($"{intVaule1 + intVaule2} soni tub son");
}
else
{
    Console.WriteLine($"{intVaule1 * intVaule2} soni tub son emas");
}

// M: 13
intVaule1 = 7000;
for (var i = 3; i <= 60; i++)
{
    Console.WriteLine($"{i} → {i * intVaule1}");
}

// M: 14
intVaule1 = 50;
caunt = 0;
for (var i = 23; i <= intVaule1; i++)
{
    if (i % 3 != 0)
    {
        caunt++;
        Console.Write($"{i}, ");
    }
}
Console.WriteLine();
Console.WriteLine($"soni: {caunt}");

// M: 15
intVaule1 = 20;
intVaule2 = 30;
caunt = 0;
sum = 0;
for (var i = 1; i <= Math.Max(intVaule1,intVaule2); i++)
{
    if (intVaule1 % i == 0)
    {
        caunt++;
    }
    if (intVaule2 % i == 0)
    {
        sum++;
    }
}
if (caunt > sum)
{
    Console.WriteLine($"{intVaule1} bo'luvchilari ko'p");
}
else
{
    Console.WriteLine($"{intVaule2} bo'luvchilari ko'p");
}

// M: 16
intVaule1 = 5;
intVaule2 = 10;
fullSum = 0;
for (var i = intVaule1+1; i < intVaule2; i++)
{
 fullSum += i;
}
Console.WriteLine($"{fullSum}");
*/
#endregion

#region 1.3.2
/*
// M: 1 
for(var i = 2; i < 10; i++)
{
    for (var j = 2; j < 10; j++)
    {
        Console.Write($"{j} * {i} = {i * j}\t");
    }
    Console.WriteLine();
}

// M: 2
intVaule1 = 2;
intVaule2 = 6;
for (var i = intVaule1+1; i < intVaule2; i++)
{
    for (var j = 0; j <i; j++)
    {
        Console.Write($"{i} ");
    }
}

// M: 3
for (var i = 1; i <= 100; i++)
{
    caunt = 0;
    for (var j = 1; j <= i; j++)
    {
        if (i % j == 0)
        {
            caunt++;
        }
    }
    if(caunt == 2)
    {
        Console.Write($"{i}, ");
    }
}

// M: 4
intVaule1 = 2;
intVaule2 = 30;
for (var i = intVaule1; i <= intVaule2; i++)
{
    caunt = 0;
    for (var j = 1; j <= i; j++)
    {
        if (i % j == 0)
        {
            caunt++;
        }
    }
    if (caunt == 2)
    {
        Console.Write($"{i}, ");
    }
}

// M: 5
intVaule1 = 5;
for (var i = 0; i < intVaule1; i++)
{
    for (var j = 0; j < intVaule1; j++)
    {
        Console.Write($"* ");
    }
    Console.WriteLine();
}

// M: 6
intVaule1 = 5;
for (var i = 0; i < intVaule1; i++)
{
    for (var j = 0; j < intVaule1; j++)
    {
        if (j == 0 || intVaule1 - 1 == j)
        {
            Console.Write($"* ");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}

// M: 7
intVaule1 = 5;
for (var i = 0; i < intVaule1; i++)
{
    for (var j = 0; j < intVaule1; j++)
    {
        if (i == 0 || intVaule1 - 1 == i)
        {
            Console.Write($"* ");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}

// M: 8
intVaule1 = 5;
for (var i = 0; i < intVaule1; i++)
{
    for (var j = 0; j < intVaule1; j++)
    {
        if (j == 0 || intVaule1 - 1 == j || i == 0 || intVaule1 - 1 == i)
        {
            Console.Write($"* ");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}

// M: 9
intVaule1 = 5;
for (var i = 0; i < intVaule1; i++)
{
    for (var j = 0; j < intVaule1; j++)
    {
        if (j == 0 || intVaule1 - 1 == j || intVaule1/2==i)
        {
            Console.Write($"* ");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}

// M: 10
intVaule1 = 5;
for (var i = 0; i < intVaule1; i++)
{
    for (var j = 0; j < intVaule1; j++)
    {
        if (j == 0 || intVaule1 - 1 == i || intVaule1 / 2 == i || i ==0)
        {
            Console.Write($"* ");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}

// M: 11
intVaule1 = 5;
for (var i = 0; i < intVaule1; i++)
{
    for (var j = 0; j < intVaule1; j++)
    {
        if (i == 0 || intVaule1 / 2 == j)
        {
            Console.Write($"* ");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}

// M: 12
intVaule1 = 5;
for (var i = 0; i < intVaule1; i++)
{
    for (var j = 0; j < intVaule1; j++)
    {
        if ( intVaule1 /2 == j || intVaule1 / 2 == i)
        {
            Console.Write($"* ");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}

// M: 13
intVaule1 = 5;
for (var i = 0; i < intVaule1; i++)
{
    for (var j = 0; j < intVaule1; j++)
    {
        if (intVaule1 / 2 == j || intVaule1 / 2 == i || j == 0 || intVaule1 - 1 == j || i == 0 || intVaule1 - 1 == i)
        {
            Console.Write($"* ");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}

// M: 14
intVaule1 = 5;
for (var i = 0; i < intVaule1; i++)
{
    for (var j = 0; j < intVaule1; j++)
    {
        if ( j == i)
        {
            Console.Write($"* ");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}

// M: 15
intVaule1 = 5;
for (var i = 0; i < intVaule1; i++)
{
    for (var j = 0; j < intVaule1; j++)
    {
        if (j + i == intVaule1-1)
        {
            Console.Write($"* ");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}

// M: 16
intVaule1 = 5;
for (var i = 0; i < intVaule1; i++)
{
    for (var j = 0; j < intVaule1; j++)
    {
        if (j == i || j == 0 || intVaule1-1==j )
        {
            Console.Write($"* ");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}

// M: 17
intVaule1 = 5;
for (var i = 0; i < intVaule1; i++)
{
    for (var j = 0; j < intVaule1; j++)
    {
        if (j == i || i == 0 || intVaule1 - 1 == i)
        {
            Console.Write($"* ");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}

// M: 18
intVaule1 = 5;
for (var i = 0; i < intVaule1; i++)
{
    for (var j = 0; j < intVaule1; j++)
    {
        if (j <= i )
        {
            Console.Write($"* ");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}

// M: 19
intVaule1 = 5;
for (var i = 0; i < intVaule1; i++)
{
    for (var j = 0; j < intVaule1; j++)
    {
        if (j >= i)
        {
            Console.Write($"* ");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}

// M: 20
intVaule1 = 5;
for (var i = 0; i < intVaule1; i++)
{
    for (var j = 0; j < intVaule1; j++)
    {
        if (j + i >= intVaule1-1)
        {
            Console.Write($"* ");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}
for (int i = 0; i < intVaule1; i++)
{
    for (int j = 0; j < intVaule1; j++)
    {
        if (j + i >= intVaule1 - 1)
        {
            Console.Write((i+1)+""+(j+1 ) +" ");
        }
        else
        {
            Console.Write("   ");
        }
    }
    Console.WriteLine();
}

// M: 21
intVaule1 = 5;
for (var i = 0; i < intVaule1; i++)
{
    for (var j = 0; j < intVaule1; j++)
    {
        Console.Write($"{i+1} ");
    }
    Console.WriteLine();
}

// M: 22
intVaule1 = 5;
for (var i = 0; i < intVaule1; i++)
{
    for (var j = 0; j < intVaule1; j++)
    {
        if (j == i)
        {
            Console.Write($"{i+1} ");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}

// M: 23
intVaule1 = 5;
for (var i = 0; i < intVaule1; i++)
{
    for (var j = 0; j < intVaule1; j++)
    {
        if (i >= j)
        {
            Console.Write($"{i+1} ");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}

// M: 24
intVaule1 = 5;
for (var i = 0; i < intVaule1; i++)
{
    for (var j = 0; j < intVaule1; j++)
    {
        if (j == i || i + j == intVaule1 -1)
        {
            Console.Write($"$ ");
        }
        else
        {
            Console.Write("  ");
        }
    }
    Console.WriteLine();
}
*/
#endregion

#region 1.3.3
/*
// M: 31
intVaule1 = 10000;
var kg= 1.2;
sum = intVaule1/100;
kg = kg*10 * sum;
Console.WriteLine($"{kg} so'm");

// M: 32
intVaule1 = 10;
if (intVaule1 > 1)
{
    for (var i = 0; i <= intVaule1; i++)
    {
        Console.WriteLine($"{Math.Sqrt(i):F2}");
    }
}

// M: 33
intVaule1 = 2;
intVaule2 = 3;
Console.WriteLine($"{Math.Pow(intVaule1,intVaule2)}");
*/
#endregion