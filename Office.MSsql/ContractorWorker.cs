using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office.MSsql
{
    internal class ContractorWorker
    {
        string fullName;
        string numberWorker;
        string mail;
        string companyName;

        public ContractorWorker(string fullName, string numberWorker, string mail, string companyName)
        {
            this.FullName = fullName;
            this.NumberWorker = numberWorker;
            this.Mail = mail;
            this.CompanyName = companyName;
        }

        public string FullName { get => fullName; set => fullName = value; }
        public string NumberWorker { get => numberWorker; set => numberWorker = value; }
        public string Mail { get => mail; set => mail = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
    }
}
