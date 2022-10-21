namespace RecruitmentTask.Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public decimal Price { get; set; }

        public Directory Directory { get; set; }
        public int DirectoryId { get; set; }
    }
}
