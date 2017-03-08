using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Proxies;
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
using GeoLib.Contracts;
using GeoLib.Proxies;

namespace GeoLib.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void buttonInfo_Click(object sender, RoutedEventArgs e)
        {
            if (textBoxInfo.Text != "")
            {
                GeoClient geoClientProxy = new GeoClient();

                ZipCodeData zipCodeData = geoClientProxy.GetZipInfo(textBoxInfo.Text);

                if (zipCodeData != null)
                {
                    lblCity.Content = zipCodeData.City;
                    lblState.Content = zipCodeData.State;
                }

                geoClientProxy.Close();
            }
        }
    }
}
