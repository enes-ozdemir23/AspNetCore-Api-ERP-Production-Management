using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Erp.EntityLayer.Entities;

[Table("TBL_ISEMRI")]
public class WorkOrder
{
    [Key]
    [Column("ISEMRI_NUMARASI")]
    public string WorkOrderCode { get; set; } = null!;

    [Column("STOK_KODU")]
    public string? StockCode { get; set; }

    [Column("STOK_ADI")]
    public string? StockName { get; set; }

    [Column("ISEMRI_ACIKLAMASI")]
    public string? Description { get; set; }

    [Column("ISEMRI_TARIHI")]
    public string? WorkOrderDate { get; set; }

    [Column("TESLIM_TARIHI")]
    public string? DeliveryDate { get; set; }

    [Column("SIPARIS_NO")]
    public string? OrderCode { get; set; }

    [Column("MIKTAR", TypeName = "decimal(5, 2)")]
    public decimal? WorkOrderAmount { get; set; }

    [Column("SIPKALEM_ID")]
    public int? OrderItemId { get; set; }

    [Column("DURUM")]
    public string? WorkOrderStatus { get; set; }
}
