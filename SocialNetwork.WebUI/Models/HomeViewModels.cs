using System.ComponentModel.DataAnnotations;

namespace SocialNetwork.WebUI.Models
{
    public class ProfileViewModel
    {
        [Required]
        public string PostContent  { get; set; }
       
        public int PostAuthorId { get; set; }
    }

    
}