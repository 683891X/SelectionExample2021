using System;

namespace Week2Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne;
            int numberTwo;
            int sum;

            Console.WriteLine("Please enter the first number: ");
            numberOne = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Please enter the second number: ");
            numberTwo = int.Parse(Console.ReadLine());

            sum = numberOne + numberTwo;

            if(sum > 10){

                Console.WriteLine("Sum of numbers is greater than 10");

            }else{

                Console.WriteLine("Sum of numbers is less than 10");
 
            }

        }
    }
}
