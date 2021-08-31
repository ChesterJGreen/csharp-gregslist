using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using gregslist.Models;
using gregslist.Services;
namespace gregslist.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class HomesController : ControllerBase
    {
        private readonly HomesService _homesService;
        public HomesController(HomesService homesService)
        {
            _homesService = homesService;
        }
        [HttpGet]
        public ActionResult<IEnumerable<Home>> Get()
        {
            try
            {
                IEnumerable<Home> homes = _homesService.Get();
                return Ok(homes);
            }
            catch (Exception err)
            {
             return BadRequest(err.Message);
            }
        }
        [HttpGet("{id}")]
        public ActionResult<Home> Get(string id)
        {
            try
            {
                Home found = _homesService.Get(id);
                return Ok(found);
            }
            catch (Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }
        [HttpPost]
        public ActionResult<Home> Create([FromBody] Home newHome)
        {
            try
            {
                Home home = _homesService.Create(newHome);
                return Ok(home);
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
                _homesService.Delete(id);
                return Ok("Successfully Deleted Home");
            }
            catch (Exception err)
            {
                
                return BadRequest(err.Message);
            }
        }
    }
}