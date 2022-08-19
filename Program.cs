/*
//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

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
*/

/*
//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

if(number1 > number2)
    if(number1 > number3)
    {
        Console.WriteLine("max = " + number1);
    }
else
{
    if(number2 > number1)
        if (number2 > number3)
        {
           Console.WriteLine("max = " + number2); 
        }
}
else
{
    if(number3 > number1)
        if(number3 > number1)
        {
            Console.WriteLine("max = " + number3);
        }
}
*/

/*
//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

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
*/

/*
// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

int current = 1;
int diff;

while (current < N)
{
    diff = current % 2;
    current++;
        
        if (diff == 1)
        {
            Console.Write(current + ", ");
        }
        
}
*/