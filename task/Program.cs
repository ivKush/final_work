// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длина которых меньше или равна 3 символа. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] FinalArray(string[] arr)
{
    int size = 0;
    for (int i = 0; i < arr.Length; i++)
        if (arr[i].Length <= 3)
            size++;
    string[] arr1 = new string[size];
    for (int i = 0, j = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            arr1[j] = arr[i];
            j++;
        }
    }
    return arr1;
}

void PrintMass(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}

string[] arr2 = { "Чижик", "Пыжик", "где", "ты", "был", "?" };
string[] arr = FinalArray(arr2);
PrintMass(arr);

