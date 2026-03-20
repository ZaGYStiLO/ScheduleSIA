using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ScheduleSIA.models
{
    [Table("weekday")]
    public class Weekday
    {
        [Key]
        [Column("weekday_id")]
        public int WeekdayId { get; set; }

        [Column("name")]
        [Required]
        public string Name { get; set; } = null!;
    }
}
