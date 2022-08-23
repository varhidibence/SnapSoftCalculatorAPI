using SnapSoftCalculatorAPI.Interfaces;
using System.Collections.Generic;

namespace SnapSoftCalculatorAPI.Services
{
  public class SnapSoftCalculationService : ISnapSoftCalculation
  {
    public List<int> CalculateMagicProduct(List<int> inputNumbers)
    {
      List<int> result = new List<int>() { 24, 21, 8, 6};
      // TODO: implement magic

      return result;
    }
  }
}
