using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using Movies.Desktop.MoviesServiceReference;

namespace Movies.Desktop.ViewModels
{
    public class MovieEditionViewModel : NotificationObject
    {
        private int id;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (id == value)
                {
                    return;
                }
                id = value;
                OnPropertyChanged();
            }
        }

        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (name == value)
                {
                    return;
                }
                name = value;
                OnPropertyChanged();
            }
        }

        private int? year;

        public int? Year
        {
            get
            {
                return year;
            }
            set
            {
                if (year == value)
                {
                    return;
                }
                year = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Country> countries;

        public ObservableCollection<Country> Countries
        {
            get
            {
                return countries;
            }
            set
            {
                if (countries == value)
                {
                    return;
                }
                countries = value;
                OnPropertyChanged();
            }
        }

        private Country selectedCountry;

        public Country SelectedCountry
        {
            get
            {
                return selectedCountry;
            }
            set
            {
                if (selectedCountry == value)
                {
                    return;
                }
                selectedCountry = value;
                OnPropertyChanged();
            }
        }

        public MovieEditionViewModel(Entities.Movie movie)
        {
            LoadCountries();

            if (movie == null)
            {
                return;
            }

            Id = movie.Id;
            Name = movie.Name;
            Year = movie.Year;
            SelectedCountry = Countries.FirstOrDefault(c => c.Id == movie.CountryId);
        }

        private void LoadCountries()
        {
            var allCountries = ServiceFactory.CountriesService.GetAllCountries();
            if (allCountries != null && allCountries.Any())
            {
                Countries = new ObservableCollection<Country>(allCountries.Select(c =>
                    new Country() { Id = c.Id, Name = c.Name }));
            }
        }

        public void Save()
        {
            try
            {
                var movieToSave = new Movie();
                movieToSave.Id = Id;
                movieToSave.Name = Name;
                movieToSave.CountryId = SelectedCountry.Id;
                movieToSave.Year = Year.Value;
                ServiceFactory.MoviesService.UpdateMovie(Id, movieToSave);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Something happened");
            }
        }
    }
}