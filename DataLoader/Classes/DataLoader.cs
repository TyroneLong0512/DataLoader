using DataLoader.ColumnResolver.Interfaces;
using DataLoader.Interfaces;
using DataLoader.Models;

namespace DataLoader.Classes
{
    public class DataLoader : IDataLoader
    {
        #region Fields
        private IEnumerable<IJoin> _joiners = new List<IJoin>();        
        private IEnumerable<IFilter> _filters = new List<IFilter>();
        private ISqlColumnResolver _columnResolver;
        #endregion

        #region Constructors
        public DataLoader(IConnectionProfile connectionProfile, ISqlColumnResolver sqlColumnResolver)
        {
            _columnResolver = sqlColumnResolver;
        }
        #endregion

        #region Public Methods
        public bool Create<TModel>(TModel inputModel) where TModel : class
        {
            IList<SqlColumnDefinition> columns = _columnResolver.ResolveModelColumns(inputModel);


            return false;
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
