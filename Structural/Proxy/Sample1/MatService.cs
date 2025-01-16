namespace Structural.Proxy.Sample1
{
    public class MatService : IMatService
    {
        public double Divide(double number1, double number2)
            => number1 / number2;


        public int Sum(int number1, int number2)
            => number1 + number2;
    }
}
