using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evidence_clip_about_public_transport.Entits
{
    public class Author:I_Work_with_Csv
    {
        private int id;
        private string login_name;
        private bool is_admin;
        private string message;
        private string email;
        private DateOnly date_create;
        private int count_of_access;
        private string user_password;

        public Author() 
        { 
        
        }
        public Author(int id, string login_name, bool is_admin, string message, string email, DateOnly date_create, int count_of_access, string user_password)
        {
            if (login_name == null) 
            { 
                throw new IndexOutOfRangeException("jméno neobsahuje text");
            }

            if (login_name.Length > 100) 
            {
                throw new IndexOutOfRangeException("jméno má více než 50 znaků");
            }

            if (email == null) 
            {
                throw new IndexOutOfRangeException("email neobashuje text");
            }

            if (email.Length > 50)
            {
                throw new IndexOutOfRangeException("email má více než 50 znaků");
            }

            if (count_of_access < 0) 
            {
                throw new IndexOutOfRangeException("počet přístupů je menší než 0");
            }

            if (user_password == null) 
            {
                throw new IndexOutOfRangeException("heslo neobsahuje text");
            }

            this.Id = id;
            this.Login_name = login_name;
            this.Is_admin = is_admin;
            this.Message = message;
            this.Email = email;
            this.Date_create = date_create;
            this.Count_of_access = count_of_access;
            this.User_password = user_password;
        }

        public int Id { get => id; set => id = value; }
        public string Login_name { get => login_name; set => login_name = value; }
        public bool Is_admin { get => is_admin; set => is_admin = value; }
        public string Message { get => message; set => message = value; }
        public string Email { get => email; set => email = value; }
        public DateOnly Date_create { get => date_create; set => date_create = value; }
        public int Count_of_access { get => count_of_access; set => count_of_access = value; }
        public string User_password { get => user_password; set => user_password = value; }

        public object from_csv(string row)
        {
            row = row.Trim();
            string[] splited = row.Split(';');
            bool boolean_from_strring = false;

            if (splited[2].Equals("True"))
            {
                boolean_from_strring = true;
            }


            return new Author(Int32.Parse(splited[0]), splited[1], boolean_from_strring, splited[3], splited[4], DateOnly.ParseExact(splited[5], "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture), Int32.Parse(splited[6]), splited[7]);
        }

        public string to_csv() 
        {
            return id + ";" + login_name + ";" + is_admin + ";" + message + ";" + email + ";" + date_create.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture) + ";" + count_of_access + ";" + user_password;
        }
    }


}
