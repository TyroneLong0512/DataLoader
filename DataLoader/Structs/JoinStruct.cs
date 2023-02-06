using System.Reflection;

namespace DataLoader.Structs
{
    public struct JoinStruct
    {
        public Type SourceModelType { get; set; }
        public PropertyInfo SourceField { get; set; }
        public Type TargetModelType { get; set; }
        public PropertyInfo TargetField { get; set; }
    }
}
