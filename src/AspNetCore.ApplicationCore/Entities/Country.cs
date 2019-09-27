using System.ComponentModel.DataAnnotations;

namespace AspNetCore.ApplicationCore.Entities
{
    public class Country : BaseEntity
    {
        [Display(Name="Nome")]
        [Required(ErrorMessage="O campo {0} é obrigatório.")]
        [StringLength(60, MinimumLength=3, ErrorMessage="O campo {0} deve conter entre {2} e {1} caracteres.")]
        public string Name { get; set; }

        [Display(Name="Código IBGE")]
        [Required(ErrorMessage="O campo {0} é obrigatório.")]
        [StringLength(3, MinimumLength=3, ErrorMessage="O campo {0} deve conter {1} caracteres.")]
        public string CodeIBGE { get; set; }

        [Display(Name="Código ISO")]
        [MaxLength(3, ErrorMessage="O campo {0} não pode conter mais que {1} caracteres.")]        
        public string CodeISO { get; set; }
    }
}