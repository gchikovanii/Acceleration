using System.Threading.Tasks;
using Task_7.API.Task_7.Domain;

namespace Task_7.API.Task_7.Application
{
    public interface IMainService
    {
        Teacher[] GetAllTeachersByStudent(string studentName);
    }
}
