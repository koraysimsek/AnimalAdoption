namespace AnimalAdoption
{
    partial class Admin
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
            this.lblName = new System.Windows.Forms.Label();
            this.dgAnimalTypes = new System.Windows.Forms.DataGridView();
            this.dgAnimals = new System.Windows.Forms.DataGridView();
            this.cmbAnimalTypes = new System.Windows.Forms.ComboBox();
            this.btnRefreshAnimalTypes = new System.Windows.Forms.Button();
            this.btnAddAnimalType = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnimalTypes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnimals)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(651, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // dgAnimalTypes
            // 
            this.dgAnimalTypes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAnimalTypes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgAnimalTypes.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgAnimalTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnimalTypes.Location = new System.Drawing.Point(12, 88);
            this.dgAnimalTypes.Name = "dgAnimalTypes";
            this.dgAnimalTypes.RowHeadersVisible = false;
            this.dgAnimalTypes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAnimalTypes.Size = new System.Drawing.Size(776, 182);
            this.dgAnimalTypes.TabIndex = 7;
            // 
            // dgAnimals
            // 
            this.dgAnimals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAnimals.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgAnimals.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnimals.Location = new System.Drawing.Point(12, 341);
            this.dgAnimals.Name = "dgAnimals";
            this.dgAnimals.RowHeadersVisible = false;
            this.dgAnimals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAnimals.Size = new System.Drawing.Size(776, 170);
            this.dgAnimals.TabIndex = 10;
            // 
            // cmbAnimalTypes
            // 
            this.cmbAnimalTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnimalTypes.FormattingEnabled = true;
            this.cmbAnimalTypes.Location = new System.Drawing.Point(577, 296);
            this.cmbAnimalTypes.Name = "cmbAnimalTypes";
            this.cmbAnimalTypes.Size = new System.Drawing.Size(211, 21);
            this.cmbAnimalTypes.TabIndex = 11;
            this.cmbAnimalTypes.SelectedIndexChanged += new System.EventHandler(this.cmbAnimalTypes_SelectedIndexChanged);
            // 
            // btnRefreshAnimalTypes
            // 
            this.btnRefreshAnimalTypes.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefreshAnimalTypes.Image = global::AnimalAdoption.Properties.Resources.refresh_20dp_FILL0_wght400_GRAD0_opsz201;
            this.btnRefreshAnimalTypes.Location = new System.Drawing.Point(12, 9);
            this.btnRefreshAnimalTypes.Name = "btnRefreshAnimalTypes";
            this.btnRefreshAnimalTypes.Size = new System.Drawing.Size(150, 62);
            this.btnRefreshAnimalTypes.TabIndex = 9;
            this.btnRefreshAnimalTypes.Text = "Yenile";
            this.btnRefreshAnimalTypes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefreshAnimalTypes.UseVisualStyleBackColor = false;
            this.btnRefreshAnimalTypes.Click += new System.EventHandler(this.btnRefreshAnimalTypes_Click);
            // 
            // btnAddAnimalType
            // 
            this.btnAddAnimalType.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAddAnimalType.Image = global::AnimalAdoption.Properties.Resources.add_20dp_FILL0_wght400_GRAD0_opsz20;
            this.btnAddAnimalType.Location = new System.Drawing.Point(168, 9);
            this.btnAddAnimalType.Name = "btnAddAnimalType";
            this.btnAddAnimalType.Size = new System.Drawing.Size(150, 62);
            this.btnAddAnimalType.TabIndex = 8;
            this.btnAddAnimalType.Text = "Ekle";
            this.btnAddAnimalType.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddAnimalType.UseVisualStyleBackColor = false;
            this.btnAddAnimalType.Click += new System.EventHandler(this.btnAddAnimalType_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDelete.Image = global::AnimalAdoption.Properties.Resources.delete_forever_20dp_FILL0_wght400_GRAD0_opsz20;
            this.btnDelete.Location = new System.Drawing.Point(324, 276);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 59);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Sil";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnAdd.Image = global::AnimalAdoption.Properties.Resources.add_20dp_FILL0_wght400_GRAD0_opsz201;
            this.btnAdd.Location = new System.Drawing.Point(168, 276);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(150, 59);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnRefresh.Image = global::AnimalAdoption.Properties.Resources.refresh_20dp_FILL0_wght400_GRAD0_opsz202;
            this.btnRefresh.Location = new System.Drawing.Point(12, 276);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(150, 59);
            this.btnRefresh.TabIndex = 2;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RoyalBlue;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.cmbAnimalTypes);
            this.Controls.Add(this.dgAnimals);
            this.Controls.Add(this.btnRefreshAnimalTypes);
            this.Controls.Add(this.btnAddAnimalType);
            this.Controls.Add(this.dgAnimalTypes);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAnimalTypes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnimals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgAnimalTypes;
        private System.Windows.Forms.Button btnAddAnimalType;
        private System.Windows.Forms.Button btnRefreshAnimalTypes;
        private System.Windows.Forms.DataGridView dgAnimals;
        private System.Windows.Forms.ComboBox cmbAnimalTypes;
    }
}