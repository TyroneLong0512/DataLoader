using DataLoader.Interfaces;
using System.Drawing;

namespace DataLoader.Attributes
{
    /// <summary>
    /// Attribute for IDataLoaderModel object models
    /// </summary>
    public class ColumnAttribute : Attribute, IAttribute
    {
        #region Properties
        public int StringSize { get; set; }

        public int DecimalIntegerSize { get; set; }

        public int DecimalFractionalSize { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Sets the StringSize of a varchar field
        /// </summary>
        /// <param name="stringSize">The size of the varchar field</param>
        public ColumnAttribute(int stringSize) : base()
        {
            StringSize = stringSize;
            DecimalIntegerSize = 0;
            DecimalFractionalSize = 0;
        }

        /// <summary>
        /// Sets the decimal size of a decimal field
        /// </summary>
        /// <param name="decimalIntegerSize">The integral size of the decimal</param>
        /// <param name="decimalFractionalSize">The fractional size of the decimal</param>
        public ColumnAttribute(int decimalIntegerSize, int decimalFractionalSize) : base()
        {
            StringSize = 0;
            DecimalIntegerSize = decimalIntegerSize;
            DecimalFractionalSize = decimalFractionalSize;
        }

        /// <summary>
        /// Base constructor that initializes properties to default values
        /// </summary>
        public ColumnAttribute() : base()
        {
            StringSize = default(int);
            DecimalIntegerSize = default(int);
            DecimalFractionalSize = default(int);
        }
        #endregion
    }
}
