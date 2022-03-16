/*

// Задача №1

int FindMaxNum(int num)
{

    int n1 = num % 10;
    int n2 = num / 10;
   

    if (n1 > n2)
    {
        return n1;
    }
    else
    {
        return n2;
    }
}

int number = new Random().Next(10, 100);
Console.WriteLine("Current number is " + number + " max part is " + FindMaxNum(number));



// Задача №2

int FindMaxNum(int num)
{

    int n1 = num / 100;
    int n2 = num % 10;

    int n3 = n1 * 10 + n2;
    return n3;
}

int number = new Random().Next(100, 199);
Console.WriteLine("Входное значение " + number + " без второго разряда " + FindMaxNum(number));

// Задача №3

void Chastnoe(int num1, int num2)
{
    if (num1 < num2)
    {
        int a = num1;
        num1 = num2;
        num2 = a;
    }

    if (num1 % num2 == 0)
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine(num1 % num2);
    }
}

Console.WriteLine("Enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Chastnoe(number1, number2);



// Задача №4

void Proverka(int num1, int num2, int num3)
{
    if (num1 % num2 == 0 && num1 % num3 == 0)
    {
        Console.WriteLine("Число " + num1 + " является кратным числом " + num2 + " и " + num3);
    }
    else
    {
        Console.WriteLine("Число " + num1 + " не является кратным числом " + num2 + " и " + num3);
    }
}

Console.WriteLine("Enter first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter third number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

Proverka(number1, number2, number3);

*/

/*
// Домашнее задание C# 2_1
// Условие: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

int FindFirstLastNum(int num)
{

    int n1 = num / 10;
    int n2 = n1 % 10;

    return n2;
}

int number = new Random().Next(100, 1000);
Console.WriteLine("Входное значение " + number + " второй разряд " + " --> " + FindFirstLastNum(number));



// Домашнее задание C# 2_2
// Условие: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void ThirdNum(int num)
{
    if (num > 99)
    {
        while (num > 999)
        {
            num = num / 10;
        }
        num = num % 10;
        Console.WriteLine(num);
    }
    else
    {
        Console.WriteLine("Входящее значение " + num + " В числе отсутствует третий порядок ");
    }
}

Console.WriteLine("Введите целое положительное число: ");
int number = Convert.ToInt32(Console.ReadLine());

ThirdNum(number);



// Домашнее задание C# 2_3
// Условие: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.Write("Введите номер дня недели ");
int number = Convert.ToInt32(Console.ReadLine());
switch (number)
{
    case 1:
        {
            Console.WriteLine("Работа не ждёт - это только начало");
            break;
        }
    case 2:
        {
            Console.WriteLine("Работа не ждёт - уже на один день меньше");
            break;
        }
    case 3:
        {
            Console.WriteLine("Работа не ждёт - экватор");
            break;
        }
    case 4:
        {
            Console.WriteLine("Работа не ждёт -уже почти");
            break;
        }
    case 5:
        {
            Console.WriteLine("Работа не ждёт - вот и финиш!");
            break;
        }
    case 6:
        {
            Console.WriteLine("Можно отдохнуть ;-)");
            break;
        }
    case 7:
        {
            Console.WriteLine("Можно отдохнуть - как быстро пролетели выходные");
            break;
        }
    default:
        {
            Console.WriteLine("Такого дня недели не существует");
            break;
        }

}


*/

