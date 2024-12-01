using System.ComponentModel.DataAnnotations;

namespace IntroAsp.Models.ViewModels
{
    public class BeerModel
    {
        [Required]
        [Display(Name= "Nombre")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Marca")]
        public int Brand_Id { get; set; }
    }
}
