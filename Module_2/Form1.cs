using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module_2
{
    public partial class Form1 : Form
    {
        string[] user1 = {"Иванова","Мария","Петровна","Женский",
            "23.07.1999","Не женат","Работник KFC" };
        string[] user2 = {"Петров","Петя","Петрович","Мужской",
            "45.12.2003","Не жеенат","Выпускник" };
        string[] user3 = {"Анастасия","Листова","Олеговна",
            "Женский","31.02.1893","Разведена","Министр здравохранения г.Омск" };
        public Form1()
        {
            InitializeComponent();
            this.Load += Form1_Load;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListUser.Focus();
            ListUser.SelectedIndexChanged += Selected;
        }
        private void Selected(object sender, EventArgs e)
        {
            ComboBox box = sender as ComboBox;
            if (box.SelectedIndex == 0 || box.SelectedIndex == 1 || box.SelectedIndex == 2)
            {
                LastName.AutoCheck = true;
                FirstName.AutoCheck = true;
                Patronymic.AutoCheck = true;
                Gender.AutoCheck = true;
                DateOfBirth.AutoCheck = true;
                FamilyStatus.AutoCheck = true;
                DopInfo.AutoCheck = true;

                LastName.Checked = false;
                FirstName.Checked = false;
                Patronymic.Checked = false;
                Gender.Checked = false;
                DateOfBirth.Checked = false;
                FamilyStatus.Checked = false;
                DopInfo.Checked = false;
            }
        }

        private void LastName_CheckedChanged(object sender, EventArgs e)
        {
            if (LastName.Checked)
            {
                if (ListUser.Text == "User 1") 
                    listBox.Items.Add($"Фамилия {ListUser.Text}: {user1[0]}");
                if (ListUser.Text == "User 2")
                    listBox.Items.Add($"Фамилия {ListUser.Text}: {user2[0]}");
                if (ListUser.Text == "User 3")
                    listBox.Items.Add($"Фамилия {ListUser.Text}: {user3[0]}");
            }
        }

        private void FirstName_CheckedChanged(object sender, EventArgs e)
        {
            if (FirstName.Checked)
            {
                if (ListUser.Text == "User 1")
                    listBox.Items.Add($"Имя {ListUser.Text}: {user1[1]}");
                if (ListUser.Text == "User 2")
                    listBox.Items.Add($"Имя {ListUser.Text}: {user2[1]}");
                if (ListUser.Text == "User 3")
                    listBox.Items.Add($"Имя {ListUser.Text}: {user3[1]}");
            }
        }

        private void Patronymic_CheckedChanged(object sender, EventArgs e)
        {
            if (Patronymic.Checked)
            {
                if (ListUser.Text == "User 1")
                    listBox.Items.Add($"Отчество {ListUser.Text}: {user1[2]}");
                if (ListUser.Text == "User 2")
                    listBox.Items.Add($"Отчество {ListUser.Text}: {user2[2]}");
                if (ListUser.Text == "User 3")
                    listBox.Items.Add($"Отчество {ListUser.Text}: {user3[2]}");
            }
        }

        private void Gender_CheckedChanged(object sender, EventArgs e)
        {
            if (Gender.Checked)
            {
                if (ListUser.Text == "User 1")
                    listBox.Items.Add($"Пол {ListUser.Text}: {user1[3]}");
                if (ListUser.Text == "User 2")
                    listBox.Items.Add($"Пол {ListUser.Text}: {user2[3]}");
                if (ListUser.Text == "User 3")
                    listBox.Items.Add($"Пол {ListUser.Text}: {user3[3]}");
            }
        }

        private void DateOfBirth_CheckedChanged(object sender, EventArgs e)
        {
            if (DateOfBirth.Checked)
            {
                if (ListUser.Text == "User 1")
                    listBox.Items.Add($"Год и дата рождения {ListUser.Text}: {user1[4]}");
                if (ListUser.Text == "User 2")
                    listBox.Items.Add($"Год и дата рождения {ListUser.Text}: {user2[4]}");
                if (ListUser.Text == "User 3")
                    listBox.Items.Add($"Год и дата рождения {ListUser.Text}: {user3[4]}");
            }
        }

        private void FamilyStatus_CheckedChanged(object sender, EventArgs e)
        {
            if (FamilyStatus.Checked)
            {
                if (ListUser.Text == "User 1")
                    listBox.Items.Add($"Семейный статус {ListUser.Text}: {user1[5]}");
                if (ListUser.Text == "User 2")
                    listBox.Items.Add($"Семейный статус {ListUser.Text}: {user2[5]}");
                if (ListUser.Text == "User 3")
                    listBox.Items.Add($"Семейный статус {ListUser.Text}: {user3[5]}");
            }
        }

        private void DopInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (DopInfo.Checked)
            {
                if (ListUser.Text == "User 1")
                    listBox.Items.Add($"Доп. информация {ListUser.Text}: {user1[6]}");
                if (ListUser.Text == "User 2")
                    listBox.Items.Add($"Доп. информация {ListUser.Text}: {user2[6]}");
                if (ListUser.Text == "User 3")
                    listBox.Items.Add($"Доп. информация {ListUser.Text}: {user3[6]}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            if(save.ShowDialog()==DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName);
                writer.Write(listBox.Text);
                writer.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ListUser.Text != "")
            {
                LastName.Checked = true;
                FirstName.Checked = true;
                Patronymic.Checked = true;
                Gender.Checked = true;
                DateOfBirth.Checked = true;
                FamilyStatus.Checked = true;
                DopInfo.Checked = true;
            }
            else
                MessageBox.Show("Пользователь не выбран", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}
