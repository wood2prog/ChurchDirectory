namespace ChurchDirectory.Domain
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string? PreferredName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Gender { get; set; } = string.Empty;
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public bool IsActive { get; set; }
        public string? Notes { get; set; }

        public List<HouseholdMembership> HouseholdMemberships { get; set; } = new();
    }
}
