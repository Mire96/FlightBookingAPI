using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GET.FlightBooking.Data.Entities
{
    [Table("User")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Column("id")]
        public int Id { get; set; }
        [Column("UserName", TypeName = "varchar(20)")]
        [Required]
        public string UserName { get; set; }
        [Column("Password", TypeName = "varchar(20)")]
        [Required]
        public string Password { get; set; }
        [Column("Role", TypeName = "varchar(20)")]
        [Required]
        public Role Role { get; set; }

    }
}
