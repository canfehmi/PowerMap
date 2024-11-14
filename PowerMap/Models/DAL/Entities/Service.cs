using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PowerMap.Models.DAL.Entities
{
    public class Service
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız.")]
        [Column(TypeName = "Varchar")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter uzunluğunda metin yazabilirsiniz.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız.")]
        [Column(TypeName = "Varchar")]
        [StringLength(250, ErrorMessage = "En fazla 250 karakter uzunluğunda metin yazabilirsiniz.")]
        public string Subdescription { get; set; }
    }
}
