using FizzBuzz_Maersk;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz_Test
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void CalculateFizzBuzz_FizzArray_ExpectFizz()
        {
            // Arrange
            var input = new int[] { 3, 6, 9 };
            FizzBuzz fizzBuzz = new();

            // Act
            var result = fizzBuzz.CalculateFizzBuzz(input);

            // Assert
            var expected = new string[] {"Fizz", "Fizz", "Fizz"};
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateFizzBuzz_InValidArray_ExpectFizzFail()
        {
            // Arrange
            var input = new int[] { 3, 10, 15 };
            FizzBuzz fizzBuzz = new();

            // Act
            var result = fizzBuzz.CalculateFizzBuzz(input);

            // Assert
            var expected = new string[] { "Fizz", "Fizz", "Fizz" };
            CollectionAssert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void CalculateFizzBuzz_BuzzArray_ExpectBuzz()
        {
            // Arrange
            var input = new int[] { 5, 10, 20 };
            FizzBuzz fizzBuzz = new();

            // Act
            var result = fizzBuzz.CalculateFizzBuzz(input);

            // Assert
            var expected = new string[] { "Buzz", "Buzz", "Buzz" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateFizzBuzz_InValidArray_ExpectBuzzFail()
        {
            // Arrange
            var input = new int[] { 3, 10, 15 };
            FizzBuzz fizzBuzz = new();

            // Act
            var result = fizzBuzz.CalculateFizzBuzz(input);

            // Assert
            var expected = new string[] { "Buzz", "Buzz", "Buzz" };
            CollectionAssert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void CalculateFizzBuzz_FizzBuzzArray_ExpectFizzBuzz()
        {
            // Arrange
            var input = new int[] { 15, 30, 45 };
            FizzBuzz fizzBuzz = new();

            // Act
            var result = fizzBuzz.CalculateFizzBuzz(input);

            // Assert
            var expected = new string[] { "FizzBuzz", "FizzBuzz", "FizzBuzz" };
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CalculateFizzBuzz_InValidArray_ExpectFizzBuzzFail()
        {
            // Arrange
            var input = new int[] { 3, 10, 15 };
            FizzBuzz fizzBuzz = new();

            // Act
            var result = fizzBuzz.CalculateFizzBuzz(input);

            // Assert
            var expected = new string[] { "FizzBuzz", "FizzBuzz", "FizzBuzz" };
            CollectionAssert.AreNotEqual(expected, result);
        }

        [TestMethod]
        public void CalculateFizzBuzz_PureNumberArray_ExpectPureNumbers()
        {
            // Arrange
            var input = new int[] { 1, 2, 4 };
            FizzBuzz fizzBuzz = new();

            // Act
            var result = fizzBuzz.CalculateFizzBuzz(input);

            // Assert
            var expected = new string[] { "1", "2", "4" };
            CollectionAssert.AreEqual(expected, result);
        }
    }
}