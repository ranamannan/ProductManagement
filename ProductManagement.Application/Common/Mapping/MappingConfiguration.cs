using AutoMapper;
using ProductManagement.Application.Categories.Queries;
using ProductManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProductManagement.Application.Common.Mapping
{
    public class MappingConfiguration : Profile
    {
        public MappingConfiguration()
        {
            CreateMap<Category, CategoryResponse>();
        }
    }
}
