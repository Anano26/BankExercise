using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExercise.Classes
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int PhoneNo { get; set; }
        public int AcctNo { get; set; }

        public Bank Bank { get; set; }
        public List<Account> Accounts { get; set; }
        public List<Teller> Tellers { get; set; }
        public List<Loan> Loans { get; set; }
    }
}
