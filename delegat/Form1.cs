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
        class Mani
        {
            
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            account = new AccountCl(Convert.ToInt32(textBox2),Convert.ToString(textBox1));
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            account.Add(Convert.ToInt32(textBox1));
            listBox1.Items.Add(account);
        }
    }
}
