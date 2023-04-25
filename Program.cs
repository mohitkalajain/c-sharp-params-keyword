using System;

namespace Use_of___params__keyword
{
    //What is the purpose of “params” keyword
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Addition(10, 20, 30, 40);
            Console.WriteLine(result);
        }

        //This code adds up all the numbers in an array and returns the total.
        public static int Addition(params int[] numbers)
        {
            //Declare a variable to store the total
            int total = 0;
            //Loop through the array
            for (int i = 0; i < numbers.Length; i++)
            {
                //Add the current number to the total
                total += numbers[i];
            }
            //Return the total
            return total;
        }
    }
}
