namespace InfaktGateway.API
{
    public class ApiResponse<T>
    {
        public required List<T> Entities { get; set; }
    }
}
