using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Erp.DataAccessLayer.Concrete.Context;

[Table("TBL_ILCE")]
public partial class TblIlce
{
    [Key]
    [Column("ID")]
    public int Id { get; set; }

    [Column("ISIM")]
    [StringLength(100)]
    [Unicode(false)]
    public string? Isim { get; set; }

    [Column("IL_ID")]
    public int? IlId { get; set; }
}
