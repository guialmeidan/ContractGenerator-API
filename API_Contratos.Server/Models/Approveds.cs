using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Text;

namespace API_Contratos.Shared.Models
{
    public class Approveds
    {
        public int Id { get; set; }
        [Required]
        public DateTime DataCriacao { get; set; }
        [Required]
        public string NomeCL { get; set; }
        [Required]
        public int Programa { get; set; }
    }
}
