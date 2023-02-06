using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLoader.Interfaces
{
    /// <summary>
    /// Interface for the Attributes on the IDataLoaderModel properties.
    /// </summary>
    public interface IAttribute
    {
        /// <summary>
        /// Indicates the size of a Varchar field
        /// </summary>
        int StringSize { get; set; }

        /// <summary>
        /// Indicates the integer size of a decimal field
        /// </summary>
        int DecimalIntegerSize { get; set; }

        /// <summary>
        /// Indicates the fractional size of a decimal field
        /// </summary>
        int DecimalFractionalSize { get; set; }
    }
}
