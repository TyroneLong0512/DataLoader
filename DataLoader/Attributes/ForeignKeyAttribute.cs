using DataLoader.Interfaces;

namespace DataLoader.Attributes
{
    /// <summary>
    /// Foreign Key attribute for IDataLoaderModel object models
    /// </summary>
    public class ForeignKeyAttribute : Attribute, IForeignKeyAttribute
    {
        #region Properties
        public Type ModelType { get; set; }

        public string FieldName { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Declares a field as a Foreign Key, providing the class linked to as well as the property
        /// </summary>
        /// <param name="modelType">The type of the model that links to the current model</param>
        /// <param name="fieldName">The field on the target type links to the current field</param>
        public ForeignKeyAttribute(Type modelType, string fieldName) : base()
        {
            ModelType = modelType;
            FieldName = fieldName;
        }

        /// <summary>
        /// Base constructor that initializes properties to default values
        /// </summary>
        public ForeignKeyAttribute() : base()
        {
            ModelType = typeof(string);
            FieldName = string.Empty;
        }
        #endregion
    }
}
