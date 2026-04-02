using ConsoleApp8.Helpers;
using ConsoleApp8.models;
using System.Text;

namespace ConsoleApp8
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;
            Airport airport = new Airport();
            Flight? flight = null;
        Restart:
            do
            {
                Console.WriteLine("1. Uçuş əlavə et\n2. Sərnişin əlavə et\r\n3. Sərnişini uçuşdan çıxar\r\n4. Sərnişin axtar (Id ilə)\r\n5. Bütün sərnişinlərə bax\r\n6. Yaş aralığına görə axtar\r\n7. İstiqamətə görə axtar\r\n8. Uçuş məlumatlarına bax\r\n0. Proqramı bitir");
                var data = Console.ReadLine();
                switch (data)
                {
                    case "1":
                        Console.WriteLine("Enter destination");
                        var d = Console.ReadLine();
                        Console.WriteLine("Enter seat limit");
                        var limit = Convert.ToInt32(Console.ReadLine());

                        flight = airport.AddFlight(limit, d);

                        break;
                    case "2":
                        if (flight == null)
                        {
                            Console.WriteLine("");
                            Console.WriteLine("***");
                            Console.WriteLine("Please create a flight first");
                            Console.WriteLine("***");
                            Console.WriteLine("");
                            goto Restart;
                        }
                    Start:
                        Console.WriteLine("Enter Name:");
                        var name = Console.ReadLine();
                        Console.WriteLine("Enter Surname:");
                        var surname = Console.ReadLine();
                        Console.WriteLine("Enter Age:");
                        var age = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter password no");
                        var password = Console.ReadLine();
                        Console.WriteLine("entr tickets:");
                        var tickets = Convert.ToInt32(Console.ReadLine());
                        if (Helper.CheckFullName(name) == false
                            || Helper.CheckAge(age) == false
                            || Helper.CheckPasswordNo(password) == false


                            )
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("Sehv daxil etdiniz");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            goto Start;

                        }
                        else
                        {
                            Passenger passenger = new Passenger(name, surname, age, password, tickets);
                            flight.AddPassenger(passenger);

                        }
                        break;
                    case "3":
                        Console.WriteLine("enter id for delete passenger ");
                        var remover = Convert.ToInt32(Console.ReadLine());
                        flight.RemovePassenger(remover);


                        break;
                    case "4":
                        Console.WriteLine("enter id for finding passenger");
                        var finder = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(flight.GetPassengersInfo(finder)); 
                        break;
                    case "5":
                        var ps = flight.GetAllPassengers();
                        for (int i = 0; i < ps.Count; i++)
                        {
                            Console.WriteLine(ps[i]);
                        }
                        break;
                    case "6":
                        Console.WriteLine("enetr minimum age:");
                        var min = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enetr maximum age:");
                        var max = Convert.ToInt32(Console.ReadLine());
                        var fl = flight.GetPassengersByAge(min, max);
                        foreach (Passenger p in fl)
                        {
                            Console.WriteLine(p);
                        }
                        break;
                    case "7":
                        Console.WriteLine("Enter destination:");
                        var dest = Console.ReadLine();
                        var pass = airport.GetAllPasengersByDestination(dest);
                        foreach (Passenger p in pass)
                        {
                            Console.WriteLine(p);
                        }

                        break;
                    case "8":
                        var fly = airport.GetFlights();
                        foreach (Flight f in fly)
                        {
                            Console.WriteLine($"{f.GetFlightInfo()}");

                        }
                        break;
                    case "0":
                        return;

                }

            } while (true);
        }
    }
}
