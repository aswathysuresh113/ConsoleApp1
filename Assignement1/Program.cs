
//Ask the user to enter two numbers and print their sum and product on screen.

Console.Write("Enter the first number:");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the Second number:");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Sum of the two numbers :{num1 + num2}");
Console.WriteLine($"Product of the two numbers:{num1 * num2}");

//Declare 3 variables a, b and c. Get the input from the user for these variables. Implement the equation (((a + b) / c) * a)

Console.Write("Enter the value of a:");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the value of b:");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the value of :c");
int c = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The result of (((a + b) / c) * a) is :{(((a +b)/c)*a) }");


