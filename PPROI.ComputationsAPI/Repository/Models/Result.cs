using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PPROI.ComputationsAPI.Repository.Models
{
    public partial class Result
    {
        [Key]
        public int Id { get; set; }
        public int EntityId { get; set; }
        [Column("Result", TypeName = "decimal(26, 2)")]
        public decimal RoomVolume { get; set; }

        [ForeignKey(nameof(EntityId))]
        [InverseProperty("Results")]
        public virtual Entity Entity { get; set; }
    }
}
