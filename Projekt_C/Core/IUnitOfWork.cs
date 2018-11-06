using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt_C.Persistence.Repositories;

namespace Projekt_C.Core
{
    interface IUnitOfWork
    {
        CategoryRepository Category { get; }
        FeedRepository Feed { get; }
    }
}

