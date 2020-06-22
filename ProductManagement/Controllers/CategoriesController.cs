using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductManagement.Application.Categories.Commands;
using ProductManagement.Application.Categories.Queries;

namespace ProductManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator mediator;

        public CategoriesController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        public async Task<ActionResult> Get()
        {
            var response = await mediator.Send(new GetCategoriesQuery());
            return Ok(response);
        }

        [HttpGet("{id}")]
        public IActionResult GetCategoryById(int id)
        {
            return Ok("Done By Id");
        }

        [HttpPost()]
        public  async Task<ActionResult<long>> PostCategory(CreateCategoryCommand command)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }
            var response = await mediator.Send(command);
            return NoContent();
        }
    }
}
