using System.ComponentModel.DataAnnotations;

namespace NotesApi.Models
{
    public class Note
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Title { get; set; } 

        [Required]
        public string Slug { get; set; }
    }
}
