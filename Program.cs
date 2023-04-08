//=============================================================================
// Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.
// 
// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
// 
//=============================================================================


Console.Clear();

//input
string[] userArray = InputArray();

//logic
string[] newArray = GetArrayStringLengthLE3(userArray);

//output
Console.WriteLine($"\n{ArrayToString(userArray)} -> {ArrayToString(newArray)}");


// Функция копирования n элементов arr в новый массив
// Для отрицательных n вернем пустой массив
static string[] CopyArray(string[] arr, int n)
{
    if (n < 0) n = 0;
    if (n >= arr.Length) return arr;
    else
    {
        string[] result = new string[n];
        for (int i = 0; i < n; i++)
        {
            result[i] = arr[i];
        }
        return result;
    }
}


// Функция возвращает новый массив из строк 
// длина которых меньше, либо равна 3 символам
static string[] GetArrayStringLengthLE3(string[] arr)
{
    int length = arr.Length;
    string[] result = new string[length];
    int count = 0;
    for (int i = 0; i < length; i++)
        if (arr[i].Length <= 3)
        {
            result[count] = arr[i];
            count++;
        }
    return CopyArray(result, count);
}


// функция представляет массив строк в виде одной строки
static string ArrayToString(string[] arr)
{
    if (arr.Length == 0) return "[]";
    return $"[\"{String.Join("\", \"", arr)}\"]";
}


//Функция ввода натурального числа
static int InputNaturalNumber(string msg, int defaultValue)
{
    int num;
    Console.Write(msg);
    if (int.TryParse(Console.ReadLine(), out num))
    {
        if (num <= 0) num = defaultValue;
    }
    else
    {
        num = defaultValue;
    }
    return num;
}


// Функция ввода массива строк
static string[] InputArray()
{
    //Веведем варианты готовых массивов
    Console.WriteLine("1. [\"Hello\", \"2\", \"world\", \":-)\"]");
    Console.WriteLine("2. [\"1234\", \"1567\", \"-2\", \"computer science\"]");
    Console.WriteLine("3. [\"Russia\", \"Denmark\", \"Kazan\"]");
    Console.WriteLine("4. [\"RUB\", \"EUR\", \"USD\"]");
    Console.WriteLine("5. [\"Bye\"]");
    Console.WriteLine("6. []");
    Console.WriteLine("7. Ввод пользователя\n");

    int userChoice = InputNaturalNumber("Ваш выбор (по умолчанию 1): ", 1);

    if (userChoice == 1) return new[] { "Hello", "2", "world", ":-)" };
    if (userChoice == 2) return new[] { "1234", "1567", "-2", "computer science" };
    if (userChoice == 3) return new[] { "Russia", "Denmark", "Kazan"};
    if (userChoice == 4) return new[] { "RUB", "EUR", "USD"};
    if (userChoice == 5) return new[] { "Bye" };
    if (userChoice == 6) return new string[0];

    int size = InputNaturalNumber("Введите длину массива (по умолчанию 3): ", 3);
    string[] result = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        result[i] = Console.ReadLine() ?? "";
    }
    return result;
}