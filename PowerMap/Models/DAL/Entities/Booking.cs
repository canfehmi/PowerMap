using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PowerMap.Models.DAL.Entities
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız.")]
        [Column(TypeName = "Varchar")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter uzunluğunda isim yazabilirsiniz.")]
        public string NameSurname { get; set; }
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız.")]
        [Column(TypeName = "Varchar")]
        [StringLength(11, ErrorMessage = "En fazla 11 karakter uzunluğunda telefon numarası yazabilirsiniz.")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız.")]
        [Column(TypeName = "Varchar")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter uzunluğunda email yazabilirsiniz.")]
        public string Email { get; set; }
        public int MakeId { get; set; }
        public virtual Make Make { get; set; }
        public int ModelId { get; set; }
        public virtual Model Model { get; set; }
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız.")]
        [Column(TypeName = "Varchar")]
        [StringLength(4, ErrorMessage = "En fazla 4 karakter uzunluğunda metin yazabilirsiniz.")]
        public string ModelYear { get; set; }
        public DateTime BookingDate { get; set; }
        public DateTime BookingHour { get; set; }
        public DateTime NowTime { get; set; }
        [Required(ErrorMessage = "Bu alanı boş bırakamazsınız.")]
        [Column(TypeName = "Varchar")]
        [StringLength(450, ErrorMessage = "En fazla 450 karakter uzunluğunda metin yazabilirsiniz.")]
        public string Message { get; set; }

    }
}
