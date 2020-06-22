using MediatR;
using ProductManagement.Application.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProductManagement.Application.Categories.Commands
{
    public class CreateCategoryCommand : IRequest<int>
    {
       
        public string Name { get; set; }
    }

    public class CreateCategoryCommandHandler : IRequestHandler<CreateCategoryCommand, int>
    {
        private readonly IApplicationDbContext context;

        public CreateCategoryCommandHandler(IApplicationDbContext context)
        {
            this.context = context;
            // context
        }
        public async Task<int> Handle(CreateCategoryCommand request, CancellationToken cancellationToken)
        {
            // Create Command object from Domain
            //request.Name
            // savechanges();
            int returnId = 1;
            return returnId;
            //throw new NotImplementedException();
        }
    }
}
