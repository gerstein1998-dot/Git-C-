using System;
using System.Collections.Generic;
using System.Text;

namespace home_task1
{
    internal class Song: MediaItem, IDownloadable
    {
        public override void Play()
        {
            Console.WriteLine("playing song");
        }

        public void Download()
        {
            Console.WriteLine("Downloading song file");
        }
    }
}
