using Microsoft.AspNetCore.Mvc;
using SnapSoftCalculatorAPI.Interfaces;
using SnapSoftCalculatorAPI.Models;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SnapSoftCalculatorAPI.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CalculateController : ControllerBase
  {
    // GET: api/<CalculateController>
    [HttpGet]
    public ActionResult<List<Calculation>> Get([FromServices] ISnapSoftCalculation snapSoftCalculationService)
    {
      return snapSoftCalculationService.GetAll();
    }

    // GET api/<CalculateController>/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
      return "value";
    }

    // POST api/<CalculateController>
    [HttpPost]
    public void Post([FromBody] string value)
    {
    }

    // PUT api/<CalculateController>/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody] string value)
    {
    }

    // DELETE api/<CalculateController>/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
  }
}
