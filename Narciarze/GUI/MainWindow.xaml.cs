using GUI.ViewModel;
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

namespace GUI
{

    public partial class MainWindow : Window
    {
        MainViewModel mainView = new MainViewModel();

        public MainWindow()
        {
            InitializeComponent();
            DataContext = mainView;
        }

        private void skocznieButtonClicked(object sender, RoutedEventArgs e)
        {
            mainView.WrzytajDaneSkoczni();
        }

        private void zawodnicyButtonClick(object sender, RoutedEventArgs e)
        {
            mainView.WczytajDaneZawodnikow();
        }

        private void trenerzyButtonClick(object sender, RoutedEventArgs e)
        {
            mainView.WczytajDaneTrenerow();
        }

     
    }
}
