using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models
{
    internal class Notification
    {
        [Key]
        public int NotificationId { get; set; }

        public string Type { get; set; } = string.Empty; // e.g. "Appointment", "Message", "Follow"

        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public string? ReferenceType { get; set; } // e.g. "Appointment", "Post"

        public int? ReferenceId { get; set; }

        public string Priority { get; set; } = string.Empty; // e.g. "High", "Normal", "Low"

        public string DeliveryChannel { get; set; } = string.Empty; // e.g. "Push", "Email", "SMS"

        public bool IsRead { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
