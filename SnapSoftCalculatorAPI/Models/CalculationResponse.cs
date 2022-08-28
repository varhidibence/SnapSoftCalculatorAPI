using SnapSoftCalculatorAPI.Interfaces;
using System;
using System.Collections.Generic;

namespace SnapSoftCalculatorAPI.Models
{
  public class CalculationResponse: ICalculationResponse
  {

    public Guid ID { get; set; }

    public Guid  RequestID { get; set; }

    /// <summary>
    /// Result of the calculation
    /// </summary>
    public List<int> Result { get; set; }
    /// <summary>
    /// Timestamp of the call
    /// </summary>
    public DateTime TimestampOfCall { get; set; }
  }
}
