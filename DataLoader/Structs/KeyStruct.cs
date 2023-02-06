using System.Reflection;
using DataLoader.Interfaces;

namespace DataLoader.Structs
{
    /// <summary>
    /// A struct containing information on the Primary and Foreign keys
    /// </summary>
    public struct KeyStruct
    {
        public PropertyInfo SourceField { get; set; }
        public IKey TargetField { get; set; }
    }
}
