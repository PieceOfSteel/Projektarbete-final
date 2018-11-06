using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Projekt_C.Core.Domain;

namespace Projekt_C.Core.Domain
{
    public class UpdateClock : Timer
    {
        public PodcastFeed TimerFeed { get; set; }
        
        public UpdateClock(PodcastFeed podcastFeed)
        {
            TimerFeed = podcastFeed;
            Interval = TimerFeed.UpdateInterval;
        }
    }
}
