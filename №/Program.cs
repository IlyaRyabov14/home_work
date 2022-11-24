string [] text = new string [4];

void FullArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите слово: ");
        array[i] = Console.ReadLine() ?? "";
    }
}
FullArray(text);