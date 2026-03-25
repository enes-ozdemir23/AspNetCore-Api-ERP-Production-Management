using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Erp.EntityLayer.Entities;

[Table("TBL_ILCE")]
public class District
{
    [Key]
    [Column("ID")]
    public int DistrictId { get; set; }

    [Column("ISIM")]
    public string? DistrictName { get; set; }

    [Column("IL_ID")]
    public int? DistrictCity { get; set; }
}
