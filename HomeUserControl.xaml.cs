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

namespace kiosk_snapprint
{
    /// <summary>
    /// Interaction logic for HomeUserControl.xaml
    /// </summary>
    public partial class HomeUserControl : UserControl
    {
        public HomeUserControl()
        {
            InitializeComponent();
        }

        private void GoToQRCodePage_Click(object sender, RoutedEventArgs e)
        {
            // Generate a session ID when the button is clicked
            string sessionId = GenerateSessionId();

            // Create an instance of the qrcode UserControl and pass the session ID
            qrcode qrPage = new qrcode(sessionId);

            // Set the content to display the QR page (assuming a ContentControl named MainContent for navigation)
            MainContent.Content = qrPage;
        }
        private string GenerateSessionId(int length = 6)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            flashdrive flashdrivePage = new flashdrive();
            MainContent.Content = flashdrivePage;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            uniquecode uniquecodePage = new uniquecode();
            MainContent.Content = uniquecodePage;

        }
    }
}