using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Movies.Desktop.Entities;

namespace Movies.Desktop.ViewModels
{
    public class MoviesViewModel : NotificationObject
    {
        private ObservableCollection<Movie> movies;

        public ObservableCollection<Movie> Movies
        {
            get
            {
                return movies;
            }
            set
            {
                if (movies == value)
                {
                    return;
                }
                movies = value;
                OnPropertyChanged();
            }
        }

        private Movie selectedMovie;

        public Movie SelectedMovie
        {
            get
            {
                return selectedMovie;
            }
            set
            {
                if (selectedMovie == value)
                {
                    return;
                }
                selectedMovie = value;
                OnPropertyChanged();
            }
        }

        public async Task LoadMoviesAsync()
        {
            var allMovies = await MoviesService.Current.GetAllMoviesAsync();
            if (allMovies != null && allMovies.Any())
            {
                Movies = new ObservableCollection<Movie>(allMovies.Select(m =>
                    new Movie() { Id = m.Id, Name = m.Name, CountryId = m.CountryId, Year = m.Year }));
            }
        }
    }
}