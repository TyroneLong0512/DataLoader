using System.Data;

namespace DataLoader.Models.Interfaces
{
    public interface ISqlColumnDefinition : IColumnDefinition
    {
        public SqlDbType ColumnType { get; set; }

        public int? DataSize { get; set; }

        public bool IsForeignKey { get; set; }

        public bool IsPrimaryKey { get; set; }
    }
}
