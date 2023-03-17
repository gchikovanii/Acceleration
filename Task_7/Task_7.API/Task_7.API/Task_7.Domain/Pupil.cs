using System.Collections.Generic;

namespace Task_7.API.Task_7.Domain
{
    public class Pupil : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Class { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
