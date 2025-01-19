namespace Behavioral.Strategy.Sample1
{
    public class FileUploaderContext
    {
        protected IFileUploadStrategy? _fileUploadStrategy;
        protected IFileUploadStrategy FileUploadStrategy { get => _fileUploadStrategy ?? throw new ArgumentNullException("File upload strategy can not be null"); }

        public void SetFileUploadStrategy(IFileUploadStrategy fileUploadStrategy)
        {
            _fileUploadStrategy = fileUploadStrategy;
        }

        public void UploadFile(byte[] file)
        {
            FileUploadStrategy.Upload(file);
        }


    }


}
