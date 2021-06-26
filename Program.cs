using System;

namespace Fibonacci__
{
    /*Write a function called () that takes one integer number as parameter. The function will find Fibonacci series and then print the results on the screen.
     Input: 10
     Output: 0 1 1 2 3 5 8 13 21 34 
    */
    class Program
    {
        static void Main(string[] args)
        {
            //enter how many Fibonacci numbers you want to print
            int fibonaccilength;

            //Here f1 and f2 are two Fibonacci numbers which are used to find the next Fibonacci number
            int f1 = 0, f2 = 1, f3;

            //prompt message on the console about Fibonacci number
            Console.WriteLine("Please enter how many fibonacci numbers you want:");

            //Reads the next line of characters from the standard input stream and store it in a variable
            fibonaccilength = int.Parse(Console.ReadLine());

            //printing 0 and 1
            Console.Write(f1 + " " + f2 + " ");
            
            //loop starts from 2 because 0 and 1 are already printed
            for (int i=2; i < fibonaccilength; ++i)
            {
                //fibonacci logic is  ; the current number is the sum of the 2 preceding number
                f3 = f1 + f2;

                //print the newly created Fibonacci number
                Console.Write(f3 + " ");

                //now set the latest 2 preceding numbers to find the next Fibonacci number
                f1 = f2;
                f2 = f3;


            }

            Console.WriteLine(" ");
        }
    }
}
