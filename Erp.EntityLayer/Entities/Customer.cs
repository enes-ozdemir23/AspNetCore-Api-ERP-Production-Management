using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Erp.DataAccessLayer.Concrete.Context;

[Table("TBL_MUSTERIKAYITLARI")]
public class Customer
{
    [Key]
    [Column("MUSTERI_KODU")]
    public string CustomerCode { get; set; } = null!;

    [Column("MUSTERI_ADI")]
    public string? CustomerName { get; set; }

    [Column("ADRES")]
    public string? Address { get; set; }

    [Column("IL")]
    public string? City { get; set; }

    [Column("ILCE")]
    public string? District { get; set; }

    [Column("TELEFON")]
    public string? Phone { get; set; }

    [Column("E_POSTA")]
    public string? Email { get; set; }

    [Column("TIP")]
    public string? Type { get; set; }
}
