using System.ComponentModel.DataAnnotations;

namespace AspNetCore.ApplicationCore.Entities
{
    public class Country : BaseEntity
    {
        [Display(Name="Nome")]
        [Required(ErrorMessage="'{0}' deve ser informado.")]
        [StringLength(100, MinimumLength=3, ErrorMessage="'{0}' deve ter entre {2} e {1} caracteres.")]
        public string Name { get; set; }

        [Display(Name="Código IBGE")]
        [Required(ErrorMessage="'{0}' deve ser informado.")]
        [MaxLength(3, ErrorMessage="'{0}' deve ser menor ou igual a {1} caracteres.")]
        [RegularExpression(@"^[0-9]*$", ErrorMessage="Utilize apenas números no campo '{0}'.")]
        public string CodeIBGE { get; set; }

        [Display(Name="Código ISO")]
        [MaxLength(3, ErrorMessage="'{0}' deve ser menor ou igual a {1} caracteres.")]
        [RegularExpression(@"^[a-zA-Z]*$", ErrorMessage="Utilize apenas letras no campo '{0}'.")]
        public string CodeISO { get; set; }
    }
}