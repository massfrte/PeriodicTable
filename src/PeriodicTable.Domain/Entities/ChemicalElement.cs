using System.ComponentModel.DataAnnotations;

namespace PeriodicTable.Domain.Entities
{
	public class ChemicalElement
	{
		[Key]
		public Guid Id { get; set; }

		[StringLength(10)]
		public string Symbol { get; set; }

		[StringLength(30)]
		public string Name { get; set; }

		[StringLength(50)]
		public string Group { get; set; }

		[StringLength(30)]
		public string StandartState { get; set; }

		public int AtomicNumber { get; set; }

		public float Electronegativity { get; set; }

		public float MeltingPointInK { get; set; }

		public float BoilingPointInk { get; set; }

		public short YearDiscovered { get; set; }
	}
}
