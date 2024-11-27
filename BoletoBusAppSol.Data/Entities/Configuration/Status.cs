

using BoletoBusAppSol.Data.Base;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoletoBusAppSol.Data.Entities.Configuration
{
    [Table("Status")]
    public sealed class Status : BaseEntity<short>
    {
        [Key]
        [Column("StatusId")]
        public override short Id { get; set; }
                
        public string? Description { get; set; }
    }
}
