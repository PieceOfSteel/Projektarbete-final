using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt_C.Persistence;

namespace Projekt_C.Core.Domain
{
    public class Category : EntityBase, IPersistent
    {
        /* Inherited:
        public int Id { get; set; }
        public string Name { get; set; } 
        */
        
        public Category(string name = "defaultCategory")
        {
            CreateId();
            Name = name;
        }

        protected override void CreateId()
        {
            Id = UnitOfWork.Category.GetFreeId();
        }
    }
}
