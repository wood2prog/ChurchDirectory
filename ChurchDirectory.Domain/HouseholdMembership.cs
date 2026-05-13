namespace ChurchDirectory.Domain
{
    public class HouseholdMembership
    {
        public int Id { get; set; }
        public int PersonId { get; set; }
        public required Person Person { get; set; }

        public int HouseholdId { get; set; }
        public required Household Household { get; set; }

        public int HouseholdRoleId { get; set; }
        public required HouseholdRole HouseholdRole { get; set; }

        public string? Notes { get; set; }

    }
}
