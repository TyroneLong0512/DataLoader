using DataLoader.ColumnResolver.Interfaces;
using DataLoader.Models.Interfaces;
using System.Reflection;

namespace DataLoader.ColumnResolver
{
    public abstract class ColumnResolver<TColumnDefinition> : IColumnResolver<TColumnDefinition> where TColumnDefinition : IColumnDefinition, new()
    {
        protected abstract TColumnDefinition ResolveProperty(PropertyInfo property);

        public IList<TColumnDefinition> ResolveModelColumns<TModel>(TModel model) where TModel : class
        {
            IList<TColumnDefinition> columnDefinitions = new List<TColumnDefinition>();
            PropertyInfo[] propertyInfos = typeof(TModel).GetProperties();

            foreach (PropertyInfo property in propertyInfos)
                columnDefinitions.Add(ResolveProperty(property));

            return columnDefinitions;
        }
    }
}
