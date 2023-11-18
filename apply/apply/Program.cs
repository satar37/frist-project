using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apply
{
    internal class Program
    {

        abstract class  Customer
        {
            int Id { get; set; }
            string Name { get; set; }
            int   Age { get; set; }
            double Salary { get; set; }
            int State { get; set; }
        }
        static void Main(string[] args)
        {

        }
    }
}
