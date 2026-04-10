using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models
{
    internal class Chat
    {
        [Key]
        public int ChatId { get; set; }

        public string ChatType { get; set; } = string.Empty; // e.g. "Private", "Group"

        public string Status { get; set; } = string.Empty; // e.g. "Active", "Archived"

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public ICollection<ChatParticipant> Participants { get; set; } = new HashSet<ChatParticipant>();
        public ICollection<Message> Messages { get; set; } = new HashSet<Message>();
    }
}
