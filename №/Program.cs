string [] text = new string [4];
string [] result = new string [4];
FullArray(text);
SortArray(text, result);
PrintArray(text,result);
void FullArray(string [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Введите слово: ");
        array[i] = Console.ReadLine() ?? "";
    }
}

void SortArray(string [] array, string [] helpArray)
{
    for(int i = 0; i<array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            helpArray[i] = array[i];
        }
    }
}

void PrintArray(string [] array, string [] helpArray)
{
    Console.Write("(");
    for(int i = 0; i <array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.Write(")-->");
    Console.Write("(");
    for(int i = 0; i <helpArray.Length; i++)
    {
        Console.Write(helpArray[i] + " ");
    }
    Console.Write(")");
}

