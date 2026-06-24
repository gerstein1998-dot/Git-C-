using System;
using System.Collections.Generic;
using System.Text;

namespace home_task1
{
    internal class LiveStream: MediaItem
    {
        public override void Play()
        {
            Console.WriteLine("playing live stream");
        }
    }
}
