using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    abstract class First
    {

        public abstract int GetAge(); 
    }

    class Second:First
    {
        public Second() : base()
        {

        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            First first = new First();
        }
    }
}
