using System.Threading.Tasks;
using Web.Models;

namespace Web.Interface
{
    public interface IHomeViewModelService
    {
        Task<HomeViewModel> GetHomeViewModelAsync(int? categoryId, int? brandId, int page);
    }
}
