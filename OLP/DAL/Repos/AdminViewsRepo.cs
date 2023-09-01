using DAL.EF.Models;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class AdminViewsRepo : Repo, IRepo<WatchList, bool, int>

    {
        public bool create(WatchList obj)
        {
            throw new NotImplementedException();
        }

        public bool delete(int id)
        {
            throw new NotImplementedException();
        }

        public bool update(WatchList obj)
        {
            throw new NotImplementedException();
        }

        public WatchList view(int id)
        {
            throw new NotImplementedException();
        }

        public List<WatchList> viewAll()
        {
            return db.WatchLists.ToList();
        }
    }
}

