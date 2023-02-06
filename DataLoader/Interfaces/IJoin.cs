using DataLoader.Structs;

namespace DataLoader.Interfaces
{
    /// <summary>
    /// Interface for Joining queries to be applied to the data loader
    /// </summary>
    public interface IJoin
    {
        /// <summary>
        /// Adds a join to the query using information obtained from the GetForeignKeys method of models
        /// </summary>
        /// <param name="joiningKey">A KeyStruct returned from the GetForeignKeys method of IModel objects</param>
        /// <returns>IJoin</returns>
        IJoin Join(KeyStruct joiningKey);

        /// <summary>
        /// Adds a filter to the query, after which no further joins may occur
        /// </summary>
        /// <param name="filter"></param>
        /// <returns>IFilter</returns>
        IFilter Filter(FilterStruct filter);
    }
}
