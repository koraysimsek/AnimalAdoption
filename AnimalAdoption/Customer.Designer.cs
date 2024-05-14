namespace AnimalAdoption
{
    partial class Customer
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
            this.btnAdopt = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.cmbAnimalTypes = new System.Windows.Forms.ComboBox();
            this.dgAnimals = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.btnGetAdpotion = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgAnimals)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdopt
            // 
            this.btnAdopt.Location = new System.Drawing.Point(130, 157);
            this.btnAdopt.Name = "btnAdopt";
            this.btnAdopt.Size = new System.Drawing.Size(106, 41);
            this.btnAdopt.TabIndex = 5;
            this.btnAdopt.Text = "Sahiplen";
            this.btnAdopt.UseVisualStyleBackColor = true;
            this.btnAdopt.Click += new System.EventHandler(this.btnAdopt_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(12, 157);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(106, 41);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "Yenile";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.Location = new System.Drawing.Point(112, 12);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(50, 16);
            this.lblName.TabIndex = 6;
            this.lblName.Text = "label1";
            // 
            // cmbAnimalTypes
            // 
            this.cmbAnimalTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnimalTypes.FormattingEnabled = true;
            this.cmbAnimalTypes.Location = new System.Drawing.Point(749, 168);
            this.cmbAnimalTypes.Name = "cmbAnimalTypes";
            this.cmbAnimalTypes.Size = new System.Drawing.Size(211, 21);
            this.cmbAnimalTypes.TabIndex = 12;
            this.cmbAnimalTypes.SelectedIndexChanged += new System.EventHandler(this.cmbAnimalTypes_SelectedIndexChanged);
            // 
            // dgAnimals
            // 
            this.dgAnimals.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgAnimals.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgAnimals.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgAnimals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAnimals.Location = new System.Drawing.Point(12, 204);
            this.dgAnimals.Name = "dgAnimals";
            this.dgAnimals.RowHeadersVisible = false;
            this.dgAnimals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgAnimals.Size = new System.Drawing.Size(948, 340);
            this.dgAnimals.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Image = global::AnimalAdoption.Properties.Resources.settings_24dp_FILL0_wght400_GRAD0_opsz24;
            this.button2.Location = new System.Drawing.Point(866, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 93);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnGetAdpotion
            // 
            this.btnGetAdpotion.Image = global::AnimalAdoption.Properties.Resources.home_24dp_FILL0_wght400_GRAD0_opsz24__1_;
            this.btnGetAdpotion.Location = new System.Drawing.Point(12, 12);
            this.btnGetAdpotion.Name = "btnGetAdpotion";
            this.btnGetAdpotion.Size = new System.Drawing.Size(94, 93);
            this.btnGetAdpotion.TabIndex = 1;
            this.btnGetAdpotion.UseVisualStyleBackColor = true;
            this.btnGetAdpotion.Click += new System.EventHandler(this.btnGetAdpotion_Click);
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 556);
            this.Controls.Add(this.dgAnimals);
            this.Controls.Add(this.cmbAnimalTypes);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnAdopt);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGetAdpotion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer";
            this.Load += new System.EventHandler(this.Customer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAnimals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGetAdpotion;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAdopt;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ComboBox cmbAnimalTypes;
        private System.Windows.Forms.DataGridView dgAnimals;
    }
}