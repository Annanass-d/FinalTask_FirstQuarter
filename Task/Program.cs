// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам.

string[] arrayFirst = new string[] { "Hello", "all", "worlds", "in", "luv", ":)" };
System.Console.WriteLine($"{String.Join("  ", arrayFirst)}");
string[] arraySecond = GetStringArraySizeEl3(arrayFirst);
System.Console.WriteLine($"{String.Join("  ", arraySecond)}");


string[] GetStringArraySizeEl3(string[] array)
{
    int length = array.Length;
    string[] arrayResult = new string[length];

    int j = 0; // индекс для второго массива

    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayResult[j] = array[i];
            j++;
        }
    }
    return arrayResult;
}
