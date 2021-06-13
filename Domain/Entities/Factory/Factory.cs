using Domain.Entities.Attributes;

namespace Domain.Entities.Factory
{
    [Auditable]
    public class Factory
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}