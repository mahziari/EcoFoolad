using Domain.Entities.Attributes;

namespace Domain.Entities.FileManagers
{
    [Auditable]
    public class FileManager
    {
        public long Id { get; set; }
        public string Address { get; set; }
        public string Title { get; set; }
    }
}