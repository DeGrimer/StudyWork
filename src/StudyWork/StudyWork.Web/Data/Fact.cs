using Calabonga.EntityFrameworkCore.Entities.Base;

namespace StudyWork.Web.Data
{
    public class Fact : Auditable
    {
        public string Content { get; set; }

        public ICollection<Tag> Tags { get; set; }
    }
}
