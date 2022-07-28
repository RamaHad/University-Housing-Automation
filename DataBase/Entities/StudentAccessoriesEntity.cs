using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Entities
{
    public class StudentAccessoriesEntity
    {
        public int Id { get; set; }
        public int Amount { get; set; }
         [Required]
         public bool Returned { get; set; }


        [Required]
        [ForeignKey("Students")]
        public int StudentId { get; set; }
        public virtual StudentEntity Student { get; set; }

        [Required]
        [ForeignKey("StoreDetails")]
        public int StoreDetailId { get; set; }
        public virtual StoreDetailEntity StoreDetail { get; set; }


    }
}
