// Задача 29. Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
// Ввод одной строкой через запятую

Console.WriteLine("Введите числа через запятую");
string inputString = Console.ReadLine();

int countNumbers = CountСharacter(inputString, ',') + 1;

int startPosition = 0;
int endPosition = 0;
int[] resultArray = new int[countNumbers];

for (int i = 0; i < countNumbers; i++)
{
    endPosition = SearchСharacter(inputString, ',', startPosition + 1) - 1;
    if (endPosition < 0)
        endPosition = inputString.Length - 1;

    string textNumber = SubString(inputString, startPosition, endPosition);
    resultArray[i] = Convert.ToInt32(textNumber);

    startPosition = endPosition + 2;
}

Console.Write("Результат: ");
PrintArray(array: resultArray,
            startSymbol: '[',
            endSymbol: ']',
            separator: ", ",
            endLine: true);



int SearchСharacter(string sourceString, char searchСharacter, int startPosition)
{
    for (int i = startPosition; i < sourceString.Length; i++)
    {
        if (sourceString[i] == searchСharacter)
        {
            return i;
        }
    }

    return -1;
}

int CountСharacter(string sourceString, char searchСharacter)
{
    int count = 0;
    for (int i = 0; i < sourceString.Length; i++)
    {
        if (sourceString[i] == searchСharacter)
        {
            count++;
        }
    }

    return count;
}

string SubString(string sourceString, int startPosition, int endPosition)
{
    string result = String.Empty;

    for (int i = startPosition; i <= endPosition; i++) result += sourceString[i];

    return result;
}

void PrintArray(int[] array, char startSymbol, char endSymbol, string separator, bool endLine)
{
    Console.Write(startSymbol);
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i != array.Length - 1)
            Console.Write(separator);
    }
    Console.Write(endSymbol);
    if (endLine)
        Console.WriteLine();
}