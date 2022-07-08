using System;
using System.Collections.Generic;
using System.Text;

namespace CandUPolyMorph
{
    public abstract class Person241
    {
        public string firstName;
        public string lastName;

        public void SayName()
        {
            Console.WriteLine(firstName + lastName);
        }

    }
}
