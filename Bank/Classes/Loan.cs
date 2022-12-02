using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankExercise.Classes
{
    public class Loan
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int AccountId { get; set; }
        public int CustomerId { get; set; }

        public Customer Customer { get; set; }

    }
}
