using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Entities
{
    public class UnitEntity
    {
        public int Id { get; set; }
        [Required]
        public String Name { get; set; } 
        [Required]
        public bool Gender { get; set; }
        public int UserFk { get; set; }

        public int UnitStoreFk { get; set; }
        

        [Required]
        [ForeignKey("StudyBranchs")]
        public int StudyBranchEntityId { get; set; }
        public virtual StudyBranchEntity StudyBranch { get; set; }

        //[Required]
        //[ForeignKey("Users")]
        //public int UserId { get; set; }
        //public virtual UserEntity User { get; set; }

        //[Required]
        //[ForeignKey("UnitStores")]
        //public int UnitStoreId { get; set; }
        //public virtual UnitStoreEntity UnitStore { get; set; }

        




    }
}
