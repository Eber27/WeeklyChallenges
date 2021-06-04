
namespace ChallengesWithTestsMark8
{
    public class Business
    {
        public static int Length { get; internal set; }
        public string Name { get; set; }
        public double TotalRevenue { get; set; }
        public double TotalExpenses { get; set; }
        public Business ParentCompany { get; set; }
    }
}
