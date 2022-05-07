using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBaseQuestuon1
{
    
        internal class TrainTicket
        {
            class Passenger
            {
                public String Name { get; set; }
                public int Age { get; set; }
                Ticket Ticket { get; set; }
                public Passenger(string name, int age)
                {
                    Name = name;
                    Age = age;
                    Ticket = new Ticket();
                }
                public void TicketBooking(int tickets)
                {
                    Ticket.Tickets = tickets;
                    Console.WriteLine("Ticket booked successfully");
                }
            }
            class Ticket
            {
                public int Tickets;
                public int tickets
                {
                    get => tickets;
                    set
                    {
                        if (value > 5) throw new Exception("can not book more than 5 tickets");
                        else tickets = value;
                    }
                }
            }
            static void Main(string[] args)
            {
                
                Passenger passenger = new Passenger("Ajay", 23);
                Console.WriteLine("Enter the number of tickets want to book");
                passenger.TicketBooking(int.Parse(Console.ReadLine()));
       
                Console.ReadKey();
            }
        }
    }

