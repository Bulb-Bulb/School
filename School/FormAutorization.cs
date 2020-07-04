using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace School
{
    public partial class FormAutorization : Form
    {
        public FormAutorization()
        {
            InitializeComponent();
        }
        public static Users users = new Users();

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == "" && textBoxPassword.Text == "")
            {
                MessageBox.Show("Введите данные!", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                bool key = false;
                foreach (Users user in Program.School.Users)
                {
                    if (textBoxLogin.Text == user.login && textBoxPassword.Text == user.password)
                    {
                        key = true;
                        users.login = user.login;
                        users.password = user.password;
                        users.type = user.type;
                    }
                }
                if (!key)
                {
                    MessageBox.Show("Проверьте данные", "Пользователь не найден", 
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                }
                else
                {
                    FormMenu menu = new FormMenu(this);
                    menu.Show();
                    this.Hide();
                }
            }
        }
        private void FormAutorization_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) buttonEnter.PerformClick();
        }
        public struct Users
        {
            public string login;
            public string password;
            public string type;
        }

        private void FormAuthorization_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void FormAutorization_Load(object sender, EventArgs e)
        {

        }
    }
}
