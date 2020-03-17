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
                Console.WriteLine($"Your array is size: {length}";
                Console.WriteLine($"The numbers in the array are ${numArray[0]}");
                for (int i = 1; i < numArray.Length; i++)
                    Console.Write($",{numArray[i]}");
                Console.WriteLine($"The sum of the array is {sum}");
                Console.WriteLine($"{sum} * {product / sum} = {product}");
                Console.WriteLine($"{product} / {product / quotient} = {quotient}");
            }
            // Catch all Format and Overflow Exceptions properly
            catch (FormatException e)
            {
                Console.WriteLine($"There was a formatting exception. The message is: \n{e}");
            }
            catch(OverflowException e)
            {
                Console.WriteLine($"There was an overflow exception. The message is: \n{e}");
            }
        }

        // POPULATE METHOD
        static int[] Populate(int[] numArray)
        {
            // Request a number for each index in the array from the user
            // Convert strings to ints along the way

            // Once the array is filled, return the populated array

            // no expected exceptions!
        }

        // GETSUM METHOD
        static int GetSum(int[] numArray)
        {
            // create new int "sum"
            // iterate through the array, adding all numbers together

            // "throw" a custom exception if sum is less than 20

            // return the sum
        }

        // GETPRODUCT METHOD
        static int GetProduct(int[] numArray, int sum)
        {
            // request a number between 1 and numArray length

            // declare int product as sum times the random index they picked in the array

            // return product
            
            // catch indexoutofrange exception, output the message of the exception, then throw it back down all the way to Main
        }

        // GETQUOTIENT METHOD
        static decimal GetQuotient(int product)
        {
            // integrating the product, ask the user for a number to divide it by

            // use decimal.Divide() to get the quotient of the product and the dividend

            // return the quotient

            // catch the dividebyzero exception, display the message and return 0. DO NOT THROW TO MAIN.
        }
    }
}
