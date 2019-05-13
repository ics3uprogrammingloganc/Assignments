using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better21LoganC
{
    class Sleep
    {
        public static async Task sleep(int milliseconds)
        {
            await Task.Delay(milliseconds);
        }
    }
}
