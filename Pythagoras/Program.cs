string input;
double a, aPow2, b, bPow2, c;

// Get input for a
do
{
    Console.WriteLine("Input a²: ");
    input = Console.ReadLine();
}
while (!double.TryParse(input, out aPow2));

// Get input for b
do
{
    Console.WriteLine("Input b²: ");
    input = Console.ReadLine();
}
while (!double.TryParse(input, out bPow2));

a = Math.Sqrt(aPow2);
b = Math.Sqrt(bPow2);

c = a + b;

Console.WriteLine($"a² + b² = c²\nc = {c}");

if (a > b)
{
    Console.WriteLine($"a was bigger. ({a} > {b})");
}
else
{
    Console.WriteLine($"b was bigger. ({b} > {a})");
}