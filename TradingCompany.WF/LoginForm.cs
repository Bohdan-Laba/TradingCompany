using DAL.Interfaces;
using System;
using System.Windows.Forms;
using TradingCompany.BLL.Interfaces;
using TradingCompany.DTO;

namespace TradingCompany.WF
{
    public partial class LoginForm : Form
    {
        protected readonly IAuthManager _manager;
        public static UserDto _CurrentUser;
        public LoginForm(IAuthManager manager)
        {
            InitializeComponent();
            _manager = manager;
        }

        private void doLogin()
        {
            if (_manager.Login(txtboxLogin.Text, txtboxPassword.Text))
            {
                _CurrentUser = _manager.GetUserByLogin(txtboxLogin.Text);
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid login or password!");
                Application.Restart();
            }

        }
        private void bLogin_Click(object sender, EventArgs e)
        {
            doLogin();
        }

        private void bCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                doLogin();
            }
        }
    }
}
