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
            using(MySqlConnection connection = new MySqlConnection(Constant.ConnectionString))
            {
                connection.Open();
                string sqlQuery = @"INSERT INTO bilets (cities, company, clock, price) values
                                    (@city, @company, @clock, @price);";
                using(MySqlCommand command = new MySqlCommand(sqlQuery, connection))
                {
                    MySqlParameter par1 = new MySqlParameter("@city", city.Text);
                    MySqlParameter par2 = new MySqlParameter("@company", company.Text);
                    MySqlParameter par3 = new MySqlParameter("@clock", clock.Text);
                    MySqlParameter par4 = new MySqlParameter("@price", price.Text);
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
