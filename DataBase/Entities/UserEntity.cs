using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Entities
{
   public class UserEntity
    {
        public int Id { get; set; }
        [Required]

        public String UserName { get; set; }
        [Required]
        public String Password { get; set; }
        public String Image { get; set; }
        public String PhoneNumber { get; set; }

        [Required]
        [ForeignKey("Roles")]
        public int RoleId { get; set; }
        public virtual RoleEntity Role { get; set; }





    }
}
