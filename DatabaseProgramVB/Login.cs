using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DatabaseProgramVB
{
    public partial class Login : Form
    {
        SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Generalbruxu\Desktop\DatabaseProgramVB\Just-Ripe\DatabaseProgramVB\AllData.mdf;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        //string[] Usernames = { "Manager", "Labourer" }; // users 
        //string[] Passwords = { "Manager1", "Labourer1" };  // passwords for the users

       /* private void TryLogin()
        {
            condition for the next form appear 
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
           */
        private void btn_login_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlDataAdapter loginAdapter = new SqlDataAdapter("SELECT [Occupation] from [dbo].[Staff] WHERE Username = '"+ textBox1.Text + "' and Password = '"+ textBox2.Text +"'", sqlcon);
            DataTable result = new DataTable();
            loginAdapter.Fill(result);


            if (result.Rows.Count != 1) {
                MessageBox.Show("Error!! Please Try again!");
                return;
            }

            switch (result.Rows[0]["Occupation"] as string)
                {
                    // User Ocupation determines the next form that comes after login.
                    // Occupation is in mixed case, either change characters to upper or lower case. 
                    case "Manager":
                        {
                            Hide();
                            EntityForm entity = new EntityForm(true);

                            //close sql connection and login form in the background when form closes
                            entity.FormClosing += delegate { sqlcon.Close(); Close(); };

                            MessageBox.Show("Login successful!");
                            entity.Show();
                            break;
                        }
                    case "Labourer":
                        {
                            Hide();
                            EntityForm entity = new EntityForm(false);

                            //close sql connection and login form in the background when form closes
                            entity.FormClosing += delegate { sqlcon.Close(); Close(); };

                            MessageBox.Show("Login successful!");
                            entity.Show();
                            break;
                           
                        }


                }
        }
    }


    }

