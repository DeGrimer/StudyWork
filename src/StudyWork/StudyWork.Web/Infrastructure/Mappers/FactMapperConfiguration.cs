using Calabonga.UnitOfWork;
using StudyWork.Web.Data;
using StudyWork.Web.Infrastructure.Mappers.Base;
using StudyWork.Web.ViewModels;

namespace StudyWork.Web.Infrastructure.Mappers
{
    public class FactMapperConfiguration : MapperConfigurationBase
    {
        public FactMapperConfiguration()
        {
            CreateMap<Fact, FactViewModel>();
            CreateMap<FactCreateViewModel, Fact>();
            CreateMap<FactUpdateViewModel, Fact>();
            CreateMap<Fact, FactUpdateViewModel>();

            CreateMap<IPagedList<Fact>, IPagedList<FactViewModel>>()
                .ConvertUsing<PagedListConverter<Fact, FactViewModel>>();
        }
    }
}
