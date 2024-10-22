using System.ComponentModel.DataAnnotations;

namespace ParcialDos.Models
{
    public class Producto
    {
        [Required(ErrorMessage = "El número de inventario es obligatorio")]
        [Range(1, int.MaxValue, ErrorMessage = "El número de inventario debe ser mayor a 0")]
        public int? NumeroInventario { get; set; }

        [Required(ErrorMessage = "El nombre no debe ser vacío")]
        [StringLength(200, ErrorMessage = "El nombre no puede superar los 200 caracteres")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Debe seleccionar un departamento")]
        [RegularExpression("Frutas|Verduras|Lácteos", ErrorMessage = "El departamento debe ser Frutas, Verduras o Lácteos")]
        public string? Departamento { get; set; }
    }
}