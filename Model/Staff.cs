using System;
using System.ComponentModel.DataAnnotations;

namespace HappyPaws.Model
{
    public class Staff
    {
        public string FullName { get; set; }

        [StringLength(10)]
        public string PhoneNumber { get; set; }

        [Required]
        public string EmailAddress { get; set; }
        public string Question { get; set; }

    }
}
