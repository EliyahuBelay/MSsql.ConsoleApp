using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office.MSsql
{
    internal class Worker
    {
        string Name;
        string BirthDate;
        string Mail;
        int Payment;

        public Worker(string name, string birthDate, string mail, int payment)
        {
            Name1 = name;
            BirthDate1 = birthDate;
            Mail1 = mail;
            Payment1 = payment;
        }

        public string Name1 { get => Name; set => Name = value; }
        public string BirthDate1 { get => BirthDate; set => BirthDate = value; }
        public string Mail1 { get => Mail; set => Mail = value; }
        public int Payment1 { get => Payment; set => Payment = value; }
    }
}
