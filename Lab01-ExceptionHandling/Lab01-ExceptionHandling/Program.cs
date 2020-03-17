﻿using System;

namespace Lab01_ExceptionHandling
{
    class Program
    {
        // MAIN METHOD
        static void Main(string[] args)
        {
            // Call StartSequenc

            // Catch Generic Errors (Anything the methods further up the stack miss)

            // Include Finally Block to finish off program

        }

        // STARTSEQUENCE METHOD
        static void StartSequence()
        {
            // Prompt user for "Length", and Convert string to int

            // Instantiate an int array matching their chosen length

            // Call The Populate, GetSum, GetProduct, and GetQuotient methods on that array, in order

            // Output all input and mathematic details back to the console screen

            // Catch all Format and Overflow Exceptions properly

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