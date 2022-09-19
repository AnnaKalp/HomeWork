Console.WriteLine("Ввведите число");
string input1 = Console.ReadLine();
int number1 = int.Parse(input1);

Console.WriteLine("Ввведите число");
string input2 = Console.ReadLine();
int number2 = int.Parse(input2);
if(number1>number2)
{
    Console.WriteLine($"max={number1},min={number2}");
}
else 
{
    Console.WriteLine($"min={number1},max={number2}");
}

