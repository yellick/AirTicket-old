﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace AirTicket
{
    /// <summary>
    /// Логика взаимодействия для WSUser.xaml
    /// </summary>
    public partial class WSUser : Page
    {
        BrushConverter bc = new BrushConverter();

        public WSUser()
        {
            InitializeComponent();
            openTicketsList();
        }

        private void ticketsListBtn_Click(object sender, RoutedEventArgs e)
        {
            changeBtnColor(ticketsListBtn, "#FF80C0FF");
            changeBtnColor(bookedTicketsBtn, "#FFFFFF");
            changeBtnColor(bookingHistoryBtn, "#FFFFFF");

            openTicketsList();
        }

        private void bookedTicketsBtn_Click(object sender, RoutedEventArgs e)
        {
            changeBtnColor(ticketsListBtn, "#FFFFFF");
            changeBtnColor(bookedTicketsBtn, "#FF80C0FF");
            changeBtnColor(bookingHistoryBtn, "#FFFFFF");

            openBookedTickets();
        }

        private void bookingHistoryBtn_Click(object sender, RoutedEventArgs e)
        {
            changeBtnColor(ticketsListBtn, "#FFFFFF");
            changeBtnColor(bookedTicketsBtn, "#FFFFFF");
            changeBtnColor(bookingHistoryBtn, "#FF80C0FF");

            openBookingHistory();
        }

        private void changeBtnColor(Button btn, string color)
        {
            btn.Foreground = (Brush)bc.ConvertFrom(color);
        }

        private void openTicketsList()
        {
            userWSFrame.Content = new userTicketsList();
        }

        private void openBookedTickets()
        {
            userWSFrame.Content = "";
        }

        private void openBookingHistory()
        {
            userWSFrame.Content = "";
        }
    }
}
