// Better21 by Logan Cantin
// Sleep Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Better21LoganC
{
    class Sleep
    {
        // An asynchronous function that allows the UI elements to continue to be interacted with, even during wait periods.
        public static async Task sleep(int milliseconds)
        {
            await Task.Delay(milliseconds);
        }
    }
}
