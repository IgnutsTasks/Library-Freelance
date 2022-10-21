using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        // Обработка кнопки ввода на перовом экарне
        private void EnterButton_Click(object sender, EventArgs e)
        {
            
            if (!Common.HasUser(InputField.Text)) return; // Проверка на то, есть ли пользователь

            // Создание формы пользователя
            UserDataForm userDataForm = new UserDataForm(Common.GetUser(InputField.Text));

            // Открытие формы пользователя
            userDataForm.Show();
        }
    }
}
