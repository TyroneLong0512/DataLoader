namespace DataLoader.Interfaces
{
    /// <summary>
    /// Interface for ConnectionProfile base class
    /// </summary>
    public interface IConnectionProfile
    {
        /// <summary>
        /// The name of the connection profile to use
        /// </summary>
        string Name { get; set; }

        /// <summary>
        /// The connection string relating to the profile
        /// </summary>
        string ConnectionString { get; set; }
    }
}
