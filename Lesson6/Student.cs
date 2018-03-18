using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6DelegatyEventy
{
  public  class Student
    {
       

        public Student(Simulation simulation)
        {
            simulation.OnExperiment += Print;
            simulation.Start();
        }

        public void Print(string msg)
        {
            Console.WriteLine(msg + "[Student]");
        }
    }
}
