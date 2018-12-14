using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace DatabaseProgramVB
{
    public partial class Login : Form
    {
        private SqlConnection sqlcon;

        public Login()
        {
            //Find database in program path
            //Create connection string to database
            string path = Directory.GetCurrentDirectory();
            string connection = Properties.Settings.Default.AllDataConnectionString;// $@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename={path}\AllData.mdf;Integrated Security=True";

            //initilaize sql connection
            sqlcon = new SqlConnection(connection);

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

        private void Btn_login_Click(object sender, EventArgs e)
        {
            sqlcon.Open();
            SqlDataAdapter loginAdapter = new SqlDataAdapter($"SELECT [Occupation] from [dbo].[Staff] WHERE Username = '{ textBox1.Text }' and Password = '{textBox2.Text}'", sqlcon);

            DataTable result = new DataTable();
            loginAdapter.Fill(result);

            if (result.Rows.Count != 1)
            {
                MessageBox.Show("Error!! Please Try again!");
                return;
            }
            Hide();

            // User Ocupation determines the next form that comes after login.
            // Occupation is in mixed case, either change characters to upper or lower case.
            // if it's not a manager the code will run as a labourer as default
            EntityForm entity = result.Rows[0]["Occupation"] as string == "Manager" ? new EntityForm(true) : new EntityForm(false);

            //close sql connection and login form in the background when form closes
            entity.FormClosing += delegate { sqlcon.Close(); Close(); };

            //Show main form
            entity.Show();
        }
    }
}