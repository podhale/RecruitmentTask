using System.Collections.Generic;

namespace RecruitmentTask.Core.Entities
{
    public class Directory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IEnumerable<Product> Products { get; set; }
    }
}
