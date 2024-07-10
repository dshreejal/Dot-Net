
using Microsoft.EntityFrameworkCore;

namespace EntityFrameWorkCore.Models
{
    public class StudentContext: DbContext
    {

        public StudentContext(DbContextOptions<StudentContext> options) : base(options) { }
        public DbSet<StudentModel> Students { get; set; }
        
    }
}
