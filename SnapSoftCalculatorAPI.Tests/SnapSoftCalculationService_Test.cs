using SnapSoftCalculatorAPI.Services;
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
      List<int> output = service.CalculateMagicProductAnyWay(inputNumbers);

      // Assert
      Assert.Equal(inputNumbers.Count, output.Count);
      Assert.Equal(24, output[0]);
      Assert.Equal(12, output[1]);
      Assert.Equal(8, output[2]);
      Assert.Equal(6, output[3]);
    }

    [Fact]
    public void SnapSoftCalculationService_Test2Elements()
    {
      // Arrange
      SnapSoftCalculationService service = new SnapSoftCalculationService();
      List<int> inputNumbers = new List<int> {1, 2};

      // Act
      List<int> output = service.CalculateMagicProductAnyWay(inputNumbers);

      // Assert
      Assert.Equal(inputNumbers.Count, output.Count);
      Assert.Equal(2, output[0]);
      Assert.Equal(1, output[1]);
    }

    [Fact]
    public void SnapSoftCalculationService_EmptyInput()
    {
      // Arrange
      SnapSoftCalculationService service = new SnapSoftCalculationService();
      List<int> inputNumbers = null;

      // Act
      List<int> output = service.CalculateMagicProductAnyWay(inputNumbers);

      // Assert
      Assert.Null(output);  
    }
  }
}
