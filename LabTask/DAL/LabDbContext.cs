using Microsoft.EntityFrameworkCore;

namespace LabTask.DAL
{
    public class LabDbContext: DbContext
    {
        public LabDbContext(DbContextOptions<LabDbContext>opt):base(opt)
        {
                
        }

    }
}
