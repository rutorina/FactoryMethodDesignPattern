using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FactoryMethod;

namespace FactoryMethodDesignPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Coffee coffee = null;
        CoffeeHouse coffeeHouse = null;        

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            coffeeHouse = new EspressoCofeeHouse();
            label1.Text = "Espresso Cofee House";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            coffeeHouse = new AmericanoCofeeHouse();
            label1.Text = "Americano Cofee House";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            coffeeHouse = new LatteCofeeHouse();
            label1.Text = "Latte Cofee House";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            coffeeHouse = new IcedCofeeHouse();
            label1.Text = "Iced Cofee House";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            coffeeHouse = new MacchiattoCofeeHouse();
            label1.Text = "Macchiatto Cofee House";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(coffeeHouse == null)
            {
                MessageBox.Show("Choose coffee house!");
            }
            else
            {
                coffee = coffeeHouse.MakeCofee();
                coffee.listBox = listBox1;
                coffee.show();
            }
        }

    }
}
