using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office.MSsql
{
    internal class Manager
    {
        string firstName;
        string lastName;
        string birthDate;
        string mail;
        string section;

        public Manager(string firstName, string lastName, string birthDate, string mail, string section)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
            this.Mail = mail;
            this.Section = section;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string BirthDate { get => birthDate; set => birthDate = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Section { get => section; set => section = value; }
    }
}
