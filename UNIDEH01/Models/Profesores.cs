using System.ComponentModel.DataAnnotations;
namespace UNIDEH01.Models
{
	public class Profesores
	{
		public int Id { get; set; }

		[Display(Name = "Nombre")]
		[Required(ErrorMessage = "{0} requerido")]
		[RegularExpression(@"^[ \s{A-Z}{a-z}ñÑ]{4,50}$", ErrorMessage = "{0} incorrecto")]
		public string? nombre { get; set; }

		[Display(Name = "apellido")]
		[Required(ErrorMessage = "{0} requerido")]
		[RegularExpression(@"^[ \s{A-Z}{a-z}ñÑ]{4,50}$", ErrorMessage = "{0} incorrecto")]
		public string? apellido { get; set; }

		[Display(Name = "DNI")]
		[Required(ErrorMessage = "{0} requerido")]
		[RegularExpression(@"^[ \s{A-Z}{a-z}{0-9}]{4,50}$", ErrorMessage = "{0} incorrecto")]
		public string? dni { get; set; }

		[Display(Name = "Id Profesor")]
		public int Idprofesor { get; set; }

	}
}
