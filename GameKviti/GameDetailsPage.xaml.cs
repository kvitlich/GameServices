using System;
using System.Collections.Generic;
using System.Text;
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
    /// <summary>
    /// Interaction logic for GameDetailsPage.xaml
    /// </summary>
    public partial class GameDetailsPage : Page
    {
        public GameDetailsPage()
        {
            InitializeComponent();
            var game = MainWindow.SelectedGame;
            genreSet.Text = game.Genre;
            nameSet.Text = game.Name;
            descriptionSet.Text = game.Description;
            logoImage.Source = new BitmapImage(game.Logo);
        }


    }
}
