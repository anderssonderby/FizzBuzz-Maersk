namespace FizzBuzz_Maersk;

public class Program
{
    static void Main()
    {
        FizzBuzz fizz = new();

        var inputArray = new int[] { 1, 2, 3, 4, 5, 6, 15 };

        var result = fizz.CalculateFizzBuzz(inputArray);

        foreach (var r in result)
        {
            Console.WriteLine(r);   
        }
    }
}