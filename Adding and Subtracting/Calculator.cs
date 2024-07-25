public class Calculator
{
    public int Add(int a, int b)
    {
        return a + b;
    }
    public int Substract(int a, int b)
    { 
        return a - b; 
    }
}
class Program
{
    static void Main(string[] args)
    {
        Calculator calc = new Calculator();
        int sum = calc.Add(17,4);
        int difference = calc.Substract(80,46);

        Console.WriteLine($"Sum: {sum}, Difference: {difference}");
    }
}