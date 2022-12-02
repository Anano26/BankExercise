using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExercise.Classes
{
    public class Bank
    {
        public int BankId { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public List<Customer> Customers { get; set; }
        public List<Teller> Tellers { get; set; }
    }
}
