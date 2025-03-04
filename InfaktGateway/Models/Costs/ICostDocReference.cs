namespace InfaktGateway.Models.Costs;

public interface ICostDocReference
{
    public string Uuid { get; set; }
    public string DocumentUrl { get; set; }
    public string Name { get; set; }
    public bool Success { get; set; }
}
