using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidSpace.Data.Models
{
    internal class DoctorFollow
    {
        [Key]
        public int FollowId { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

        public int FollowerDoctorId { get; set; }
        public Doctor FollowerDoctor { get; set; } = null!;

        public int FollowedDoctorId { get; set; }
        public Doctor FollowedDoctor { get; set; } = null!;
    }
}
