using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Erp.EntityLayer.Entities;

[Table("TBL_STOKKAYITLARI")]
public class Stock
{
    [Key]
    [Column("STOK_KODU")]
    public string StockCode { get; set; } = null!;

    [Column("STOK_ADI")]
    public string? StockName { get; set; }

    [Column("GRUP_KODU")]
    public string? GroupCode { get; set; }

    [Column("FIYAT", TypeName = "decimal(18, 3)")]
    public decimal? Price { get; set; }

    [Column("KDV_ORANI", TypeName = "decimal(18, 2)")]
    public decimal? Vat { get; set; }
}
