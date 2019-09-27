using System;
using System.ComponentModel.DataAnnotations;

namespace AspNetCore.ApplicationCore.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        [Display(Name="Código")]
        public long ID { get; set; }

        [Display(Name="Cadastro")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? Created { get; set; }

        [Display(Name="Atualizado")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(ApplyFormatInEditMode =true, DataFormatString ="{0:dd/MM/yyyy HH:mm:ss}")]
        public DateTime? Updated { get; set; }
    }
}
