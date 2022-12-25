/* Имеется одномерный массив array из n элементов,
требуется найти элемент массива, равный find*/



int[] array = new int[] {15, 1, 9, 8, 12, 40, 98, 0, 56, 41, 66, 12};
int n = array.Length;
int find = 12;
int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine($"Index of {find} in this array is : {index}!");
        break;
    
    }
    index++;
}



/*int[] array = { 1, 12, 31, 4, 18, 15, 16, 71, 18 };

int n = array.Length;
//Console.WriteLine(array.Length);

int find = 18;

int index = 0;

while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}*/