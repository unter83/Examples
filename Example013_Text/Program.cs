string text = Console.ReadLine();

string Replace (string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int letter_count = text.Length;
    for (int i = 0; i < letter_count; i++)
    {
        if (text[i] == oldValue)
            result = result + $"{newValue}"; 
         else
           result = result  + $"{text[i]}"; 
    }
    return result;
}

string newText = Replace (text, ' ', '_');

Console.WriteLine(newText);
