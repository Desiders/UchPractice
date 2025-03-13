using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Uch;

public class Models
{
    public class Material
    {
        [Key]
        public int Id { get; set; }

        [Required]
#pragma warning disable CS8618 
        public string Name { get; set; }
#pragma warning restore CS8618

        [Required]
#pragma warning disable CS8618
        public string Type { get; set; }
#pragma warning restore CS8618

#pragma warning disable CS8618
        public string ImagePath { get; set; }
#pragma warning restore CS8618

        [Required]
        public double Price { get; set; }

        [Required, MinLength(0)]
        public int Count { get; set; } = 0;

        [Required, MinLength(0)]
        public int MinCount { get; set; } = 0;

        [MinLength(0)]
        public int? CountPerOne { get; set; }

        [Required, MaxLength(4)]
#pragma warning disable CS8618
        public string UnitType { get; set; }
#pragma warning restore CS8618

#pragma warning disable CS8618
        public ICollection<MaterialProvider> MaterialProviders { get; set; }
#pragma warning restore CS8618
    }

    public class Provider
    {
        [Key]
        public int Id { get; set; }

        [Required]
#pragma warning disable CS8618
        public string Name { get; set; }
#pragma warning restore CS8618

        [Required]
#pragma warning disable CS8618
        public string Type { get; set; }
#pragma warning restore CS8618

        [Required]
        public long Inn { get; set; }

        [Required]
        public int Rating { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

#pragma warning disable CS8618
        public ICollection<MaterialProvider> MaterialProviders { get; set; }
#pragma warning restore CS8618
    }

    [PrimaryKey(nameof(ProvidersId), nameof(MaterialsId))]
    public class MaterialProvider
    {
        [ForeignKey("Provider")]
        public int ProvidersId { get; set; }
#pragma warning disable CS8618
        public Provider Provider { get; set; }
#pragma warning restore CS8618

        [ForeignKey("Material")]
        public int MaterialsId { get; set; }
#pragma warning disable CS8618
        public Material Material { get; set; }
#pragma warning restore CS8618
    }

}
