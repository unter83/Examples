void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int position = 0;
    while (position < col.Length)
    {
        Console.Write(col[position] + " ");
        position++;
    }
}

int IndexOf(int[] collection, int find)
{
    int index = 0;
    int position = -1;
    while (index < collection.Length)
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
array[4] = 4;
array[6] = 4;
PrintArray(array);

Console.WriteLine();

int pos = IndexOf(array, 44);
Console.WriteLine(pos);