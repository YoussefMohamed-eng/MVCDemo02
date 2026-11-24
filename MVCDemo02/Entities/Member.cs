namespace MVCDemo02.Entities
{
    public class Member :GymUser
    {
        public string? Photo { get; set; }
        //Relationships
        public ICollection<Membership> MemberSubscriptions { get; set; } = default!;

    }
}
