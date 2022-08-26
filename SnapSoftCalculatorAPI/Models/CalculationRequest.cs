using SnapSoftCalculatorAPI.Interfaces;
using System.Collections.Generic;

namespace SnapSoftCalculatorAPI.Models
{
  public class CalculationRequest : ICalculationRequest
  {

    public List<int> Request { get; set; }

    public string Comment { get; set; }
  }
}
