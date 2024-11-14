using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PowerMap.Models.DAL.Entities
{
    public class Portfolio
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
        public string Description { get; set; }
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız.")]
        [Column(TypeName = "Varchar")]
        [StringLength(150, ErrorMessage = "En fazla 150 karakter uzunluğunda metin yazabilirsiniz.")]
        public string ImageUrl { get; set; }
    }
}
