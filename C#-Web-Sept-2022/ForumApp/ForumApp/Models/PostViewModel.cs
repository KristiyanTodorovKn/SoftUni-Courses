using System.ComponentModel.DataAnnotations;

namespace ForumApp.Models
{
    public class PostViewModel : AddPostViewModel
    {
        [UIHint("hidden")]
        
        public int Id { get; set; }

      
    }
}
