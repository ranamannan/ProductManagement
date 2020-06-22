using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ProductManagement.Application.Common.Interfaces;
using ProductManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProductManagement.Application.Categories.Queries
{
    public class GetCategoriesQuery : IRequest<IList<CategoryResponse>>
    {
        public int id { get; set; }
        public GetCategoriesQuery()
        {
            id = 1;
        }
    }

    public class GetCategoriesQueryHandler : IRequestHandler<GetCategoriesQuery, IList<CategoryResponse>>
    {
        private readonly IApplicationDbContext context;
        private readonly IMapper mapper;

        public GetCategoriesQueryHandler(
            IApplicationDbContext context ,
            IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
            // context
        }
        public async Task<IList<CategoryResponse>> Handle(GetCategoriesQuery request, CancellationToken cancellationToken)
        {
            var entity_Categories = await GetCategoryFromDb();
            var categories = mapper.Map<IList<CategoryResponse>>(entity_Categories);
            
            return categories;
        }

        private async Task<IList<Category>> GetCategoryFromDb()
        {
            var categories = await context.Categories.ToListAsync();
            return categories;
            //var categoriesCollection = new List<Category>();

            //categoriesCollection.Add(new Category { Id = 1, Name = "Grocerry" });
            //categoriesCollection.Add(new Category { Id = 1, Name = "Electronics" });
            //return categories;
        }

    }
}
