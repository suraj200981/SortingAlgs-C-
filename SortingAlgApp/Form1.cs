using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SortingAlgApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            var a = txtInput.Text.ToString();
            int[] intArray = a.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            String intArraytoString = string.Join("", intArray);

            var meth = Program.bubbleSort(intArray);

            String resultToString = string.Join(", ", meth);

            txtOutput.Text = resultToString; 


        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtInput.Text = "";
            txtOutput.Text = "";
        }
    }
}
