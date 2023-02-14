
string[] Array = new string[3];
for (int i = 0; i <Array.Length; i++)
{   
    Console.Write($"Введите {i+1} элемент массива: ");
    Array[i] = Console.ReadLine();
}
for (int i = 0; i <Array.Length; i++)
{   
    if(Array[i].Length <= 3) Console.WriteLine(Array[i]);
}
