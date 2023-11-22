using System.ComponentModel.DataAnnotations;

namespace ApiRestBilling.Models
{
    public class Supplier
    {
        [Key]
       public int Id { get; set; }
        [Required]
        [MaxLength(128)]
        public string CompanyName { get; set; }
        [MaxLength(64)]
        public string ContactName { get; set; }
        [MaxLength(64)]
        public string ContactTitle { get; set; }
        [MaxLength(64)]
        public string  City { get; set; }
        [MaxLength(64)]
        public string  Country { get; set; }
        [MaxLength(16)]
        public string Phone { get; set; }
        [EmailAddress(ErrorMessage ="El valor introducido no es una direccion de correo electronico valida.")]
        
        public string Email { get; set; }
        public ICollection<Product>? Products { get; set; }



        








    }
}
