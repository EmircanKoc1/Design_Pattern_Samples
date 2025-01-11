using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational.FactoryMethod.Sample1
{
    public class BigSpiderMaster : SpiderMaster
    {
        protected override ISpider GetSpider()
        {
            return new BigSpider(); 
        }
    }
}
