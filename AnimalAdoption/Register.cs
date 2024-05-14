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
    public partial class Register : Form
    {
        private DbService dbService;
        public Register()
        {
            InitializeComponent();
            dbService = new DbService(); //instance
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string userName = txtFirstName.Text;
            string password = txtPassword.Text;
            string firstName = txtFirstName.Text;
            string lastName = txtLastName.Text;
            string city = txtCity.Text;
            string address = txtAddress.Text;
            DateTime birthDate = dtpBirthDate.Value;
            bool isValid = checker(userName, password, firstName, lastName, city, address);
            if(isValid )
            {
                int isRegister = dbService.Register(userName, password, firstName, lastName, birthDate, city, address);
                if (isRegister > 0)
                {
                    MessageBox.Show("Kayıt Başarılı Hoş Geldin " + firstName + " " + lastName + ", giriş yapabilirsin.");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Lütfen bilgileri eksiksiz giriniz");
            }
            
        }

        private bool checker(params string[] args)
        {
            foreach (var arg in args)
            {
                if (String.IsNullOrEmpty(arg))
                    return false;
            }
            return true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
