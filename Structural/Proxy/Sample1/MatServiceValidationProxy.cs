namespace Structural.Proxy.Sample1
{
    public class MatServiceValidationProxy : IMatService
    {
        private readonly IMatService _service;

        public MatServiceValidationProxy(IMatService service)
        {
            _service = service;
        }

        public double Divide(double number1, double number2)
        {
            if (number2 is 0)
                throw new DivideByZeroException();

            return _service.Divide(number1, number2);
        }

        public int Sum(int number1, int number2)
        {
            return _service.Sum(number1, number2);
        }
    }
}
