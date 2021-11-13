using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MVC__BO.Models
{
    public class Aluno
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="O nome seve ser informado!")]
        [StringLength(50,MinimumLength =5, ErrorMessage ="O nome deve ter no minimo 5 caracters!" )]
        [Display(Name ="Informe o Nome do cliente!")]
        public string Nome { get; set; }


        [Required(ErrorMessage = "O campo sexo deve ser informado!")]
        [Display(Name = "Informe o Sexo do cliente!")]
        public string Sexo { get; set; }


        [Required(ErrorMessage ="O email dever ser informado!")]
        [EmailAddress(ErrorMessage ="Email invalido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "A data de nascimento deve ser informada!")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString ="{0:dd/MM/yyyy}")]
        public DateTime Nascimento { get; set; }
    }
}
