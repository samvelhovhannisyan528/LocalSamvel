using AutoMapper;

namespace TechnicalTask.Entities.Infrastructure
{
    public interface IMapperService
    {
        TDestination Map<TSource, TDestination>(TSource source);
        object Map(object source, Type sourceType, Type destinationType);
    }

    public class MapperService : IMapperService
    {
        private readonly IMapper mapper;

        public MapperService(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public TDestination Map<TSource, TDestination>(TSource source)
        {
            return mapper.Map<TSource, TDestination>(source);
        }

        public object Map(object source, Type sourceType, Type destinationType)
        {
            return mapper.Map(source, sourceType, destinationType);
        }
    }
}
