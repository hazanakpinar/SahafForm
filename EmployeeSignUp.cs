using ConsoleApp1.Utility;
using BooksellerApp.Data;
using BooksellerApp.Models;

namespace BooksellerApp
{
    public partial class EmployeeSignUp : Form
    {
        SahafDBContext sahafDBContext = new SahafDBContext();
        public EmployeeSignUp()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Kullanıcı adı kontrolü
            bool userExists = sahafDBContext.Users.Any(u => u.UserName == txtUserName.Text);
            if (userExists)
            {
                MessageBox.Show("Username already taken. Please enter another username!");
            }
            else
            {
                User user = new User()
                {
                    UserName = txtUserName.Text,
                    Password = HashUtility.MdFive(txtPassword.Text),
                    EmployeeName = txtEmployeeName.Text,
                    EmployeeSurname = txtEmployeeSurname.Text
                };
                sahafDBContext.Users.Add(user);
                sahafDBContext.SaveChanges();
                MessageBox.Show("New User Added");
                Login login = new Login();
                login.Show();
                this.Hide();
            }
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }
    }
}
