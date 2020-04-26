using AutoMapper;
using System;
using System.Linq;
using System.Reflection;

namespace Orderkeeper.Core.Common
{
    public abstract class MapFrom<T>
    {
        public void Mapping(Profile profile)
        {
            profile.CreateMap(typeof(T), GetType());
            profile.CreateMap(GetType(), typeof(T));
        }
    }

}