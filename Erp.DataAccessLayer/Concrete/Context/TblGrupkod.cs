using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Erp.DataAccessLayer.Concrete.Context;

[Table("TBL_GRUPKOD")]
public partial class TblGrupkod
{
    [Key]
    [Column("GRUP_KODU")]
    [StringLength(10)]
    [Unicode(false)]
    public string GrupKodu { get; set; } = null!;

    [Column("GRUP_ADI")]
    [StringLength(50)]
    [Unicode(false)]
    public string? GrupAdi { get; set; }
}
