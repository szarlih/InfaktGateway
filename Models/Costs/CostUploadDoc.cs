namespace InfaktGateway.Models.Costs
{
    public class CostUploadDoc
    {
        /// <summary>
        /// Base64 encoded file content
        /// </summary>
        public required string Content { get; set; }
        public required string FileName { get; set; }
        public required ContentType ContentType { get; set; }
    }
}
