Console.WriteLine("Введите слова через пробел: ");
String[] size = Console.ReadLine().Split().ToArray();

Console.WriteLine("Введенные слова: ");
for (int i = 0; i < size.Length; i++) 
{
    Console.Write(size[i] + " ");
}
Console.WriteLine();

Console.WriteLine("Введенные слова с длинною больше или равной 3: ");
for (int i = 0; i < size.Length; i++) 
{
    if (size[i].Length <= 3) 
    {
        Console.Write(size[i] + " ");
    }
}