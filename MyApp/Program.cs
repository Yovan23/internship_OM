using System;

// ----> Encapsulation: Using properties to control access to fields
class Person
{
    private string name;
    public int Age { get; set; } // Auto-implemented property

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

// ----> Inheritance: Base class
class car
{
    public string? carName { get; set; }
    public void Start()
    {
        Console.WriteLine($"{carName} is Start.");
    }
}

// Derived class
class Engine : car
{
    public void run()
    {
        Console.WriteLine($"{carName} engine run .");
    }
}

// ----> Polymorphism: Method Overriding
class Shape
{
    public virtual void Draw()
    {
        Console.WriteLine("Drawing a shape");
    }
}

class Circle : Shape
{
    public override void Draw()
    {
        Console.WriteLine("Drawing a Circle");
    }
}

// ----> Abstraction: Abstract Class
abstract class Vehicle
{
    public abstract void Move();
}

class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine("Car is moving on the road");
    }
}
namespace MyApp
{
class Program
{
    // ----> Readonly Variable
    public readonly int maxLimit;

    public Program(int limit)
    {
        maxLimit = limit; // Allowed inside constructor
    }

    static void Main()
    {
        Console.WriteLine("Hello, World!");

        WorkWithIntegers();
        DataTypesDemo();
        TypeConversionDemo();
        VariableScopeDemo();
        loopsDemo();
        oopsDemo();
        // Day 2 code 
        // Day2 day2 = new Day2();
        Console.WriteLine("----------------------------------Day 2 code:--------------------------------");
        Console.WriteLine("-------------------------> List");
        list.ListDemo();
        Console.WriteLine("-------------------------> Type of Methods");
        Method method = new Method();
        method.PredefinedMethod();
        method.UserDefinedMethod();
        Method.StaticMethod(); // Call without creating an object
        method.MethodWithParameters(5, 10);
        Console.WriteLine($"Addition: {method.Add(5, 10)}");
        Console.WriteLine($"Addition: {method.Add(5.5, 10.5)}");  // Overloaded method
        method.Greet();
        method.Greet("Yovan");
        method.Greet(name: "Jay");  // Named arguments
        Console.WriteLine($"Factorial: {method.Factorial(5)}"); // Recursion
        Method.DoWorkAsync();
        Console.WriteLine("Main Method Finished.");
        Linq.XYZ();


        // ----> Constants
        // Value must be assigned at declaration.
        // Cannot be changed later.
        const double pi = 3.14;
        Console.WriteLine($"Constant Pi Value: {pi}");

        // ----> Readonly Variable
        // Can be assigned in constructor (unlike const).
        // Value cannot change after initialization.
        Program example = new Program(500);
        Console.WriteLine($"Readonly maxLimit: {example.maxLimit}");
    }

    static void WorkWithIntegers()
    {
        int a = 5, b = 2;
        Console.WriteLine($"Addition: {a + b}");
        Console.WriteLine($"Subtraction: {a - b}");
        Console.WriteLine($"Multiplication: {a * b}");
        Console.WriteLine($"Integer Division: {a / b}");
        Console.WriteLine($"Double Division: {(double)a / b}");

        Console.WriteLine($"The range of integers is {int.MinValue} to {int.MaxValue}");
    }

    static void DataTypesDemo()
    {
        // ----> Value Types (Stored in Stack)
        int num = 100;   // 4 bytes
        float pi = 3.14f; // 4 bytes
        char grade = 'A'; // 2 bytes
        bool isPassed = true;  // 1 byte
        double d = 123.456; // 8 bytes
        decimal money = 100.5m; // 16 bytes
        byte b = 5; // 1 byte

        Console.WriteLine($"Int: {num}, Float: {pi}, Char: {grade}, Bool: {isPassed}, Double: {d}, Decimal: {money}, Byte: {b}");

        // ----> Reference Types (Stored in Heap)
        string name = "Yovan"; // 2 bytes per character
        object obj = new object(); // 4 bytes
        Console.WriteLine($"String: {name}, Object: {obj}");


        // ----> Nullable Types
        // By default, value types cannot store null. To allow null, use nullable types (?).
        int? x = null;  // -> Use HasValue to check if a nullable type contains a value
        Console.WriteLine(x.HasValue ? $"Value: {x.Value}" : "x is null");
    }

    static void TypeConversionDemo()
    {
        // ----> Type Conversion in C#

        // Implicit Conversion (Automatically)(safe) - No data loss , smaller to larger
        int num = 100;
        double d = num;
        Console.WriteLine($"Implicit Conversion: {d}");

        // Explicit Conversion (Manually)(unsafe) - Data loss , larger to smaller
        double d2 = 123.45;
        int num2 = (int)d2;
        Console.WriteLine($"Explicit Conversion: {num2}");

        // ----> Type Conversion Methods

        // Convert.ToType()
        string strNum = "100";
        int parsedNum = Convert.ToInt32(strNum);
        Console.WriteLine($"Convert.ToInt32: {parsedNum}");

        // Type.Parse() - Throws exception if conversion fails
        int parsedNum2 = int.Parse(strNum);  // faster than Convert.ToInt32()
        Console.WriteLine($"int.Parse: {parsedNum2}");

        // TryParse() - Returns a boolean value
        int result;
        bool success = int.TryParse(strNum, out result);
        Console.WriteLine(success ? $"TryParse succeeded: {result}" : "TryParse failed");
    }

    static void VariableScopeDemo()
    {
        // ----> Variables Scope and Lifetime
        // Scope: The region where the variable is accessible.
        // Lifetime: The duration for which the variable exists in memory.

        // Local Variables: Declared inside a method or block. 
        //               -> Only accessible in that block.
        void Test()
        {
            int localVar = 10; // Only accessible in Test()
            Console.WriteLine($"Local Variable: {localVar}");
        }
        Test();

        // Static Variables: Belong to the class rather than an object.
        //               -> Shared among all instances of the class.

        Example ex1 = new Example();
        Example ex2 = new Example();
        ex1.IncrementCount();
        ex2.IncrementCount();
        Console.WriteLine($"Static Count: {Example.count}");

        // Global Variables: Declared at the class level.
        //               -> Accessible throughout the class.
        //               -> Not recommended due to maintainability issues.
          // class Example
          // {
          // int globalVar = 100; // Accessible inside the class
           // }

}

static void loopsDemo()
{

        // For Loop
      Console.WriteLine("for loop");
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine($"For Loop: {i}");
    }

    // While Loop
    Console.WriteLine("while loop");
    int j = 0;
    while (j < 5)
    {
        Console.WriteLine($"While Loop: {j}");
        j++;
    }

    // Do-While Loop
    Console.WriteLine("do-while loop");
    int k = 0;
    do
    {
        Console.WriteLine($"Do-While Loop: {k}");
        k++;
    } while (k < 5);

    // Foreach Loop
    Console.WriteLine("foreach loop");
    string[] names = { "Yovan", "Jay", "Joy" };
    foreach (string name in names)
    {
        Console.WriteLine($"Foreach Loop: {name}");
    }
}

static void oopsDemo()
{
     // Encapsulation
        Person person = new Person { Name = "Yovan", Age = 22 };
        person.DisplayInfo();

        // Inheritance
        Engine xyz = new Engine { carName = "BMW" };
        xyz.Start();
        xyz.run();

        // Polymorphism
        Shape shape = new Circle();
        shape.Draw();

        // Abstraction
        Vehicle vehicle = new Car();
        vehicle.Move();
}

class Example
{
    public static int count = 0; // Shared across all objects
    public void IncrementCount()
    {
        count++;
    }
}
}
}