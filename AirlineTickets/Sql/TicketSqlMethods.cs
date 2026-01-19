using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AirlineTickets.Sql
{
    internal class TicketSqlMethods
    {
        public static List<Ticket> ReadTickets()
        {
            List<Ticket> tickets = new List<Ticket>();
            using (MySqlConnection connection = new MySqlConnection(Constant.ConnectionString))
            {
                connection.Open();
                string sqlQuery = @"SELECT * FROM bilets";
                using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Ticket ticket = new Ticket(reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetInt32(4));
                            ticket.Id = reader.GetInt32(0);
                            tickets.Add(ticket);
                        }
                    }
                }
            }
            return tickets;
        }
        public static void AddTicket(Ticket ticket)
        {
            using (MySqlConnection connection = new MySqlConnection(Constant.ConnectionString))
            {
                connection.Open();
                string sqlQuery = @"INSERT INTO bilets (cities, company, clock, price) values
                                    (@city, @company, @clock, @price);";
                using (MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                {
                    MySqlParameter par1 = new MySqlParameter("@city", ticket.Cities);
                    MySqlParameter par2 = new MySqlParameter("@company", ticket.Company);
                    MySqlParameter par3 = new MySqlParameter("@clock", ticket.Clock);
                    MySqlParameter par4 = new MySqlParameter("@price", ticket.Price);
                    command.Parameters.Add(par1);
                    command.Parameters.Add(par2);
                    command.Parameters.Add(par3);
                    command.Parameters.Add(par4);

                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
