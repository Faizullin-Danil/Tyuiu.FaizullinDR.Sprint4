using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.FaizullinDR.Sprint4.Task6.V2.Lib;

namespace Tyuiu.FaizullinDR.Sprint4.Task6.V2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr = Array.FindAll(str, i => i.Length > 5);
            return arr;
        }
    }
}
