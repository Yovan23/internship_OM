namespace MyApp;

class list
{
    public static void ListDemo()
    {
        List<int> numbers = new List<int> { 1, 5, 3, 8, 6, 2 };
        numbers.Add(6);
        numbers.Add(7);
        numbers.Remove(5);
        Console.WriteLine(string.Join(", ", numbers));
        Console.WriteLine($"Count: {numbers.Count}");
        int index = numbers.IndexOf(4);
        if(index != -1){
            Console.WriteLine($"Index of 4: {index}");
        } else {
            Console.WriteLine("4 not found");
        }

        numbers.Sort();
        Console.WriteLine(string.Join(", ", numbers));
    }
}
