namespace DataLoader.Interfaces
{
    /// <summary>
    /// Interface for the Foreign Key attributes on the IDataLoaderModel properties
    /// </summary>
    public interface IForeignKeyAttribute : IKey
    {
        Type ModelType { get; set; }

        string FieldName { get; set; }
    }
}
