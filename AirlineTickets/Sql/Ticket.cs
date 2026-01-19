using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTickets.Sql
{
    internal class Ticket
    {
        public int Id { get; set; }
        public string Cities { get; set; }
        public string Company { get; set; }
        public string Clock { get; set; }
        public int Price { get; set; }
        public Ticket(string cities,string company,string clock,int price)
        {
            Cities = cities;
            Company = company;
            Clock = clock;
            Price = price;
        }
    }
}
