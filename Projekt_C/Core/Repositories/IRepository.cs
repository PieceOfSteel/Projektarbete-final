using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projekt_C.Core;

namespace Projekt_C.Core.Repositories
{
    public interface IRepository<T> where T : IPersistent
    {
        string Path { get; set; }

        T Get(int id);
        void Add(T obj);
        void Remove(T obj);
    }
}
