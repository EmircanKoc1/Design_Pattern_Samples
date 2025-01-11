using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.FactoryMethod.Sample1
{
    public class SmallSpider : ISpider
    {
        public void ThrowWeb()
        {
            Console.WriteLine("The small spider threw a small web");
        }
    }
}
