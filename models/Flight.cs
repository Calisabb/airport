using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.models
{
    internal class Flight
    {
        static int _no;
        public int No;
        public string Destination { get; set; }
        List<Passenger> passengers  = new List<Passenger>();

        public int SeatLimit { get; set; }


        public Flight(int seat_lim)
        {
            SeatLimit = seat_lim;
            _no++;
            No = _no;
        }

        public void AddPassenger(Passenger p)
        {
            if (SeatLimit > passengers.Count)
            {
                passengers.Add(p);
            }
            else
            {
                throw new Exception(); 
            }
        }

        public void RemovePassenger(int id)
        { 
            foreach (Passenger p in passengers)
            { 
                if (p.Id == id)
                {
                    passengers.Remove(p);
                    p.TicketCount--;
                    Console.WriteLine("passenger uchdu cole");
                    
                }
                else
                {
                    throw new Exception("BELE passenger yoxdu");
                    
                    
                }
                break;
            }
        
        }
        public Passenger GetPassenger(int id)
        {
            foreach (Passenger p in passengers)
            {
                if (p.Id == id)
                {
                    return p;
                   
                }

            }
            throw new Exception();
        
        }
        public string GetPassengersInfo(int id)
        {
            foreach (Passenger p in passengers)
            {
                if (p.Id == id)
                {
                    return $"Full Name:{p.Name + " " + p.Surname}, Age:{p.Age}, Password number:{p.PasswordNo} Tickets: {p.TicketCount}";

                }
            }
            throw new Exception();


        }
        public List<Passenger> GetAllPassengers()
        {
            return passengers;
            
        }

        public List<Passenger> GetPassengersByAge(int min_age, int max_age)
        { 
            List<Passenger> byAge = new List<Passenger>();
            foreach (Passenger p in passengers)
            {
                if (p.Age >= min_age && p.Age <= max_age)
                { 
                    byAge.Add(p);
                }
            }
            return byAge;
        }

        public List<Passenger> GetAllPasengersByDestination(string destination)
        {
            List<Passenger> byDest = new List<Passenger>();
            foreach (Passenger p in passengers)
            {
                if (p.Destination == )
                {
                    byDest.Add(p);
                }
            }
            return byDest;

        }

        public string GetFlightInfo()
        {
            return $"Destination:{Destination}, SeatLimit:{SeatLimit}, Passengers:{passengers.Count}";
        }

    }
}
