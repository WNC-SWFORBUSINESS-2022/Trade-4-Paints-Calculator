using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Paint_Calculator
{
    public partial class Form1 : Form
    {
        #region Variables
        List<int> Input_Type = new List<int>(); // Holds the more complex information: numbers = 0, method = 1, Unit = 2, Calculating = 3; can then be used for visual translation

        List<Double> Input_Numbers = new List<Double>(); // Holds the Numeric values
        List<int> Input_Units = new List<int>(); // Holds more specific information for Units (0 - 3)
        List<Double> Input_Operators = new List<Double>(); // Holds more specific information for Methods(0 - 3)

        Double Section = 0; // Numbers and Operators fight for this variable

        // ram
        int Current_Section_Type = 0;// Numbers = 0, Operators = 1
        int Current_Section_Unit = 0; // (0 - 3)

        //Library
        string[] Unit_Values = { "mm", "cm", "m", "km", "miles" }; // Extchange Rates to a Meter, mm = / 1000, cm = / 100, m = x 1, km = x 1000, mile = x 1609.34
        string[] L_Operators = { "+", "-", "*", "/" };

        int Cycle = 0; // Cycles what Unit the user wants
        bool Decimal_Enable = false;
        
        //Calculation for paint
        bool Empty_Check = false;
        Double Var_Litres = 0;
        String Str_Litres;
        int Big_Paint_Counter = 0;
        int Small_Paint_Counter = 0;
        Double Small_Paint_Cost;
        Double Big_Paint_Cost;

        //Recipt
        String Company_Name = "Trade4Paint";
        String Company_Address = "Mansfield, Hamilton Way";
        String Small_Paint;
        String Big_Paint;
        Double Total_Cost;
        String String_Cost;
        Double Total_Cost_VAT;
        String String_VAT;
        String Title = "Recipt";
        #endregion

        #region Functions
        public void Number(Double x)
        {
            if (Current_Section_Type == 1) // Doesn't like Numbers
            {
                Input_Type.Add(1); // Adds Operator to type list be fore replacing it with Number type
                Input_Operators.Add(Section); // Adds the Operator to the Operator list

                Current_Section_Type = 0;
                Section = x;

                textBox1_Update(); // Run update for text box
                textBox2.Text = Section.ToString() + Unit_Values[Current_Section_Unit];
            }
            else if (Decimal_Enable == true)
            {
                Section = Double.Parse(Section.ToString() + '.' + x.ToString());
                Decimal_Enable = false;
                textBox2.Text = Section.ToString() + Unit_Values[Current_Section_Unit];
            }
            else
            {
                Section = Double.Parse(Section.ToString() + x.ToString()); // inputs number;
                textBox2.Text = Section.ToString() + Unit_Values[Current_Section_Unit];
            }
        }

        public void Operation(int x)
        {
            if (Current_Section_Type == 0) // Doesn't like Operators
            {
                Input_Type.Add(0); // add numbers to type list be fore replacing it with Operator type
                Input_Numbers.Add(Section); // add numbers to the visual list

                Input_Type.Add(2); // Adds the Unit type to the list
                Input_Units.Add(Current_Section_Unit); // adds the specific unit to the list

                Current_Section_Type = 1; // Finally does the Operator
                Section = (x);
                textBox2.Text = L_Operators[Convert.ToInt32(Section)];

                textBox1_Update();
            }
            else
            {
                Section = (x);
                textBox2.Text = L_Operators[Convert.ToInt32(Section)];
            }
        }

        public void Unit(int x)
        {
            Current_Section_Unit = x;
            button11.Text = Unit_Values[x];
            textBox2.Text = Section.ToString() + Unit_Values[Current_Section_Unit];
        }


        public void textBox1_Update()
        {
            int Length = Input_Type.Count(); // Calculate the length of the list

            string Display = "";

            int Number_Count = 0;
            int Operator_Count = 0;
            int Unit_Count = 0;
            
            for (int i = 0; i < Length; i++)
            {
                switch (Input_Type[i])
                {
                    case 0: // Numerals
                        Display = Display + Input_Numbers[Number_Count];
                        Number_Count = Number_Count + 1;
                        break;
                                             
                    case 1: // Operators
                        Display = Display + L_Operators[Convert.ToInt32(Input_Operators[Operator_Count])];
                        Operator_Count = Operator_Count + 1;
                        break;
                                             
                    case 2: // Units
                        Display = Display + Unit_Values[Convert.ToInt32(Input_Units[Unit_Count])];
                        Unit_Count = Unit_Count + 1;
                        break;

                    default:
                        // Nothing
                        break;
                }
            }
            textBox1.Text = Display;
        }

        public void Reset_Values()
        {
            Input_Type.Clear();
            
            Input_Numbers.Clear();
            Input_Units.Clear();
            Input_Operators.Clear();

            Section = 0;
            Current_Section_Type = 0;
        }
        #endregion

        //ignore for now
        public Form1()
        {
            InitializeComponent();
        } 
        
        // Holds the main numerical inputs (Includes Decimal)
        #region Number Input
        private void button1_Click(object sender, EventArgs e)
        {
            Number(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Number(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Number(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Number(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Number(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Number(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Number(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Number(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Number(9);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Number(0);
        }
        
        // Decimal
        private void button16_Click(object sender, EventArgs e)
        {
            if (Current_Section_Type == 0)
            {
                if (Decimal_Enable == true)
                    {
                        Decimal_Enable = false;
                    }
                else
                    {
                        Decimal_Enable = true;
                    }
            }
        }
        #endregion

        // Change Unit
        private void button11_Click(object sender, EventArgs e)
        {
            if (Cycle == Unit_Values.Count() - 1)
            {
                Cycle = 0;
            }
            else
            {
                Cycle = Cycle + 1;
            }
            Unit(Cycle);
        }
        
        // Operators, Duh... (holds the inputs for operations like additon or division)
        #region Operators
        // Plus
        private void button12_Click(object sender, EventArgs e)
        {
            Operation(0);
        }

        // Minus
        private void button13_Click(object sender, EventArgs e)
        {
            Operation(1);
        }

        // Times
        private void button14_Click(object sender, EventArgs e)
        {
            Operation(2);
        }

        // Division
        private void button15_Click(object sender, EventArgs e)
        {
            Operation(3);
        }

        #endregion

        // Reset (resets averything before User Input (Ignoring Unit))
        private void button17_Click(object sender, EventArgs e)
        {
            Reset_Values();
        }

        // The actuial Calculation...
        private void button18_Click(object sender, EventArgs e)
        {
            bool Inital_Calculation = true;
            Double Results = 0;

            // Adds the inputed number (if there is any)
            if (Current_Section_Type == 0) // Number
            {
                Input_Type.Add(0); // add numbers to type list be fore replacing it with Operator type
                Input_Numbers.Add(Section); // add numbers to the visual list

                Input_Type.Add(2); // Adds the Unit type to the list
                Input_Units.Add(Current_Section_Unit); // adds the specific unit to the list
            }

            // Converting the number
            for (int i = 0; i <= (Input_Units.Count - 1); i++) // Extchange Rates to a Meter, mm = / 1000, cm = / 100, m = x 1, km = x 1000, mile = x 1609.34
            {
                switch(Input_Units[i]) // to add more numbers just add the unit of mesurement name into the list and add the calculation here as a new case
                {
                    case 0:
                        Input_Numbers[i] = Input_Numbers[i] / 1000; // millimeter to meter
                        break;
                    case 1:
                        Input_Numbers[i] = Input_Numbers[i] / 100; // centimeter to meter
                        break;
                    case 2:
                        Input_Numbers[i] = Input_Numbers[i] * 1; // meter to meter 
                        break;
                    case 3:
                        Input_Numbers[i] = Input_Numbers[i] * 1000; // kilometer to meter
                        break;
                    case 4:
                        Input_Numbers[i] = Input_Numbers[i] * 1609.34; // mile to meter
                        break;
                    default:
                        //add text to tell the user to input something :P
                        break;
                }
            }


            for (int i = 0; i <= (Input_Operators.Count - 1); i++) // counting how many times it needs to calculate
            {
                switch (Input_Operators[i])
                {
                    case 0: // +
                        if (Inital_Calculation == true) // The Inital Calculation Is Special
                        {
                            Inital_Calculation = false;

                            Results = Input_Numbers[i] + Input_Numbers[i + 1];
                        }
                        else
                        {
                            Results = Results + Input_Numbers[i + 1];
                        }
                        break;
                    case 1: // -
                        if (Inital_Calculation == true)
                        {
                            Inital_Calculation = false;

                            Results = Input_Numbers[i] - Input_Numbers[i + 1];
                        }
                        else
                        {
                            Results = Results - Input_Numbers[i + 1];
                        }
                        break;
                    case 2: // *
                        if (Inital_Calculation == true)
                        {
                            Inital_Calculation = false;

                            Results = Input_Numbers[i] * Input_Numbers[i + 1];
                        }
                        else
                        {
                            Results = Results * Input_Numbers[i + 1];
                        }
                        break;
                    case 3: // %
                        if (Inital_Calculation == true)
                        {
                            Inital_Calculation = false;

                            Results = Input_Numbers[i] / Input_Numbers[i + 1];
                        }
                        else
                        {
                            Results = Results / Input_Numbers[i + 1];
                        }
                        break;
                }
            }
            Reset_Values();
            textBox3.Text = Results.ToString() + " m";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Empty_Check = false;
            Var_Litres = 0;
            Big_Paint_Counter = 0;
            Small_Paint_Counter = 0;

            Small_Paint_Cost = 0;
            Big_Paint_Cost = 0;
            
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                //send error
                MessageBox.Show("Please Insert a Value");
            }
            else
            {
                Var_Litres = Convert.ToDouble(textBox4.Text) / 1.625; // the number of litres needed
                Str_Litres = "Litres = " + Var_Litres.ToString() + "L";

                while (Empty_Check == false)
                {
                    if (Var_Litres > 8)
                    {
                        Big_Paint_Counter++;
                        Var_Litres = Var_Litres - 5;
                        //get big paint
                    }
                    else if (Var_Litres < 8)
                    {
                        if (Var_Litres > 4)
                        {
                            Big_Paint_Counter++;
                            Var_Litres = 0;
                            Empty_Check = true;
                            // get big paint
                        }
                        else if (Var_Litres < 4)
                        {
                            if (Var_Litres == 0)
                            {
                                Empty_Check = true; //stop calculating
                            }
                            else
                            {
                                Small_Paint_Counter++; //get small paint
                                Var_Litres = 0;
                                Empty_Check = true;
                            }
                        }

                    }
                }

                Small_Paint_Cost = Small_Paint_Counter * 18.99;
                Big_Paint_Cost = Big_Paint_Counter * 28;

                Small_Paint = "Small Paint X " + Small_Paint_Counter.ToString();
                Big_Paint = "Big Paint x " + Big_Paint_Counter.ToString();

                Total_Cost = Big_Paint_Cost + Small_Paint_Cost;
                String_Cost = "Total Cost = £" + Total_Cost.ToString();

                Total_Cost_VAT = Total_Cost * 1.05;
                String_VAT = "Total Cost With VAT = £" + Total_Cost_VAT.ToString();

                DateTime Date = DateTime.Today;
                MessageBox.Show(Company_Name + "\n" + Company_Address + "\n" + Small_Paint + "\n" + Big_Paint + Str_Litres + "\n" + String_Cost + "\n" + String_VAT + "\n" + Date, Title);
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
