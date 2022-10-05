// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Press 1 for Reverse \nPress 2 for Capitalize \nPress 3 for Lowercase");


var choice = Console.ReadLine();

Console.WriteLine("Input your string");

string stringChoice = Console.ReadLine();

if(choice == "1")
{
    var res = Functions.ReverseString(stringChoice);
    Console.WriteLine(res);
}
if (choice == "2")
{
    var res = Functions.CapitalizeString(stringChoice);
    Console.WriteLine(res);
}
if (choice == "3")
{
    var res = Functions.LowerString(stringChoice);
    Console.WriteLine(res);
}