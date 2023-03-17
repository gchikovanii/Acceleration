
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;
using Task_7.API.Models;
using Task_7.API.Task_7.Application;
using Task_7.API.Task_7.Domain;

namespace Booking.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MainController : ControllerBase
    {
        private readonly IMainService _mainService;

        public MainController(IMainService mainService)
        {
            _mainService = mainService;
        }

        [HttpGet("{studentName}")]
        public TeacherDto[] GetTeachers(string studentName)
        {
            var result = _mainService.GetAllTeachersByStudent(studentName);
            return result.Select(i => new TeacherDto
            {
                Id = i.Id,
                FirstName = i.FirstName,
                LastName = i.LastName,
                Gender = i.Gender,
                Subject = i.Subject
            }).ToArray();
        }
       
    }
}
