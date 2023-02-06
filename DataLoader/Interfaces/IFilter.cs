using DataLoader.Structs;
using DataLoader.Enums;

namespace DataLoader.Interfaces
{
    /// <summary>
    /// Interface of filters to be applied to the data access
    /// </summary>
    public interface IFilter
    {
        /// <summary>
        /// Adds a filter to the Filters Collection
        /// </summary>
        /// <param name="filter">The FilterStruct to append to the Filters</param>
        IFilter Filter(FilterStruct filter);

        /// <summary>
        /// Retrieves the filters initialized as a SQL query filter string
        /// </summary>
        /// <returns>String</returns>
        string GetFilterString();

        /// <summary>
        /// Retrieves the filters initialized as a collection of DataModelLoaderFitlers
        /// </summary>
        /// <returns>IEnumerable of FilterStructs</returns>
        IEnumerable<FilterStruct> GetFilters();

        /// <summary>
        /// Clears the filters loaded into the collection
        /// </summary>
        /// <returns>Boolean</returns>
        bool ClearFilters();

        /// <summary>
        /// Deletes filters for the collection based on a fieldName
        /// </summary>
        /// <param name="fieldName">The field name to remove from the filters collection</param>
        /// <returns>Boolean</returns>
        bool DeleteFilters(string fieldName);

        /// <summary>
        /// Deletes all items from the collection that use the specified appender
        /// </summary>
        /// <param name="appenders">The enum value to remove from the collection</param>
        /// <returns>Boolean</returns>
        bool DeleteFilters(SqlFilterAppenders appenders);

        /// <summary>
        /// Deletes the first record in the collection
        /// </summary>
        /// <returns>Boolean</returns>
        bool DeleteFirst();
    }
}