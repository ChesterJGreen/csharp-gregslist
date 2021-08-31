using System;
using System.Collections.Generic;
using gregslist.Models;
namespace gregslist.Services
{
    public class HomesService
    {
        internal IEnumerable<Home> Get()
        {
            return FakeDB.Homes;
        }
        internal Home Get(string id)
        {
            Home found = FakeDB.Homes.Find(h => h.Id == id);
            if (found == null)
            {
                throw new Exception("Invalid Id");
            }
            return found;
        }
        internal Home Create(Home newHome)
        {
            FakeDB.Homes.Add(newHome);
            return newHome;
        }
        internal void Delete(string id)
        {
            int deleted = FakeDB.Homes.RemoveAll(h => h.Id == id);
            if (deleted == 0)
            {
            throw new Exception("Invalid Id");
            }
        }
    }

}