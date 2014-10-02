using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BugSleuth.Models
{
    public class ProjectUsersViewModel
    {
        public int ProjectId { get; set; }

        [Display(Name = "Project Name")]
        public string ProjectName { get; set; }

        [Display(Name = "Users")]
        public System.Web.Mvc.MultiSelectList Users { get; set; }

        public string[] SelectedUsers { get; set; }
    }
}