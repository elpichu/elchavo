using System;
using System.ComponentModel.DataAnnotations;

namespace Tienda.Models
{
    public class Categoria
    {
        public Categoria()
        {
        }


        [Required(ErrorMessage = "ID Categoría es requerido")]
        public int CategoriaID { get; set; }


        [Required(ErrorMessage = "Nombre es requerido")]
        [StringLength(50, ErrorMessage = " No exceder 50 caracteres")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Fecha es requerida")]
        public DateTime Fecha { get; set; }

    }
}
