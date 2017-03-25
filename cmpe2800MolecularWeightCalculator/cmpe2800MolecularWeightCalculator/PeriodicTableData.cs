using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace cmpe2800MolecularWeightCalculator
{
    public class PeriodicTableData
    {
        // Periodic table Dictionary
        public Dictionary<string, Element> PeriodicTable = new Dictionary<string, Element>();

        // Dictionary Indexer
        public Element this[string s]
        {
            get
            {
                return PeriodicTable[s];
            }
        }

        // Default constructor
        public PeriodicTableData()
        {
            ReadCSV();
        }

        // Read CSV from bin/debug
        public void ReadCSV()
        {
            // Read all lines
            var lines = File.ReadAllLines("PeriodicTableData.csv");  
            
            // split lines into elements
            foreach(var str in lines)
            {
                // Split at , (CSV)
                string[] currentElementasArray = str.Split(',');

                // parsed mass info
                float atomicMass = 0;

                // if the mass has molecular mass 
                if (currentElementasArray[3].IndexOf('(') > 0)
                    atomicMass = float.Parse(currentElementasArray[3].Substring(0, currentElementasArray[3].IndexOf('(')));

                // Create element
                Element currentElementasElement = new Element(currentElementasArray[2].Trim(), currentElementasArray[1].Trim(), int.Parse(currentElementasArray[0]), atomicMass);

                // Add to dictionary
                PeriodicTable.Add(currentElementasElement.Symbol, currentElementasElement);
            }       
        }
    }
}
