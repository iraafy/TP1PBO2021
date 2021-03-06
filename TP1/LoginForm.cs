using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            tb_password.PasswordChar = '*';
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username;
            String password;
            username = tb_username.Text;
            password = tb_password.Text;
            if (username.Equals(""))
            {
                MessageBox.Show("Please Enter Username", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (password.Equals("pbo123") && username != "")
            {
                HomePage obj = new HomePage();
                if (obj == null)
                {
                    obj.Parent = this;
                }
                obj.Show();
                this.Hide();
                tb_username.Clear();
                tb_password.Clear();
            }
            else
            {
                MessageBox.Show("Login Failed, Incorrect Password", "information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void reset_Click(object sender, EventArgs e)
        {
            tb_username.Clear();
            tb_password.Clear();
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            btnHide.BringToFront();
            tb_password.PasswordChar = '\0';
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            btnShow.BringToFront();
            tb_password.PasswordChar = '*';
        }
    }
}