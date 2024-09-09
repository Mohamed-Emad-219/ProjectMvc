using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDataAccessLayer.DAL.Models
{
    public class Department
    {
        public int Id { get; set; } // PK identity (1,1)
        [Required(ErrorMessage ="Name is Required !")]
        public string  Name { get; set; }// .NET 5 allow null
        [Required(ErrorMessage ="Code is Required !")]
        public string Code { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
