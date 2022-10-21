namespace RecruitmentTask.Core.Dtos
{
    public class ProductDto
    {
        public string Name { get; set; } = string.Empty;
        public string Code { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int DirectoryId { get; set; }

    }
}
