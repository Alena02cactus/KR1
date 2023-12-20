// 1. ввод массива (с клавиатуры) 
// 2. поиск среди элементов массива строк меньше трёх символов
// 3. формирование и вывод нового массива из найденных элементов

using System;

class Program
{
    static void Main()
    {
        // Ввод массива строк с клавиатуры
        Console.Write("Введите строки через пробел: ");
        string[] inputStrings = Console.ReadLine().Split(' ');

        // Формирование нового массива строк длиной меньше или равной 3 символам
        string[] resultStrings = FilterStrings(inputStrings);

        // Вывод результата
        Console.WriteLine("Результирующий массив строк: ");
        foreach (string str in resultStrings)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterStrings(string[] inputStrings)
    {
        // Подсчет количества строк, удовлетворяющих условию
        int count = 0;
        foreach (string str in inputStrings)
        {
            if (str.Length <= 3)
            {
                count++;
            }
        }

        // Создание нового массива
        string[] resultStrings = new string[count];

        // Заполнение нового массива
        int index = 0;
        foreach (string str in inputStrings)
        {
            if (str.Length <= 3)
            {
                resultStrings[index] = str;
                index++;
            }
        }

        return resultStrings;
    }
}
