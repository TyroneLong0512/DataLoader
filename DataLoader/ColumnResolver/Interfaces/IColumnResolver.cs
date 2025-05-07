using DataLoader.Models.Interfaces;

namespace DataLoader.ColumnResolver.Interfaces
{
    public interface IColumnResolver<TColumnDefinition> where TColumnDefinition : IColumnDefinition
    {
        IList<TColumnDefinition> ResolveModelColumns<TModel>(TModel model) where TModel : class;
    }
}
