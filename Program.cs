Console.WriteLine("Введите количество элементов");
int size = int.Parse(Console.ReadLine()!);

string[] array = CreateArray(size);
string [] arrayNew = FilterArray(array);
PrintArray(arrayNew);

string[] FilterArray(string[] array) {
    string[] arrayNew = new string[array.Length];
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            arrayNew[count] = array[i];
            count++;
        }
    }

    Array.Resize(ref arrayNew, count);
    return arrayNew;
}

string[] CreateArray (int size)
{
    string[] array = new string[size];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1}-й элемент: ");
        array[i] = Console.ReadLine()!;
    }

    return array;
}

void PrintArray (string[] array)
{
    Console.WriteLine($"Итоговый массив");
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine(array[i]);
    }
}

