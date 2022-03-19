using System.ComponentModel.DataAnnotations;
namespace UNIDEH01.Models
{
	public class Alumnos
	{
		public int Id { get; set; }

		public string? nombres { get; set; }

		public string? apellidos { get; set; }

		[Display(Name = "Release Date")]
		[DataType(DataType.Date)]
		public DateTime fecha_de_nacimiento { get; set; }

		public int grado { get; set; }

		public string? seccion { get; set; }

		public string? direccion { get; set; }

		public string? telefono { get; set; }

		[DataType(DataType.EmailAddress)]
		public string? correo { get; set; }

		public string? pass { get; set; }
	}
}
