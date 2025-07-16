using System.ComponentModel.DataAnnotations;

namespace AgendaConsulta.Models
{
    public class LoginModel
    {
        [Required]
        public string CPF { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Lembrar?")]
        public bool RememberMe { get; set; }
    }
}
