using AutoMapper;
using DataTransfer.Dto;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DefaultConfiguration.App_Start
{
    /// <summary>
    /// Automapper configuration class
    /// </summary>
    public class AutomapperConfig
    {

        /// <summary>
        /// Configure the mappings needed
        /// </summary>
        public static void Configure()
        {
            Mapper.CreateMap<Reddit.DataTransfer.Item, Domain.Item>()
                .ForMember(d => d.AuthorName, o => o.MapFrom(src => src.Data.Author))
                .ForMember(d => d.CreatedDate, o => o.MapFrom(src => new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc).AddSeconds(src.Data.Created)))
                .ForMember(d => d.Domain, o => o.MapFrom(src => src.Data.Domain))
                .ForMember(d => d.Id, o => o.MapFrom(src => src.Data.Id))
                .ForMember(d => d.PermaLink, o => o.MapFrom(src => src.Data.PermaLink))
                .ForMember(d => d.Title, o => o.MapFrom(src => src.Data.Title));
            Mapper.CreateMap<Domain.Author, AuthorDto>();
            Mapper.CreateMap<Domain.Item, ItemDto>();
        }

    }
}
