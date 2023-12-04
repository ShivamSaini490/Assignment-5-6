using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("Outer try block: Start");

            try
            {
                Console.WriteLine("Inner try block: Start");

                int result = DivideByZero();
                Console.WriteLine("Result: " + result);

                Console.WriteLine("Inner try block: End");
            }
            catch (Exception innerException)
            {
                Console.WriteLine("Inner catch block: " + innerException.Message);
            }

            Console.WriteLine("Outer try block: End");
        }
        catch (Exception outerException)
        {
            Console.WriteLine("Outer catch block: " + outerException.Message);
        }

        Console.WriteLine("Program continues...");
    }

    static int DivideByZero()
    {
        int numerator = 10;
        int denominator = 0;

        return numerator / denominator;
    }
}


//Explanation of the flow of execution:

// 1. The program enters the outer try block.
// 2. Inside the outer try block, it enters the inner try block.
// 3. Within the inner try block, the DivideByZero() method is called, which intentionally throws a DivideByZeroException.
// 4. The DivideByZeroException is caught by the inner catch block, and a message is printed.
// 5. The inner try block is completed, and the program continues to execute the outer try block.
// 6. The outer catch block catches the same exception that was thrown in the inner try block.
// 7. The outer catch block prints a message and handles the exception.
// 8. The program continues with the "Program continues..." message and any subsequent code.