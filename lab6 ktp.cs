using System;
try
{
    Console.WriteLine("Input integer number");
    string str = Console.ReadLine();
    int num = int.Parse(str);
    Console.WriteLine($"Your number is {num}");
}
catch
{
    Console.WriteLine(
        "You input not integer number"
        );
} 