void FillArray(int[] collection)
{
    int lengt = collection.Length;
    int index = 0;
    while (index < lengt)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] printCollection)
{
    int count = printCollection.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(printCollection[position]);
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);
