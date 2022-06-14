Console.Write("Введите количество элементов массива, которые хотите ввести: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] array1 = new string[n];
string[] array2 = new string[n];

CreatyArray(array1);
PrintArray1(array1);
SearchArrayElements(array1, array2);
PrintArray2(array2);

//entering an array from the keyboard
void CreatyArray(string[] array)
{
    for (int i = 0; i < n; i++)
    {
        array[i] = Console.ReadLine();
    }
}

//printing an array entered from the keyboard
void PrintArray1(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        if (i == array.Length - 1)
            Console.Write(array[i] + " -> ");
        else
            Console.Write($"{array[i]} ");
}

//checking the size of array elements
void SearchArrayElements(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}

//printing an array with elements of the specified size
void PrintArray2(string[] array)
{ 
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }    
}
