using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionalSetGet
{
    class User
    {
        private string name, login, surname;
        private int age;
        readonly DateTime date;

        public User()
        {
            this.date = DateTime.Now;
        }

        public string SetName
        {
            set {name = value; }
        }

        public string SetLogin
        {
            set {login = value; }
        }

        public string SetSurname
        {
            set { surname = value;}
        }

        public int SetAge
        {
            set { age = value;}
        }

        public string GetName
        {
            get { return name; }
        }

        public string GetLogin
        {
            get { return login; }
        }

        public string GetSurname
        {
            get { return surname; }
        }

        public int GetAge
        {
            get { return age; }
        }

        public DateTime GetDate
        {
            get { return date; }
        }
    }
}
