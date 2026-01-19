using AirlineTickets.Sql;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineTickets
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            FormBase formbase = new FormBase();
            formbase.Show();
            this.Close();

        }

        private void buttonAddTicket_Click(object sender, EventArgs e)
        {
            Ticket ticket = new Ticket(city.Text, company.Text, clock.Text, Convert.ToInt32(price.Text));
            TicketSqlMethods.AddTicket(ticket);
            MessageBox.Show("Биллет добавлен!");
        }
    }
}
