using AirlineTickets.DynamicСreation;
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
    public partial class FormBase : Form
    {
        public FormBase()
        {
            InitializeComponent();
        }

        private void Base_Load(object sender, EventArgs e)
        {
            List<Ticket> tickets = TicketSqlMethods.ReadTickets();
            foreach(Ticket ticket in tickets)
            {
                DynamicCard.CreateTicketCard(tickets, this);
            }
        }

        private void buttonAdmin_Click(object sender, EventArgs e)
        {
            Admin admin = new Admin();
            admin.Show();
            this.Visible = false;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearch.Text != "")
            {
                List<Ticket> tickets = TicketSqlMethods.ReadTickets().Where(i => i.Cities == textBoxSearch.Text).ToList();
                DynamicCard.ClearExistingTicketCards(this);
                foreach (Ticket ticket in tickets)
                {
                    DynamicCard.CreateTicketCard(tickets, this);
                }
            }
            else
            {
                List<Ticket> tickets = TicketSqlMethods.ReadTickets();
                DynamicCard.ClearExistingTicketCards(this);
                foreach (Ticket ticket in tickets)
                {
                    DynamicCard.CreateTicketCard(tickets, this);
                }
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            List<Ticket> tickets = TicketSqlMethods.ReadTickets().OrderBy(i=>i.Price).ToList();
            DynamicCard.ClearExistingTicketCards(this);
            foreach (Ticket ticket in tickets)
            {
                DynamicCard.CreateTicketCard(tickets, this);
            }
        }
    }
}
