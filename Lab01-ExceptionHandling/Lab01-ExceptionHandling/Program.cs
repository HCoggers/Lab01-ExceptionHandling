using System;

namespace Lab01_ExceptionHandling
{
    class Program
    {
        // MAIN METHOD
        static void Main(string[] args)
        {
            try
            {
                // Call StartSequence
                StartSequence();
            }
            // Catch Generic Errors (Anything the methods further up the stack miss)
            catch (Exception e)
            {
                Console.WriteLine("I'm sorry, something went wrong. Let's restart.");
                Console.WriteLine($"The Exception was: {e.Message}");
            }
            // Include Finally Block to finish off program
            finally
            {
                Console.WriteLine("Program is complete.");
            }
        }

        // STARTSEQUENCE METHOD
        static void StartSequence()
        {
            // Prompt user for "Length", and Convert string to int
            try
            {
                Console.WriteLine("Welcome to my game! Let's do some math!\n" +
                "Please enter a number greater than zero");
                string inputLength = Console.ReadLine();
                int length = Convert.ToInt32(inputLength);

                // Instantiate an int array matching their chosen length
                int[] numArray = new int[length];

                // Call The Populate, GetSum, GetProduct, and GetQuotient methods on that array, in order
                numArray = Populate(numArray);
                int sum = GetSum(numArray);
                int product = GetProduct(numArray, sum);
                decimal quotient = GetQuotient(product);

                // Output all input and mathematic details back to the console screen
                Console.WriteLine($"Your array is size: {length}");
                Console.Write($"The numbers in the array are {numArray[0]}");
                for (int i = 1; i < numArray.Length; i++)
                    Console.Write($",{numArray[i]}");
                Console.WriteLine($"\nThe sum of the array is {sum}");
                Console.WriteLine($"{sum} * {product / sum} = {product}");
                Console.WriteLine($"{product} / {((quotient != 0) ? (product / quotient) : quotient)} = {quotient}");
            }
            // Catch all Format and Overflow Exceptions properly
            catch (FormatException e)
            {
                Console.WriteLine($"There was a formatting exception. The message is: \n{e.Message}");
            }
            catch(OverflowException e)
            {
                Console.WriteLine($"There was an overflow exception. The message is: \n{e.Message}");
            }
        }

        // POPULATE METHOD
        static int[] Populate(int[] numArray)
        {
            // Request a number for each index in the array from the user
            for(int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine($"Please enter number: {i + 1} of {numArray.Length}");
                // Convert strings to ints along the way
                string inputNum = Console.ReadLine();
                numArray[i] = Convert.ToInt32(inputNum);
            }
            // Once the array is filled, return the populated array
            return numArray;
            // no expected exceptions!
        }

        // GETSUM METHOD
        static int GetSum(int[] numArray)
        {
            // create new int "sum"
            int sum = 0;
            // iterate through the array, adding all numbers together
            foreach (int num in numArray)
                sum += num;

            // "throw" a custom exception if sum is less than 20
            if (sum < 20)
                throw (new Exception($"Value of {sum} is too low"));
            // return the sum
            return sum;
        }

        // GETPRODUCT METHOD
        static int GetProduct(int[] numArray, int sum)
        {
            try
            {
                // request a number between 1 and numArray length
                Console.WriteLine($"Please select a number between 1 and {numArray.Length}");
                string inputIdx = Console.ReadLine();

                // declare int product as sum times the random index they picked in the array
                int multiplier = numArray[Convert.ToInt32(inputIdx)];
                int product = sum * multiplier;

                // return product
                return product;
            }
            // catch indexoutofrange exception, output the message of the exception, then throw it back down all the way to Main
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine($"There was an Index exception: {e.Message}");
                throw;
            }
        }

        // GETQUOTIENT METHOD
        static decimal GetQuotient(int product)
        {
            decimal quotient;
            try
            { 
                // integrating the product, ask the user for a number to divide it by
                Console.WriteLine($"Please enter a number to divide your product {product} by");
                string inputDiv = Console.ReadLine();
                decimal divisor = Convert.ToDecimal(inputDiv);

                // use decimal.Divide() to get the quotient of the product and the dividend
                quotient = decimal.Divide(product, divisor);
            }
            catch (DivideByZeroException e)
            {
                // catch the dividebyzero exception, display the message and return 0. DO NOT THROW TO MAIN.
                Console.WriteLine($"There was a dividing exception:\n" +
                    $"{e.Message}");
                return 0;
            }
            // return the quotient
            return quotient;
        }
    }
}
