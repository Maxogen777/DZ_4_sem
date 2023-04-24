Console.WriteLine("\n\nЗадача 25: \n  Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. \n" );

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());
int c = 1;
if (b < 1)
Console.Write("Число B должно быть натуральным\n");
else
{
while (b != 0)
{
c = c * a;
b = b - 1;
}
Console.Write($"Число A в натуральной степени B равно {c}");
}

Console.WriteLine("\n\nЗадача 27: \n  Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. \n" );

int number = ReadInt("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}

Console.WriteLine("\n\nЗадача 29: \n  Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. \n" );

int[] randomArray = new int[8];

for (int i = 0; i < 8; i++)
{
randomArray[i] = new Random().Next(1,99);
Console.Write(randomArray[i] + " ");
}


/*
int lenArray = ReadIntArr("Введите длинну массива: ");

int[] randomArray = new int[lenArray];
for (int i = 0; i < randomArray.Length; i++)
{
    randomArray[i] = new Random().Next(1,9);
    Console.Write(randomArray[i] + " ");
}


// Функция ввода
int ReadIntArr(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
*/