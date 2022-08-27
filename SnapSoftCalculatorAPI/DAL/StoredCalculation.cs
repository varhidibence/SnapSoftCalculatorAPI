using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace SnapSoftCalculatorAPI.DAL
{
  public class StoredCalculation
  {
    [Key]
    public Guid ID { get; set; }

    [Required]
    public DateTime TimeStamp { get; set; }

    public string Comment { get; set; }

    public virtual List<StoredNumber> RequestedNumbers { get; set; }

    public virtual List<StoredNumber> ResponseNumbers { get; set; }
  }
}
