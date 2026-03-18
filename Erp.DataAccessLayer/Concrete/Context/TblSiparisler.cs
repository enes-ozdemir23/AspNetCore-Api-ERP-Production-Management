using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Erp.DataAccessLayer.Concrete.Context;

[Table("TBL_SIPARISLER")]
public partial class TblSiparisler
{
    [Key]
    [Column("SIPARIS_NO")]
    [StringLength(50)]
    [Unicode(false)]
    public string SiparisNo { get; set; } = null!;

    [Column("MUSTERI_KODU")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MusteriKodu { get; set; }

    [Column("SIPARIS_TARIHI")]
    [StringLength(20)]
    [Unicode(false)]
    public string? SiparisTarihi { get; set; }

    [Column("TESLIM_TARIHI")]
    [StringLength(20)]
    [Unicode(false)]
    public string? TeslimTarihi { get; set; }

    [Column("TOPLAM_TUTAR", TypeName = "decimal(18, 3)")]
    public decimal? ToplamTutar { get; set; }
}
