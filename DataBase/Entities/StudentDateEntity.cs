using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Entities
{
    public class StudentDateEntity
    {
        public int Id { get; set; }
        [Required]
        public float Price { get; set; }


        [Required]
        [ForeignKey("Students")]
        public int StudentId { get; set; }
        public virtual StudentEntity Student { get; set; }

        [Required]
        [ForeignKey("TimeSlotes")]
        public int TimeSloteId { get; set; }
        public virtual TimeSloteEntity TimeSlote { get; set; }

        [Required]
        [ForeignKey("DateTypes")]
        public int DateTypeId { get; set; }
        public virtual DateTypeEntity DateType { get; set; }




    }
}
