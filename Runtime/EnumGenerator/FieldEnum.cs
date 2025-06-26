using System;

namespace Leon.FieldRef
{
    [AttributeUsage(AttributeTargets.Class,AllowMultiple = true)]
    public class FieldEnumAttribute : Attribute
    {
        public FieldEnumAttribute(Type fieldType) { }
    }
}