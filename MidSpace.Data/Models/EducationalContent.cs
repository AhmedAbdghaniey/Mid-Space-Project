using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models
{
    internal class EducationalContent
    {
        [Key]
        public int ContentId { get; set; }

        public string Title { get; set; } = string.Empty;

        public string? Description { get; set; }

        public string Category { get; set; } = string.Empty;

        public string ContentType { get; set; } = string.Empty; // e.g. "Article", "Video", "PDF"

        public string? ResourceURL { get; set; }

        public string? ThumbnailURL { get; set; }

        public string Status { get; set; } = string.Empty; // e.g. "Published", "Draft"

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int DoctorId { get; set; }
        public Doctor Doctor { get; set; } = null!;
    }
}
