using InfaktGateway.Models.Costs;

namespace InfaktGateway.Services;

public interface IInfaktApiService
{
    public ICostDocReference AddCost(CostUploadDoc costDoc);

    public List<ICostDoc> GetCosts();
}
