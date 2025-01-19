namespace Behavioral.Strategy.Sample1
{
    public class AzureBlobFileUploadStrategy : IFileUploadStrategy
    {
        public void Upload(byte[] file)
        {
            Console.WriteLine("The file has been uploaded with Azure Blob Storage");

        }
    }


}
