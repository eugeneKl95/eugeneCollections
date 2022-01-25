using System.ComponentModel.DataAnnotations;

namespace eugeneCollections.Models
{
    public class AddCollectionViewModel
    {
        //[Required]
        //[Display(Name ="Тема коллекции")]
        //public string ThemeCollection { get; set; }
        [Required]
        [Display(Name = "Название коллекции")]
        public string NameCollection { get; set; }
        [Required]
        [Display(Name = "Описание коллекции")]
        public string DescriptionCollection { get; set; }
        [Required]
        [Display(Name = "URL картинки")]
        public string PathImg { get; set; }
        public string UserName { get; set; }
        public int ThemeId { get; set; }
    }
}
