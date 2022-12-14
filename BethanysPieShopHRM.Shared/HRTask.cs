using System.ComponentModel.DataAnnotations;

namespace BethanysPieShopHRM.Shared
{
    public class HRTask
    {
        public int HRTaskId { get; set; }

        [Required]
        public string Title { get; set; }
        
        [Required]
        public string Description { get; set; }
        
        public int AssignedTo { get; set; }

        public HRTaskStatus Status { get; set; }

    }

    public enum HRTaskStatus
    {
        Open,
        Assigned,
        InProgress,
        Blocked,
        Complete
    }
}
