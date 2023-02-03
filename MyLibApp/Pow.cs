//Joshua Roasa, Molisha Khosla, Angel Robles
namespace MyLibApp
{
    public class Pow
    {
        public static double pow(double num1, double num2)
        {
            double result_one = Math.Pow(num1, num2);
            return result_one;
        }
        public static double pow(double num1, double num2, double num3)
        {
            double result_one = Math.Pow(num1, num2);
            double result_two = Math.Pow(result_one, num3);
            return result_two;
        }
    }
}
