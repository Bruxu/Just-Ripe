namespace DatabaseProgramVB
{
    partial class EntityForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cropList = new System.Windows.Forms.Label();
            this.vehicleList = new System.Windows.Forms.Label();
            this.storageList = new System.Windows.Forms.Label();
            this.cropListButton = new System.Windows.Forms.Button();
            this.vehicleListButton = new System.Windows.Forms.Button();
            this.storageListButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.allDataDataSet = new DatabaseProgramVB.AllDataDataSet();
            this.cropBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cropTableAdapter = new DatabaseProgramVB.AllDataDataSetTableAdapters.CropTableAdapter();
            this.allDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new DatabaseProgramVB.AllDataDataSetTableAdapters.StaffTableAdapter();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.fertilizerList = new System.Windows.Forms.Label();
            this.fertilizerListButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // cropList
            // 
            this.cropList.AutoSize = true;
            this.cropList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cropList.Location = new System.Drawing.Point(81, 112);
            this.cropList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cropList.Name = "cropList";
            this.cropList.Size = new System.Drawing.Size(99, 25);
            this.cropList.TabIndex = 0;
            this.cropList.Text = "Crop List";
            // 
            // vehicleList
            // 
            this.vehicleList.AutoSize = true;
            this.vehicleList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleList.Location = new System.Drawing.Point(59, 219);
            this.vehicleList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.vehicleList.Name = "vehicleList";
            this.vehicleList.Size = new System.Drawing.Size(124, 25);
            this.vehicleList.TabIndex = 1;
            this.vehicleList.Text = "Vehicle List";
            // 
            // storageList
            // 
            this.storageList.AutoSize = true;
            this.storageList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storageList.Location = new System.Drawing.Point(52, 346);
            this.storageList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.storageList.Name = "storageList";
            this.storageList.Size = new System.Drawing.Size(128, 25);
            this.storageList.TabIndex = 2;
            this.storageList.Text = "Storage List";
            // 
            // cropListButton
            // 
            this.cropListButton.Location = new System.Drawing.Point(209, 114);
            this.cropListButton.Margin = new System.Windows.Forms.Padding(4);
            this.cropListButton.Name = "cropListButton";
            this.cropListButton.Size = new System.Drawing.Size(76, 26);
            this.cropListButton.TabIndex = 6;
            this.cropListButton.Text = "Go";
            this.cropListButton.UseVisualStyleBackColor = true;
            this.cropListButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // vehicleListButton
            // 
            this.vehicleListButton.Location = new System.Drawing.Point(209, 222);
            this.vehicleListButton.Margin = new System.Windows.Forms.Padding(4);
            this.vehicleListButton.Name = "vehicleListButton";
            this.vehicleListButton.Size = new System.Drawing.Size(76, 26);
            this.vehicleListButton.TabIndex = 7;
            this.vehicleListButton.Text = "Go";
            this.vehicleListButton.UseVisualStyleBackColor = true;
            // 
            // storageListButton
            // 
            this.storageListButton.Location = new System.Drawing.Point(209, 345);
            this.storageListButton.Margin = new System.Windows.Forms.Padding(4);
            this.storageListButton.Name = "storageListButton";
            this.storageListButton.Size = new System.Drawing.Size(76, 26);
            this.storageListButton.TabIndex = 8;
            this.storageListButton.Text = "Go";
            this.storageListButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(383, 85);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(783, 354);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // allDataDataSet
            // 
            this.allDataDataSet.DataSetName = "AllDataDataSet";
            this.allDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cropBindingSource
            // 
            this.cropBindingSource.DataMember = "Crop";
            this.cropBindingSource.DataSource = this.allDataDataSet;
            // 
            // cropTableAdapter
            // 
            this.cropTableAdapter.ClearBeforeFill = true;
            // 
            // allDataDataSetBindingSource
            // 
            this.allDataDataSetBindingSource.DataSource = this.allDataDataSet;
            this.allDataDataSetBindingSource.Position = 0;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.allDataDataSetBindingSource;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // fertilizerList
            // 
            this.fertilizerList.AutoSize = true;
            this.fertilizerList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fertilizerList.Location = new System.Drawing.Point(48, 280);
            this.fertilizerList.Name = "fertilizerList";
            this.fertilizerList.Size = new System.Drawing.Size(135, 25);
            this.fertilizerList.TabIndex = 1;
            this.fertilizerList.Text = "Fertilizer List";
            // 
            // fertilizerListButton
            // 
            this.fertilizerListButton.Location = new System.Drawing.Point(210, 280);
            this.fertilizerListButton.Name = "fertilizerListButton";
            this.fertilizerListButton.Size = new System.Drawing.Size(75, 23);
            this.fertilizerListButton.TabIndex = 10;
            this.fertilizerListButton.Text = "Go";
            this.fertilizerListButton.UseVisualStyleBackColor = true;
            this.fertilizerListButton.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // EntityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1349, 554);
            this.Controls.Add(this.fertilizerListButton);
            this.Controls.Add(this.fertilizerList);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.storageListButton);
            this.Controls.Add(this.vehicleListButton);
            this.Controls.Add(this.cropListButton);
            this.Controls.Add(this.storageList);
            this.Controls.Add(this.vehicleList);
            this.Controls.Add(this.cropList);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EntityForm";
            this.Text = "Form2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EntityForm_FormClosing);
            this.Load += new System.EventHandler(this.EntityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cropBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.allDataDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cropList;
        private System.Windows.Forms.Label vehicleList;
        private System.Windows.Forms.Label storageList;
        private System.Windows.Forms.Button cropListButton;
        private System.Windows.Forms.Button vehicleListButton;
        private System.Windows.Forms.Button storageListButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AllDataDataSet allDataDataSet;
        private System.Windows.Forms.BindingSource cropBindingSource;
        private AllDataDataSetTableAdapters.CropTableAdapter cropTableAdapter;
        private System.Windows.Forms.BindingSource allDataDataSetBindingSource;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private AllDataDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label fertilizerList;
        private System.Windows.Forms.Button fertilizerListButton;
    }
}