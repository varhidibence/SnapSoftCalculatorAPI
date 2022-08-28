using System;
using System.Collections.Generic;

namespace SnapSoftCalculatorAPI.Interfaces
{
  public interface ICalculationResponse
  {

    /// <summary>
    /// Result of the calculation
    /// </summary>
    List<int> Result { get; set; }

    /// <summary>
    /// Timestamp of the call
    /// </summary>
    DateTime TimestampOfCall { get; set; }
  }
}
