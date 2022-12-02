using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExercise.Classes
{
    public class Teller
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Bank Bank { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
