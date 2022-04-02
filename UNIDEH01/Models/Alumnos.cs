using System.ComponentModel.DataAnnotations;
namespace UNIDEH01.Models
{
	public class Alumnos
	{
		public int Id { get; set; }

		[Display(Name = "Nombre")]
		[Required(ErrorMessage = "{0} requerido")]
		[RegularExpression(@"^[ \s{A-Z}{a-z}ñÑ]{4,50}$", ErrorMessage = "{0} incorrecto")]
		public string? nombres { get; set; }

		[Display(Name = "Apellidos")]
		[Required(ErrorMessage = "{0} requerido")]
		[RegularExpression(@"^[ \s{A-Z}{a-z}ñÑ]{4,50}$", ErrorMessage = "{0} incorrecto")]
		public string? apellidos { get; set; }

		[Display(Name = "Fecha de nacimiento")]
		[DataType(DataType.Date)]
		public DateTime fecha_de_nacimiento { get; set; }

		[Display(Name = "Grado")]
		[Required(ErrorMessage = "{0} requerido")]
		public int grado { get; set; }

		[Display(Name = "Sección")]
		[RegularExpression(@"^[ \s{A-Z}{a-z}{0-9}ñÑó]{4,50}$", ErrorMessage = "{0} incorrecto")]
		[Required(ErrorMessage = "{0} requerido")]
		public string? seccion { get; set; }

		[Display(Name = "Dirección")]
		[RegularExpression(@"^[ \s{A-Z}{a-z}{0-9}ñÑó#.-]{4,50}$", ErrorMessage = "{0} incorrecto")]
		[Required(ErrorMessage = "{0} requerido")]
		public string? direccion { get; set; }

		[Display(Name = "Telefono")]
		[Required(ErrorMessage = "{0} requerido")]
		[RegularExpression(@"^[ \s{0-9}]{10}$", ErrorMessage = "{0} incorrecto")]
		public string? telefono { get; set; }

		[Display(Name = "Correo electronico")]
		[Required(ErrorMessage = "{0} requerido")]
		[RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "{0} incorrecto")]
		public string? correo { get; set; }

		[Display(Name = "Contraseña")]
		[Required(ErrorMessage = "{0} requerido")]
		public string? pass { get; set; }
	}
}
