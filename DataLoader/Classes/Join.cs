using DataLoader.Interfaces;
using DataLoader.Structs;

namespace DataLoader.Classes
{
    /// <summary>
    /// Base implementation for the IJoin interface
    /// </summary>
    public class Join : IJoin
    {
        #region Fields
        private IEnumerable<JoinStruct> _joinCollection;
        #endregion

        #region Constructors
        public Join()
        {
            _joinCollection = new List<JoinStruct>();
        }
        #endregion

        #region Public Methods
        public IFilter Filter(FilterStruct filter)
        {
            throw new NotImplementedException();
        }

        public IJoin Join(KeyStruct joiningKey)
        {
            throw new NotImplementedException();
        }


        #endregion
    }
}
