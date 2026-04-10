using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models
{
    internal class Post
    {
        [Key]
        public int PostId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public string Visibility { get; set; } = string.Empty; // e.g. "Public", "Followers"

        public string Status { get; set; } = string.Empty; // e.g. "Published", "Draft"

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; } = null!;

        public ICollection<Comment> Comments { get; set; } = new HashSet<Comment>();
    }
}
