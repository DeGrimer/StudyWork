using AutoMapper;
using Calabonga.UnitOfWork;

namespace StudyWork.Web.Infrastructure.Mappers.Base
{
    internal class PagedListConverter<TSource, TDestination> : ITypeConverter<IPagedList<TSource>, IPagedList<TDestination>>
    {
        public IPagedList<TDestination> Convert(IPagedList<TSource> source, IPagedList<TDestination> destination, ResolutionContext context)
        {
            return source == null
                ? PagedList.Empty<TDestination>()
                : PagedList.From(source, x => context.Mapper.Map<IEnumerable<TDestination>>(x));


        }
    }
}
