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
    public partial class FormMenu : Form
    {
        private FormAutorization autorization;
        public FormMenu(FormAutorization autorization)
        {
            InitializeComponent();
            this.autorization = autorization;
            if (FormAutorization.users.type == "employee")
            {
                buttonOpenTeachers.Enabled = false;
            }
        }
        private void buttonOpenTeachers_Click(object sender, EventArgs e)
        {
            Form formTeachers = new FormTeachers();
            formTeachers.Show();
        }

        private void buttonOpenLessons_Click(object sender, EventArgs e)
        {
            Form formLessons = new FormLessons();
            formLessons.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
        private void FormMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            autorization.Show();
        }

    }
}
