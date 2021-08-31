using System;
using System.Collections.Generic;
using gregslist.Models;

namespace gregslist.Services
{
  public class JobsService
  {


    internal IEnumerable<Job> Get()
    {
      return FakeDB.Jobs;
    }
    internal Job Get(string id)
    {
     Job found = FakeDB.Jobs.Find(j => j.Id == id);
     if (found == null)
     {
         throw new Exception("Invalid Id");
     }
     return found;
    }
    internal Job Create(Job newJob)
    {
      FakeDB.Jobs.Add(newJob);
      return newJob;
    }
    internal void Delete(string id)
    {
    int deleted = FakeDB.Jobs.RemoveAll(j => j.Id == id);
    if (deleted == 0)
    {
        throw new Exception("Invalid Id");
        
    }
        }

  }
}