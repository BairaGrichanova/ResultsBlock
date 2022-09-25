string[] NewShortArray(string[] myArray)
{
    string[] newArray = new string[myArray.Length + 1];
    int i, j = 0;
    for (i = 0; i < myArray.Length; i++)
    {
        if (myArray[i].Length < 4)
        {
            newArray[j] = myArray[i];
            newArray[j + 1] = "exit";
            j++;
        }
    }
    return newArray;
}

void ShowArray(string[] myArray)
{
    for (int i = 0; i < myArray.Length; i++)
    {
        if (myArray[i] == "exit") break;
        Console.WriteLine(myArray[i] + ' ');
    }
}

string[] myArray = new string[] { "Hello", "2", "world", ":-)", "1234", "1567", "-2", "computer science", "Rus", "Denmark", "Kaz" };

myArray = NewShortArray(myArray);

ShowArray(myArray);