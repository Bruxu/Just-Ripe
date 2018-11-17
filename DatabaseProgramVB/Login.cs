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

        private void TryLogin()
        {
            //condition for the next form appear 
            if (Usernames.Contains(textBox1.Text) && Passwords.Contains(textBox2.Text) &&
               Array.IndexOf(Usernames, textBox1.Text) == Array.IndexOf(Passwords, textBox2.Text
               ))

            {
                Hide();//Hide current form
                EntityForm f2 = new EntityForm() // a new form is open by a click on the button
                                        //Add closing event to the entity object f2

                f2.FormClosing += delegate
                {
                    Close();//close current form  
                };
                f2.ShowDialog();
            }
            else
                MessageBox.Show("The Username or Password is incorrect, please try again");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TryLogin();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //if down arrow key is pressed change focus to password box
            if (e.KeyCode == Keys.Down)
            {
                TextBox1.Focus();
            }
        }

        private void TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            //Run login method if the enter key is pressed
            if (e.KeyCode == Keys.Enter)
            {
                TryLogin();
            }
            if (e.KeyCode == Keys.Up)
            {
                textBox1.Focus();
            }
        }


    }
}
