using ItemNamespace;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CashierApplication
{
    public partial class Form1 : Form
    {
        DiscountedItem item;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

            string name = textBox1.Text;
            double price = Convert.ToDouble(textBox2.Text);
            int quantity = Convert.ToInt32(textBox3.Text);
            double discount = Convert.ToDouble(textBox4.Text);

            item = new DiscountedItem(name, price, quantity, discount);
            label5.Text = "Total amount: " + item.getTotalPrice().ToString("F2");

        }
        private void button2_Click(object sender, EventArgs e)
        {
            {
                double payment = Convert.ToDouble(textBox5.Text);
                item.setPayment(payment);
                label7.Text = "Change: " + item.getChange().ToString("F2");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


        
        

        
    


        
        

        
    
    

