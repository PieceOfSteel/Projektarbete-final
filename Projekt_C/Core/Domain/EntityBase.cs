using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_C.Core.Domain
{
    public abstract class EntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }


        public virtual string GetInfo(string sep = "\t")
        {
            string Info = "Id: " + sep + sep + Id + "\n" 
                + "Name: " + sep + sep + Name + "\n";
            return Info;
        }

        protected virtual void CreateId()
        {
            Id = 0;
        }

        public override string ToString()
        {
            return Name;
        }
    } 
}
