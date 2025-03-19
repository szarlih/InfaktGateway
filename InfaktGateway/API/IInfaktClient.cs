using InfaktGateway.Models.Costs;
using Refit;

namespace InfaktGateway.API;

public interface IInfaktClient
{
    [Post("/documents/costs/upload.json")]
    public ApiResponse<ICostDocReference> AddCostFile();

    [Get("/documents/costs.json")]
    public ApiResponse<ICostDoc> GetCostFiles(
        [Query("kind_in")] string kindIn = null,
        [Query("created_at_gteq")] string createdAtGteq = null,
        [Query("created_at_lteq")] string createdAtLteq = null,
        [Query("issue_date_gteq")] string issueDateGteq = null,
        [Query("issue_date_lteq")] string issueDateLteq = null,
        [Query("due_date_gteq")] string dueDateGteq = null,
        [Query("due_date_lteq")] string dueDateLteq = null,
        [Query("net_in_cents_gteq")] int? netInCentsGteq = null,
        [Query("net_in_cents_lteq")] int? netInCentsLteq = null,
        [Query("gross_in_cents_gteq")] int? grossInCentsGteq = null,
        [Query("gross_in_cents_lteq")] int? grossInCentsLteq = null,
        [Query("currency_in[]")] string[] currencyIn = null
        );
}
