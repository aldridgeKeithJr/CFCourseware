using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BugSleuth.Models
{
    public class TicketViewModel
    {
        public int ProjectId { get; set; }
        public string OwnerUserName { get; set; }
        public string AssignedTotUserName { get; set; }
        public string SortKey { get; set; }
    }
}