using System.ComponentModel.DataAnnotations;

namespace Uberrr.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100,MinimumLength =3)]
        public string FullName { get; set; }

        public string Passwod {  get; set; }
        public string Phone { get; set; }
        public string Role {  get; set; }

    }
}
