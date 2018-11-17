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

        string[] Usernames = { "Manager", "Labourer" }; // users 
        string[] Passwords = { "Manager1", "Labourer1" };  // passwords for the users

        private void button1_Click(object sender, EventArgs e)
        {
            //condition for the next form appear 
            if (Usernames.Contains(textBox1.Text) && Passwords.Contains(textBox2.Text) &&
                Array.IndexOf(Usernames, textBox1.Text) == Array.IndexOf(Passwords, textBox2.Text
                ))
            {
                EntityForm f2 = new EntityForm(); // a new form is open by a click on the button
                Hide();
            f2.ShowDialog();
            }
            else
                MessageBox.Show("The Username or Password is incorrect, please try again");
        }
    }
    }
