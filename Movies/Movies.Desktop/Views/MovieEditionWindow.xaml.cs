using System.Windows;
using Movies.Desktop.Entities;
using Movies.Desktop.ViewModels;

namespace Movies.Desktop.Views
{
    public partial class MovieEditionWindow : Window
    {
        private MovieEditionViewModel movieEditionViewModel;

        public MovieEditionWindow(Movie movie)
        {
            InitializeComponent();
            movieEditionViewModel = new MovieEditionViewModel(movie);
            DataContext = movieEditionViewModel;
        }

        private void SaveClick(object sender, RoutedEventArgs e)
        {
            movieEditionViewModel.Save();
        }
    }
}