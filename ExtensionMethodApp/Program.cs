using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "ddfeae".Truncate(5,"aaaaaaa");
            Console.WriteLine(a);

        }
    }
    
}
