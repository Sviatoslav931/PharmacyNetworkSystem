using PharmaRepositories;
using System;
using System.Windows.Forms;
using System.Configuration;
using PharmaShop.Code;

namespace PharmaShop
{
    public partial class LoginForm : Form
    {
        private readonly IUserRepository _userRepository;

        public LoginForm()
        {
            _userRepository = new SqlUserRepository(ConfigurationManager.ConnectionStrings["PharmaDB"].ConnectionString);

            InitializeComponent();            
        }
        
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;
            var user = _userRepository.GetUserByLogin(login, password);
            if (user == null)
            {
                MessageBox.Show(this, "Invalid user name or password.", "Authentication Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                CurrentUser.Initialize(user);
                this.DialogResult = (user.Role == "administrator") ? DialogResult.Yes : DialogResult.OK;
                this.Close();
            }
        }
        
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}