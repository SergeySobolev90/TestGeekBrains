Console.Clear();
string[] GetNewArray(string[] firstArray)
{
    string[] newArray = new string[firstArray.Length];
    int size = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
        if (firstArray[i].Length <= 3)
        {
            newArray[size] = firstArray[i];
            size++;
        }
    }
    Array.Resize(ref newArray, size);
    return newArray;
}
void PrintArray(string[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item} ");
    }
}

string[] firstArray = { "Fytmkkrr", "dkgjdkgj",  ",!", "Hello", "111", "yes",  "hard", "$" };
string[] newArray = GetNewArray(firstArray);
Console.WriteLine("Массив строк:");
PrintArray(firstArray);
Console.WriteLine();
Console.WriteLine("Новый массив:");
PrintArray(newArray);
