using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt_C.Persistence.Repositories;


namespace Projekt_C.Persistence
{
    public static class UnitOfWork
    {
        public static CategoryRepository Category { get; }
        public static FeedRepository PodcastFeed { get; }

        static UnitOfWork()
        {
            Category = new CategoryRepository(@"..\..\Database\Categories.xml");
            PodcastFeed = new FeedRepository(@"..\..\Database\PodcastFeeds.xml");
        }
    }
}
