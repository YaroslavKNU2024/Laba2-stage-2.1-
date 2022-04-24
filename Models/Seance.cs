using System.ComponentModel.DataAnnotations;

namespace CinemaWebApp.Models
{       
    public class Seance
    {
        private const string ERR= "Поле необхідно заповнити";

        public Seance() {
            FilmStudioSeance = new HashSet<FilmStudioSeance>();
        }

        public int Id { get; set; }

        [Required(ErrorMessage = ERR)]
        [Display(Name = "Назва")]
        public string Name { get; set; }
        [Required(ErrorMessage = ERR)]
        [Display(Name = "Ціна")]
        public decimal TicketPrice { get; set; }
        [Required(ErrorMessage = ERR)]
        [Display(Name = "Час")]
        public DateTime Time { get; set; }
        [Required(ErrorMessage = ERR)]
        [Display(Name = "Залишилось місць")]
        public int SeatsLeft { get; set; }
        public int CinemaId { get; set; }

        public virtual Cinema Cinema { get; set; }

        public virtual ICollection<FilmStudioSeance> FilmStudioSeance { get; set; }
        
    }
}
