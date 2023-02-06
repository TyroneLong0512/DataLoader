using DataLoader.Interfaces;

namespace DataLoader.Classes
{
    /// <summary>
    /// Default implementation for the IConnectionProfile interface
    /// </summary>
    public class ConnectionProfile : IConnectionProfile
    {
        #region Properties
        public string Name { get; set; }
        public string ConnectionString { get; set; }
        #endregion

        #region Constructors
        /// <summary>
        /// Default constructor that initializes the class properties to empty values
        /// </summary>
        public ConnectionProfile()
        {
            Name = string.Empty;
            ConnectionString = string.Empty;
        }

        /// <summary>
        /// Constructor for initializing a connection profile with set values for the class properties
        /// </summary>
        /// <param name="name">The name of the connection profile</param>
        /// <param name="connectionString">The connection string to use for the connection profile</param>
        public ConnectionProfile(string name, string connectionString)
        {
            Name = name;
            ConnectionString = connectionString;
        }
        #endregion
    }
}
