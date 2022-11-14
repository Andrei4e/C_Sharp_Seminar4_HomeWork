//Задача 25. Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B (Math.Pow НЕ использовать)
/*int exp(int a, int b)
{
    int Result = a;
    int i = 1;
    while (i < b)
    {
        Result *= a;
        i++;
    }
    return Result;
}
Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
Console.Write($"число А, возведенное в натуральную степень В, равно: {exp(A, B)}");*/


//Задача 27. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*int exp(int a, int b)
{
    int Result = a;
    int i = 1;
    while (i < b)
    {
        Result *= a;
        i++;
    }
    return Result;
}

int SumDigit (int number)
{
    int num = number;
    int DigitalCount = 0;
    int Result = 0;
    while (num>0)
    {
        DigitalCount++;
        num = num/10;
    }

    for (int i=0; i < DigitalCount; i++)
    {
        if (i == 0) 
        {
            if (i == DigitalCount-1) Result += number;
            else Result += number%exp(10,DigitalCount-i)/exp(10,DigitalCount-i-1);
        }
        else
        {
            if (i == DigitalCount-1) Result += number%exp(10,DigitalCount-i);
            else Result += number%exp(10,DigitalCount-i)/exp(10,DigitalCount-i-1);
        }
    }
    return Result;
}

Console.Write("Введите число A: ");
int Number = Convert.ToInt32(Console.ReadLine());
Console.Write($"Сумма всех цифр в числе равна: {SumDigit(Number)}");*/

//Задача 29. Напишите программу, которая создает массив заданного пользователем размера, заполняет массив элементами от 1 до 99 и выводит их на экран.
void CreateArray(int size)
{
    int[] array = new int[size];
    int i = 0;
    while (i < size)
    {
        array[i] = new Random().Next(1,100);
        if (i == size-1) Console.WriteLine($"{array[i]}");
        else Console.Write($"{array[i]}, ");
        i++;
    }
}
Console.Write("Введите размер массива: ");
int Size = Convert.ToInt32(Console.ReadLine());
CreateArray(Size);