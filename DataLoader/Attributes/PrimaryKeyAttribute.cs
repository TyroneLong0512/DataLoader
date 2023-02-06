using DataLoader.Interfaces;

namespace DataLoader.Attributes
{
    public class PrimaryKeyAttribute : Attribute, IPrimaryKeyAttribute
    {
        /// <summary>
        /// Base constructor for the class
        /// </summary>
        public PrimaryKeyAttribute() : base()
        {

        }
    }
}
