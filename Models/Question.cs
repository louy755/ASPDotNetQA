using System;
using System.ComponentModel.DataAnnotations;

namespace ASPDotNET.Models
{
    public class Question
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Qtn { get; set; }
        [Required]
        public string Amswer { get; set; }
        [Required]
        public string Category { get; set; }
    }
}
