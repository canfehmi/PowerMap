using System.ComponentModel.DataAnnotations;

namespace PowerMap.Models.DAL.Entities
{
    public class Make
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime UpdatedOn { get; set; }
        public ICollection<Make_Model> Make_Models { get; set; }
    }
}
