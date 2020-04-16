using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PingPong_v5
{
    class RandomMethods
    {
        // randomly chooses a number (built-in method)
        static Random random = new Random();
        static void Number()
        {
            int n = random.Next(10, 30);
        }
        

        // randomly chooses a number (selfwritten)
        public int RandomNumber(int min, int max)
        {
            return min;
        }

        // randomly chooses a ball-color
        public void RandomColor()
        {

        }
    }
}
