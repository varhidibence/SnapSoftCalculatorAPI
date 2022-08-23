using System;
using System.Collections.Generic;

namespace SnapSoftCalculatorAPI.Models
{
  public class Calculation
  {

    /// <summary>
    /// List of integers for the calculation
    /// </summary>
    public List<int> Input { get; set; }

    /// <summary>
    /// Result of the calculation
    /// </summary>
    public List<int> Output { get; set; }

    /// <summary>
    /// Comment for the calculation
    /// </summary>
    public string Comment { get; set; }

    /// <summary>
    /// Timestamp of the call
    /// </summary>
    public DateTime TimestampOfCall { get; set; }
  }
}
