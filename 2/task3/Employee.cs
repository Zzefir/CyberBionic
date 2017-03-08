using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Employee
    {
        string name, surname, position;
        int experience;

        public Employee(string name, string surname)
        {
            this.name = name;
            this.surname = surname;
        }

        public void Show()
        {
            Console.WriteLine("name is: {0}, surname is: {1}", this.name, this.surname);
        }

        public int SetExperience
        {
            set { experience = value; }
        }
        public int GetExperience
        {
            get { return experience; }
        }
        public string SetPosition
        {
            set { position = value; }
        }
        public string GetPosition
        {
            get { return position; }
        }
    }
}
