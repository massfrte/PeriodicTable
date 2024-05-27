namespace PeriodicTable.Application.Exceptions
{
	public class ElementNotFoundException : Exception
	{
		public ElementNotFoundException(Guid id) : base($"Chemical element with id '{id}' is not found.")
		{ }
    }
}
