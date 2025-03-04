using InfaktGateway.API;
using InfaktGateway.Models.Costs;

namespace InfaktGateway.Services;

public class InfaktApiService : IInfaktApiService
{
    private readonly IInfaktClient _infaktClient;

    public InfaktApiService(IInfaktClient infaktClient)
    {
        _infaktClient = infaktClient;
    }

    public ICostDocReference? AddCost(CostUploadDoc costDoc)
    {
        var costFileResponse = _infaktClient.AddCostFile();

        return costFileResponse.Entities.FirstOrDefault();
    }
}
