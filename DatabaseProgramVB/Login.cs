using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProgramVB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string name;
            Console.WriteLine("Enter your username:");
            name = Console.ReadLine();
            Console.WriteLine(name);

        
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
