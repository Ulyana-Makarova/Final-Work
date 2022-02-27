string[] array = { "103", "Fljg", "Hello", ":-)" };
Result(array);
void Result(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3) Console.WriteLine($"{array[i]} ");
    }
    Console.Write(" ");
}