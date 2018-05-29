namespace Movies.Desktop
{
    public class MoviesService
    {
        private MoviesService()
        {
        }

        private static MoviesServiceReference.MoviesServiceClient client;

        public static MoviesServiceReference.MoviesServiceClient Current
        {
            get
            {
                if (client == null)
                {
                    client = new MoviesServiceReference.MoviesServiceClient();
                }

                return client;
            }
        }
    }
}