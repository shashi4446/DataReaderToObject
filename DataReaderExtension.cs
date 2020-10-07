using AutoMapper;
using AutoMapper.Data;
using System.Collections.Generic;
using System.Data;

namespace AutoMapperDemo
{
    public static class DataReaderExtension
    {
        public static IEnumerable<T> ToObject<T>(this IDataReader reader)
        {
            MapperConfiguration configuration = new MapperConfiguration(configuration =>
            {
                configuration.AddDataReaderMapping(true);
                configuration.CreateMap<IDataRecord, T>();
            });
            IMapper mapper = new Mapper(configuration);
            IEnumerable<T> results = mapper.Map<IDataReader, IEnumerable<T>>(reader);
            return results;

        }
    }
}
