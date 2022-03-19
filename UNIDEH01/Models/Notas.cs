using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UNIDEH01.Models
{
	public class Notas
	{
		public int Id { get; set; }

		public int idalumnos { get; set; }

		public int idcurso { get; set; }

		public string? unidad { get; set; }

		[Column(TypeName = "decimal(2, 2)")]
		public decimal promedio { get; set; }
	}

}
