namespace EdifyApp.API.Dtos
{
    public class UserForListDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Department { get; set; }
        public int RemainingLeaveDays { get; set; }
    }
}