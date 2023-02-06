using DataLoader.Enums;

namespace DataLoader.Structs
{
    /// <summary>
    /// Struct for the first filter applied to a data operation
    /// </summary>
    public struct FirstFilterStruct
    {
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
