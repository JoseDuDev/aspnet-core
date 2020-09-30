using Abp.Application.Services;
using Abp.Authorization;
using Abp.Domain.Repositories;
using docspider.Pessoas.Dtos;
using System.Threading.Tasks;

namespace docspider.Pessoas
{
    [AbpAuthorize]
    public class PessoaAppService : AsyncCrudAppService<Pessoa, PessoaDto>, IPessoaAppService
    {
        public PessoaAppService(IRepository<Pessoa> repository) : base(repository)
        {
        }

        public async Task ToggleStateActive(int id)
        {
            var pessoa = await this.Repository.GetAsync(id);

            pessoa.ToggleStateActive();

            await CurrentUnitOfWork.SaveChangesAsync();
        }
    }
}
