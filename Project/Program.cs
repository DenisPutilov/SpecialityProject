// Написать программу, которая из имеющегося массива строк сформирует массив из строк, длина которыз меньше или равна 3. 
// Первоначальный массив можно задать с клавиатуры или задать на старте.

string[] CreateArray() // создаем текстовый массив определенной длины
{
    Console.Write("input a number of elements in array: ");
    int size = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[size];

    for(int i = 0; i < size; i++)
    {
        Console.Write($"input {i+1} text element: ");
        array[i] = Console.ReadLine();

        if(array[i] == string.Empty) 
        {
            Console.WriteLine("input some text!");
            i--;
        }

    }
    return array;
}

void ShowArray(string[] array) // печать массива
{
    for(int i = 0; i < array.Length; i++)
    {
        if(i < array.Length - 1) Console.Write(array[i] + ", ");
        else Console.Write(array[i]);
    }
    Console.WriteLine();
}

int NumberOfExectElements(string[] array) // считаем количество элементов в массиве, длина которых меньше или равна 3
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3) sum ++;
    }
    return sum;
}

string[] ChangedArray(string[] array, int sumOfExectElements) // новый массив, включающий только элементы длиной <=3
{
    string[] changedArray = new string[sumOfExectElements];

    for(int i = 0, j = 0; i < array.Length; i++, j++)
    {
        int size = array[i].Length;
        if(size <= 3) 
        {
            changedArray[j] = array[i];
        }
        else j--;
    }
    return changedArray;
}


string[] myArray = CreateArray();
Console.WriteLine("введенный с клавиатуры массив выглядит так:");
ShowArray(myArray);
int sumOfExectElements = NumberOfExectElements(myArray);
string[] newArray = ChangedArray(myArray, sumOfExectElements);
Console.WriteLine("ниже массив, который содержит только элементы длиной менее или равные 3 символам:");
ShowArray(newArray);