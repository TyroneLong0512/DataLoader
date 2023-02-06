using DataLoader.Interfaces;
using DataLoader.Structs;

namespace DataLoader
{
    /// <summary>
    /// Interface for the Data Models used with the DataLoader. Must always be inherited if using a Data Model.
    /// </summary>
    public interface IModel
    {
        /// <summary>
        /// Retrieves the Primary Key on the model
        /// </summary>
        /// <returns>IEnumerable of KeyStructs</returns>
        IEnumerable<KeyStruct> GetPrimaryKey();

        /// <summary>
        /// Retrives the Foreign Key on the model
        /// </summary>
        /// <returns>IEnumerable of KeyStructs</returns>
        IEnumerable<KeyStruct> GetForeignKeys();
    }
}
