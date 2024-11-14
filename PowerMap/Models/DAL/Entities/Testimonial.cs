using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PowerMap.Models.DAL.Entities
{
    public class Testimonial
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız.")]
        [Column(TypeName = "Varchar")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter uzunluğunda metin yazabilirsiniz.")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız.")]
        [Column(TypeName = "Varchar")]
        [StringLength(70, ErrorMessage = "En fazla 70 karakter uzunluğunda metin yazabilirsiniz.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız.")]
        [Column(TypeName = "Varchar")]
        [StringLength(350, ErrorMessage = "En fazla 350 karakter uzunluğunda metin yazabilirsiniz.")]
        public string Comment { get; set; }
        public short Star {  get; set; }
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız.")]
        [Column(TypeName = "Varchar")]
        [StringLength(150, ErrorMessage = "En fazla 150 karakter uzunluğunda URL yazabilirsiniz.")]
        public string ImageUrl { get; set; }
    }
}
