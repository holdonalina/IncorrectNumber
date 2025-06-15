Console.WriteLine("Enter the first number:");
bool numberA = double.TryParse(Console.ReadLine(), out double a);


Console.WriteLine("Enter the operator(+, -, * or /):");
string operators = Console.ReadLine();

Console.WriteLine("Enter the second number:");
bool numberB = double.TryParse(Console.ReadLine(), out double b);

try
{
  if (!numberA || !numberB)
  {
    throw new FormatException("Incorrect symbols");
  }

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
  Console.WriteLine("Incorrect symbols");
}