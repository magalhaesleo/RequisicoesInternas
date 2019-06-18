using Requisições_Internas.Application.Features.Users;
using Requisições_Internas.Domain.Features.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Requisições_Internas.WinApp.Features.Users
{
    public partial class UserLogin : Form
    {
        IUserService _userService;
        public bool Authenticated { get; private set; } = false;
        public User User { get; private set; }
        public UserLogin(IUserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string user = txtUser.Text;
            string password = txtPassword.Text;
            User userAuth = _userService.Authenticate(user, password);

            if (userAuth != null)
            {
                Authenticated = true;
                User = userAuth;
                this.Close();
            }
            else
            {
                txtUser.Text = "";
                txtPassword.Text = "";
                txtUser.Focus();
                MessageBox.Show("Dados invalidos");
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                btnLogin.PerformClick();
        }
    }
}
