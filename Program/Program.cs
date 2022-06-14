string[] array1 = new string[10] {"dog", "cat", "hello", "world", "99999", "qwe", "1", "5467", "king", "Task"};
string[] array2 = new string[array1.Length];

SecondArrayWithIF(array1, array2);
PrintArray(array2);

//checking the size of array elements
void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

//printing an array with elements of the specified size
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
