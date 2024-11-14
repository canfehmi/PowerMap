using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PowerMap.Models.DAL.Entities
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız.")]
        [Column(TypeName = "Varchar")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter uzunluğunda isim yazabilirsiniz.")]
        public string NameSurname { get; set; }
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız.")]
        [Column(TypeName = "Varchar")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter uzunluğunda email yazabilirsiniz.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız.")]
        [Column(TypeName = "Varchar")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter uzunluğunda konu yazabilirsiniz.")]
        public string Subject { get; set; }
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız.")]
        [Column(TypeName = "Varchar")]
        [StringLength(2500, ErrorMessage = "En fazla 2500 karakter uzunluğunda metin yazabilirsiniz.")]
        public string MessageBody { get; set; }
        public DateTime SendTime { get; set; }
    }
}
