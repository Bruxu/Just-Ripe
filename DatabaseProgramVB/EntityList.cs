using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DatabaseProgramVB
{
    public partial class EntityForm : Form
    {
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private string SelectedTableName;
        public EntityForm()
        {
            InitializeComponent();

            
        }

        private void SelectDataBaseTable(string tableName)
        {
            SelectedTableName = tableName;

            //Note tableName is case sensitive

            //Set dataGrid datasource to binding source
            //Change the binding source data to the data of the selected table
            dataGridView1.DataSource = allDataDataSetBindingSource;
            GetData($"select * from {SelectedTableName}");
            
        }

        private void EntityForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'allDataDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.allDataDataSet.Staff);
            // TODO: This line of code loads data into the 'allDataDataSet.Crop' table. You can move, or remove it, as needed.
            this.cropTableAdapter.Fill(this.allDataDataSet.Crop);

        }
        //Get data from database using query (selectCommand)
        //Save data to binding source
          private void GetData(string selectCommand)
         {
            //Idea Gotten from https://social.msdn.microsoft.com/Forums/en-US/779f97cf-0f09-4c5a-9cde-097a717179db/how-to-save-datagridview-changes-into-database?forum=winformsdatacontrols
            try
            {
                // Specify a connection string. Replace the given value with a 
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                string connectionString =Properties.Settings.Default.AllDataConnectionString;

                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                allDataDataSetBindingSource.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //
            SelectDataBaseTable("Crop");
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            //Try to save dataBase whenever a value changes
            try
            {
                dataAdapter.Update((DataTable)allDataDataSetBindingSource.DataSource);
            }
            catch 
            {
                
            }
            
        }
    }
}
