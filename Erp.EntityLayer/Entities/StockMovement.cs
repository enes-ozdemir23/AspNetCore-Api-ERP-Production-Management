using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Erp.EntityLayer.Entities;

[Table("TBL_STOKHAREKETLERI")]
public class StockMovement
{
    [Key]
    [Column("STOKHAREKET_ID")]
    public int StockMovementId { get; set; }

    [Column("URETIMSONUKAYDI_NUMARASI")]
    public string? ProductionResultCode { get; set; }

    [Column("ISEMRI_NUMARASI")]
    public string? WorkOrderCode { get; set; }

    [Column("STOK_KODU")]
    public string? StockCode { get; set; }

    [Column("STOK_ADI")]
    public string? StockName { get; set; }

    [Column("G_MIKTAR", TypeName = "decimal(5, 2)")]
    public decimal? IncomingAmount { get; set; }

    [Column("C_MIKTAR", TypeName = "decimal(5, 2)")]
    public decimal? OutgoingAmount { get; set; }

    [Column("MUSTERI_ADI")]
    public string? CustomerName { get; set; }

    [Column("ACIKLAMA")]
    public string? ProductionResultDescription { get; set; }
}
