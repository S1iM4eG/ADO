using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
    public partial class HumanForm : Form
    {
        internal Models.Human human;
        public HumanForm()
        {
            InitializeComponent();
        }
        protected virtual void Compress()
        {
            human = new Models.Human(
                Convert.ToInt32(labelID.Text == "" ? "0" : labelID.Text.Split(':').Last()),
                textBoxLastName.Text,
                textBoxFirstName.Text,
                textBoxMiddleName.Text,
                dtpBirthDate.Value.ToString("yyyy-MM-dd"),
                textBoxEmail.Text,
                textBoxPhone.Text,
                pictureBoxPhoto.Image);
        }
        protected virtual void Extract()
        {
            labelID.Text = $"ID:{human.id}";
            textBoxLastName.Text = human.last_name;
            textBoxFirstName.Text = human.first_name;
            textBoxMiddleName.Text = human.middle_name;
            dtpBirthDate.Value = Convert.ToDateTime(human.birth_date);
            textBoxEmail.Text = human.email;
            textBoxPhone.Text = human.phone;
            pictureBoxPhoto.Image = human.photo;
        }
        protected virtual void buttonOk_Click(object sender, EventArgs e)
        {
            Compress();
        }
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog(); // Создаем окно выбора файла
            dialog.Filter = "JPG files|*.jpg|PNG files|*.png|All image files|*.png;*.jpg;|All files|*.*"; // Настраиваем фильтры, которые будут отображать нужные типы файлов
            // Фильтр - это строка, которая состоит из пар "Описание|Маска", разделенных символом "|". 
            // Описание - это текст, который будет отображаться в окне выбора файла, а Маска - это шаблон, который определяет, какие файлы будут отображаться при выборе данного фильтра. 
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxPhoto.Image = Image.FromFile(dialog.FileName);
            }
        }
    }
}
