using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Account;



namespace delegat
{
    public partial class Form1 : Form
    {
        AccountCl account;
        xxx xx;
        
        public Form1()
        {
            InitializeComponent();
        }
        public void hhh (string mes)
        {
            listBox1.Items.Add(mes);
        }
        public void h(string mes)
        {
            MessageBox.Show(mes);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            account = new AccountCl(Convert.ToInt32(textBox2.Text),Convert.ToString(textBox1.Text));
            account.RegisterHandler(hhh);
            xx = new xxx(Convert.ToInt32(textBox2.Text));
            xx.RegHandler(h);
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            account.Add(Convert.ToInt32(textBox3.Text));
            xx.Ad(Convert.ToInt32(textBox3.Text));

        }

        private void button2_Click(object sender, EventArgs e)
        {
            account.Take(Convert.ToInt32(textBox3.Text));
            xx.Ta(Convert.ToInt32(textBox3.Text));

        }
    }
}
