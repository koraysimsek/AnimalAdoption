namespace AnimalAdoption
{
    partial class AddAnimal
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSpecies = new System.Windows.Forms.TextBox();
            this.cmbAnimalTypes = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGEnder = new System.Windows.Forms.TextBox();
            this.chIsInfertile = new System.Windows.Forms.CheckBox();
            this.chIsVaccinated = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 271);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(263, 43);
            this.btnAdd.TabIndex = 35;
            this.btnAdd.Text = "Ekle";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Ad";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(12, 21);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(263, 20);
            this.txtName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 13);
            this.label2.TabIndex = 43;
            this.label2.Text = "Yaş";
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(12, 67);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(263, 20);
            this.txtAge.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 47;
            this.label3.Text = "Hayvan Türü";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 45;
            this.label4.Text = "Cins";
            // 
            // txtSpecies
            // 
            this.txtSpecies.Location = new System.Drawing.Point(12, 115);
            this.txtSpecies.Name = "txtSpecies";
            this.txtSpecies.Size = new System.Drawing.Size(263, 20);
            this.txtSpecies.TabIndex = 10;
            // 
            // cmbAnimalTypes
            // 
            this.cmbAnimalTypes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAnimalTypes.FormattingEnabled = true;
            this.cmbAnimalTypes.Location = new System.Drawing.Point(12, 158);
            this.cmbAnimalTypes.Name = "cmbAnimalTypes";
            this.cmbAnimalTypes.Size = new System.Drawing.Size(263, 21);
            this.cmbAnimalTypes.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 50;
            this.label5.Text = "Cinsiyeti";
            // 
            // txtGEnder
            // 
            this.txtGEnder.Location = new System.Drawing.Point(12, 206);
            this.txtGEnder.Name = "txtGEnder";
            this.txtGEnder.Size = new System.Drawing.Size(263, 20);
            this.txtGEnder.TabIndex = 20;
            // 
            // chIsInfertile
            // 
            this.chIsInfertile.AutoSize = true;
            this.chIsInfertile.Location = new System.Drawing.Point(12, 248);
            this.chIsInfertile.Name = "chIsInfertile";
            this.chIsInfertile.Size = new System.Drawing.Size(105, 17);
            this.chIsInfertile.TabIndex = 25;
            this.chIsInfertile.Text = "Kısırlaştırılmış Mı?";
            this.chIsInfertile.UseVisualStyleBackColor = true;
            // 
            // chIsVaccinated
            // 
            this.chIsVaccinated.AutoSize = true;
            this.chIsVaccinated.Location = new System.Drawing.Point(179, 248);
            this.chIsVaccinated.Name = "chIsVaccinated";
            this.chIsVaccinated.Size = new System.Drawing.Size(96, 17);
            this.chIsVaccinated.TabIndex = 30;
            this.chIsVaccinated.Text = "Aşıları Tam mı?";
            this.chIsVaccinated.UseVisualStyleBackColor = true;
            // 
            // AddAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 334);
            this.Controls.Add(this.chIsVaccinated);
            this.Controls.Add(this.chIsInfertile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtGEnder);
            this.Controls.Add(this.cmbAnimalTypes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSpecies);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddAnimal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddAnimal";
            this.Load += new System.EventHandler(this.AddAnimal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSpecies;
        private System.Windows.Forms.ComboBox cmbAnimalTypes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtGEnder;
        private System.Windows.Forms.CheckBox chIsInfertile;
        private System.Windows.Forms.CheckBox chIsVaccinated;
    }
}