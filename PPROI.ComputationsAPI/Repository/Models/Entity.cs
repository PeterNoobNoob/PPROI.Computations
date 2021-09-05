using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PPROI.ComputationsAPI.Repository.Models
{
    [Table("Entity")]
    public partial class Entity
    {
        public Entity()
        {
            Results = new HashSet<Result>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Column(TypeName = "decimal(16, 2)")]
        public decimal FloorArea { get; set; }
        [Column(TypeName = "decimal(16, 3)")]
        public decimal CeilingHeight { get; set; }

        [InverseProperty(nameof(Result.Entity))]
        public virtual ICollection<Result> Results { get; set; }
    }
}
