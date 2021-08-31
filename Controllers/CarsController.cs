using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using gregslist.Models;
using gregslist.Services;

namespace gregslist.Controllers
{
  [ApiController]
  [Route("/api/[controller]")]
  public class CarsController : ControllerBase
  {
    private readonly CarsService _carsService;
    public CarsController(CarsService carsService)
    {
      _carsService = carsService;
    }
    [HttpGet]
    public ActionResult<IEnumerable<Car>> Get()
    {
      try
      {
        IEnumerable<Car> cars = _carsService.Get();
        return ok(cars);
      }
      catch (Exception err)
      {

        return BadRequest(err.Message);
      }
    }
    [HttpGet("{id}")]
    public ACtionResult<Car> GetACtionResult(string id)
    {
      try
      {
        Car found = _carsService.Get(id);
        return ok(found);
      }
      catch (Exception err)
      {

        return BadRequest(err.Message);
      }
    }
    [HttpPost]
    public ActionResult<Car> Create([FromBody] Car NewCar)
    {
      try
      {
        Car car = _carsService.Create(newCar);
        return ok(car);
      }
      catch (Exception err)
      {

        return BadRequest(err.Message);
      }
    }
    [HttpDelete("{id}")]
    public ACtionResult<String> Delete(string id)
    {
      try
      {
        _carsService.Delete(id);
        return ok("Successfully Deleted Car");
      }
      catch (Exception err)
      {

        return BadRequest(err.Message);
      }
    }
  }
}