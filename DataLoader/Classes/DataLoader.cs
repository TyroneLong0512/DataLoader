

using DataLoader.Interfaces;

namespace DataLoader.Classes
{
    public class DataLoader : IDataLoader
    {
        #region Fields
        private IEnumerable<IJoin> _joiners = new List<IJoin>();
        //private IFilterCollectionFirst _firstFilter = FilterCollectionfirst;
        private IEnumerable<IFilter> _filters = new List<IFilter>();
        #endregion

        #region Constructors
        public DataLoader(IConnectionProfile connectionProfile)
        {

        }
        #endregion

        #region Public Methods
        public bool Create(IModel inputModel)
        {
            throw new NotImplementedException();
        }

        public IFirstFilter Delete(IModel inputModel)
        {
            throw new NotImplementedException();
        }

        public IFirstFilter Delete<TModel>(IFilter filters) where TModel : IModel
        {
            throw new NotImplementedException();
        }

        public IFirstFilter Load(IModel inputModel)
        {
            throw new NotImplementedException();
        }

        public IFirstFilter Load<TModel>() where TModel : IModel
        {
            throw new NotImplementedException();
        }

        public IFirstFilter Update(IModel inputModel)
        {
            throw new NotImplementedException();
        }

        public IFirstFilter Update(IModel inputModel, IEnumerable<string> columnsToUpdate)
        {
            throw new NotImplementedException();
        }

        public IFirstFilter Update(IModel inputModel, IEnumerable<string> columnsToUpdate, IFilter filters)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
