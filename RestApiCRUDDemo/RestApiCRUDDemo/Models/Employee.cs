using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiCRUDDemo.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage ="Max length of Name should be 50")]
        public string Name { get; set; }
    }
}
