using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Erp.EntityLayer.Entities;

[Table("TBL_URETIMSONUKAYITLARI")]
public class ProductionResult
{
    [Key]
    [Column("URETIMSONUKAYDI_NUMARASI")]
    public string ProductionResultCode { get; set; } = null!;

    [Column("ISEMRI_NUMARASI")]
    public string? WorkOrderCode { get; set; }

    [Column("STOK_KODU")]
    public string? StockCode { get; set; }

    [Column("STOK_ADI")]
    public string? StockName { get; set; }

    [Column("MIKTAR", TypeName = "decimal(5, 2)")]
    public decimal? ProductionResultAmount { get; set; }

    [Column("SIPARIS_NUMARASI")]
    public string? OrderCode { get; set; }

    [Column("SIPKALEM_ID")]
    public int? OrderItemId { get; set; }

    [Column("MUSTERI_KODU")]
    public string? CustomerCode { get; set; }

    [Column("MUSTERI_ADI")]
    public string? CustomerName { get; set; }
}
