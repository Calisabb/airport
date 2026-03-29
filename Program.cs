using ConsoleApp8.Helpers;
using ConsoleApp8.models;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // a= 10 b =5 a =b b=
            Flight flight = new Flight(20);
            do
            {
                Console.WriteLine("1. Sərnişin əlavə et\r\n2. Sərnişini uçuşdan çıxar\r\n3. Sərnişin axtar (Id ilə)\r\n4. Bütün sərnişinlərə bax\r\n5. Yaş aralığına görə axtar\r\n6. İstiqamətə görə axtar\r\n7. Uçuş məlumatlarına bax\r\n0. Proqramı bitir");
                var data = Console.ReadLine();
                switch (data)
                {
                    case "1":
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
                        case "2":
                        Console.WriteLine("enter id for delete passenger ");
                        var remover = Convert.ToInt32(Console.ReadLine());
                        flight.RemovePassenger(remover);


                        break;
                        case "3":
                        Console.WriteLine("enter id for delete passenger ");
                        var finder = Convert.ToInt32(Console.ReadLine());
                        flight.GetPassengersInfo(finder);
                        break;
                        case "4":
                        var ps = flight.GetAllPassengers(); 
                        for (int i = 0; i < ps.Count; i++)
                        {
                            Console.WriteLine(ps[i]);
                        }
                        break;
                        case "5":
                        Console.WriteLine("enetr minimum age:");
                        var min = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("enetr maximum age:");
                        var max = Convert.ToInt32(Console.ReadLine());
                        var fl = flight.GetPassengersByAge(min,max);
                        foreach (Passenger p in fl)
                        {
                            Console.WriteLine(p);
                        }
                        break;
                    case "6":

                        break;
                    case "7":
                        Console.WriteLine(flight.GetFlightInfo()); 
                        break;
                    case "0":
                        return;
             
                }

            } while (true);
        }
    }
}
