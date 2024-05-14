using System;
using System.Data;
using System.Windows.Forms;

namespace AnimalAdoption
{
    public partial class CustomerAdoption : Form
    {
        DbService dbService;
        int _customerId;
        DataTable customerAdoption;
        public CustomerAdoption(int customerId)
        {
            InitializeComponent();
            _customerId = customerId;
            dbService = new DbService();
        }

        private void CustomerAdoption_Load(object sender, EventArgs e)
        {
            GetCustomerAdoption();
        }
        
        public void GetCustomerAdoption()
        {
            customerAdoption = dbService.GetCustomerAdoption(_customerId);
            dgAdoption.DataSource = customerAdoption;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            GetCustomerAdoption();
        }
    }
}
