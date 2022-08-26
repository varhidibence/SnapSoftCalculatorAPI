using SnapSoftCalculatorAPI.Interfaces;
using SnapSoftCalculatorAPI.Models;
using System;
using System.Collections.Generic;

namespace SnapSoftCalculatorAPI.Services
{
  public class SnapSoftCalculationService : ISnapSoftCalculation
  {
    private readonly List<ICalculation> calculationsMock;

    private static int nextId = 1;

    public SnapSoftCalculationService()
    {
      calculationsMock = new List<ICalculation>
      {
        new Calculation
        {
          CalculationID = Guid.NewGuid(),
          CalculationRequest = new CalculationRequest
          {
            
            Comment = "This is a comment.",
            Request =  new List<int> {1, 2, 3, 4}
          },
          CalculationResponse = new CalculationResponse
          {
            ID= nextId++,
            RequestID = nextId++,
            Result = new List<int> {24, 12, 8, 6},
             TimestampOfCall = new DateTime(2022, 08, 22),
          }
        },
        new Calculation
        {
          CalculationID = Guid.NewGuid(),
          CalculationRequest = new CalculationRequest
          {
            Comment = "This is a comment.",
            Request =  new List<int> {1, 2}
          },
          CalculationResponse = new CalculationResponse
          {
            ID= nextId++,
            RequestID = nextId ++, 
            Result = new List<int> {2, 1},
            TimestampOfCall = new DateTime(2022, 08, 22),
          }
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

    public ICalculationResponse Add(ICalculationRequest calculationRequest)
    {
      var result = CalculateMagicProduct(calculationRequest.Request);

      CalculationResponse response = new CalculationResponse
      {
        ID = Guid.NewGuid(),
        RequestID = Guid.NewGuid(),
        Result = result,
        TimestampOfCall = DateTime.Now
      };

      var calculation = new Calculation()
      {
        CalculationID = Guid.NewGuid(),
        CalculationRequest = calculationRequest,
        CalculationResponse = response
      };

      calculationsMock?.Add(calculation);

      return response;
    }

    List<ICalculation> ISnapSoftCalculation.GetAll()
    {
      return calculationsMock;
    }

    public ICalculationResponse CalculateAnyWay(ICalculationRequest request)
    {
      return Add(request);
    }

    public ICalculationResponse CalculateWithoutDivison(ICalculationRequest request)
    {
      return Add(request);
    }

    public ICalculationResponse CalculateBetterComplexity(ICalculationRequest request)
    {
      throw new NotImplementedException();
    }
  }
}
