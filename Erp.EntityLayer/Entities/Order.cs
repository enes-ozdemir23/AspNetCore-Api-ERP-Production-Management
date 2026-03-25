using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Erp.EntityLayer.Entities;

[Table("TBL_SIPARISLER")]
public class Order
{
    [Key]
    [Column("SIPARIS_NO")]
    public string OrderCode { get; set; } = null!;

    [Column("MUSTERI_KODU")]
    public string? CustomerCode { get; set; }

    [Column("SIPARIS_TARIHI")]
    public string? OrderDate { get; set; }

    [Column("TESLIM_TARIHI")]
    public string? OrderDeliveryDate { get; set; }

    [Column("TOPLAM_TUTAR", TypeName = "decimal(18, 3)")]
    public decimal? TotalPrice { get; set; }
}
