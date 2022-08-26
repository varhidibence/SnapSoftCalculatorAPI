using SnapSoftCalculatorAPI.Models;
using System.Collections.Generic;

namespace SnapSoftCalculatorAPI.Interfaces
{
  public interface ISnapSoftCalculation
  {
    /// <summary>
    /// output is also an n-long integer array, 
    /// where the element with index i is equal to the product 
    /// of the input array except the element
    /// </summary>
    /// <param name="inputNumbers"></param>
    /// <returns></returns>
    List<int> CalculateMagicProductAnyWay(List<int> inputNumbers);

    List<ICalculation> GetAll();

    ICalculationResponse CalculateAnyWay(ICalculationRequest request);

    ICalculationResponse CalculateWithoutDivison(ICalculationRequest request);

    ICalculationResponse CalculateBetterComplexity(ICalculationRequest request);


  }
}
