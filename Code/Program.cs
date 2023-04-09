//  Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string [] CreateArray()
{
    Console.WriteLine("Введите длину строки");
    int N = Convert.ToInt32(Console.ReadLine());
    string [] array = new string [N];
    return array;
}

string [] FillArray(string [] array)
{
    for (int i=0;i<array.Length;i++)
    {
        Console.WriteLine($"Введите значение для {i+1} элемента строки");
        array[i] = Console.ReadLine();
    }
return array;
}

void PrintArray (string [] array)
{
    foreach(string i in array)
    {
        Console.Write($"[{i}] ");
    }
    Console.WriteLine();
}

void DublCheck (int [] array, int temp, string [] array2)
{
    int temp2 = new Random().Next(0,array2.Length);
        for (int j=0;j<array.Length;j++)
        {
            if (array[j]==temp)
            {
                DublCheck(array,temp2, array2);
            }
            else break;
        }
}

string [] NewArray (string [] array)
{
    
    string [] NewArray = new string [new Random().Next(3,3)];
    int [] TempArray = new int [NewArray.Length];
    for (int i=0;i<NewArray.Length;i++)
    {
        int temp = new Random().Next(0,array.Length);
        DublCheck(TempArray, temp, array);
        NewArray[i] = array[temp];
        TempArray[i]=temp;
    }
return NewArray;
}

string [] massive = CreateArray();
FillArray(massive);
PrintArray(massive);

string [] NewMassive = NewArray(massive);
PrintArray(NewMassive);