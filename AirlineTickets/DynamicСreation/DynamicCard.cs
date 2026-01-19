using AirlineTickets.Sql;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirlineTickets.DynamicСreation
{
    internal class DynamicCard
    {
        private static List<Panel> ticketCards = new List<Panel>();
        public static void CreateTicketCard(List<Ticket> tickets, Form form)
        {
            int padding = 15; // Отступ между карточками
            int cardWidth = 200; // Ширина карточки
            int cardHeight = 180; // Высота карточки
            int currentX = 15; // Текущая позиция X
            int currentY = 50; // Текущая позиция Y
            int maxCardsPerRow = 0; // Максимальное количество карточек в ряду

            foreach (Ticket ticket in tickets)
            {
                if (currentX + cardWidth + padding > form.ClientSize.Width - padding)
                {
                    currentX = padding;
                    currentY += cardHeight + padding;
                }

                // Создаем панель (карточку) как контейнер
                Panel cardPanel = new Panel
                {
                    Name = $"ticketCard_{ticket.Id}",
                    Location = new Point(currentX, currentY),
                    Size = new Size(cardWidth, cardHeight),
                    Tag = ticket, // Сохраняем объект билета
                    BorderStyle = BorderStyle.FixedSingle,
                    BackColor = Color.White,
                    Cursor = Cursors.Hand
                };

                // Добавляем эффект при наведении
                cardPanel.MouseEnter += (s, e) =>
                {
                    cardPanel.BackColor = Color.FromArgb(245, 245, 245);
                    cardPanel.BorderStyle = BorderStyle.Fixed3D;
                };

                cardPanel.MouseLeave += (s, e) =>
                {
                    cardPanel.BackColor = Color.White;
                    cardPanel.BorderStyle = BorderStyle.FixedSingle;
                };

                // Заголовок карточки
                Label lblTitle = new Label
                {
                    Text = ticket.Cities,
                    Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold),
                    ForeColor = Color.FromArgb(0, 102, 204),
                    Location = new Point(10, 10),
                    Size = new Size(cardWidth - 20, 25),
                    TextAlign = ContentAlignment.MiddleLeft
                };
                cardPanel.Controls.Add(lblTitle);

                // Разделительная линия
                Panel separator = new Panel
                {
                    BackColor = Color.LightGray,
                    Location = new Point(10, 40),
                    Size = new Size(cardWidth - 20, 1)
                };
                cardPanel.Controls.Add(separator);

                int labelY = 50;
                int labelHeight = 25;

                // Компания
                Label lblCompanyLabel = new Label
                {
                    Text = "Компания:",
                    Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular),
                    ForeColor = Color.Gray,
                    Location = new Point(10, labelY),
                    Size = new Size(70, labelHeight),
                    TextAlign = ContentAlignment.MiddleLeft
                };
                cardPanel.Controls.Add(lblCompanyLabel);

                Label lblCompanyValue = new Label
                {
                    Text = ticket.Company,
                    Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold),
                    ForeColor = Color.Black,
                    Location = new Point(85, labelY),
                    Size = new Size(cardWidth - 95, labelHeight),
                    TextAlign = ContentAlignment.MiddleLeft
                };
                cardPanel.Controls.Add(lblCompanyValue);
                labelY += labelHeight;

                // Время отправления
                Label lblClockLabel = new Label
                {
                    Text = "Время:",
                    Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular),
                    ForeColor = Color.Gray,
                    Location = new Point(10, labelY),
                    Size = new Size(70, labelHeight),
                    TextAlign = ContentAlignment.MiddleLeft
                };
                cardPanel.Controls.Add(lblClockLabel);

                Label lblClockValue = new Label
                {
                    Text = ticket.Clock,
                    Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Bold),
                    ForeColor = Color.Black,
                    Location = new Point(85, labelY),
                    Size = new Size(cardWidth - 95, labelHeight),
                    TextAlign = ContentAlignment.MiddleLeft
                };
                cardPanel.Controls.Add(lblClockValue);
                labelY += labelHeight;

                // Цена
                Label lblPriceLabel = new Label
                {
                    Text = "Цена:",
                    Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular),
                    ForeColor = Color.Gray,
                    Location = new Point(10, labelY),
                    Size = new Size(70, labelHeight),
                    TextAlign = ContentAlignment.MiddleLeft
                };
                cardPanel.Controls.Add(lblPriceLabel);

                Label lblPriceValue = new Label
                {
                    Text = $"{ticket.Price:C}",
                    Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold),
                    ForeColor = Color.FromArgb(0, 150, 0),
                    Location = new Point(85, labelY),
                    Size = new Size(cardWidth - 95, labelHeight),
                    TextAlign = ContentAlignment.MiddleLeft
                };
                cardPanel.Controls.Add(lblPriceValue);

                // Кнопка покупки
                Button btnBuy = new Button
                {
                    Text = "КУПИТЬ",
                    Name = $"btnBuy_{ticket.Id}",
                    Location = new Point(10, cardHeight - 45),
                    Size = new Size(cardWidth - 40, 25),
                    BackColor = Color.FromArgb(0, 123, 255),
                    ForeColor = Color.White,
                    Font = new Font("Microsoft Sans Serif", 10f, FontStyle.Bold),
                    FlatStyle = FlatStyle.Flat,
                    Cursor = Cursors.Hand
                };


                btnBuy.Click += BtnBuy_Click;

                cardPanel.Controls.Add(btnBuy);

                form.Controls.Add(cardPanel);
                ticketCards.Add(cardPanel);

                currentX += cardWidth + padding;
            }
        }

            public static void BtnBuy_Click(object sender, EventArgs e)
            {
                Button buyButton = (Button)sender;
                Ticket selectedTicket = (Ticket)buyButton.Tag;

                DialogResult result = MessageBox.Show(
                $"Вы уверены, что хотите купить билет?\n\n" +
                $"Название: {selectedTicket.Cities}\n" +
                $"Компания: {selectedTicket.Company}\n" +
                $"Время: {selectedTicket.Clock}\n" +
                $"Цена: {selectedTicket.Price:C}",
                "Подтверждение покупки",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                { 

                    MessageBox.Show($"Билет '{selectedTicket.Cities}' успешно куплен!",
                        "Покупка завершена",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
        public static void ClearExistingTicketCards(Form form)
        {
            foreach (var card in ticketCards)
            {

                foreach (Control control in card.Controls)
                {
                    if (control is Button button && button.Name.StartsWith("btnBuy_"))
                    {
                        button.Click -= BtnBuy_Click;
                    }
                }

                form.Controls.Remove(card);
                card.Dispose();
            }
            ticketCards.Clear();
        }
        
    }
}
