using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VS11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            LevyeQuation levyeQuation = new LevyeQuation { coefK = 1.45, coefB = -14.25 };
            levyeQuation.Root();
            Console.ReadKey();
        }
        struct LevyeQuation
        {
            public double coefK { get; set; }
            public double coefB { get; set; }

            public LevyeQuation(double coefK, double coefB)
            {
                this.coefK = coefK;
                this.coefB = coefB;
            }

            public void Root()
            {
                double resultX = -coefB / coefK;
                Console.WriteLine("Решение уравнения x = {0:f2}", resultX);
                if (coefK == 0)
                {
                    Console.WriteLine("Ошибка, деление на ноль");
                }
            }
        }
    }
}
