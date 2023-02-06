using DataLoader.Enums;

namespace DataLoader.Structs
{
    /// <summary>
    /// Struct for the filter to be applied to the IDataLoaderFilterCollection
    /// </summary>
    public struct FilterStruct
    {
        /// <summary>
        /// The appender, being And/Or for the current filter
        /// </summary>
        SqlFilterAppenders FilterAppender { get; set; }

        /// <summary>
        /// The field to filter with
        /// </summary>
        string FilterField { get; set; }

        /// <summary>
        /// The operator to use for the filter
        /// </summary>
        SqlFilters FilterOperator { get; set; }

        /// <summary>
        /// The value to filter with
        /// </summary>
        object FilterValue { get; set; }
    }
}
