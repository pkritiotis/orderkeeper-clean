using AutoMapper;

namespace Orderkeeper.Core.Common
{
    public abstract class MapFrom<T>
    {
        public void Mapping(Profile profile) => profile.CreateMap(typeof(T), GetType());
    }
}
