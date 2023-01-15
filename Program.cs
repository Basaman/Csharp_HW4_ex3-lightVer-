//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

Console.Clear();
int num1 = GetNumber1FromUser("Введите целое число: ", "Ошибка ввода!");
int num2 = GetNumber2FromUser("Введите целое число: ", "Ошибка ввода!");
int num3 = GetNumber3FromUser("Введите целое число: ", "Ошибка ввода!");
int num4 = GetNumber4FromUser("Введите целое число: ", "Ошибка ввода!");
int num5 = GetNumber5FromUser("Введите целое число: ", "Ошибка ввода!");
int num6 = GetNumber6FromUser("Введите целое число: ", "Ошибка ввода!");
int num7 = GetNumber7FromUser("Введите целое число: ", "Ошибка ввода!");
int num8 = GetNumber8FromUser("Введите целое число: ", "Ошибка ввода!");
Console.WriteLine($"{num1}, {num2}, {num3}, {num4}, {num5}, {num6}, {num7}, {num8} -> [{num1}, {num2}, {num3}, {num4}, {num5}, {num6}, {num7}, {num8}]");

int GetNumber1FromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
    
}

int GetNumber2FromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
    
}

int GetNumber3FromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
    
}

int GetNumber4FromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
    
}

int GetNumber5FromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
    
}

int GetNumber6FromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
    
}

int GetNumber7FromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
    
}

int GetNumber8FromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
    
}