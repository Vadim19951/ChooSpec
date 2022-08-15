int firstSize = InputInt("What size of the string array? ");
string[] magazine = new string[firstSize];
FillStringArray(magazine);
int secondSize = GetCount(magazine);
string[] newMagazine = new string[secondSize];
FillCleanArray(magazine, newMagazine);
PrintMagazine(newMagazine);

void PrintMagazine(string[] newMagazine)
{    Console.WriteLine("New array of the strings");
    for (int i = 0; i < newMagazine.Length; i++)
    {
        Console.Write($"{newMagazine[i]}, ");
    }
}

void FillCleanArray(string[] array, string[] array2)
{
    for (int i = 0; i < array2.Length; i++)
    {
        string temp = String.Empty;
        for (int j = 0; j < array.Length; j++)
        {
            temp = array[j];
            if (temp.Length <= 3)
            {
                array2[i] = temp;
                i++;
            }
            temp = String.Empty;
        }
    }
}

int GetCount(string[] array)
{
    string temp = String.Empty;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        temp = array[i];
        if (temp.Length <= 3)
        {
            count++;
        }
    }
    return count;
}

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