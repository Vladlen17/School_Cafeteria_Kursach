using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafeteria.App
{
    public partial class UsersAuthForm : Form
    {
        private MainForm mainForm;
        public UsersAuthForm()
        {
            InitializeComponent();
        }

        private void btnAuthUser(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if(Auth.Check(login, password))
            {
                MessageBox.Show("Вход выполнен", "Авторизация пользователя", MessageBoxButtons.OK, MessageBoxIcon.Information);
                mainForm = new MainForm();
                mainForm.ShowDialog();
            }

        }
    }
}
