int firstSize = InputInt("What size of the string array? ");
string[] magazine = new string[firstSize];
FillStringArray(magazine);






void FillStringArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = InputString("Enter element: ");
    }
}

string InputString(string output)
{
    Console.WriteLine(output);
    return Console.ReadLine();
}

int InputInt(string output)
{
    Console.WriteLine(output);
    return Convert.ToInt32(Console.ReadLine());
}