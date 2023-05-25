using System.ComponentModel.DataAnnotations;

namespace TPLOCAL1.Models
{
    public class FormulaireModel
    {
        [Required ( ErrorMessage = "Champ requis." )] public string? Name { get; set; }
        [Required ( ErrorMessage = "Champ requis." )] public string? Firstname { get; set; }
        [Required ( ErrorMessage = "Champ requis." )] public string? Sex { get; set; }
        [Required ( ErrorMessage = "Champ requis." )] public string? Adress { get; set; }
        [Required ( ErrorMessage = "Champ requis." )][RegularExpression ( @"[0-9]{5}", ErrorMessage = "erreur de saisie" )] public int PostalCode { get; set; }
        [Required ( ErrorMessage = "Champ requis." )] public string? City { get; set; }
        [Required ( ErrorMessage = "Champ requis." )][RegularExpression ( @"^([\w]+)@([\w]+)\.([\w]+)$", ErrorMessage = "erreur de saisie" )] public string? Mail { get; set; }
        [Required ( ErrorMessage = "Champ requis." )] public string? StartFormation { get; set; }
        [Required ( ErrorMessage = "Champ requis." )] public string? FormationType { get; set; }
        [Required ( ErrorMessage = "Champ requis." )] public string? Cobol { get; set; }
        [Required ( ErrorMessage = "Champ requis." )] public string? Csharp { get; set; }
    }
}