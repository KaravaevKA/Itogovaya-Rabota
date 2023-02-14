
string[] Array = new string[3]{"Hello", "World", "23"};

for (int i = 0; i <Array.Length; i++)
{   
    if(Array[i].Length <= 3) Console.WriteLine(Array[i]);
}
