using System.ComponentModel.DataAnnotations;

namespace CinemaWebApp.Models
{
    public class Cinema
    {
        public Cinema() {
            Seance = new HashSet<Seance>();
        }

        public int Id { get; set; }
        [Required(ErrorMessage = "Поле необхідно заповнити")]
        [Display(Name = "Організатор")]
        public string CinemaName { get; set; }

        [Required(ErrorMessage = "Поле необхідно заповнити")]
        [Display(Name = "Email")]
        public string Contacts { get; set; }
        public int CountryId { get; set; }

        public virtual Country Country { get; set; }

        public virtual ICollection<Seance> Seance { get; set; }
    }
}
