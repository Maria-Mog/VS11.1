using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LQ;

namespace VS11._1
{
    class Program
    {
        static void Main(string[] args)
        {
            LevyeQuation levyeQuation = new LevyeQuation { coefK = 0.45, coefB = 28.56 };
            levyeQuation.Root();
            Console.ReadKey();
        }
        
    }
    
}
