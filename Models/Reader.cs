using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp.Models
{
    public class Reader
    {
        public string CardNumber { get; }
        public string FirstName { get; }
        public string LastName { get; }

        public Reader(string cardNumber, string firstName, string lastName)
        {
            CardNumber = cardNumber;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
