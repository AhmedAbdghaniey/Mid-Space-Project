using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models
{
    internal class Comment
    {
        [Key]
        public int CommentId { get; set; }

        public string Content { get; set; } = string.Empty;

        public string Status { get; set; } = string.Empty; // e.g. "Visible", "Hidden"

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int PostId { get; set; }
        public Post Post { get; set; } = null!;

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; } = null!;
    }
}
