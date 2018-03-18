using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson6DelegatyEventy
{
    public class Simulation
    {
        // wzór funkcji i jednocześnie typ
        public delegate void Experiment(string msg);
        public event Experiment OnExperiment;
       


        public int CurrentTime { get; set; }

        public void Start()
        {
            for (CurrentTime = 0; CurrentTime <= 10; CurrentTime++)
            {
                if (CurrentTime % 2 == 0)
                {
                    Console.WriteLine(CurrentTime);
                    RaiseOnExperiment("parystość");
                }
                Thread.Sleep(1000);
            }

            Console.ReadKey();
        }

        private void RaiseOnExperiment(string msg)
        {
            OnExperiment?.Invoke(msg);
        }

        public Simulation()
        {
            CurrentTime = 0;
        }
    }
}
