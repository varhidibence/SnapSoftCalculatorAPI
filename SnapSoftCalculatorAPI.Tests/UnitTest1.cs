using SnapSoftCalculatorAPI.Services;
using System;
using System.Collections.Generic;
using Xunit;

namespace SnapSoftCalculatorAPI.Tests
{
  public class SnapSoftCalculationService_Test
  {
    [Fact]
    public void SnapSoftCalculationService_Test4Elements()
    {
      // Arrange
      SnapSoftCalculationService service = new SnapSoftCalculationService();
      List<int> inputNumbers = new List<int> { 1, 2, 3, 4 };

      // Act
      List<int> output = service.CalculateMagicProduct(inputNumbers);

      // Assert
      Assert.Equal(inputNumbers.Count, output.Count);
      Assert.Equal(24, output[0]);
      Assert.Equal(12, output[1]);
      Assert.Equal(8, output[2]);
      Assert.Equal(6, output[3]);

    }
  }
}
