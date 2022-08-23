using SnapSoftCalculatorAPI.Interfaces;
using SnapSoftCalculatorAPI.Models;
using System.Collections.Generic;
using System;

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

    public List<int> CalculateMagicProduct(List<int> inputNumbers)
    {
      List<int> result = new List<int>() { 24, 21, 8, 6};
      // TODO: implement magic

      return result;
    }

    public List<Calculation> GetAll()
    {
      return calculationsMock;
    }
  }
}
