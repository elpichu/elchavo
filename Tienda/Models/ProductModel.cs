using System;
using System.ComponentModel.DataAnnotations;


namespace Tienda.Models
{
    public class Product
    {
        public Product()
        {
        }



        public int ProductID { get; set;  }


        [Required(ErrorMessage = "Favor de escribir un nombre")]
        [StringLength (50, ErrorMessage = " No exceder 50 caracteres")]
        public string Nombre { get; set; }

        [StringLength(500, ErrorMessage = "La descripción no debe exceder 500 caracteres.")]
        public string Desc { get; set; }


        public DateTime Fecha { get; set; }

        public Categoria Categoria { get; set; }

    }
}
    