﻿namespace EFCoreRelationshipss
{
	public class Product
	{
		internal readonly object Size;

		public int Id { get; set; }

		public string? Name { get; set; }

		public double Price { get; set; }

		public Category Category { get; set; }

		public int CategoryId { get; set; }
		public List<Color> Colors { get; set; }
	}
}
