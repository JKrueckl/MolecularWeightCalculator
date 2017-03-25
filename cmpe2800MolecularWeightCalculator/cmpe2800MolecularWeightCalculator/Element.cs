using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cmpe2800MolecularWeightCalculator
{
    public class Element
    {
        // actual name of the element
        public string Name { private set; get; }

        // periodic table symbol
        public string Symbol { private set; get; }

        // periodic table number of the element
        public int Number { private set; get; }
        
        // atomic mass of the element
        public float AtomicMass { private set; get; }

        // constructor to initialize all fields
        public Element(string name, string symbol, int number, float atomicMass)
        {
            Name = name;
            Symbol = symbol;
            Number = number;
            AtomicMass = atomicMass;
        }


    }
}
