using System;
using System.Linq;
using System.Windows.Forms;

namespace AnimalAdoption
{
    public partial class Form1 : Form
    {
        private DbService dbService;

        public Form1()
        {
            InitializeComponent();
            dbService = new DbService();
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.ShowDialog();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (!String.IsNullOrEmpty(username) && !String.IsNullOrEmpty(password))
            {
                var result = dbService.Login(username, password).FirstOrDefault();
                int type = result.Key;
                if(type == 0)
                {
                    MessageBox.Show("Kullanıcı bulunamamıştır. Kullanıcı adı veya şifre hatalı");
                }
                else if(type == 1)
                {
                    // yönetici 
                    Admin admin = new Admin(result.Value);
                    admin.ShowDialog();
                }
                else if(type == 2)
                {
                    //müşteri sayfası
                    Customer customer = new Customer(result.Value);
                    customer.ShowDialog();
                }             
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
