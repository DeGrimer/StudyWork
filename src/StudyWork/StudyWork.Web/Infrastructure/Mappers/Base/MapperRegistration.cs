using AutoMapper;

namespace StudyWork.Web.Infrastructure.Mappers.Base
{
    public static class MapperRegistration
    {
        public static MapperConfiguration GetMapperConfiguration()
        {
            var profiles = GetProfiles();
            return new MapperConfiguration(cfg =>
            {
                foreach (var profile in profiles.Select(profile => Activator.CreateInstance(profile) as Profile))
                {
                    cfg.AddProfile(profile);
                }
            });
        }

        private static List<Type> GetProfiles()
        {
            return (from t in typeof(Program).GetType().Assembly.GetTypes()
                    where typeof(IAutomapper).IsAssignableFrom(t) && !t.GetType().IsAbstract
                    select t).ToList();
        }
    }
}
