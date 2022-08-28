using SnapSoftCalculatorAPI.Interfaces;
using SnapSoftCalculatorAPI.Models;
using System.Collections.Generic;
using System.Linq;

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
    //  var calculations = new List<ICalculation>();
    //  var stored = _context.StoredCalculations.ToList();

    //  stored.ForEach(storedCal => calculations.Add(new Calculation()
    //  {
    //    CalculationID = storedCal.ID,
    //    CalculationRequest = new CalculationRequest
    //    {
    //      Comment = storedCal.Comment,
    //      Request = storedCal.RequestedNumbers.ToList<int>(num => num),

    //    }
        
    //  }))
    //}
  }
}
