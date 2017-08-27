using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EvenOrOdd
{
    public partial class evenOrOdd : Form
    {
        public evenOrOdd()
        {
            InitializeComponent();
        }

        private void btnEvenOdd_Click(object sender, EventArgs e)
        {
            int number;
            number = int.Parse(Microsoft.VisualBasic.Interaction.InputBox("Enter a number","",""));

            if (number % 2 == 0)
            {
                MessageBox.Show("Even");
            }
            else
            {
                MessageBox.Show("Odd");
            }
        }
    }
}
