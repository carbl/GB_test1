string [] array = new string [] {"hello", "2", "world", ":-)", "1234", "-2", "Russia"};
int m = 0;
for (int i = 0; i < array.Length; i++) if (array[i].Length <= 3) m++;
string [] arrayOut = new string [m];
m = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i].Length <= 3)
    {
        arrayOut[m] = array[i];
        m++;
    }
}

Console.Write("[");
WriteArray(array);
Console.Write("] -> [");
WriteArray(arrayOut);
Console.WriteLine("]");

//Метод
void WriteArray (string [] writeArr)
{
    for (int i = 0; i < writeArr.Length-1; i++)
    {
        Console.Write($"{writeArr[i]}, ");
    }
    Console.Write($"{writeArr[writeArr.Length-1]}");
}
