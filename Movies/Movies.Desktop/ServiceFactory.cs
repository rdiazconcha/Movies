using Movies.Desktop.CountriesServiceReference;
using Movies.Desktop.RolesServiceReference;

namespace Movies.Desktop
{
    public class ServiceFactory
    {
        private ServiceFactory()
        {
        }

        private static MoviesServiceReference.MoviesServiceSoapClient moviesService;

        public static MoviesServiceReference.MoviesServiceSoapClient MoviesService
        {
            get
            {
                if (moviesService == null)
                {
                    moviesService = new MoviesServiceReference.MoviesServiceSoapClient();
                }

                return moviesService;
            }
        }

        private static CountriesServiceSoapClient countriesService;

        public static CountriesServiceSoapClient CountriesService
        {
            get
            {
                if (countriesService == null)
                {
                    countriesService = new CountriesServiceSoapClient();
                }

                return countriesService;
            }
        }

        private static RolesServiceSoapClient rolesService;

        public static RolesServiceSoapClient RolesService
        {
            get
            {
                if (rolesService == null)
                {
                    rolesService = new RolesServiceSoapClient();
                }

                return rolesService;
            }
        }
    }
}