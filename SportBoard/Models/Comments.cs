using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SportBoard.Models
{
    public class Comment
    {
        [Key]
        public int CommentId { get; set; }

        [Required]
        public string Content { get; set; }

        public DateTime DatePosted { get; set; }

        // Foreign Key to News
        public int NewsId { get; set; }

        [ForeignKey("NewsId")]
        public virtual News News { get; set; }

        // Foreign Key to ApplicationUser
        public string UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual ApplicationUser User { get; set; }

        public DateTime CommentDate { get; set; }
    }
}
