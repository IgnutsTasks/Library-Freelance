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
    public static class Common
    {
        public static string DataPath => Application.UserAppDataPath + "/user_";

        public static int UsersCount
        {
            get
            {
                int result = 0;
                while (File.Exists(DataPath + (result + 1)))
                {
                    result++;
                }

                return result;
            }
        }

        public static bool HasNubers(string value)
        {
            foreach (char s in value)
            {
                if (char.IsDigit(s)) return true;
            }

            return false;
        }

        public static bool IsOnlyDigits(string value)
        {
            foreach (char s in value)
            {
                if (!char.IsDigit(s)) return false;
            }

            return true;
        }

        public static bool HasUser(string userData)
        {
            for (int i = 1; i <= UsersCount; i++)
            {
                if (File.ReadAllText(DataPath + i) == userData) return true;
            }

            return false;
        }
    }
}
