using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Practical_Manit.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required(ErrorMessage ="Name Is Required")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Display Order Is Required")]
        public int DisplayOrder { get; set; }
    }
}