using System;
using System.ComponentModel.DataAnnotations;

namespace Joe.Models
{
    public class Message : BaseEntity
    {
     [Key]
        public int? ID { get; set; }

        [Required]
        public string Name { get; set; }

        public string Email { get; set; }
        public string Note { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime UpdateAt { get; set; }

    }
}