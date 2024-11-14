using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PowerMap.Models.DAL.Entities
{
    public class About
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız.")]
        [Column(TypeName = "Varchar")]
        [StringLength(100, ErrorMessage = "En fazla 100 karakter uzunluğunda metin yazabilirsiniz.")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız.")]
        [Column(TypeName = "Varchar")]
        [StringLength(250, ErrorMessage = "En fazla 250 karakter uzunluğunda metin yazabilirsiniz.")]
        public string Subdescription { get; set; }
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız.")]
        [Column(TypeName = "Varchar")]
        [StringLength(1000, ErrorMessage = "En fazla 1000 karakter uzunluğunda metin yazabilirsiniz.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız.")]
        [Column(TypeName = "Varchar")]
        [StringLength(150, ErrorMessage = "En fazla 150 karakter uzunluğunda URL yazabilirsiniz.")]
        public string ImageUrl { get; set; }
    }
}
