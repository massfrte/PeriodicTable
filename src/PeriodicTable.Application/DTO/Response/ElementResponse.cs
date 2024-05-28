namespace PeriodicTable.Application.DTO.Response
{
	public class ElementResponse
	{
		public Guid Id { get; set; }

		public string Symbol { get; set; }

		public string Name { get; set; }

		public string Group { get; set; }

		public string StandartState { get; set; }

		public int AtomicNumber { get; set; }

		public float Electronegativity { get; set; }

		public float MeltingPointInK { get; set; }

		public float BoilingPointInK { get; set; }

		public short YearDiscovered { get; set; }
	}
}
