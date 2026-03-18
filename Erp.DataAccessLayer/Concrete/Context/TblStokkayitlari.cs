using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Erp.DataAccessLayer.Concrete.Context;

[Table("TBL_STOKKAYITLARI")]
public partial class TblStokkayitlari
{
    [Key]
    [Column("STOK_KODU")]
    [StringLength(50)]
    [Unicode(false)]
    public string StokKodu { get; set; } = null!;

    [Column("STOK_ADI")]
    [StringLength(100)]
    [Unicode(false)]
    public string? StokAdi { get; set; }

    [Column("GRUP_KODU")]
    [StringLength(10)]
    [Unicode(false)]
    public string? GrupKodu { get; set; }

    [Column("FIYAT", TypeName = "decimal(18, 3)")]
    public decimal? Fiyat { get; set; }

    [Column("KDV_ORANI", TypeName = "decimal(18, 2)")]
    public decimal? KdvOrani { get; set; }
}
