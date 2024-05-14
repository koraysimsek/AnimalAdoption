using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AnimalAdoption
{
    public partial class Admin : Form
    {
        DbService dbService;
        DataRow admin;
        DataTable animalTypes;
        DataTable animals;
        int _adminId;
        public Admin(int adminId)
        {
            InitializeComponent();
            _adminId = adminId;
            dbService = new DbService();
        }
        
        private void Admin_Load(object sender, EventArgs e)
        {
            admin = dbService.GetUserDetails(_adminId).Rows[0];
            var name = admin[3] + " " + admin[4];
            lblName.Text = name;
            GetAnimalTypes();
        }

        private void GetAnimalTypes()
        {
            animalTypes = dbService.GetAnimalTypes();
            dgAnimalTypes.DataSource = animalTypes;
            cmbAnimalTypes.DisplayMember = "Code";
            cmbAnimalTypes.ValueMember = "Id";
            cmbAnimalTypes.DataSource = animalTypes.Copy();
        }

        private void btnRefreshAnimalTypes_Click(object sender, EventArgs e)
        {
            GetAnimalTypes();
        }

        private void btnAddAnimalType_Click(object sender, EventArgs e)
        {
            AddAnimalType addAnimalType = new AddAnimalType();
            addAnimalType.ShowDialog();
            GetAnimalTypes();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddAnimal addAnimal = new AddAnimal();
            addAnimal.ShowDialog();
            GetAnimals();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetAnimals();
        }

        void GetAnimals()
        {
            var animalTypeId = Convert.ToInt32(cmbAnimalTypes.SelectedValue);
            animals = dbService.GetAnimalsForAdmin(animalTypeId);
            dgAnimals.DataSource = animals;
        }

        private void cmbAnimalTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAnimals();
        }
        
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            var selectedRow = dgAnimals.SelectedRows[0];
            if(selectedRow != null)
            {
                 int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                 var delete = dbService.DeleteAnimal(id);
                if(delete > 0)
                {
                    GetAnimals();
                }
            }
        }

    }
}
