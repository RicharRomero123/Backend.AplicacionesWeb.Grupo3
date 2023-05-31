using System.ComponentModel.DataAnnotations;

namespace LearningCenter.API.Request
{
    public class EmployeeRequest
    {
        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        public string Name { get; set; }
    }
}
