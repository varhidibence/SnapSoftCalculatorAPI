using SnapSoftCalculatorAPI.Interfaces;

namespace SnapSoftCalculatorAPI.DAL
{
  public class DbHelper
  {
    private ApplicatonDbContext _context;

    public DbHelper(ApplicatonDbContext context)
    {
      _context = context;
    }

    //public List<ICalculation> GetAllCalculations()
    //{
    //  var dataList = _context
    //}
  }
}
