using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoIHC.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string NomeCompleto { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DataNascimento { get; set; }

        [Required]
        [StringLength(15)]
        public string RG { get; set; }

        [Required]
        [StringLength(14)]
        public string CPF { get; set; }

        [Required]
        [StringLength(100)]
        public string Logradouro { get; set; }

        [Required]
        [StringLength(50)]
        public string Bairro { get; set; }

        [Required]
        [StringLength(50)]
        public string Cidade { get; set; }

        [StringLength(50)]
        public string Complemento { get; set; }

        [Required]
        [StringLength(2)]
        public string UF { get; set; }

        [Required]
        [StringLength(9)]
        public string CEP { get; set; }

        [Required]
        public string EstadoCivil { get; set; } // Casado, Solteiro, etc.

        [StringLength(150)]
        public string NomePai { get; set; }

        [StringLength(150)]
        public string NomeMae { get; set; }
    }
}
