// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int inputNumber = GetInteger("Введите число: ");
int sumDigits = SumDigits(inputNumber);
Console.WriteLine($"Сумма цифр числа {inputNumber}: {sumDigits}");

int GetInteger(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigits(int number)
{
    int result = 0;

    while (number != 0)
    {
        result += number % 10;
        number /= 10;
    }

    return result;
}