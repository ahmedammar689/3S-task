using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain1.Entities;
public class Address
{

    public int Id { get; set; }

    [Required]
    public string Governate { get; set; }

    [Required]
    public string City { get; set; }

    [Required]
    [MaxLength(200)]
    public string Street { get; set; }

    [Required]
    public string BuildingNumber { get; set; }

    [Required]
    public int FlatNumber { get; set; }

    [Required]
    public string AppUserId { get; set; }

}
