using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models
{
    internal class ChatParticipant
    {
        // Composite PK: ChatId + UserId
        public int ChatId { get; set; }
        public int UserId { get; set; }

        public Chat Chat { get; set; } = null!;
        public User User { get; set; } = null!;
    }
}
