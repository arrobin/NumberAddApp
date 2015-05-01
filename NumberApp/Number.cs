using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumberApp
{
    public partial class Number : Form
    {
        public Number()
        {
            InitializeComponent();
        }

        private void numberListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            double selecetedItem = Convert.ToDouble(numberListBox.SelectedIndex);
            MessageBox.Show("Seleceted Number is "+selecetedItem.ToString());
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            double number = Convert.ToDouble(numberTextBox.Text);

            for (int i = 0; i <= number; i++)
            {
                numberListBox.Items.Add(i);
            }
        }
    }
}