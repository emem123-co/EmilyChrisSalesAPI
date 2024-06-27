using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmilyChrisSalesAPI.Models;

public class Order
{
    [Key]
    public int Id { get; set; }

    public int CustomerId { get; set; }
    public virtual Customer? Customer { get; set; }

    public DateTime Date { get; set; }

    public string? Description { get; set; } = string.Empty;


    [Column(TypeName = "decimal(11,2)")]
    public decimal OrderTotal { get; set; } 


    [StringLength(30)]
    public string Status { get; set; } = string.Empty;
        

}
