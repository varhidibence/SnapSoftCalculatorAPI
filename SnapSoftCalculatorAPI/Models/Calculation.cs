using SnapSoftCalculatorAPI.Interfaces;
using System;

namespace SnapSoftCalculatorAPI.Models
{
  public class Calculation : ICalculation
  {
    public Guid CalculationID { get; set; }

    public ICalculationRequest CalculationRequest { get; set; }

    public ICalculationResponse CalculationResponse { get; set; }
  }
}
