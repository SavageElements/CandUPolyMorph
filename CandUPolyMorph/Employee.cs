using System;
using System.Collections.Generic;
using System.Text;

namespace CandUPolyMorph
{
    class Employee :IQuit
    {
        public int ID { get; set; }

        public void Quit()
        {
            Console.WriteLine("Take this job and shove it!");
        }
    }
}
