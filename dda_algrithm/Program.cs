using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dda_algrithm
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter point X0:");
            float x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point Y0:");
            float y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point X1: ");
            float x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter point Y1:");
            float y2 = Convert.ToInt32(Console.ReadLine());

            float dx = x2 - x1;
            float dy = y2 - y1;
            float Slope = dy / dx;

            if(Slope<1)
            {
                for(int i=0;i<100;i++)
                {
                    x1 += 1;
                    y1 += Slope;
                    double y11 = Math.Round(y1);
                    Console.WriteLine("(" + x1 + "," + y11 + ")" );
                    if(x1==x2||y1==y2)
                        break;   
                }
            
            }
            else if (Slope > 1)
            {
                for (int i = 0; i < 100; i++)
                {
                    y1 += 1;
                    x1 +=1/Slope;
                    double x11 = Math.Round(x1);
                    Console.WriteLine("(" + x11 + "," + y1 + ")");
                    if (x1 == x2 || y1 == y2)
                        break;
                }

            }

            else
            {
                for (int i = 0; i < 100; i++)
                {
                    y1 += 1;
                    x1 += 1;
                    Console.WriteLine("(" + x1 + "," + y1 + ")");
                    if (x1 == x2 || y1 == y2)
                        break;
                }

            }
                Console.ReadLine();
        }
    }
}
