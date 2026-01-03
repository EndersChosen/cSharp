using System;


class Program
{
    static void Main()
    {
        Random dice = new();
        int roll = dice.Next(1,7);
        Console.WriteLine(roll);
        int result = Random.Next();
        Console.WriteLine(result);
    }
}