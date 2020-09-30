using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using docspider.Contatos;
using System;
using System.Collections.Generic;

namespace docspider.Pessoas
{
    public class Pessoa : Entity, ICreationAudited, IDeletionAudited, IPassivable
    {
        public Pessoa()
        {
            IsActive = true;
        }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateTime? DataNascimento { get; set; }

        public ICollection<Contato> Contatos { get; set; }

        public long? CreatorUserId { get; set; }
        public DateTime CreationTime { get; set; }

        public long? DeleterUserId { get; set; }
        public DateTime? DeletionTime { get; set; }
        public bool IsDeleted { get; set; }

        public bool IsActive { get; set; }

        public void ToggleStateActive()
        {
            if (DataNascimento == null)
                throw new InvalidOperationException("Não é possível trocar o status quando perfil não está completo.");

            IsActive = !IsActive;
        }
    }
}
