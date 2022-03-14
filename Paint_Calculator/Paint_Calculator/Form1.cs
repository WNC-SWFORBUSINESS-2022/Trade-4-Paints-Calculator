using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// holds the visual stuff
List<string> Input_List = new List<string>(); // use biger version
// holds the more complex information
List<string> Input_Type = new List<string>();
//holds something...
List<string> Section_Type = new List<string>();
//exchange rate
List<string> Exchange_Rate = new List<string>();

// therse are temporary information
string Section = "";
List<string> Section_Units;
int Current_Section_Type = 0;
int Current_Section_Unit = 0;
namespace Paint_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int Current_Section_Type != 0)
            {
                Section_Type.append(Curent_Section_Type);
                Section == Section + "1";
                Section_Type = 1
            }
            else
            {
            Section == Section + "1";
            }
        }
    }
}
