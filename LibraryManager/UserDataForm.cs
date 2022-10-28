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
            // Настройка lable`ov
            UserNameLabel.Text = userData.UserName;
            BornDataLabel.Text = userData.BornData;
            TicketNuberLabel.Text = userData.NumberOfTicket;

            string[] books = GetParsedBooks(userData.Books);

            ListBox[] booksListBox = {BooksDataLayout, GetDataLayout, ReturnDataLayout, RFIDDataLayout};

            foreach (string book in books)
            {
                string[] bookInfo = book.Split(' ');

                int index = 0;
                foreach (var listBox in booksListBox)
                {
                    listBox.Items.Add(bookInfo[index]);

                    index++;
                }
            }

        }

        // Обработка книжек в массив строк
        private string[] GetParsedBooks(string bookData)
        {

            string[] data = bookData.Split(' ');
            List<string> result = new List<string>();

            if (data.Length % 4 != 0) throw new Exception("Data is not correct!");

            for (int i = 0; i < data.Length; i += 4)
            {
                result.Add(data[i] + " ");
                result[result.Count - 1] += data[i + 1] + " ";
                result[result.Count - 1] += data[i + 2] + " ";
                result[result.Count - 1] += data[i + 3];
            }

            return result.ToArray();
        }

    }
}
