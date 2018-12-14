using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DatabaseProgramVB
{
    public partial class EntityForm : Form
    {
        private SqlDataAdapter dataAdapter = new SqlDataAdapter();
        private string SelectedTableName;

        public EntityForm(bool isAdmin)
        {
            InitializeComponent();

            //if not manager
            if (!isAdmin) RestrictAdminPrivilege();
        }

        private void RestrictAdminPrivilege()
        {
            //Hide Controls not meant ofr the labourers
            vehicleList.Hide();
            vehicleListButton.Hide();

            storageList.Hide();
            storageListButton.Hide();
        }

        private void SelectDataBaseTable(string tableName)
        {
            SelectedTableName = tableName;

            //Note tableName is case sensitive

            //Set dataGrid datasource to data source
            GetData($"select * from {SelectedTableName}");
        }

        //Get data from database using query (selectCommand)
        private void GetData(string selectCommand)
        {
            //Idea Gotten from https://social.msdn.microsoft.com/Forums/en-US/779f97cf-0f09-4c5a-9cde-097a717179db/how-to-save-datagridview-changes-into-database?forum=winformsdatacontrols
            try
            {
                // Specify a connection string. Replace the given value with a
                // valid connection string for a Northwind SQL Server sample
                // database accessible to your system.
                string connectionString = Properties.Settings.Default.AllDataConnectionString;

                // Create a new data adapter based on the specified query.
                dataAdapter = new SqlDataAdapter(selectCommand, connectionString);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the data Source.
                DataTable table = new DataTable
                {
                    Locale = System.Globalization.CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                dataGridView1.DataSource = table;

                /*
                allDataDataSetBindingSource.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
                    */
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button1_Click(object sender, EventArgs e) => SelectDataBaseTable("Crop");

        private void Button4_Click_1(object sender, EventArgs e) => SelectDataBaseTable("Fertilizer");

        private void StorageListButton_Click(object sender, EventArgs e) => SelectDataBaseTable("Storage");

        private void VehicleListButton_Click(object sender, EventArgs e) => SelectDataBaseTable("Vehicles");
    }
}