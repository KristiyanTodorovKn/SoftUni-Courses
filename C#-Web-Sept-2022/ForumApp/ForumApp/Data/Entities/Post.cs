using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;
using static ForumApp.Data.DataConstants.Post;

namespace ForumApp.Data.Entities
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLenght)]
        public string Title { get; set; }

        [Required]
        [MaxLength(ContentMaxLenght)]
        public string Content { get; set; }

        [Required]
        public bool isDeleted { get; set; } = false;
    }
}
