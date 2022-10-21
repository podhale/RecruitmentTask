using Microsoft.EntityFrameworkCore;
using RecruitmentTask.Core.Entities;
using System.Threading;
using System.Threading.Tasks;

namespace RecruitmentTask.Core.Interfaces
{
    public interface ISimpleApiContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<Directory> Directories { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
