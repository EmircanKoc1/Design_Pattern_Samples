namespace Behavioral.TemplateMethod.Sample1
{
    public class APIDataProccessor : DataProcessor
    {
        protected override void LoadData()
        {
            Console.WriteLine("The data has been loaded from the API");
        }

        protected override void ProcessData()
        {
            Console.WriteLine("The data has been processed");
        }

        protected override void ValidateData()
        {
            Console.WriteLine("The data has been validated.");
        }
    }
}
