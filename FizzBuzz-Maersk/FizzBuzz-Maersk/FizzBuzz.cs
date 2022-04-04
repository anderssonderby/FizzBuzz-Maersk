namespace FizzBuzz_Maersk
{
    public class FizzBuzz
    {
        public string[] CalculateFizzBuzz(int[] input)
        {
            var result = new string[input.Length];

            for (int i = 0; i < input.Length; i++)
            {
                // If input modulo 3 and 5 (divisible by 3 and 5) == 0, print FizzBuzz
                if (((input[i] % 3) == 0) & ((input[i] % 5) == 0))
                {
                    result[i] = "FizzBuzz";
                }
                // If input modulo 3 (divisible by 3) == 0, print Fizz
                else if ((input[i] % 3) == 0)
                {
                    result[i] = "Fizz";
                }
                // If input modulo 3 (divisible by 5) == 0, print Buzz
                else if ((input[i] % 5) == 0)
                {
                    result[i] = "Buzz";
                }
                // If not divisible by 3 or 5, print the number itself
                else
                {
                    result[i] = input[i].ToString();
                }
            }

            return result;
        }
    }
}
