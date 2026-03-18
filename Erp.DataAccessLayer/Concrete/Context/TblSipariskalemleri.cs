using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Erp.DataAccessLayer.Concrete.Context;

[Table("TBL_SIPARISKALEMLERI")]
public partial class TblSipariskalemleri
{
    [Key]
    [Column("SIPKALEM_ID")]
    public int SipkalemId { get; set; }

    [Column("SIPARIS_NO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SiparisNo { get; set; }

    [Column("STOK_KODU")]
    [StringLength(50)]
    [Unicode(false)]
    public string? StokKodu { get; set; }

    [Column("STOK_ADI")]
    [StringLength(100)]
    [Unicode(false)]
    public string? StokAdi { get; set; }

    [Column("MIKTAR", TypeName = "decimal(5, 2)")]
    public decimal? Miktar { get; set; }

    [Column("URUN_ACIKLAMASI")]
    [StringLength(100)]
    [Unicode(false)]
    public string? UrunAciklamasi { get; set; }

    [Column("FIYAT", TypeName = "decimal(18, 2)")]
    public decimal? Fiyat { get; set; }

    [Column("KDV", TypeName = "decimal(5, 2)")]
    public decimal? Kdv { get; set; }

    [Column("URETIMDURUMU")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Uretimdurumu { get; set; }
}
