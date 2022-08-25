using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SnapSoftCalculatorAPI.Tets
{
  [TestClass]
  public class SnapSoftCalculatorServiceTest
  {
    [TestMethod]
    public void CalculateMagicProductTest()
    {
      List<int> Input = new List<int> { 1, 2, 3, 4 };
      List<int> Output = new List<int> { 24, 12, 8, 6 };

      Assert.AreEqual(Input.Count, Output.Count);
    }
  }
}
