using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.models
{
    internal class Passenger
    {
        static int _id;
        public int Id;

        public Passenger(string name, string surname, int age, string passwordNo, int ticketCount)
        {
            Name = name;
            Surname = surname;
            Age = age;
            PasswordNo = passwordNo;
            TicketCount = ticketCount;
            _id++;
            Id = _id;
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string PasswordNo { get; set; }
        public int TicketCount { get; set; }

        public override string ToString()
        {
            return $"Full Name:{Name + " " + Surname}, Age:{Age}, Password number:{PasswordNo} Tickets: {TicketCount}";
        }


    }
}
