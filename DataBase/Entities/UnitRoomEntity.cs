using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.Entities
{
    public class UnitRoomEntity
    {
        public int Id { get; set; }
        [Required]
        public int StudentCount { get; set; }

        [Required]
        [ForeignKey("Rooms")]
        public int RoomId { get; set; }
        public virtual RoomEntity Room { get; set; }

        [Required]
        [ForeignKey("Units")]
        public int UnitId { get; set; }
        public virtual UnitEntity Unit { get; set; }

    }
}
