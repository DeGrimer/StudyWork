using Calabonga.UnitOfWork;
using StudyWork.Web.Data;
using StudyWork.Web.Infrastructure.Mappers.Base;
using StudyWork.Web.ViewModels;

namespace StudyWork.Web.Infrastructure.Mappers
{
    public class TagMapperConfiguration : MapperConfigurationBase
    {
        public TagMapperConfiguration()
        {
            CreateMap<Tag, TagViewModel>();
            CreateMap<TagUpdateViewModel, Tag>();
            CreateMap<Tag, TagUpdateViewModel>();
        }
    }

    public record TagUpdateViewModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
    }
}
