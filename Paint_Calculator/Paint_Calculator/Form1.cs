using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Paint_Calculator
{
    public partial class Form1 : Form
    {
        #region Variables
        List<int> Input_Type = new List<int>(); // Holds the more complex information: numbers = 0, method = 1, Unit = 2, Calculating = 3; can then be used for visual translation

        Double[] Input_Numbers = {0,0}; // Holds the Numeric values
         List<int> Input_Units = new List<int>();// Holds more specific information for Units (0 - 3)

        Double Section = 0; // Numbers and Operators fight for this variable

        // ram
        int Current_Section_Type = 0;// Numbers = 0, Operators = 1
        int Current_Section_Unit = 0; // (0 - 3)

        //Library
        string[] Unit_Values = {"Meters", "Foot"}; // Extchange Rates to a Meter, mm = / 1000, cm = / 100, m = x 1, km = x 1000, mile = x 1609.34
        int Cycle_1 = 0;
        int Cycle_2 = 0;// Cycles what Unit the user wants
        bool Decimal_Enable = false;
        
        //Calculation for paint
        bool Empty_Check = false;
        Double Var_Litres = 0;
        String Str_Litres;
        int Big_Paint_Counter = 0;
        int Small_Paint_Counter = 0;
        Double Small_Paint_Cost_Total;
        Double Big_Paint_Cost_Total;

        String Small_Paint_Size;
        String Small_Paint_Trade_Cost;
        String Small_Paint_Dom_Cost;
        String Big_Paint_Size;
        String Big_Paint_Trade_Cost;
        String Large_Paint_Dom_Cost;

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




        //ignore for now
        public Form1()
        {
            InitializeComponent();
            String path = Application.StartupPath + "\\form\\" + "Paint_Details.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                Small_Paint_Size = sr.ReadLine(); // loads up the txt document and saves them as diffrent var
                textBox5.Text = Small_Paint_Size;

                Small_Paint_Trade_Cost = sr.ReadLine();
                textBox6.Text = Small_Paint_Trade_Cost;

                Small_Paint_Dom_Cost = sr.ReadLine();
                textBox10.Text = Small_Paint_Dom_Cost;

                Big_Paint_Size = sr.ReadLine();
                textBox7.Text = Big_Paint_Size;

                Big_Paint_Trade_Cost = sr.ReadLine();
                textBox8.Text = Big_Paint_Trade_Cost;

                Large_Paint_Dom_Cost = sr.ReadLine();
                textBox9.Text = Large_Paint_Dom_Cost;
            }
        } 
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (Cycle_1 == Unit_Values.Count() - 1)
            {
                Cycle_1 = 0;
            }
            else
            {
                Cycle_1 = Cycle_1 + 1;
            }

            button1.Text = Unit_Values[Cycle_1];
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (Cycle_2 >= Unit_Values.Count() - 1)
            {
                Cycle_2 = 0;
            }
            else
            {
                Cycle_2++;
            }
            button2.Text = Unit_Values[Cycle_2];
        }
        public void Unit(int x)
        {
            
        }
        // The actuial Calculation...
        private void button18_Click(object sender, EventArgs e)
        {
            bool Inital_Calculation = true;
            Double Results = 0;

            // Adds the inputed number (if there is any)
            if (String.IsNullOrEmpty(textBox1.Text)|| String.IsNullOrEmpty(textBox2.Text))
            {
                //error
            }
            else
            {
                // Converting the number
                switch (Cycle_1) // to add more numbers just add the unit of mesurement name into the list and add the calculation here as a new case
                {
                    case 0:
                        Input_Numbers[0] = Convert.ToDouble(textBox1.Text); // meter to meter
                        break;
                    case 1:
                        Input_Numbers[0] = Convert.ToDouble(textBox1.Text) * 0.3048; // feet to meter
                        break;
                    default:
                        //add text to tell the user to input something :P
                        break;
                }
                switch (Cycle_2) // to add more numbers just add the unit of mesurement name into the list and add the calculation here as a new case
                {
                    case 0:
                        Input_Numbers[1] = Convert.ToDouble(textBox2.Text); // meter to meter
                        break;
                    case 1:
                        Input_Numbers[1] = Convert.ToDouble(textBox2.Text) * 0.3048; // feet to meter
                        break;
                    default:
                        //add text to tell the user to input something :P
                        break;
                }

                Results = Input_Numbers[0] * Input_Numbers[1];
                textBox4.Text = Results.ToString();
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Empty_Check = false;
            Var_Litres = 0;
            Big_Paint_Counter = 0;
            Small_Paint_Counter = 0;

            Small_Paint_Cost_Total = 0;
            Big_Paint_Cost_Total = 0;

            String path = Application.StartupPath + "\\form\\" + "Paint_Details.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                Small_Paint_Size = sr.ReadLine(); // loads up the txt document and saves them as diffrent var
                textBox5.Text = Small_Paint_Size;

                Small_Paint_Trade_Cost = sr.ReadLine();
                textBox6.Text = Small_Paint_Trade_Cost;

                Small_Paint_Dom_Cost = sr.ReadLine();
                textBox10.Text = Small_Paint_Dom_Cost;

                Big_Paint_Size = sr.ReadLine();
                textBox7.Text = Big_Paint_Size;

                Big_Paint_Trade_Cost = sr.ReadLine();
                textBox8.Text = Big_Paint_Trade_Cost;

                Large_Paint_Dom_Cost = sr.ReadLine();
                textBox9.Text = Large_Paint_Dom_Cost;
            }

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
                    if (Var_Litres > Convert.ToDouble(Big_Paint_Size))
                    {
                        Big_Paint_Counter++;
                        Var_Litres = Var_Litres - Convert.ToDouble(Big_Paint_Size);
                        //get big paint
                    }
                    else if (Var_Litres < Convert.ToDouble(Big_Paint_Size))
                    {
                        if (Var_Litres > Convert.ToDouble(Small_Paint_Size))
                        {
                            Big_Paint_Counter++;
                            Var_Litres = 0;
                            Empty_Check = true;
                            // get big paint
                        }
                        else if (Var_Litres < Convert.ToDouble(Small_Paint_Size))
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


                if (checkBox1.Checked)
                {
                    Small_Paint_Cost_Total = Small_Paint_Counter * Convert.ToDouble(Small_Paint_Trade_Cost);
                    Big_Paint_Cost_Total = Big_Paint_Counter * Convert.ToDouble(Small_Paint_Trade_Cost);
                }
                else
                {
                    Small_Paint_Cost_Total = Small_Paint_Counter * Convert.ToDouble(Small_Paint_Dom_Cost);
                    Big_Paint_Cost_Total = Big_Paint_Counter * Convert.ToDouble(Small_Paint_Dom_Cost);
                }

                Small_Paint = "Small Paint X " + Small_Paint_Counter.ToString();
                Big_Paint = "Big Paint x " + Big_Paint_Counter.ToString();

                Total_Cost = Big_Paint_Cost_Total + Small_Paint_Cost_Total;
                String_Cost = "Total Cost = £" + Total_Cost.ToString();

                Total_Cost_VAT = Total_Cost * 1.2;
                String_VAT = "Total Cost With VAT = £" + Total_Cost_VAT.ToString();

                DateTime Date = DateTime.Today;
                MessageBox.Show(Company_Name + "\n" + Company_Address + "\n" + Small_Paint + "\n" + Big_Paint + "\n" + Str_Litres + "\n" + String_Cost + "\n" + String_VAT + "\n" + Date, Title);
            }
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox5.Text)|| String.IsNullOrEmpty(textBox6.Text)|| String.IsNullOrEmpty(textBox7.Text)|| String.IsNullOrEmpty(textBox8.Text))
            {
                //send error
                MessageBox.Show("Please Insert a Value");
            }
            else
            {
                StreamWriter A = new StreamWriter(Application.StartupPath + "\\form\\" + "Paint_Details.txt");
                A.WriteLine(textBox5.Text); //Small Paint Size
                A.WriteLine(textBox6.Text); //Small paint Trade Price
                A.WriteLine(textBox10.Text); //Small paint Dom Price
                A.WriteLine(textBox7.Text); //large Paint size
                A.WriteLine(textBox8.Text); //Large Paint Trade Price
                A.WriteLine(textBox9.Text); //Large paint Dom Price

                A.Close();
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label9.Text = "Enabled";
            }
            else
            {
                label9.Text = "Disabled";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
