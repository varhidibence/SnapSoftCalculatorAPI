using Microsoft.AspNetCore.Mvc;
using SnapSoftCalculatorAPI.Interfaces;
using SnapSoftCalculatorAPI.Models;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SnapSoftCalculatorAPI.Controllers
{
  [Route("api")]
  [ApiController]
  public class CalculateController : ControllerBase
  {
    // GET: api/<CalculateController>
    //[HttpGet]
    //[Route("/history")]
    //public ActionResult<List<ICalculation>> Get([FromServices] ISnapSoftCalculation snapSoftCalculationService)
    //{
    //  return snapSoftCalculationService.GetAll();
    //}

    [HttpGet]
    [Route("/history")]
    public ActionResult<List<ICalculation>> Get([FromServices] ISnapSoftCalculation snapSoftCalculationService,[FromQuery] string comment)
    {
      return snapSoftCalculationService.SearchByComment(comment);
    }


    // POST api/<CalculateController>/a
    [HttpPost]
    [Route("/[controller]/a")]
    public IActionResult Post_a([FromBody] CalculationRequest request, [FromServices] ISnapSoftCalculation snapSoftCalculationService)
    {
      var response = snapSoftCalculationService.CalculateAnyWay(request);
      return CreatedAtAction(nameof(Post_a), new {request, response});
    }

    // POST api/<CalculateController>/b
    [HttpPost]
    [Route("/[controller]/b")]
    public IActionResult Post_b([FromBody] CalculationRequest request, [FromServices] ISnapSoftCalculation snapSoftCalculationService)
    {
      var response = snapSoftCalculationService.CalculateAnyWay(request);
      return CreatedAtAction(nameof(Post_b), new { request, response });
    }

    // POST api/<CalculateController>/c
    [HttpPost]
    [Route("/[controller]/c")]
    public IActionResult Post_c([FromBody] CalculationRequest request, [FromServices] ISnapSoftCalculation snapSoftCalculationService)
    {
      var response = snapSoftCalculationService.CalculateAnyWay(request);
      return CreatedAtAction(nameof(Post_c), new { request, response });
    }
  }
}
