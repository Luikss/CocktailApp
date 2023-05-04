namespace Services
{
    internal class JokeService
    {
        private static readonly List<Joke> jokes = new()
        {
            new()
            {
                ImageUrl = "https://www.rd.com/wp-content/uploads/2018/07/The-past-present-and-future-walk-into-a-bar-bar-joke.jpg?resize=1536,1536",

            },

            new()
            {
                ImageUrl = "https://www.rd.com/wp-content/uploads/2018/07/The-NSA-walks-into-a-bar-bar-joke.jpg?resize=1536,1536",

            },

            new()
            {
                ImageUrl = "https://www.rd.com/wp-content/uploads/2018/07/Comic-Sans-Helvetica-and-Times-New-Roman-walk-into-a-bar-bar-joke.jpg?resize=1536,1536",

            },

            new()
            {
                ImageUrl = "https://www.rd.com/wp-content/uploads/2018/07/An-amnesiac-walks-into-a-bar-bar-joke.jpg?resize=1536,1536",

            },

            new()
            {
                ImageUrl = "https://www.rd.com/wp-content/uploads/2018/07/A-neutron-walks-into-a-bar-bar-joke.jpg?resize=1536,1536",

            },

            new()
            {
                ImageUrl = "https://www.rd.com/wp-content/uploads/2018/07/Jimmy-Wales-walks-into-a-bar-bar-joke.jpg?resize=1536,1536",

            },

            new()
            {
                ImageUrl = "https://www.rd.com/wp-content/uploads/2018/07/Two-dragons-walk-into-a-bar-bar-joke.jpg?resize=1536,1536",

            },

            new()
            {
                ImageUrl = "https://www.rd.com/wp-content/uploads/2018/07/A-screwdriver-rolls-into-a-bar-bar-joke.jpg?resize=1536,1536",

            },

            new()
            {
                ImageUrl = "https://www.rd.com/wp-content/uploads/2018/07/The-barman-says-We-dont-serve-time-travelers-in-here-bar-joke.jpg?resize=1536,1536",

            },

            new()
            {
                ImageUrl = "https://www.rd.com/wp-content/uploads/2018/07/A-Frenchman-walks-into-a-bar-with-a-cat-on-his-shoulder-bar-joke.jpg?resize=1536,1536",

            },

            new()
            {
                ImageUrl = "https://www.rd.com/wp-content/uploads/2018/07/mathematician-bar-joke.jpg?resize=1536,1536",

            },

            new()
            {
                ImageUrl = "https://www.rd.com/wp-content/uploads/2018/07/A-panda-walks-into-a-bar-bar-joke.jpg?resize=1536,1536",

            },

            new()
            {
                ImageUrl = "https://www.rd.com/wp-content/uploads/2018/07/This-cowboy-walks-into-a-bar-bar-joke.jpg?resize=1536,1536",

            },
        };

        public static List<Joke> GetJokes()
        {
            return jokes;
        }
    }
}
