using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt_C.Persistence;

namespace Projekt_C.Core.Domain
{
    public class PodcastFeed : EntityBase, IPersistent
    {
        /* Inherited:
        public int Id { get; set; }
        public string Name { get; set; } 
        */
        
        public string Url { get; set; }
        public int UpdateInterval { get; set; }
        public List<PodcastEpisode> PodcastEpisodes { get; set; }
        public Category Category { get; set; }

        public PodcastFeed()
        {
            CreateId();
            PodcastEpisodes = new List<PodcastEpisode>();
        }

        public PodcastFeed(string name, string Description, string url, Category category, int updateInterval)
        {
            CreateId();
            Name = name;
            Url = url;
            PodcastEpisodes = new List<PodcastEpisode>();
            Category = category;
            UpdateInterval = updateInterval;
        }

        public override string GetInfo(string sep = "\t")
        {
            string info = base.GetInfo()
                + "Category:" + sep + sep + Category.Name + "\n"
                + "Update Interval:" + sep + UpdateInterval + "\n"
                + "Url:" + sep + Url + "\n";
            return info;
        }

        protected override void CreateId()
        {
            Id = UnitOfWork.PodcastFeed.GetFreeId();
        }

    }
}
