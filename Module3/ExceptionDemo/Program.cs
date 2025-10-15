using System;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call method without try/catch bblock (for testing)
            // This will cause an unhandled exception and terminate the program
            // Console.WriteLine(DivideByZero(10)); 

            // Now we use try/catch to handle the exception
            try
            {
                Console.WriteLine(DivideByZeroException(10));
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Caught a DivideByZeroException: {ex.Message}");
            }
            catch (Exception ex)
            {
                // General catch block for all other exceptions
                Console.WriteLine($"Caught an exception: {ex.Message}");
            }
        }

        // Static Method that causes a divide-by-zero exception
        static int DivideByZero(int x)
        {
            return x / 0; // Intentional divide by zero to trigger exception
        }
    }

}
