using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cursuri1_4
{
    class Ionatan: Apple
    {
        public Ionatan()
        {
            Console.WriteLine("An apple Ionatan has been created");
        }
        public override int getCalories()
        {
            return 3;
        }
    }
}
