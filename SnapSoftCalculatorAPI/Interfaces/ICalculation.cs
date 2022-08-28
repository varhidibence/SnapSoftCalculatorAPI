namespace SnapSoftCalculatorAPI.Interfaces
{
  public interface ICalculation
  {
    ICalculationRequest CalculationRequest { get; set; }

    ICalculationResponse CalculationResponse { get; set; }
  }
}
