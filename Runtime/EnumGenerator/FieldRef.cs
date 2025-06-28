using System;
namespace FieldRef
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple = true)]
    public class FieldRefAttribute : Attribute
    {
        public FieldRefAttribute(Type fieldType) { }
    }
}