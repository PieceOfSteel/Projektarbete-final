using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_C.Core.Domain
{
    public class PodcastEpisode : EntityBase
    {
        /* Inherited:
        public int Id { get; set; }
        public string Name { get; set; } 
        */

        public PodcastEpisode()
        {

        }

        public PodcastEpisode(int Id, string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }


    }
}
