using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            SubsidionaryClass subclass = new SubsidionaryClass();
            subclass[0] = "Hello";
            Console.WriteLine(subclass[0]);

            for (int i = 0; i < subclass.Arrays.Length; i++)
            {
                Console.WriteLine(subclass.Arrays[i]);
            }
        }
    }
}
