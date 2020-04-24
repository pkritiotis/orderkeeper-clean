using AutoMapper;

namespace orderkeeper.core.Common
{
    public abstract class MapFrom<T>
    {
        public void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
