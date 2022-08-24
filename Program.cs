/*
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// Вариант 1
Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 < number2)
{
    Console.WriteLine("max = " + number2);
}
else
{
Console.WriteLine("max = " + number1);
}


// Вариант 2
void BiggerNumber (int num1, int num2)
{
if (num1 > num2) Console.WriteLine($"Первое число {num1} больше второго {num2}");
else Console.WriteLine($"Второе число {num2} больше первого {num1}");
}

Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
BiggerNumber(number1, number2);
________________________________________________________________________________________________________________
*/


//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Вариант 1
/*
Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
if (number1 > number3)
    {
     Console.Write(number1);
    }
if (number2 > number1)
if (number2 > number3) 
    {
    Console.Write(number2); 
    }
if (number3 > number1)
if (number3 > number2) 
    {
    Console.Write(number3); 
    }
if (number1 == number2)
if (number1 == number3)
    {
    Console.Write("все числа равны");
    }

// Вариант 2

void MaxThreeNum (int n1, int n2, int n3)
{
if (n1 > n2)
if (n1 > n3)
    {
     Console.Write($"самое большое число {n1}");
    }
if (n2 > n1)
if (n2 > n3) 
    {
    Console.Write($"самое большое число {n2}");
    }
if (n3 > n1)
if (n3 > n2) 
    {
    Console.Write($"самое большое число {n3}");
    }
if (n1 == n2)
if (n1 == n3)
    {
    Console.Write("все числа равны");
    }
}
Console.Write("Введите число 1: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int n3 = Convert.ToInt32(Console.ReadLine());
MaxThreeNum(n1, n2, n3);
*/
//_______________________________________________________________________________________________________________________

//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
// Вариант 1
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int diff = number % 2;

if (diff == 1)
{
    Console.WriteLine("число " + number + " является НЕ ЧЁТНЫМ");
}
else 
if (diff == 0)
{
Console.WriteLine("число " + number + " является ЧЁТНЫМ");
}

// Вариант 2

void EvenNumbers (int num)
{
    if (num % 2 == 0) Console.WriteLine($"{num} чётное число");
    else Console.WriteLine($"{num} не чётное число");
}
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
EvenNumbers(number);
*/
//_______________________________________________________________________________________________________________________

// Вариант 1
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

int current = 1;
int ost;

while (current < N)
{
    ost = current % 2;
    current++;
        
        if (ost == 1)
        {
            Console.Write(current + ", ");
        }
        
}
*/
// Вариант 2

void EvenNumbers (int n)
{
    int current = 1;
    int ost;
    while (current > n)
    {
        ost = current % 2;
        current++;
        if (ost == 1) Console.Write(current + ", ");
                      
    }   
}
Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());
EvenNumbers(N);
