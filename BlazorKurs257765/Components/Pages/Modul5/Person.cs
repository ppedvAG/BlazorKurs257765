using System.ComponentModel.DataAnnotations;

namespace BlazorKurs257765.Components.Pages.Modul5
{
    public class Person
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="da muss was rein")]
        [StringLength(10, MinimumLength =2,ErrorMessage ="zwischen 2 und 10 Zeoichen")]
        public string FirstName { get; set; } = string.Empty;
        [Required(ErrorMessage = "da muss was rein")]
        [Range(100, 250, ErrorMessage ="zwischen 100 und 250")]
        public int Gross { get; set; }
        [Required(ErrorMessage = "da muss was rein")]
             public DateTime GebDat { get; set; }
    }
}
