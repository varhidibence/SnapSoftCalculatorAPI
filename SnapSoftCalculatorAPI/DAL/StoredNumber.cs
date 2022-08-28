using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SnapSoftCalculatorAPI.DAL
{
  public class StoredNumber
  {
    [Key]
    public int Number { get; set; }

    public virtual ICollection<StoredCalculation> Calculations { get; set; }
  }
}
