using System.ComponentModel.DataAnnotations;
namespace UNIDEH01.Models
{
	public class Cursos
	{
		public int Id { get; set; }

		[Display(Name = "Nombre del curso")]
		[Required(ErrorMessage = "{0} requerido")]
		[RegularExpression(@"^[ \s{A-Z}{a-z}ñÑ]{4,50}$", ErrorMessage = "{0} incorrecto")]
		public string? nombre_curso { get; set; }

		[Display(Name = "Id Profesor")]
		public int Idprofesor { get; set; }

	}
}
