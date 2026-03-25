using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Erp.EntityLayer.Entities;

[Table("TBL_SIPARISKALEMLERI")]
public class OrderItem
{
    [Key]
    [Column("SIPKALEM_ID")]
    public int OrderItemId { get; set; }

    [Column("SIPARIS_NO")]
    public string? OrderCode { get; set; }

    [Column("STOK_KODU")]
    public string? StockCode { get; set; }

    [Column("STOK_ADI")]
    public string? StockName { get; set; }

    [Column("MIKTAR", TypeName = "decimal(5, 2)")]
    public decimal? OrderItemAmount { get; set; }

    [Column("URUN_ACIKLAMASI")]
    public string? Description { get; set; }

    [Column("FIYAT", TypeName = "decimal(18, 2)")]
    public decimal? Price { get; set; }

    [Column("KDV", TypeName = "decimal(5, 2)")]
    public decimal? Vat { get; set; }

    [Column("URETIMDURUMU")]
    public string? OrderItemStatus { get; set; }
}
