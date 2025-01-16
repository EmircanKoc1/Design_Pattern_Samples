namespace Structural.Proxy.Sample1
{
    public class MatServiceLogProxy : IMatService
    {
        private readonly IMatService _service;

        public MatServiceLogProxy(IMatService service)
        {
            _service = service;
        }

        public double Divide(double number1, double number2)
        {
            Console.WriteLine($"number1 : {number1} , number2 : {number2}");
            var divideResult = _service.Divide(number1, number2);
            Console.WriteLine($"divide result : {divideResult}");
            return divideResult;
        }

        public int Sum(int number1, int number2)
        {
            Console.WriteLine($"number1 : {number1} , number2 : {number2}");
            var sumResult = _service.Sum(number1, number2);
            Console.WriteLine($"sum result : {sumResult}");
            return sumResult;
        }
    }
}
