using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Erp.DataAccessLayer.Concrete.Context;

[Table("TBL_URETIMSONUKAYITLARI")]
public partial class TblUretimsonukayitlari
{
    [Key]
    [Column("URETIMSONUKAYDI_NUMARASI")]
    [StringLength(50)]
    [Unicode(false)]
    public string UretimsonukaydiNumarasi { get; set; } = null!;

    [Column("ISEMRI_NUMARASI")]
    [StringLength(50)]
    [Unicode(false)]
    public string? IsemriNumarasi { get; set; }

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

    [Column("SIPARIS_NUMARASI")]
    [StringLength(50)]
    [Unicode(false)]
    public string? SiparisNumarasi { get; set; }

    [Column("SIPKALEM_ID")]
    public int? SipkalemId { get; set; }

    [Column("MUSTERI_KODU")]
    [StringLength(50)]
    [Unicode(false)]
    public string? MusteriKodu { get; set; }

    [Column("MUSTERI_ADI")]
    [StringLength(100)]
    [Unicode(false)]
    public string? MusteriAdi { get; set; }
}
