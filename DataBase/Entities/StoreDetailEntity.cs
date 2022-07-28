using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Entities
{
    public class StoreDetailEntity
    {
        public int Id { get; set; }
        public int Amount { get; set; }

        [Required]
        [ForeignKey("Accessories")]
        public int AccessoryId { get; set; }
        public virtual AccessoryEntity Accessory { get; set; }

        [Required]
        [ForeignKey("UnitStores")]
        public int UnitStoreId { get; set; }
        public virtual UnitStoreEntity UnitStore { get; set; }



    }
}
