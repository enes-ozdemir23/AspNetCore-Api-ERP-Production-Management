using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Erp.DataAccessLayer.Concrete.Context;

[Table("TBL_IL")]
public class City
{
    [Key]
    [Column("ID")]
    public int CityId { get; set; }

    [Column("ISIM")]
    public string? CityName { get; set; }

}
