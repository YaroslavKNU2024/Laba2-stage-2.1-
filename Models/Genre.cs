using System.ComponentModel.DataAnnotations;

namespace CinemaWebApp.Models
{
    public class Genre
    {
        public Genre()
        {
            Films = new List<Film>();
        }
        public int Id { get; set; }
        [Required(ErrorMessage="Поле має не бути порожнім")]
        [Display(Name ="Жанр")]
        public string GenreName { get; set; }
        public virtual ICollection<Film> Films { get; set; }
    }
}
