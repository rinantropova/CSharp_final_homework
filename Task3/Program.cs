// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 


int[] CreateArrayRndInt(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < size; i++)
    {
        arr[i] = rnd.Next(min, max);
    }

    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1)
        {
            Console.Write($"{arr[i]}, ");
        }
        else
        {
            Console.Write($"{arr[i]}");
        }
    }
    Console.Write("]");
}

void ReverseArray(int[] arr, int firstIndex, int lastIndex)
{
    if (firstIndex >= lastIndex) return;
    int temp = arr[firstIndex];
    arr[firstIndex] = arr[lastIndex];
    arr[lastIndex] = temp;
    ReverseArray(arr, firstIndex + 1, lastIndex - 1);
}

int[] array = CreateArrayRndInt(7, 0, 100);
Console.Write("Original array: ");
PrintArray(array);
Console.WriteLine();

ReverseArray(array, 0, array.Length - 1);

Console.Write("Reversed array: ");
PrintArray(array);