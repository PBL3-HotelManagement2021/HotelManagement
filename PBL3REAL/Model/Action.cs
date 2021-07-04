using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PBL3REAL.Model
{
    [Table("action")]
    public partial class Action
    {
        public Action()
        {
            Permissions = new HashSet<Permission>();
        }

        [Key]
        [Column("id_action")]
        public int IdAction { get; set; }
        [Required]
        [Column("action_name")]
        [StringLength(30)]
        public string ActionName { get; set; }
        [Required]
        [Column("action_code")]
        [StringLength(20)]
        public string ActionCode { get; set; }

        [InverseProperty(nameof(Permission.PerIdactionNavigation))]
        public virtual ICollection<Permission> Permissions { get; set; }
    }
}
