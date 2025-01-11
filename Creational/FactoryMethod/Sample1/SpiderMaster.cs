namespace Creational.FactoryMethod.Sample1
{
    public abstract class SpiderMaster
    {

        protected abstract ISpider CreateSpider();

        public void ThrowAWeb()
        {
            ISpider spider = CreateSpider();
            spider.ThrowWeb();
        }


    }
}
