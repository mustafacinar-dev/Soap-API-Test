using System.Threading.Tasks;
using TKentService.Services.BulutService;

namespace TKentService.Services.Interfaces
{
    public interface ITransactionService
    {
        Task<ListResultOfTransaction> GetListResultOfTransaction();
    }
}
