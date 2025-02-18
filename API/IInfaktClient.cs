using InfaktGateway.Models.Costs;
using Refit;

namespace InfaktGateway.API
{
    public interface IInfaktClient
    {
        [Post("/documents/costs/upload.json")]
        public ApiResponse<ICostDocReference> AddCostFile();
    }
}
