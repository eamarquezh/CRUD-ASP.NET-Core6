using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UNIDEH01.Models
{
	public class Notas
	{
		public int Id { get; set; }

		[Display(Name = "Id alumno")]
		public int idalumnos { get; set; }

		[Display(Name = "Id Curso")]
		public int idcurso { get; set; }

		[Display(Name = "Sección")]
		[RegularExpression(@"^[ \s{A-Z}{a-z}{0-9}ñÑó]{4,50}$", ErrorMessage = "{0} incorrecto")]
		[Required(ErrorMessage = "{0} requerido")]
		public string? unidad { get; set; }

		[Display(Name = "Promedio")]
		public int promedio { get; set; }
	}

}
