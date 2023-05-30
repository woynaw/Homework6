int[] InputArray(int arg)
{
    int[] array = new int[arg];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
void PrintArray(int[] array)
{

    Console.Write("[");

    for (int i = 0; i < array.Length; i++)
    {
        if (i == array.Length - 1) System.Console.Write($"{array[i]}");
        else System.Console.Write($"{array[i]},");
    }
    Console.Write("]");
}
int Positive(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}
Console.WriteLine("Введите M");
int m = Convert.ToInt32(Console.ReadLine());
int[] array = InputArray(m);
PrintArray(array);
Console.WriteLine($" -> {Positive(array)}");