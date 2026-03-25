using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Erp.EntityLayer.Entities;

[Table("TBL_GRUPKOD")]
public class GroupCode
{
    [Key]
    [Column("GRUP_KODU")]
    public string GroupCodeValue { get; set; } = null!;

    [Column("GRUP_ADI")]
    public string? GroupName { get; set; }
}
