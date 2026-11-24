using MVCDemo02.Entities.Enums;

namespace MVCDemo02.Entities
{
    public class Trainer :GymUser
    {
       
        public DateTime HireDate { get; set; }
        public Specialties Specialties { get; set; }

        //Relationships
        public ICollection<Session> Sessions = default!;

    }
}
