using System;
using System.Data;
using System.Windows.Forms;

namespace AnimalAdoption
{
    public partial class Customer : Form
    {
        DbService dbService;
        int _customerId;
        DataRow customer;
        DataTable animals;
        DataTable animalTypes;

        public Customer(int customerId)
        {
            InitializeComponent();
            _customerId = customerId;
            dbService = new DbService();
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            customer = dbService.GetUserDetails(_customerId).Rows[0];
            var name = customer[3] + " " + customer[4];
            lblName.Text = name;
            GetAnimalTypes();
            GetAnimals();
        }

        private void GetAnimalTypes()
        {
            animalTypes = dbService.GetAnimalTypes();
            cmbAnimalTypes.DisplayMember = "Code";
            cmbAnimalTypes.ValueMember = "Id";
            cmbAnimalTypes.DataSource = animalTypes.Copy();
        }

        void GetAnimals()
        {
            var animalTypeId = Convert.ToInt32(cmbAnimalTypes.SelectedValue);
            animals = dbService.GetAnimalsForCustomer(animalTypeId);
            dgAnimals.DataSource = animals;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetAnimals();
        }

        private void cmbAnimalTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetAnimals();
        }

        private void btnAdopt_Click(object sender, EventArgs e)
        {
            var selectedRow = dgAnimals.SelectedRows[0];
            var userId = Convert.ToInt32(customer[0]);
            if (selectedRow != null)
            {
                int id = Convert.ToInt32(selectedRow.Cells[0].Value);
                var add = dbService.AddAdoption(userId, id);
                if (add > 0)
                {
                    dbService.UpdateAnimal(id, true);
                    MessageBox.Show("Başarıyla Sahiplenildi");
                    GetAnimals();
                }
            }
        }

        private void btnGetAdpotion_Click(object sender, EventArgs e)
        {
            CustomerAdoption customerAdoption = new CustomerAdoption(_customerId);
            customerAdoption.ShowDialog();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(_customerId);
            settings.ShowDialog();
        }
    }
}
