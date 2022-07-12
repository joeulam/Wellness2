using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409


namespace Wellness2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            Viewbox viewbox = new Viewbox();

            // Set the Viewbox maximum width and height
            // This will resize the inside content
            viewbox.MaxWidth = 300;
            viewbox.MaxHeight = 100;

            // Set the margin of Viewbox
            viewbox.Margin = new Thickness(10);

            // Set the Viewbox Stretch programmatically
            viewbox.Stretch = Stretch.Fill;

            // Set the Viewbox Stretch direction
            viewbox.StretchDirection = StretchDirection.Both;
            this.InitializeComponent();
        }

        private void richTextBlock_SelectionChanged(object sender, RoutedEventArgs e)
        {

        }

        void submitButtonClick(object sender, RoutedEventArgs e)
        {
            
            Debug.WriteLine("Loggin in");
            String password = pass.Password.ToString();
            string connStr = "server=localhost;user=" + password + ";database=app;port=3306;password=" + password;
            MySqlConnection conn = new MySqlConnection(connStr);
            bool logint = false;
            try
            {
                conn.Open();
                logint = true;
            }
            catch (Exception)
            {
                logint = false;
                wrongpass.Visibility = Visibility.Visible;
                Debug.Write("FUCK FUCK FUCK");
            }
            if(logint)
            {
                Frame.Navigate(typeof(Dashboard));
            }
            

        }


    }
}
