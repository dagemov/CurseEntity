using RunningClubs.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RunningClubs.Models
{
    public class Race
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        [ForeignKey("Address")]
        public int AdressId { get; set; }
        public RacesCategory RacesCategory { get; set; }
        public ClubCategory ClubCategory { get; set; }
        [ForeignKey("AppUserId")]
        public string? AppUserId { get; set; }
        public AppUser AppUser { get; set; }
    }
}
