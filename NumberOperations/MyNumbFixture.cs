using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace grouping.NumberOperations
{
    public class MyNumbFixture: IDisposable
    {
        public NumberOps numbOps;

        public MyNumbFixture()
        {
            numbOps = new NumberOps();
        }


        public void Dispose()
        {

        }
    }
}
