using System;
using System.Windows.Forms;

namespace AnimalAdoption
{
    public partial class Customer : Form
    {
        int _customerId;
        public Customer(int customerId)
        {
            InitializeComponent();
            _customerId = customerId;
        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }
    }
}
