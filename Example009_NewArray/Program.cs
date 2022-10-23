int Max (int arg, int max)
{
    if (arg > max) max = arg;
    return max;
}

int[] array = {1, 34, 53, 64, 677, 23, 85, 4003, 22};
short i = 0;
int max = array[0];
while (i < 9)
 {
    max = Max(array[i], max);
    i++;
}
Console.WriteLine(max);