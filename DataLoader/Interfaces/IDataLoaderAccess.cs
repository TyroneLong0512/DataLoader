using System.Data;

namespace DataLoader.Interfaces
{
    /// <summary>
    /// Interface for db interactions through IDataLoader implementations
    /// </summary>
    public interface IDataLoaderAccess
    {
        /// <summary>
        /// Runs a query that returns a results table
        /// </summary>
        /// <param name="query">The query to run</param>
        /// <returns>DataTable</returns>
        DataTable RunQuery(string query);

        /// <summary>
        /// Runs a query that returns no data
        /// </summary>
        /// <param name="query">The query to run</param>
        /// <returns>Boolean</returns>
        bool RunNoDataQuery(string query);
    }
}
