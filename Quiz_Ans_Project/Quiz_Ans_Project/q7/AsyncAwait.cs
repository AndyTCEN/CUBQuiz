using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q7
{
    public class AsyncAwait
    {
        public int? Result;
        public async Task Flow()
        {
            Result = null;
             AsyncSample1();
             AsyncSample2();
        }

        private async Task AsyncSample1()
        {
            await Task.Delay(1000);
            Result = 10;
        }

        private async Task AsyncSample2()
        {
            await Task.Delay(2000);
        }
    }
}
