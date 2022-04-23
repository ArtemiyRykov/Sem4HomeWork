// **Задача 25**: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите два числа через запятую. Второе число должнобыть натуральным.");
string inputString = Console.ReadLine();


int numberA = GetNumberA(inputString);
int numberB = GetNumberB(inputString);

if(numberB>0)
{
    int result = Pow(numberA, numberB);
    Console.WriteLine($"{numberA} ^ {numberB} = {result}");
}
else
{
    Console.WriteLine($"Число {numberB} не натуральное");
}


int GetNumberA(string sourceString)
{
    int separatorPosition = SearchСharacter(sourceString, ',');
    string numberAString = SubString(sourceString, 0, separatorPosition - 1);
    return Convert.ToInt32(numberAString);
}

int GetNumberB(string sourceString)
{
    int separatorPosition = SearchСharacter(sourceString, ',');
    string numberBString = SubString(sourceString, separatorPosition + 1, sourceString.Length - 1);
    return Convert.ToInt32(numberBString);
}

int Pow(int value, int pow)
{
    int result = value;
    pow--;
    while (pow > 0)
    {
        result *= value;
        pow--;
    }
    return result;
}

int SearchСharacter(string sourceString, char searchСharacter)
{
    for (int i = 0; i < sourceString.Length; i++)
    {
        if (sourceString[i] == searchСharacter)
        {
            return i;
        }
    }

    return -1;
}

string SubString(string sourceString, int startPosition, int endPosition)
{
    string result = String.Empty;

    for (int i = startPosition; i <= endPosition; i++)
        result += sourceString[i];

    return result;
}


