using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace PBL3REAL.Model
{
    [Table("permission")]
    public partial class Permission
    {
        [Key]
        [Column("id_permission")]
        public int IdPermission { get; set; }
        [Column("per_idrole")]
        public int PerIdrole { get; set; }
        [Column("per_idaction")]
        public int PerIdaction { get; set; }
        [Required]
        [Column("per_activeflag")]
        public bool? PerActiveflag { get; set; }

        [ForeignKey(nameof(PerIdaction))]
        [InverseProperty(nameof(Action.Permissions))]
        public virtual Action PerIdactionNavigation { get; set; }
        [ForeignKey(nameof(PerIdrole))]
        [InverseProperty(nameof(Role.Permissions))]
        public virtual Role PerIdroleNavigation { get; set; }
    }
}
