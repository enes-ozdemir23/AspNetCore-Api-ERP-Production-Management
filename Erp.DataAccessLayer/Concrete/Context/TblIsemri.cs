using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Erp.DataAccessLayer.Concrete.Context;

[Table("TBL_ISEMRI")]
public partial class TblIsemri
{
    [Key]
    [Column("ISEMRI_NUMARASI")]
    [StringLength(50)]
    [Unicode(false)]
    public string IsemriNumarasi { get; set; } = null!;

    [Column("STOK_KODU")]
    [StringLength(50)]
    [Unicode(false)]
    public string? StokKodu { get; set; }

    [Column("STOK_ADI")]
    [StringLength(100)]
    [Unicode(false)]
    public string? StokAdi { get; set; }

    [Column("ISEMRI_ACIKLAMASI")]
    [StringLength(100)]
    [Unicode(false)]
    public string? IsemriAciklamasi { get; set; }

    [Column("ISEMRI_TARIHI")]
    [StringLength(20)]
    [Unicode(false)]
    public string? IsemriTarihi { get; set; }

    [Column("TESLIM_TARIHI")]
    [StringLength(20)]
    [Unicode(false)]
    public string? TeslimTarihi { get; set; }

    [Column("SIPARIS_NO")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SiparisNo { get; set; }

    [Column("MIKTAR", TypeName = "decimal(5, 2)")]
    public decimal? Miktar { get; set; }

    [Column("SIPKALEM_ID")]
    public int? SipkalemId { get; set; }

    [Column("DURUM")]
    [StringLength(1)]
    [Unicode(false)]
    public string? Durum { get; set; }
}
