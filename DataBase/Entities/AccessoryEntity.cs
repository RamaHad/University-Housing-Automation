using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Entities
{
    public class AccessoryEntity
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; }

    }
}
