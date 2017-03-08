using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional
{
    class User
    {
        private string name, login, surname;
        private int age;
        readonly DateTime date;

        public User (string name, string surname, string login, int age)
        {
            this.name = name;
            this.surname = surname;
            this.login = login;
            this.age = age;
            this.date = DateTime.Now;
        }

        public void Show()
        {
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}", this.name, this.surname, this.login, this.age, this.date);
        }
    }
}
