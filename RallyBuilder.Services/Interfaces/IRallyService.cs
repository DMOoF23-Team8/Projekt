using RallyBuilder.Models;

namespace RallyBuilder.Services
{
    public interface IRallyService
    {
        Task<List<Rally>> GetRallies();
    }
}
