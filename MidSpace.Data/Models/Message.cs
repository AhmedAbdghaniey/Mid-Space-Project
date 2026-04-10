using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models
{
    internal class Message
    {
        [Key]
        public int MessageId { get; set; }

        public string? Content { get; set; }

        public string MessageType { get; set; } = string.Empty; // e.g. "Text", "Image", "File"

        public string? AttachmentURL { get; set; }

        public bool IsSeen { get; set; }

        public bool DeliveredAt { get; set; }

        public DateTime SentAt { get; set; } = DateTime.UtcNow;

        public int ChatId { get; set; }
        public Chat Chat { get; set; } = null!;

        public int SenderUserId { get; set; }
        public User Sender { get; set; } = null!;
    }
}
