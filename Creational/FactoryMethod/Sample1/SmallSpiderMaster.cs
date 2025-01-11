using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.FactoryMethod.Sample1
{
    public class SmallSpiderMaster : SpiderMaster
    {
        protected override ISpider GetSpider()
        {
            return new SmallSpider();
        }
    }
}
