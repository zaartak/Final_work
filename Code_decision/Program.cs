// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] array = { "Mon", "Tues", "Wen", "Fri", "Satur" };
        
string[] newArray = FilterArray(array);

Console.WriteLine("New Array:");

foreach (string element in newArray)
{
    Console.WriteLine(element);
}

string[] FilterArray(string[] array)
{
    int count = 0;

// Получаем количество элементов, удовлетворяющих условию
    foreach (string element in array)
    {
        if (element.Length <= 3)
        {
            count++;
        }
    }

string[] newArray = new string[count];
int index = 0;