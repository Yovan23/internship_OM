using MyApp;

class Method
{
    public void PredefinedMethod()
    {
        string str = "Hello World";
        Console.WriteLine($"ToUpper() --> {str.ToUpper()}");
        Console.WriteLine($"Math.Sqrt(x) --> {Math.Sqrt(25)}");
    }

    public void UserDefinedMethod()
    {
        Console.WriteLine("This is a user defined method");
    }

    public static void StaticMethod()
    {
        Console.WriteLine("This is a static method");
    }

    public void MethodWithParameters(int x, int y)
    {
        Console.WriteLine($"Sum of {x} and {y} is {x + y}");
    }

    public int MethodWithReturn()
    {
        Console.WriteLine("This method returns a value");
        int x = 5;
        int y = 10;
        return x + y;
    }

    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b) // Overloaded method
    {
        return a + b;
    }

    public void Greet(string name = "Guest")
    {
        Console.WriteLine($"Hello, {name}!");
    }

    public int Factorial(int n)
    {
        if (n == 0) return 1;
        return n * Factorial(n - 1);
    }

    public static async Task DoWorkAsync()
    {
        Console.WriteLine("Task Started...");
        await Task.Delay(2000);  // Simulate 2 sec delay
        Console.WriteLine("Task Completed.");
    }


}

public static class StringExtensions
{
    public static void ExtensionMethod(this string str)
    {
        Console.WriteLine(str);
    }
}
