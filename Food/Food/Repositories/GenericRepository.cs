using Food.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Food.Repositories
{
    public class GenericRepository<T> where T : class, new()
    {
        Context ct = new Context();

        public List<T> TList()
        {
            return ct.Set<T>().ToList();
        }

        public void TAdd(T p)
        {
            ct.Set<T>().Add(p);
            ct.SaveChanges();
        }

        public void TDelete(T p)
        {
            ct.Set<T>().Remove(p);
            ct.SaveChanges();
        }

        public void TUpdate(T p)
        {
            ct.Set<T>().Update(p);
            ct.SaveChanges();
        }

        public void TGet(int id)
        {
            ct.Set<T>().Find(id);
        }

        public List<T> TList(string p)
        {
            return ct.Set<T>().Include(p).ToList();
        }
    }
}
