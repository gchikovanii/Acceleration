using System.Collections.Generic;

namespace Task_7.API.Task_7.Domain
{
    public class Teacher : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public string Subject { get; set; }
        public List<Pupil> Pupils { get; set; }
    }
}
