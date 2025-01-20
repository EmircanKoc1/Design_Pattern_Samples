namespace Behavioral.TemplateMethod.Sample1
{
    public abstract class DataProcessor
    {

        public void Process()
        {
            LoadData();
            ValidateData();
            ProcessData();
            SaveData();
        }

        protected abstract void LoadData();
        protected abstract void ValidateData();
        protected abstract void ProcessData();
        protected void SaveData()
        {
            Console.WriteLine("The data has been saved to the database");
        }

    }
}
