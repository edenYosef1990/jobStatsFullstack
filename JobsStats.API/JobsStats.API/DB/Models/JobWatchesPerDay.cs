using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobsStats.API.DB.Models
{
    public class JobWatchesPerDay
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity),Key()]
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int JobId { get; set; }
        public int NumberOfWatches { get; set; }
    }
}
