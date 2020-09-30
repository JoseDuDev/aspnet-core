using Abp.Application.Services;
using docspider.Pessoas.Dtos;
using System.Threading.Tasks;

namespace docspider.Pessoas
{
    public interface IPessoaAppService : IAsyncCrudAppService<PessoaDto>
    {
        Task ToggleStateActive(int id);
    }
}
