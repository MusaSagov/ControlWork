// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решение не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами

string[] arrayFirst = new string[6] { "777", "GeekBrains", "cat", "global", "32", "push" }; //объявили заполненный массив
string[] arraySecond = new string[arrayFirst.Length]; // объявили пустой массив с длинной заполненного массива

void SortingArray(string[] arrayFirst, string[] arraySecond) // объявили метод по сортировке элементов массива
{
    int count = 0; //ввели переменную
    for (int i = 0; i < arrayFirst.Length; i++) // цикл для перебора всех элементов заполненного массива
    {
        if (arrayFirst[i].Length <= 3) //условие для сортировки элементов массива
        {
            arraySecond[count] = arrayFirst[i]; //поэлементное заполнение пустого массива
            count++; //инкремент
        }
    }
}

void PrintArray(string[] array) // метод для вывода печати
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++) // цикл для поэтапного отображения эелементов на печати
    {
        Console.Write($"{array[i]} ");

    }
    Console.Write("]");
}

SortingArray(arrayFirst, arraySecond);
PrintArray(arraySecond);
