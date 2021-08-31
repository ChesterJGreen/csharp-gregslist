using System;
using System.Collections.Generic;
using gregslist.Models;
using gregslist.Services;
using Microsoft.AspNetCore.Mvc;
namespace gregslist.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class JobsController : ControllerBase
    {
        private readonly JobsService _jobsService;
        public JobsController(JobsService jobsService)
        {
            _jobsService = jobsService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Home>> Get()

{
    try
    {
        IEnumerable<Job> jobs = _jobsService.Get();
        return Ok(jobs);
    }
    catch (Exception err)
    {
        
        return BadRequest(err.Message);
    }
    }  
[HttpGet("{id}")]
public ActionResult<Job> Get(string id)
{
    try
    {
        Job found = _jobsService.Get(id);
        return Ok(found);
    }
    catch (Exception err)
    {
        
        return BadRequest(err.Message);
    }
}
[HttpPost]
public ActionResult<Job> Create([FromBody] Job newJob)
{
    try
    {
        Job job = _jobsService.Create(newJob);
        return Ok(job);
    }
    catch (Exception err)
    {
        
        return BadRequest(err.Message);
    }
}
[HttpDelete("{id}")]
public ActionResult<String> Delete(string id)
{
    try
    {
        _jobsService.Delete(id);
        return Ok("Successfully Deleted Job");
    }
    catch (Exception err)
    {
        
        return BadRequest(err.Message);
    }
}
  }

}