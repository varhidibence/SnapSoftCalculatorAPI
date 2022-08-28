using System.Collections.Generic;

namespace SnapSoftCalculatorAPI.Interfaces
{
  public interface ICalculationRequest
  {    
    /// <summary>
    /// Request for the calculation
    /// </summary>
    List<int> Request { get; set; }

    /// <summary>
    /// Comment for the calculation
    /// </summary>
    string Comment { get; set; }
  }
}
