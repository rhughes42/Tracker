using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tracker
{
    class Utlities
    {
        // Functions
        static double RadiansToDegrees(double dRads)
        {
            return dRads * (180.0f / Math.PI);
        }

        static int LowWord(int number)
        {
            return number & 0xFFFF;
        }

        static int HighWord(int number)
        {
            return ((number >> 16) & 0xFFFF);
        }
    }
}
