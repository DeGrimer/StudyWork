using Calabonga.EntityFrameworkCore.Entities.Base;

namespace StudyWork.Web.Data
{
    public class Tag : Identity
    {
        public string Name { get; set; }

        public ICollection<Fact> Facts { get; set; }
    }
}
