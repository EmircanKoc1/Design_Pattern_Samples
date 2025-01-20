namespace Behavioral.TemplateMethod.Sample1
{

    public class DBDataProcessor : DataProcessor
    {
        protected override void LoadData()
        {
            Console.WriteLine("The data has been loaded from the Database");

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
