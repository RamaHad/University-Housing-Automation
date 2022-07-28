using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Entities
{
    public class UnitStoreEntity
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }
        public int UserFk { get; set; }

        //[Required]
        //[ForeignKey("Users")]
        //public int UserId { get; set; }
        //public virtual UserEntity User { get; set; }

    }
}
