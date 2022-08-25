using SnapSoftCalculatorAPI.Interfaces;
using SnapSoftCalculatorAPI.Models;
using System;
using System.Collections.Generic;

namespace SnapSoftCalculatorAPI.Services
{
  public class SnapSoftCalculationService : ISnapSoftCalculation
  {
    private readonly List<Calculation> calculationsMock;

    public SnapSoftCalculationService()
    {
      calculationsMock = new List<Calculation>
      {
        new Calculation
        {
          Input = new List<int> {1, 2, 3, 4},
          Output = new List<int> {24, 12, 8, 6},
          Comment = "This is a comment.",
          TimestampOfCall = new DateTime(2022, 08, 22),
        },
        new Calculation
        {
          Input = new List<int> {1, 2, 3, 4},
          Output = new List<int> {5, 6, 7, 8},
          Comment = "This is a comment.",
          TimestampOfCall = new DateTime(2022, 08, 23),
        },
      };
    }

    /// <summary>
    /// output is also an n-long integer array,
    /// where the element with index i is equal to the product 
    /// of the input array except the element i.
    /// </summary>
    /// <param name="inputNumbers">n-long integer array</param>
    /// <returns>product of the input array except the element i.</returns>
    public List<int> CalculateMagicProduct(List<int> inputNumbers)
    {
      if (inputNumbers is null)
      {
        return null;
      }

      List<int> result = new List<int>();

      for (int i = 0; i < inputNumbers.Count; i++)
      {
        int product = 1;
        for (int j = 0; j < inputNumbers.Count; j++)
        {
          if (i != j)
          {
            product *= inputNumbers[j];
          }
        }
        result.Add(product);
      }

      return result;
    }

    public List<Calculation> GetAll()
    {
      return calculationsMock;
    }
  }
}
