using System;
using System.ComponentModel.DataAnnotations;

namespace SES.Data.Models
{
    public class DemandRequest
    {
        [Key]
        public int Id { get; set; }
        public DateTime Date { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Status { get; set; }
    }
}
