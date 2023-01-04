/* Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться 
коллекциями, лучше обойтись исключительно массивами.

Примеры:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]
["1234", "1567", "-2", "computer science"] -> ["-2]
["Russia", "Denmark", "Kazan"] -> [] */

Console.Clear();
int quantity = UserInput("Введите количество элементов массива: ", "Введено неверное значение!");
string[] array = ArrayInput("Введите элемент массива: ");

Console.WriteLine();
PrintArray(array);



string[] ArrayInput(string message)
{
    string[] newArray = new string[quantity];
    int index = 0;
    int count = 0;
    int temp = quantity;
    quantity = 0;
    while (true)
    {
        Console.Write(message);
        newArray[index] = Console.ReadLine()??"";
        index++;
        count++;
        quantity++;
        if (temp == quantity)
        {
            Console.WriteLine("Отлично! Массив заполнен!");
            break;
        }
        Console.WriteLine("Для завершения ввода элементов нажмите q, для продолжения - любую другую клавишу");
        if (Console.ReadKey(true).Key == ConsoleKey.Q) break;
    }
    Array.Resize(ref newArray, quantity);
    return newArray;    
}

void PrintArray(string[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
    {
        Console.Write($"{inArray[i]} \t");
    }
    Console.WriteLine();
}

int UserInput(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        if (int.TryParse(Console.ReadLine()??"", out int number) && number > 0) return number;
        else Console.WriteLine(errorMessage);
    }
}