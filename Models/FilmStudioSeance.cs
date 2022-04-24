using System.ComponentModel.DataAnnotations.Schema;

namespace CinemaWebApp.Models
{
    public class FilmStudioSeance
    {
        public class FilmStudioSeanceі
        {
            public int Id { get; set; }
            public int? FilmId { get; set; }
            public int? StudioId { get; set; }
            public int? SeanceId { get; set; }

            [ForeignKey("FilmId")]
            public virtual Film Film { get; set; }

            [ForeignKey("StudioId")]
            public virtual Studio Studio { get; set; }

            [ForeignKey("SeanceId")]
            public virtual Seance Seance { get; set; }
        }
    }
}
