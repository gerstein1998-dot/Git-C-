namespace home_task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MediaItem[] items = new MediaItem[]
            {
            new Movie(){Title= "KofiKo", Duration=10},
            new Song(){Title= "Baby", Duration= 3},
            new LiveStream(){Title="The big bro", Duration= 8}
            };

            foreach (var item in items)
            {
                item.Play();
            }

            Console.WriteLine();
            Movie[] movies = new Movie[]
            {
             new Movie(){Title= "Sing", Duration=50},
            new Movie(){Title= "KofiKo", Duration=10},
            new Movie(){Title= "The last song", Duration=18}
            };

            Array.Sort(movies);
            foreach (var item in movies)
            {
                Console.WriteLine(item.Title +" "+ item.Duration);
            }
        }
    }
}

