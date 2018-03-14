using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Practice_Integer_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            const sbyte sbMin = sbyte.MinValue;
            const sbyte sbMax = sbyte.MaxValue;
            const byte bMin = byte.MinValue;
            const byte bMax = byte.MaxValue;
            const short shMin = short.MinValue;
            const short shMax = short.MaxValue;
            const ushort ushMin = ushort.MinValue;
            const ushort ushMax = ushort.MaxValue;


            for (int i = 1; i<=n; i++)
                {
                    string num = Console.ReadLine();
                    if (num >= sbMin && num <= sbMax)
                    {
                        Console.WriteLine((sbyte)num);
                    }
                    else
                    {
                        Console.WriteLine("Num is not sbyte");
                }

                }
        }
    }
}
