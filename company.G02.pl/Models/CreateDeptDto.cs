using System.ComponentModel.DataAnnotations;

namespace company.G02.pl.Models
{
    public class CreateDeptDto
    {
        [Required(ErrorMessage ="code is requires!!!!")]
        public string name { get; set; }
        [Required(ErrorMessage = "name is requires!!!!")]
        public string code { get; set; }
        [Required(ErrorMessage = "create at is requires!!!!")]
        public DateTime createat { get; set; }
    }
}
