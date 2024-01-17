using System;

namespace Maths_Functions
{
    using System;

    class MathFunctions
    {
        static void Main()
        {
            // Example usage
            int result = AddInts(3, 5);
            Console.WriteLine("Addition Result: " + result);

            result = SubtractInts(8, 3);
            Console.WriteLine("Subtraction Result: " + result);

            result = MultiplyInts(4, 6);
            Console.WriteLine("Multiplication Result: " + result);

            result = DivideInts(10, 2);
            Console.WriteLine("Division Result: " + result);

            result = SquareInt(7);
            Console.WriteLine("Square Result: " + result);
        }

        // A and B should be added together and returned
        static int AddInts(int a, int b)
        {
            int sum = 0;
            return sum;
        }

        // A and B should be subtracted from eachother and returned
        static int SubtractInts(int a, int b)
        {

            int sum = 0;
            return sum;
        }

        //A should be multiplied by B and returned
        static int MultiplyInts(int a, int b)
        {
            int sum = 0;
            return sum;
        }

        //Divide A against B, and return the sum. Think about what happens if b is 0!
        static int DivideInts(int a, int b)
        {
            if (b != 0)
            {
                int sum = 0;
                return sum;
            }
            else
            {
                Console.WriteLine("Cannot divide by zero.");
                return 0;
            }
        }

        //Return the square of a
        static int SquareInt(int a)
        {
            int sum = 0;
            return sum;
        }

        //Return the remainder of a/b 
        static int GetRemainder(int a, int b)
        {
            return 0;
        }

        //Return if a number is even or not
        static bool IsEven(int a)
        {
            bool x = false;
            return x;
        }
    }
}
