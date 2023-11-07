using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.FaizullinDR.Sprint4.Task6.V2.Lib
{
    public class DataService : ISprint4Task6V2
    {
        public string[] Calculate(string[] array)
        {
            string[] arr = Array.FindAll(array, i => i.Length > 5);
            return arr;
        }
    }
}
