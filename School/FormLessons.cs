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
    public partial class FormLessons : Form
    {
        public FormLessons()
        {
            InitializeComponent();
            ShowLessons();
            ShowTeachers();
        }

        private void FormLessons_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listViewLessons_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewLessons.SelectedItems.Count == 1)
            {
                Lessons lessons = listViewLessons.SelectedItems[0].Tag as Lessons;
                comboBoxTeachers.SelectedIndex = comboBoxTeachers.FindString(lessons.IdTeachers.ToString());
                textBoxName.Text = lessons.Name;
            }
            else
            {
                comboBoxTeachers.SelectedItem = null;
                textBoxName.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxTeachers.SelectedItem != null && textBoxName.Text != "")
            {
                Lessons lessons = new Lessons();
                lessons.IdTeachers = Convert.ToInt32(comboBoxTeachers.SelectedItem.ToString().Split('.')[0]);
                lessons.Name = textBoxName.Text;
                Program.School.Lessons.Add(lessons);
                Program.School.SaveChanges();
                ShowLessons();
            }
            else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK, 
                MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewLessons.SelectedItems.Count == 1)
            {
                if (comboBoxTeachers.SelectedItem != null && textBoxName.Text != "")
                {
                    Lessons lessons = listViewLessons.SelectedItems[0].Tag as Lessons;
                    lessons.IdTeachers = Convert.ToInt32(comboBoxTeachers.SelectedItem.ToString().Split('.')[0]);
                    lessons.Name = textBoxName.Text;
                    Program.School.SaveChanges();
                    ShowLessons();
                }
                else MessageBox.Show("Данные не выбраны", "Ошибка", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewLessons.SelectedItems.Count == 1)
                {
                    Lessons lessons = listViewLessons.SelectedItems[0].Tag as Lessons;
                    Program.School.Lessons.Remove(lessons);
                    Program.School.SaveChanges();
                    ShowLessons();
                }
                comboBoxTeachers.SelectedItem = null;
                textBoxName.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        void ShowTeachers()
        {
            comboBoxTeachers.Items.Clear();
            foreach (Teachers teachers in Program.School.Teachers)
            {
                string[] item = { teachers.Id.ToString() + ".", teachers.FirstName,
                        teachers.MiddleName, teachers.LastName,
                        teachers.Phone, teachers.Email };
                comboBoxTeachers.Items.Add(string.Join(" ", item));
            }
        }
        void ShowLessons()
        {
            listViewLessons.Items.Clear();
            foreach (Lessons lessons in Program.School.Lessons)
            {
                ListViewItem item = new ListViewItem(new string[] {

                   lessons.Teachers.LastName+" "+lessons.Teachers.FirstName+" "
                   +lessons.Teachers.MiddleName,
                   lessons.Name
                });
                item.Tag = lessons;
                listViewLessons.Items.Add(item);
            }
            listViewLessons.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
        void Name()
        {
            if (textBoxName.Text == "")
            {
                textBoxName.Text = DateTime.Now.ToString("dd.MM.yyyy");
            }
        }
    }
}
