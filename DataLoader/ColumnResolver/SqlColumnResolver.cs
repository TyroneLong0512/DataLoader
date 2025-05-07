using DataLoader.Attributes;
using DataLoader.ColumnResolver.Interfaces;
using DataLoader.Models;
using System.Data;
using System.Reflection;

namespace DataLoader.ColumnResolver
{
    public class SqlColumnResolver : ColumnResolver<SqlColumnDefinition>, ISqlColumnResolver
    {
        private SqlDbType ResolveDataType(PropertyInfo propertyInfo)
        {
            if (propertyInfo.PropertyType == typeof(int))
                return SqlDbType.Int;
            if (propertyInfo.PropertyType == typeof(long))
                return SqlDbType.BigInt;
            if (propertyInfo.PropertyType == typeof(short))
                return SqlDbType.SmallInt;
            if (propertyInfo.PropertyType == typeof(decimal))
                return SqlDbType.Decimal;

            if (propertyInfo.PropertyType == typeof(string))
                return SqlDbType.VarChar;
            if (propertyInfo.PropertyType == typeof(char))
                return SqlDbType.Char;

            if (propertyInfo.PropertyType == typeof(bool))
                return SqlDbType.Bit;
            if (propertyInfo.PropertyType == typeof(DateTime))
                return SqlDbType.DateTime;
            if (propertyInfo.PropertyType == typeof(DateTimeOffset))
                return SqlDbType.DateTimeOffset;
            if (propertyInfo.PropertyType == typeof(byte[]))
                return SqlDbType.VarBinary;

            throw new ArgumentException($"Could not find a matching data type for property: {propertyInfo.Name}");
        }

        protected override SqlColumnDefinition ResolveProperty(PropertyInfo property)
        {
            ColumnAttribute? columnAttribute = property.GetCustomAttribute<ColumnAttribute>();
            PrimaryKeyAttribute? primaryKeyAttribute = property.GetCustomAttribute<PrimaryKeyAttribute>();
            ForeignKeyAttribute? foreignKeyAttribute = property.GetCustomAttribute<ForeignKeyAttribute>();

            SqlColumnDefinition definition = new()
            {
                ColumName = property.Name,
                ColumnType = ResolveDataType(property),
                IsPrimaryKey = primaryKeyAttribute == null ? false : true,
                IsForeignKey = foreignKeyAttribute == null ? false : true
            };

            if (columnAttribute != null)
                if (columnAttribute.StringSize.HasValue)
                    definition.DataSize = columnAttribute.StringSize.Value;

            return definition;
        }
    }
}
