// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Write("Проверка на количество символов ");
Console.Write("Какое количество элементов будет в массиве?");
int sizearr = Convert.ToInt32(Console.ReadLine());

string[] arrayProb = new string[sizearr];
int max = 3;
int pos = 0;

for (int i = 0; i < sizearr; i++)
{
 Console.WriteLine($"Введите {i+1}-й элемент: ");
 string element = Convert.ToString(Console.ReadLine());

 if (element.Length <= max)
    {
 arrayProb[pos] = element;
 pos++;
    }
}

Console.WriteLine();
PrintArray(arrayProb);

void PrintArray(string[] array)
{
 for (int i = 0; i < array.Length; i++)
    {
 Console.Write(array[i] + " ");
    }
 Console.WriteLine();
}