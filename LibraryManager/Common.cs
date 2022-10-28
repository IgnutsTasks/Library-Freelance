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

namespace LibraryManager
{
    // Класс в котором хранится информация о пользователе
    public class UserData
    {
        public string NumberOfTicket;
        public string UserName;
        public string Books;

        public string BornData;
    }
    public static class Common
    {
        // Свойство на путь файла любого пользователя
        public static string UserDataPath => Application.UserAppDataPath + "/User";

        public static string NumberOfTicketFile => "NumberOfTicket.txt";
        public static string UserFullNameFile => "UserFullName.txt";
        public static string BooksFile => "Books.txt";
        public static string BornDataFile => "BornData.txt";

        // Свойство на получения количества пользователей
        public static int UsersCount
        {
            get
            {
                // подсчет пользователей путем прохода по папкам
                int result = 0;
                while (File.Exists(UserDataPath + (result + 1) + "/" + NumberOfTicketFile))
                {
                    result++;
                }

                return result;
            }
        }

        // Проверка на то, есть ли пользователь
        // Функция (он же метод)
        public static bool HasUser(string ticketNumber)
        {
            for (int i = 1; i <= UsersCount; i++)
            {
                if (File.ReadAllText(UserDataPath + i + "/" + NumberOfTicketFile) == ticketNumber) return true;
            }

            return false;
        }

        // Получение информации конкретного пользователя
        public static UserData GetUser(string ticketNumber)
        {
            for (int i = 1; i <= UsersCount; i++)
            {
                if (File.ReadAllText(UserDataPath + i + "/" + NumberOfTicketFile) == ticketNumber)
                {
                    UserData userData = new UserData
                    {
                        NumberOfTicket = File.ReadAllText(UserDataPath + i + "/" + NumberOfTicketFile),
                        UserName = File.ReadAllText(UserDataPath + i + "/" + UserFullNameFile),
                        Books = File.ReadAllText(UserDataPath + i + "/" + BooksFile),
                        BornData = File.ReadAllText(UserDataPath + i + "/" + BornDataFile)
                    };

                    return userData;
                }
            }

            throw new Exception("User did not find!");
        }

    }
}
