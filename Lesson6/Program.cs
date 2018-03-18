 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6DelegatyEventy
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Simulation simulation = new Simulation();
            
            Student student = new Student(simulation);
            Teacher teacher = new Teacher(simulation);

            //simulation.OnExperiment += teacher.Print;

            simulation.Start();
        }
    }
}
