using System.ComponentModel.DataAnnotations;

namespace PowerMap.Models.DAL.Entities
{
    public class Make_Model
    {
        [Key]
        public int Id { get; set; }
        public int MakeId { get; set; }
        public virtual Make Make { get; set; }
        public int ModelId { get; set; }
        public virtual Model Model { get; set; }
    }
}
