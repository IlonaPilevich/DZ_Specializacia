/// <summary>
/// Задаём первональный и последующий массивы
/// </summary>
/// <value></value>
string[] arrayFirst = new string[] {"hello,world", "597", "array", "cat", "5649", "10"};
string[] arraySecond = new string[arrayFirst.Length];
void FillArray(string[] arrayFirst, string[] arraySecond)
{
    int size = 0;
    for (int i = 0; i < arrayFirst.Length; i++)
    {
    if(arrayFirst[i].Length <= 3)
        {
        arraySecond[size] = arrayFirst[i];
        size++;
        }
    }
}
/// <summary>
/// выводим на печать элементы массива, длинна которых <=3
/// </summary>
/// <param name="arr"></param>
void PrintArray(string[] arr)
{
    for (int j = 0; j < arr.Length; j++)
    {
        Console.Write($"{arr[j]} ");
    }
    Console.WriteLine("- это элементы массива, длинна которых <= 3");
}
FillArray(arrayFirst, arraySecond);
PrintArray(arraySecond);