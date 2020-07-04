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
    public partial class FormTeachers : Form
    {
        public FormTeachers()
        {
            InitializeComponent();
            ShowTeachers();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFirstName.Text != "" && textBoxLastName.Text != "" 
                && textBoxMiddleName.Text != "" && textBoxPhone.Text != "")
            {
                Teachers teachers = new Teachers();
                teachers.FirstName = textBoxFirstName.Text;
                teachers.MiddleName = textBoxMiddleName.Text;
                teachers.LastName = textBoxLastName.Text;
                teachers.Phone = textBoxPhone.Text;
                teachers.Email = textBoxEmail.Text;
                Program.School.Teachers.Add(teachers);
                Program.School.SaveChanges();
                ShowTeachers();
            }
            else { MessageBox.Show("Поля ФИО и " +
                "Телефон должны быть обязательно заполнены!", "Ошибка!", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewTeachers.SelectedItems.Count == 1)
            {
                if (textBoxFirstName.Text != "" && textBoxLastName.Text != "" 
                    && textBoxMiddleName.Text != "" && textBoxPhone.Text != "")
                {
                    Teachers teachers = listViewTeachers.SelectedItems[0].Tag as Teachers;
                    teachers.FirstName = textBoxFirstName.Text;
                    teachers.MiddleName = textBoxMiddleName.Text;
                    teachers.LastName = textBoxLastName.Text;
                    teachers.Phone = textBoxPhone.Text;
                    teachers.Email = textBoxEmail.Text;
                    Program.School.SaveChanges();
                    ShowTeachers();
                }
                else { MessageBox.Show("Поля ФИО и " +
                    "Телефон должны быть обязательно заполнены!", "Ошибка!", 
                    MessageBoxButtons.OK, MessageBoxIcon.Warning); }
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewTeachers.SelectedItems.Count == 1)
                {
                    Teachers teachers = listViewTeachers.SelectedItems[0].Tag as Teachers;
                    Program.School.Teachers.Remove(teachers);
                    Program.School.SaveChanges();
                    ShowTeachers();
                }
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", 
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ShowTeachers()
        {
            listViewTeachers.Items.Clear();
            foreach (Teachers teachers in Program.School.Teachers)
            {
                ListViewItem item = new ListViewItem(new string[]
                    {
                        teachers.Id.ToString(), teachers.FirstName,
                        teachers.MiddleName,teachers.LastName,teachers.Phone,
                        teachers.Email
                    }
                    );
                item.Tag = teachers;
                listViewTeachers.Items.Add(item);
            }
            listViewTeachers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        private void listViewTeachers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTeachers.SelectedItems.Count == 1)
            {
                Teachers teachers = listViewTeachers.SelectedItems[0].Tag as Teachers;
                textBoxFirstName.Text = teachers.FirstName;
                textBoxMiddleName.Text = teachers.MiddleName;
                textBoxLastName.Text = teachers.LastName;
                textBoxPhone.Text = teachers.Phone;
                textBoxEmail.Text = teachers.Email;

            }
            else
            {
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }

        private void FormTeachers_Load(object sender, EventArgs e)
        {

        }
    }
}
