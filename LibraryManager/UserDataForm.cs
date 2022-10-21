using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManager
{
    public partial class UserDataForm : Form
    {
        public UserDataForm(UserData userData)
        {
            InitializeComponent();
            Initialize(userData); // Инитиализация формы
        }

        // Функционал интиализции
        private void Initialize(UserData userData)
        {
            UserNameLabel.Text = userData.UserName;
            string[] books = GetParsedBooks(userData.Books);

            foreach (string book in books)
            {
                BooksDataLayout.Items.Add(book);
            }

        }

        // Обработка книжек в массив строк
        private string[] GetParsedBooks(string bookData)
        {

            string[] data = bookData.Split(' ');
            List<string> result = new List<string>();

            if (data.Length % 3 != 0) throw new Exception("Data is not correct!");

            for (int i = 0; i < data.Length; i += 3)
            {
                result.Add(data[i] + " ");
                result[result.Count - 1] += data[i + 1] + " ";
                result[result.Count - 1] += data[i + 2];
            }

            return result.ToArray();
        }
    }
}
