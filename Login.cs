using ConsoleApp1.Utility;
using BooksellerApp.Data;
using BooksellerApp.Models;

namespace BooksellerApp
{
    public partial class Login : Form
    {
        SahafDBContext sahafDBContext = new SahafDBContext();
        public Login()
        {
            InitializeComponent();
        }
        public bool ValidateUser(string username, string password)
        {
            return sahafDBContext.Users
                                 .Any(user => user.UserName == username && user.Password == HashUtility.MdFive(password));
        }

        //Kullanýcý giriþi için kullanýcý adý ve þifre kontrolü
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "" && txtPassword.Text != "")
            {
                MessageBox.Show("UserName Required");
            }
            else if (txtUserName.Text != "" && txtPassword.Text == "")
            {
                MessageBox.Show("Password Required");
            }
            else if (txtUserName.Text == "" && txtPassword.Text == "")
            {
                MessageBox.Show("UserName And Password Empty! ");
            }
            else if (ValidateUser(txtUserName.Text, txtPassword.Text))
            {
                User user = sahafDBContext.Users
                                          .FirstOrDefault(u => u.UserName == txtUserName.Text);
                BookInventory bookInventory = new BookInventory(user.UserID);
                MessageBox.Show("Login Is Succesfull");
                this.Hide();
                bookInventory.Show();
            }
            else
            {
                MessageBox.Show("UserName Or Password is Wrong, Try Again!");
            }
        }
        private void lblNewEmployeeSignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            EmployeeSignUp employeeSignUp = new EmployeeSignUp();
            this.Hide();
            employeeSignUp.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
