using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6DelegatyEventy
{
  public  class Teacher
    {
       

        public Teacher(Simulation simulation)
        {
            simulation.OnExperiment += Print;
        }

        public void Print(string msg)
        {
            Console.WriteLine(msg + "[Teacher]");

        }
    }
}
