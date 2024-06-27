using System.ComponentModel.DataAnnotations;

namespace EmilyChrisSalesAPI.Models;



public class Employees {

    public int Id { get; set; }
    [StringLength(50)]

    public string Email { get; set; } = string.Empty;
    [StringLength(20)]

    public string Password { get; set; } = string.Empty;

    public string FirstName { get; set; } = string.Empty;

    public string LastName { get; set; } = string.Empty;

}


