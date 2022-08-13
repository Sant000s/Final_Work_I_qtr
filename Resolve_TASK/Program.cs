Console.Clear();
Console.Write("\n КОНТРОЛЬНАЯ ЗАДАЧА: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.\n\n");
Console.Write("\nПримечание: Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.\n\n");
Console.Write("\n РЕШЕНИЕ:\n");
Console.Write("\n1) Формируем массив из произвольного текста:\n\n");

string[] arrText = new string[12] { "[", "My", "name", "is", "Bob", ",", "I'm", "35", "years", "old", "!", "]" };
string[] arrTotal = new string[arrText.Length];
PrintArray(arrText);
ArrayConvert(arrText, arrTotal);
Console.Write("\n2) Формируем массив из строк, длина которых меньше либо равна 3 символам:\n\n");
PrintArray(arrTotal);
Console.WriteLine();


void ArrayConvert(string[] arrText, string[] arrTotal)
{
    int count = 0;
    for (int i = 0; i < arrText.Length; i++)
    {
        if (arrText[i].Length <= 3)
        {
            arrTotal[count] = arrText[i];
            count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
