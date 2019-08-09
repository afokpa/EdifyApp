namespace EdifyApp.API.Dtos
{
    public class UserForUpdateDto
    {
        public string CurrentOutstandingDuties { get; set; }
        public string LeaveReason { get; set; }
        public string NumberOfDays { get; set; }
        public string StatusOfCurrentOutstandingDuties { get; set; }
        public string TakeoverEmployee { get; set; }
        public string LeaveCommencingDate { get; set; }
        public string ReturnDate { get; set; }
        public string FillInEmployeeReportsTo { get; set; }

    }
}