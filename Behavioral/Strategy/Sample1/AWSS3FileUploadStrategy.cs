namespace Behavioral.Strategy.Sample1
{
    public class AWSS3FileUploadStrategy : IFileUploadStrategy
    {
        public void Upload(byte[] file)
        {
            Console.WriteLine("The file has been uploaded with AWS S3");
        }
    }


}
