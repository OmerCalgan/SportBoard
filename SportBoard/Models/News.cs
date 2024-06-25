using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportBoard.Models
{
    public class News
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime PublishDate { get; set; }

        // Navigation property for related comments
        public virtual ICollection<Comment> Comments { get; set; }
        public int NewsId { get; internal set; }

        public News()
        {
            Comments = new HashSet<Comment>();
        }
    }
}
