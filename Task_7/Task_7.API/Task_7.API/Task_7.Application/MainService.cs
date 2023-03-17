using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Task_7.API.Task_7.Domain;
using Task_7.API.Task_7.Infrastructure.DataContext;

namespace Task_7.API.Task_7.Application
{
    public class MainService : IMainService
    {
        private readonly ApplicationDbContext _context;

        public MainService(ApplicationDbContext context)
        {
            _context = context;
        }

        public Teacher[] GetAllTeachersByStudent(string studentName)
        {
            var result = _context.Set<Teacher>().Include(i => i.Pupils).Where(i => i.Pupils.Any(i => i.FirstName == studentName)).ToArray();
            return result;
        }
    }
}
