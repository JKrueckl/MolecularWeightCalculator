using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace cmpe2800MolecularWeightCalculator
{
    public partial class dlg_Main : Form
    {
        // Dictionary breakdown of the chemical that the user input | Element symbol -> quantity
        Dictionary<string, int> inputElements = new Dictionary<string, int>();

        // Full periodic table class, holds a dictionary that is Element symbol -> Element (All element info)
        PeriodicTableData FullTable = new PeriodicTableData();

        BindingSource bs = new BindingSource();

        public dlg_Main()
        {
            InitializeComponent();

            // Bind bs on form creation
            UI_DGV_ElementDisplay.DataSource = bs;

            // All elements from periodic table get displayed
            var allTableElements = from element in FullTable.PeriodicTable
                                   select new
                                   {
                                       AtomicNumber = element.Value.Number,
                                       Name = element.Value.Name,
                                       Symbol = element.Key,
                                       Mass = element.Value.AtomicMass
                                   };

            bs.DataSource = allTableElements;
        }


        private void UI_TB_ChemForm_TextChanged(object sender, EventArgs e)
        {
            // Get the text from ChemForm into our dictionary
            inputElements = CountElements(UI_TB_ChemForm.Text);

            // Make sure there is something in the text box
            if (inputElements.Count > 0)
            {
                // Display all of the elements from the ChemForm textbox
                var allInputElements = from element in inputElements
                                       join tableElement in FullTable.PeriodicTable on element.Key equals tableElement.Key
                                       select new
                                       {
                                           Element = tableElement.Value.Name,
                                           Count = element.Value,
                                           Mass = tableElement.Value.AtomicMass,
                                           TotalMass = tableElement.Value.AtomicMass * element.Value
                                       };

                bs.DataSource = allInputElements;

                // Calculate total molar mass of all of the elements in the ChemForm
                var molarMass = (from element in allInputElements select element.TotalMass).Sum();

                // Display total molar mass
                UI_TB_MolarMass.Text = molarMass.ToString() + " g/mol";
            }
            else // Textbox is empty 
            {
                // Display all periodic table elements
                var allTableElements = from element in FullTable.PeriodicTable
                                       select new
                                       {
                                           AtomicNumber = element.Value.Number,
                                           Name = element.Value.Name,
                                           Symbol = element.Key,
                                           Mass = element.Value.AtomicMass
                                       };

                bs.DataSource = allTableElements;
                UI_TB_MolarMass.Text = "0 g/mol";
            }
        }

        // Regex for ChemForm text box
        private Dictionary<string, int> CountElements(string strChemForm)
        {
            // Temp dictionary
            Dictionary<string, int> dElements = new Dictionary<string, int>();

            //select all that match the patterns: 
            //string pattern = @"([A-Z])([a-z]+)(\d+)|([A-Z])(\d+)|([A-Z])([a-z]+)|([A-Z])";  
            string pattern = @"([A-Z])([a-z]+)?(([1-9])(\d+)?)?"; //new and better pattern
            Regex rgx = new Regex(pattern);

            string matchingSymbolStr = "";

            foreach (Match match in rgx.Matches(strChemForm))
            {
                string symbol;
                int count;
                //check for numbers 
                if (Regex.IsMatch(match.Value, @"([a-zA-Z]+)(\d+)"))
                {
                    Regex rgx2 = new Regex(@"([a-zA-Z]+)(\d+)");
                    Match match2 = rgx2.Match(match.Value);
                    symbol = match2.Groups[1].Value;

                    Int32.TryParse(match2.Groups[2].Value, out count);
                    if (match2.Groups[2].Length <= 9)
                    {
                        Int32.TryParse(match2.Groups[2].Value, out count);
                    }
                    else
                    {
                        MessageBox.Show("Too many elements after " + symbol + ". This element will not be calculated.");
                    }
                }
                else
                {
                    symbol = match.Value;
                    count = 1;
                }


                //check for valid symbol
                if (FullTable.PeriodicTable.ContainsKey(symbol))
                {
                    matchingSymbolStr += match.Value;

                    //add to dictionary
                    if (dElements.ContainsKey(symbol))
                    {
                        dElements[symbol] += count;
                    }
                    else
                    {
                        dElements.Add(symbol, count);
                    }
                }
            }

            // Calculations for result accuracy in the order of Green, Yellow, Red
            if (matchingSymbolStr.Length == UI_TB_ChemForm.Text.Length)
            {
                //green
                UI_TB_MolarMass.BackColor = Color.Green;
            }
            else if (matchingSymbolStr.Length == 0)
            {
                //red
                UI_TB_MolarMass.BackColor = Color.Red;
            }
            else if (matchingSymbolStr.Length < UI_TB_ChemForm.Text.Length)
            {
                //yellow
                UI_TB_MolarMass.BackColor = Color.Yellow;
            }

            return dElements;
        }

        #region Sort_Buttons
        private void UI_Btn_SortByName_Click(object sender, EventArgs e)
        {
            UI_TB_ChemForm.Text = "";
            var allTableElements = from element in FullTable.PeriodicTable
                                   orderby element.Value.Name
                                   select new
                                   {
                                       AtomicNumber = element.Value.Number,
                                       Name = element.Value.Name,
                                       Symbol = element.Key,
                                       Mass = element.Value.AtomicMass
                                   };

            bs.DataSource = allTableElements;
        }

        private void UI_Btn_SingleCharSymbols_Click(object sender, EventArgs e)
        {
            UI_TB_ChemForm.Text = "";

            var allTableElements = from element in FullTable.PeriodicTable
                                   where element.Key.Length == 1
                                   select new
                                   {
                                       AtomicNumber = element.Value.Number,
                                       Name = element.Value.Name,
                                       Symbol = element.Key,
                                       Mass = element.Value.AtomicMass
                                   };

            bs.DataSource = allTableElements;



        }

        private void UI_Btn_SortAtomicNum_Click(object sender, EventArgs e)
        {
            UI_TB_ChemForm.Text = "";

            var allTableElements = from element in FullTable.PeriodicTable
                                   orderby element.Value.Number
                                   select new
                                   {
                                       AtomicNumber = element.Value.Number,
                                       Name = element.Value.Name,
                                       Symbol = element.Key,
                                       Mass = element.Value.AtomicMass
                                   };

            bs.DataSource = allTableElements;


        }

        #endregion
    }
}
