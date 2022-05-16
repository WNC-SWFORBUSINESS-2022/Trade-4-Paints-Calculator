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

        //colour blind mode
        int Colour_State = 0;

        int Background_R;
        int Background_G;
        int Background_B;

        int Text_R;
        int Text_G;
        int Text_B;

        int TextBox_Background_R;
        int TextBox_Background_G;
        int TextBox_Background_B;

        int Button_Background_R;
        int Button_Background_G;
        int Button_Background_B;
        #endregion




        //ignore for now
        public Form1()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
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
                switch (comboBox1.SelectedIndex) // to add more numbers just add the unit of mesurement name into the list and add the calculation here as a new case
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
                switch (comboBox2.SelectedIndex) // to add more numbers just add the unit of mesurement name into the list and add the calculation here as a new case
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
                Str_Litres = "Litres = " + Math.Round(Var_Litres,2).ToString() + "L";

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

                Total_Cost = Math.Round((Big_Paint_Cost_Total + Small_Paint_Cost_Total),2);
                String_Cost = "Total Cost = £" + Total_Cost.ToString();

                Total_Cost_VAT = Math.Round((Total_Cost * 1.2),2);
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
                textBox8.Text = Convert.ToString(Math.Round(Convert.ToDouble(textBox8.Text), 2));
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

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        //colour blind button
        private void button1_Click(object sender, EventArgs e)
        {
            switch (Colour_State)
            {
                case 0:
                    Background_R = 0;
                    Background_G = 0;
                    Background_B = 0;

                    Text_R = 255;
                    Text_G = 255;
                    Text_B = 255;

                    TextBox_Background_R = 0;
                    TextBox_Background_G = 0;
                    TextBox_Background_B = 0;

                    Button_Background_R = 0;
                    Button_Background_G = 0;
                    Button_Background_B = 0;

                    Colour_State = 1;
                    button1.Text = "Colour blind mode : On";
                    break;
                case 1:
                    Background_R = 190;
                    Background_G = 211;
                    Background_B = 240;

                    Text_R = 15;
                    Text_G = 124;
                    Text_B = 241;

                    TextBox_Background_R = 255;
                    TextBox_Background_G = 255;
                    TextBox_Background_B = 255;

                    Button_Background_R = 224;
                    Button_Background_G = 224;
                    Button_Background_B = 224;

                    Colour_State = 0;
                    button1.Text = "Colour blind mode : Off";
                    break;
            }
            
            BackColor = Color.FromArgb(Background_R, Background_G, Background_B);

            // Label Font colours
            label1.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);
            label2.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);
            label3.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);
            label4.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);
            label5.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);
            label6.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);
            label7.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);
            label8.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);
            label9.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);
            label10.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);

            // Textbox Background
            textBox1.BackColor = Color.FromArgb(TextBox_Background_R, TextBox_Background_G, TextBox_Background_B);
            textBox2.BackColor = Color.FromArgb(TextBox_Background_R, TextBox_Background_G, TextBox_Background_B);
            textBox4.BackColor = Color.FromArgb(TextBox_Background_R, TextBox_Background_G, TextBox_Background_B);
            textBox5.BackColor = Color.FromArgb(TextBox_Background_R, TextBox_Background_G, TextBox_Background_B);
            textBox6.BackColor = Color.FromArgb(TextBox_Background_R, TextBox_Background_G, TextBox_Background_B);
            textBox7.BackColor = Color.FromArgb(TextBox_Background_R, TextBox_Background_G, TextBox_Background_B);
            textBox8.BackColor = Color.FromArgb(TextBox_Background_R, TextBox_Background_G, TextBox_Background_B);
            textBox9.BackColor = Color.FromArgb(TextBox_Background_R, TextBox_Background_G, TextBox_Background_B);
            textBox10.BackColor = Color.FromArgb(TextBox_Background_R, TextBox_Background_G, TextBox_Background_B);

            // Textbox Fonts
            textBox1.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);
            textBox2.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);
            textBox4.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);
            textBox5.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);
            textBox6.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);
            textBox7.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);
            textBox8.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);
            textBox9.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);
            textBox10.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);

            // Button Background
            button1.BackColor = Color.FromArgb(Button_Background_R, Button_Background_G, Button_Background_B);
            button18.BackColor = Color.FromArgb(Button_Background_R, Button_Background_G, Button_Background_B);
            button19.BackColor = Color.FromArgb(Button_Background_R, Button_Background_G, Button_Background_B);
            button20.BackColor = Color.FromArgb(Button_Background_R, Button_Background_G, Button_Background_B);
            checkBox1.BackColor = Color.FromArgb(Button_Background_R, Button_Background_G, Button_Background_B);

            // Button Fonts
            button1.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);
            button18.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);
            button19.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);
            button20.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);
            checkBox1.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);

            // Combobox Background
            comboBox1.BackColor = Color.FromArgb(TextBox_Background_R, TextBox_Background_G, TextBox_Background_B);
            comboBox2.BackColor = Color.FromArgb(TextBox_Background_R, TextBox_Background_G, TextBox_Background_B);

            // Combobox Fonts
            comboBox1.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);
            comboBox2.ForeColor = Color.FromArgb(Text_R, Text_G, Text_B);
        }
    }
}
