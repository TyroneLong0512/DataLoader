using DataLoader.Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace DataLoader.Classes
{
    /// <summary>
    /// Base implementation for the IDataLoaderAccess interface
    /// </summary>
    public class DataLoaderAccess : IDataLoaderAccess, IDisposable
    {
        #region Fields
        private IConnectionProfile _profile;
        private SqlConnection _connection;
        private SqlCommand _command;
        private bool disposedValue;
        #endregion

        #region Constructors
        /// <summary>
        /// Initializes the class with a connection profile
        /// </summary>
        /// <param name="connectionProfile">An IConnectionProfile set with a name and connection string</param>
        public DataLoaderAccess(IConnectionProfile connectionProfile)
        {
            _profile = connectionProfile;
            _connection = new SqlConnection(connectionProfile.ConnectionString);
            _command = new SqlCommand();
        }
        #endregion

        #region Destructors
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (_connection.State == ConnectionState.Open)
                    _connection.Close();

                _connection.Dispose();
                _command.Dispose();

                disposedValue = true;
            }
        }
        
        ~DataLoaderAccess()
        {
            Dispose(disposing: false);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
        #endregion

        #region Public Methods
        public bool RunNoDataQuery(string query)
        {
            try
            {
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public DataTable RunQuery(string query)
        {
            try
            {
                return new DataTable();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        #endregion
    }
}
