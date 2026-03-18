using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Erp.DataAccessLayer.Concrete.Context;

[Table("TBL_STOKHAREKETLERI")]
public partial class TblStokhareketleri
{
    [Key]
    [Column("STOKHAREKET_ID")]
    public int StokhareketId { get; set; }

    [Column("URETIMSONUKAYDI_NUMARASI")]
    [StringLength(50)]
    [Unicode(false)]
    public string? UretimsonukaydiNumarasi { get; set; }

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

    [Column("G_MIKTAR", TypeName = "decimal(5, 2)")]
    public decimal? GMiktar { get; set; }

    [Column("C_MIKTAR", TypeName = "decimal(5, 2)")]
    public decimal? CMiktar { get; set; }

    [Column("MUSTERI_ADI")]
    [StringLength(100)]
    [Unicode(false)]
    public string? MusteriAdi { get; set; }

    [Column("ACIKLAMA")]
    [StringLength(10)]
    [Unicode(false)]
    public string? Aciklama { get; set; }
}
