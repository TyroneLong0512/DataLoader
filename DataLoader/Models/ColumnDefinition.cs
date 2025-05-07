using System.Data;
using DataLoader.Models.Interfaces;

namespace DataLoader.Models
{
    /// <summary>
    /// Model defining the definition for an SQl Column
    /// </summary>
    public class SqlColumnDefinition : ISqlColumnDefinition
    {
        public string ColumName { get; set; }

        public SqlDbType ColumnType { get; set; }

        public int? DataSize { get; set; }

        public bool IsForeignKey { get; set; }

        public bool IsPrimaryKey { get; set; }


        public SqlColumnDefinition()
        {
            ColumName = string.Empty;
        }
    }
}
