using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PowerMap.Models.DAL.Entities
{
    public class FAQ
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız.")]
        [Column(TypeName = "Varchar")]
        [StringLength(250, ErrorMessage = "En fazla 250 karakter uzunluğunda metin yazabilirsiniz.")]
        public string Question { get; set; }
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız.")]
        [Column(TypeName = "Varchar")]
        [StringLength(750, ErrorMessage = "En fazla 750 karakter uzunluğunda metin yazabilirsiniz.")]
        public string Answer { get; set; }
    }
}
