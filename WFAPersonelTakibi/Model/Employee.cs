using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFAPersonelTakibi.Model
{
    public class Employee
    {
        public Employee()

        {
            this.Id = new Guid();
        }
        public Guid Id { get; set; }
        [Required, MaxLength(25)]
        public string FirstName { get; set; }
        [Required, MaxLength(25)]
        public string LastName { get; set; }  
        public DateTime BirthDate { get; set; }
        public string EMail { get; set; }
        [Required]
        public Gender Gender { get; set; }
        [Required]
        public Department Department { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required, MaxLength(25)]
        public string Address { get; set; }
        public string ImageUrl { get; set; }

    }
}
