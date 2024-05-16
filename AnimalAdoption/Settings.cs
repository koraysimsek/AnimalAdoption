using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace AnimalAdoption
{
    public partial class Settings : Form
    {
        private DbService dbService;
        DataRow customer;
        int _customerId;

        public Settings(int customerId)
        {
            InitializeComponent();
            _customerId = customerId;
            dbService = new DbService();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            customer = dbService.GetUserDetails(_customerId).Rows[0];
            var city = customer[6];
            var address = customer[7];
            txtCity.Text = city.ToString();
            txtAddress.Text = address.ToString();

        }

        private void btnAddressUpdate_Click(object sender, EventArgs e)
        {
            var city = txtCity.Text.ToString();
            var address = txtAddress.Text.ToString();
            if (!string.IsNullOrEmpty(txtCity.Text) && !string.IsNullOrEmpty(txtAddress.Text))
            {
                dbService.UpdateAddress(_customerId, city, address);
                MessageBox.Show("Şehir ve Adres başarıyla kaydedildi");
            }
            else
            {
                MessageBox.Show("Şehir ve Adres boş olamaz");
            }

        }
    }
}
