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
string[] userArray = { "Hello", "2", "world", ":-)" };

string[] newArray = GetArrayStringLengthLE3(userArray);

Console.WriteLine($"[{String.Join(", ", userArray)}] -> [{String.Join(", ", newArray)}]");


// Функция копирования n элементов arr в новый массив
string[] CopyArray(string[] arr, int n)
{
    if (n == arr.Length) return arr;
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
string[] GetArrayStringLengthLE3(string[] arr)
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