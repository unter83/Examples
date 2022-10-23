Console.WriteLine("Find the N element of one-dimensional array");
Console.WriteLine("___________________________________________");
Console.WriteLine("");
Console.WriteLine("Enter the lenth of array");
int a_length = Convert.ToInt32(Console.ReadLine());
if (a_length > 0)
{
    int[] array = new int[a_length];
    int i = 0;
    Console.WriteLine($"Enter {a_length} elements ");

    while (i < a_length)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }

    Console.Write("Enter the N'th element you want to find ");
    i = Math.Abs(Convert.ToInt32(Console.ReadLine()));

    if (i == 0)
        Console.Write("You entered 0 elements");
    else
       if (i <= a_length)
        Console.Write($"The {i}'th element of your array is " + array[i - 1]);
    else
        Console.Write("Amount of elements in your array is less than you enered");
}
else 
    Console.Write("Error! Write not 0 and positive ammout of elements for array");
/*
switch (i)
{
  case == 0: 
    Console.Write("You entered 0 elements"); break;
  case <= a_length: 
    Console.Write($"The {i}'th element of your array is " + array[i-1]); break;
  case > a_length: 
    Console.Write("Amount of elements in your array is less than you enered"); break;
}

if (i <= a_length)
    Console.Write($"The {i}'th element of your array is " + array[i-1]);
else
    Console.Write("Amount of elements in your array is less than you enered");
    */