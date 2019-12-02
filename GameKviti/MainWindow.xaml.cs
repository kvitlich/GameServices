using System;
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

namespace GameKviti
{

    public partial class MainWindow : Window
    {
        public static Game SelectedGame;

        public MainWindow()
        {
            InitializeComponent();
            using (GameDbContext context = new GameDbContext())
            {
                dataGrid.ItemsSource = context.Games.ToList<Game>();
            }
        }

        private void WatchDetails(object sender, RoutedEventArgs e)
        {
            SelectedGame = (Game)dataGrid.SelectedItem;
            detailsFrame.Source = new Uri("pack://application:,,,/GameDetailsPage.xaml");
        }
    }
}
