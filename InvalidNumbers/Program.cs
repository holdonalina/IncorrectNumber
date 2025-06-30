Console.WriteLine("Enter the first number:");
  string numberA = Console.ReadLine();

  Console.WriteLine("Enter the operator(+, -, * or /):");
  string operators = Console.ReadLine();

  Console.WriteLine("Enter the second number:");
  string numberB = Console.ReadLine();

try
{
    int a = int.Parse(numberA);
    int b = int.Parse(numberB);

  double result = operators switch
    {
        "+" => a + b,
        "-" => a - b,
        "*" => a * b,
        "/" => a / b,
    };

    Console.WriteLine($"{a} {operators} {b} = {result}");
}
catch (FormatException)
{
    Console.WriteLine("Invalid symbols");
}

