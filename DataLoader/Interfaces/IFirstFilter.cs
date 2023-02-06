using DataLoader.Structs;

namespace DataLoader.Interfaces
{
    /// <summary>
    /// Interface for first filter called on the joiners or data loader methods.
    /// </summary>
    public interface IFirstFilter
    {
        /// <summary>
        /// Adds a filter to the Filters Collection
        /// </summary>
        /// <param name="filter">The FilterStruct to append to the Filters</param>
        /// <returns>IFilterCollection</returns>
        IFilter Filter(FirstFilterStruct filter);
    }
}
