using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.ComponentModel.DataAnnotations;

namespace docspider.Pessoas.Dtos
{
    [AutoMap(typeof(Pessoa))]
    public class PessoaDto : EntityDto
    {
        [Required]
        [MaxLength(10)]
        public string Nome { get; set; }

        [Required]
        [MaxLength(150)]
        public string Sobrenome { get; set; }

        [Required]
        public DateTime? DataNascimento { get; set; }

        public bool IsActive { get; set; }
    }
}
