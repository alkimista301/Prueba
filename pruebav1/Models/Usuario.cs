using System.ComponentModel.DataAnnotations;

namespace pruebav1.Models
{
    public class Usuario
    {

        public string Id { get; set; }

        [Required(ErrorMessage ="es obligatorio agregar tu nombre")]
        [StringLength(100,ErrorMessage ="solo ingresar 100 caracteres")]
        public string Name { get; set; }

        public decimal Price { get; set; }  

        public string Description { get; set; }

    }
}
