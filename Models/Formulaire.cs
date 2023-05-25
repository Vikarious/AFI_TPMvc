using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class Formulaire
    {
/*        public int Id { get; set; }
*/        [Required]
        public string? Nom { get; set; }
        [Required]
        public string? Prénom { get; set; }
        [Required]
        public string? Sexe { get; set; }
        [Required]
        public string? Adresse { get; set; }
        [Required]
        public string? Codepostal { get; set; }
        [Required]
        public string? Ville { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? Date { get; set; }
        [Required]
        public string? Formationsuivie { get; set; }
        [Required]
        public string? Formationcobol { get; set; }
        [Required]
        public string? FormationC { get; set; }
    }
}