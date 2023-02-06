using DataLoader.Enums;
using DataLoader.Interfaces;
using DataLoader.Structs;
using System.Collections;

namespace DataLoader.Classes
{
    /// <summary>
    /// Base implementation for the IFilter interface
    /// </summary>
    public class Filter : IFilter
    {
        #region Fields
        public IEnumerable<FilterStruct> _filters;
        #endregion

        #region Constructors
        /// <summary>
        /// Base constructor that initializes properties to default values
        /// </summary>
        public Filter()
        {
            _filters = new List<FilterStruct>();
        }
        #endregion

        #region Public Methods
        public IFilter Filter(FilterStruct filter)
        {
            return this;
        }

        public bool ClearFilters()
        {
            throw new NotImplementedException();
        }

        public bool DeleteFilters(string fieldName)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFilters(SqlFilterAppenders appenders)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFirst()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<FilterStruct> GetFilters()
        {
            throw new NotImplementedException();
        }

        public string GetFilterString()
        {
            //To Do: Get filter string implementation
            throw new NotImplementedException();
        }
        #endregion
    }
}
