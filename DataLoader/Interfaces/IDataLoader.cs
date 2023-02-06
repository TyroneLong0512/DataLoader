namespace DataLoader.Interfaces
{
    /// <summary>
    /// Interface for DataLoader BaseClass
    /// </summary>
    public interface IDataLoader
    {
        /// <summary>
        /// Loads all records from the table based on values set in the model
        /// </summary>
        /// <param name="inputModel">The model to load</param>
        /// <returns>IFilterCollectionFirst</returns>
        IFirstFilter Load(IModel inputModel);

        /// <summary>
        /// Loads records from the table based on the filter collection given
        /// </summary>
        /// <typeparam name="TModel">The type of the model to load that must inherit from IModel</typeparam>
        /// <returns>IFilterCollectionFirst</returns>
        IFirstFilter Load<TModel>() where TModel : IModel;

        /// <summary>
        /// Creates a record in the table based on the values set in the model
        /// </summary>
        /// <param name="inputModel">The model to create</param>
        /// <returns>Boolean</returns>
        bool Create(IModel inputModel);

        /// <summary>
        /// Updates a record in the table based on the values set in the model for the primary keys
        /// </summary>
        /// <param name="inputModel">The model to update</param>
        /// <returns>IFilterCollectionFirst</returns>
        IFirstFilter Update(IModel inputModel);

        /// <summary>
        /// Updates a record in the table based on the values set in the model and columns given
        /// </summary>
        /// <param name="inputModel">The model to update</param>
        /// <param name="columnsToUpdate">The columns to update</param>
        /// <returns>IFilterCollectionFirst</returns>
        IFirstFilter Update(IModel inputModel, IEnumerable<string> columnsToUpdate);

        /// <summary>
        /// Updates a record in the table based on the valuses set in the model and the columns given, uses the filters given to determine which entries should be updated
        /// </summary>
        /// <param name="inputModel">The model to update</param>
        /// <param name="columnsToUpdate">The columns to update</param>
        /// <param name="filters">The collection of filters to use</param>
        /// <returns>IFilterCollectionFirst</returns>
        IFirstFilter Update(IModel inputModel, IEnumerable<string> columnsToUpdate, IFilter filters);

        /// <summary>
        /// Deletes a record in the table based on the values set in the model
        /// </summary>
        /// <param name="inputModel"></param>
        /// <returns>IFilterCollectionFirst</returns>
        IFirstFilter Delete(IModel inputModel);

        /// <summary>
        /// Deletes a record in the table based on the filter collection given
        /// </summary>
        /// <typeparam name="TModel">The type of the model to delete</typeparam>
        /// <param name="filters">The collection of filters to use</param>
        /// <returns>IFilterCollectionFirst</returns>
        IFirstFilter Delete<TModel>(IFilter filters) where TModel : IModel;
    }
}
