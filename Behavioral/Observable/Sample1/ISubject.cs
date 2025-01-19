namespace Behavioral.Observable.Sample1
{
    //Observable
    public interface ISubject
    {
        void Unsubcribe(ICustomObserver observer);
        void Subcribe(ICustomObserver observer);
        void Notify(string message);
    }



}
