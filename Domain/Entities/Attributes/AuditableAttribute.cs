using System;

namespace Domain.Entities.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AuditableAttribute:Attribute
    {
    }
}
