namespace home_task1
{
    internal class Movie: MediaItem, IDownloadable, IComparable
    {
        public override void Play()
        {
            Console.WriteLine("playing movie");
        }

        public void Download()
        {
            Console.WriteLine("Downloading movie file");
        }

        public int CompareTo(object? obj)
        {
            return Duration.CompareTo(((MediaItem)obj).Duration);
        }
    }
}
