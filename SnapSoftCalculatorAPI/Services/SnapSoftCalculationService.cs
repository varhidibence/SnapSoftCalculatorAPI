using SnapSoftCalculatorAPI.Interfaces;
using SnapSoftCalculatorAPI.Models;
using System;
using System.Collections.Generic;

namespace SnapSoftCalculatorAPI.Services
{
  public class SnapSoftCalculationService : ISnapSoftCalculation
  {
    public List<ICalculation> calculations { get; private set; }

    public SnapSoftCalculationService()
    {
      calculations = new List<ICalculation>();
    }

    /// <summary>
    /// output is also an n-long integer array,
    /// where the element with index i is equal to the product 
    /// of the input array except the element i.
    /// </summary>
    /// <param name="inputNumbers">n-long integer array</param>
    /// <returns>product of the input array except the element i.</returns>
    public List<int> CalculateMagicProductAnyWay(List<int> inputNumbers)
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

    public ICalculationResponse CreateResponse(ICalculationRequest calculationRequest, List<int> result)
    {
      CalculationResponse response = CreateResponseFromResult(result);
      SaveCalculationFromResponse(calculationRequest, response);

      return response;
    }

    private void SaveCalculationFromResponse(ICalculationRequest calculationRequest, CalculationResponse response)
    {
      var calculation = new Calculation()
      {
        CalculationID = Guid.NewGuid(),
        CalculationRequest = calculationRequest,
        CalculationResponse = response
      };

      calculations?.Add(calculation);
    }

    private CalculationResponse CreateResponseFromResult(List<int> result)
    {
      return new CalculationResponse
      {
        ID = Guid.NewGuid(),
        RequestID = Guid.NewGuid(),
        Result = result,
        TimestampOfCall = DateTime.Now
      };
    }

    List<ICalculation> ISnapSoftCalculation.GetAll()
    {
      return calculations;
    }

    public List<ICalculation> SearchByComment(string commentFilter)
    {
      if (string.IsNullOrWhiteSpace(commentFilter))
      {
        return calculations;
      }

      return calculations.FindAll(calculation => calculation.CalculationRequest.Comment.Contains(commentFilter));
    }

    public ICalculationResponse CalculateAnyWay(ICalculationRequest request)
    {
      var result = CalculateMagicProductAnyWay(request.Request);
      return CreateResponse(request, result);
    }

    public ICalculationResponse CalculateWithoutDivison(ICalculationRequest request)
    {
      var result = CalculateMagicProductAnyWay(request.Request);
      return CreateResponse(request, result);
    }

    public ICalculationResponse CalculateBetterComplexity(ICalculationRequest request)
    {
      throw new NotImplementedException();
    }

  }
}
