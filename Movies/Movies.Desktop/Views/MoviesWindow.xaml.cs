using System.Threading.Tasks;
using System.Windows;
using Movies.Desktop.ViewModels;

namespace Movies.Desktop.Views
{
    public partial class MoviesWindow : Window
    {
        private readonly MoviesViewModel moviesViewModel = new MoviesViewModel();

        public MoviesWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;

            DataContext = moviesViewModel;
        }

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Loaded -= MainWindow_Loaded;
            await Task.Delay(5000); // Just wait for the service to run
            await moviesViewModel.LoadMoviesAsync();
        }

        private async void EditClick(object sender, RoutedEventArgs e)
        {
            if (moviesViewModel.SelectedMovie == null)
            {
                return;
            }

            var newMovieWindow = new MovieEditionWindow(moviesViewModel.SelectedMovie);

            newMovieWindow.ShowDialog();
            await moviesViewModel.LoadMoviesAsync();
        }
    }
}