using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8.models
{
    internal class Airport
    {
        public List<Flight> flights = new List<Flight>();

        public Flight AddFlight(int seat_lim, string destination)
        {
            
            var flight = new Flight(seat_lim, destination);
            flights.Add(flight);
            return flight;

        }

        public List<Flight> GetFlights() { return flights; }

        public List<Passenger> GetAllPasengersByDestination(string destination)
        {
            List<Passenger> byDest = new List<Passenger>();


            foreach (Flight f in flights)
            {
                if (f.Destination==destination)
                {
                    foreach (Passenger p in f.passengers)
                    { 
                        byDest.Add(p);
                    }
                
                }
            
            }
            return byDest;


        }
    }
}
