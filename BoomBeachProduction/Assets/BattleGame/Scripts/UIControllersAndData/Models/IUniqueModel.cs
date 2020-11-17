namespace Assets.Scripts.UIControllersAndData.Models
{
	/// <inheritdoc />
	/// <summary>
	/// Interface for model with unique identifier.
	/// </summary>
	public interface IUniqueModel<TData> : IModel<TData>
	{
		/// <summary>
		///     Unique identifier of this object
		/// </summary>
		string UniqueIdentifier{get; set;}
	}
}