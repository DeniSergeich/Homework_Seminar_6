Console.Clear();
Console.Write("Введите массив чисел через пробел: ");
string messege = Console.ReadLine()!;
string[] arrayString = messege.Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[] arrayInt = GetIntArray(arrayString);
PrintResult();
int[] GetIntArray(string[] array)
{
    int[] intArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        intArray[i] = int.Parse(array[i]);
    }
    return intArray;
}
int GetResult(int[] array)
{
    int count = 0;
    foreach (var item in array)
    {
        if (item > 0) count++;
    }
    return count;
}
void PrintResult()
{
    Console.WriteLine($"Пользователь ввел {GetResult(arrayInt)} числа(чисел) больше 0.");
}