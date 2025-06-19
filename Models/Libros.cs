
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;

namespace T3_PILCO_JOSE.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Debe ingresar el título del libro")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "Debe ingresar el nombre del autor")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "Debe especificar el tema del libro")]
        public string Tema { get; set; }

        [Required(ErrorMessage = "Debe ingresar la editorial del libro")]
        public string Editorial { get; set; }

        [Required(ErrorMessage = "Debe ingresar el año de publicación")]
        [Range(1900, 3000, ErrorMessage = "El año debe estar entre 1900 y 3000")]
        public int AnioPublicacion { get; set; }

        [Required(ErrorMessage = "Debe ingresar la cantidad de páginas")]
        [Range(10, 1000, ErrorMessage = "El número de páginas debe estar entre 10 y 1000")]
        public int Paginas { get; set; }

        [Required(ErrorMessage = "Debe ingresar la categoría del libro")]
        public string Categoria { get; set; }

        [Required(ErrorMessage = "Debe indicar el material del libro")]
        public string Material { get; set; }

        [Required(ErrorMessage = "Debe ingresar la cantidad de copias")]
        [Range(1, 20, ErrorMessage = "La cantidad de copias debe estar entre 1 y 20")]
        public int Copias { get; set; }
    }
}
