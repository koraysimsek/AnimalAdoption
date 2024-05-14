using System;
using System.Windows.Forms;

namespace AnimalAdoption
{
    public partial class AddAnimalType : Form
    {
        private DbService dbService;

        public AddAnimalType()
        {
            InitializeComponent();
            dbService = new DbService();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string description = txtDescription.Text;
            int save = dbService.AddAnimalType(name, description);
            if(save > 0)
            {
                MessageBox.Show("Ekleme işlemi başarılı");
                this.Close();
            }
        }
    }
}
