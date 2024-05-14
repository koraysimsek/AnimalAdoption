using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalAdoption
{
    public partial class AddAnimal : Form
    {
        DbService dbService;

        public AddAnimal()
        {
            InitializeComponent();
            dbService = new DbService();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                int age = Convert.ToInt32(txtAge.Text);
                string species = txtSpecies.Text;
                int animalTypeId = Convert.ToInt32(cmbAnimalTypes.SelectedValue);
                string gender = txtGEnder.Text;
                bool isInfertile = chIsInfertile.Checked;
                bool isVaccinated = chIsVaccinated.Checked;
                int affectedRow = dbService.AddAnimal(name, age, species, animalTypeId, gender, isInfertile, isVaccinated, false);
                MessageBox.Show("Başarıyla eklendi");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Lütfen bilgileri doğru girin");
            }

        }
        private void GetAnimalTypes()
        {
            cmbAnimalTypes.DisplayMember = "Code";
            cmbAnimalTypes.ValueMember = "Id";
            cmbAnimalTypes.DataSource = dbService.GetAnimalTypes();
        }

        private void AddAnimal_Load(object sender, EventArgs e)
        {
            GetAnimalTypes();
        }
    }
}
