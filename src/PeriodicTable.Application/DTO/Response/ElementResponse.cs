﻿using System.ComponentModel.DataAnnotations;

namespace PeriodicTable.Application.DTO.Response
{
	public class ElementResponse
	{
		public Guid Id { get; set; }

		[Required]
		[StringLength(10)]
		public string Symbol { get; set; }

		[Required]
		[StringLength(30)]
		public string Name { get; set; }

		[Required]
		[StringLength(50)]
		public string Group { get; set; }

		[Required]
		[StringLength(30)]
		public string StandartState { get; set; }

		[Required]
		[Range(1, int.MaxValue)]
		public int AtomicNumber { get; set; }

		[Range(0, float.MaxValue)]
		public float? Electronegativity { get; set; }

		[Required]
		public float MeltingPointInK { get; set; }

		[Required]
		public float BoilingPointInK { get; set; }

		[Range(0, 2024)]
		public short? YearDiscovered { get; set; }
	}
}
