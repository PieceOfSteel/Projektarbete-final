using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt_C.Core.Domain;
using System.Xml;
using System.ServiceModel.Syndication;

namespace Projekt_C.Core.Utilities
{
    public static class RssParser
    {
        private static SyndicationFeed feed;

        public static PodcastFeed GetPodcastFeed(Rss rss)
        {
            var reader = XmlReader.Create(rss.Url);
            feed = SyndicationFeed.Load(reader);
            
            var podcastFeed = new PodcastFeed
            {
                Name = feed.Title.Text
            };

            foreach(SyndicationItem feedItem in feed.Items)
            {
                podcastFeed.PodcastEpisodes.Add(new PodcastEpisode
                {
                    Name = feedItem.Title.Text
                });
            }

            return podcastFeed;
        }
    }
}
