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

string [] NewArrayCreate (string [] array)
{   
    int count = 0;
    for (int i = 0; i<array.Length;i++)
    {
        if (array[i].Length<=3) count++;
    }
    string [] arrayNew = new string [count];
    return arrayNew;
}

string [] FillNewArray(string [] array, string [] array2)
{
    int j=0;
    for (int i=0;i<array2.Length;i++)
    {
        if (array2[i].Length<=3)
        { 
            array[j]=array2[i];
            j++;
        }
    }
return array;
}

string [] massive = CreateArray();
FillArray(massive);
Console.WriteLine("Ваш старый массив:");
PrintArray(massive);

string [] NewMassive = NewArrayCreate(massive);
FillNewArray(NewMassive,massive);
Console.WriteLine("Ваш новый массив:");
PrintArray(NewMassive);