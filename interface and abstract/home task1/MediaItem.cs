using System;
using System.Collections.Generic;
using System.Text;

namespace home_task1
{
    abstract class MediaItem 
    {
        public string Title { get; set; }
        public int Duration { get; set; }

        public abstract void Play();
       

       
    }
}
