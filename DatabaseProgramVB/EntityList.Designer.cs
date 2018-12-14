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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cropList = new System.Windows.Forms.Label();
            this.vehicleList = new System.Windows.Forms.Label();
            this.storageList = new System.Windows.Forms.Label();
            this.cropListButton = new System.Windows.Forms.Button();
            this.vehicleListButton = new System.Windows.Forms.Button();
            this.storageListButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.fertilizerList = new System.Windows.Forms.Label();
            this.fertilizerListButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.cropListButton.Click += new System.EventHandler(this.Button1_Click);
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
            this.vehicleListButton.Click += new System.EventHandler(this.VehicleListButton_Click);
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
            this.storageListButton.Click += new System.EventHandler(this.StorageListButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(383, 85);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(783, 354);
            this.dataGridView1.TabIndex = 9;
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
            this.fertilizerListButton.Click += new System.EventHandler(this.Button4_Click_1);
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
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label fertilizerList;
        private System.Windows.Forms.Button fertilizerListButton;
    }
}