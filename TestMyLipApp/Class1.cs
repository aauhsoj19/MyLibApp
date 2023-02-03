//Joshua Roasa, Molisha Khosla, Angel Robles
using static System.Console;

namespace TestMyLipApp

{
    public class Class1
    {
        static void Main(string[] args)
        {

            Double numOne, numTwo, numThree;

            Write("Enter your first number: ");
            numOne = Convert.ToDouble(ReadLine());
            Write("Enter your second number: ");
            numTwo = Convert.ToDouble(ReadLine());
                    
            WriteLine("{0} to the power of {1} is {2} ", numOne, numTwo, MyLibApp.Pow.pow(numOne, numTwo));

            Write("Enter your third number: ");
            numThree = Convert.ToDouble(ReadLine());

            WriteLine("{0} to the power of {1} is {2} ", MyLibApp.Pow.pow(numOne, numTwo), numThree, MyLibApp.Pow.pow(numOne, numTwo, numThree));
        }
    }
}