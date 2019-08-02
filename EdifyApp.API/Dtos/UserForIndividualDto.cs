using System;

namespace EdifyApp.API.Dtos
{
    public class UserForIndividualDto
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Department { get; set; }
        public int NumberOfDays { get; set; }
        public DateTime LeaveCommencingDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public string TakeoverEmployee { get; set; }
        public string CurrentOutstandingDuties { get; set; }
        public string StatusOfCurrentOutstandingDuties { get; set; }
        public string FillInEmployeeReportsTo { get; set; }
        public int RemainingLeaveDays { get; set; }
        public string LeaveReason { get; set; }
    }
}