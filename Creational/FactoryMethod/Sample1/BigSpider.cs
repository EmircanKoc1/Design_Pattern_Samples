using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.FactoryMethod.Sample1
{
    public class BigSpider : ISpider
    {
        public void ThrowWeb()
        {
            Console.WriteLine("The big spider threw a big web");
        }
    }
}
